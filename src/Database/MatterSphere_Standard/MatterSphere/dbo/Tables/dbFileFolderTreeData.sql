﻿CREATE TABLE [dbo].[dbFileFolderTreeData](
	[id] [bigint] NOT NULL,
	[treeXML] [varchar](max) NOT NULL,
	[rowguid] [uniqueidentifier] ROWGUIDCOL  NOT NULL CONSTRAINT [DF_dbFileFolderTree_rowguid]  DEFAULT (newid()),
 CONSTRAINT [PK_dbFileFolderTree_1] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO

CREATE TRIGGER dbo.dbFileFolderTreeIUD
	ON dbo.dbFileFolderTreeData
AFTER INSERT,DELETE,UPDATE
NOT FOR REPLICATION
AS 
BEGIN
	SET NOCOUNT ON;
	IF EXISTS(SELECT * FROM inserted)
	BEGIN
		WITH CF AS
		(
			SELECT * FROM dbo.dbFileFolder
			WHERE EXISTS(SELECT 1 FROM inserted WHERE ID = fileID)
		)
		MERGE CF AS target
		USING (
			SELECT fileID
				,T.N.value('@FolderGUID','UNIQUEIDENTIFIER') AS FolderGuid
				,T.N.value('@FolderCode','nvarchar(15)') AS FolderCode
			FROM (SELECT id AS fileID, CONVERT(XML, treeXML) AS treeXML FROM  inserted) i
				CROSS APPLY treeXML.nodes('//node') AS T(N)
			WHERE T.N.value('@FolderCode', 'varchar(15)') IS NOT NULL			
		) AS source ON (target.fileID = source.fileID AND target.FolderGuid = source.FolderGuid)
		WHEN NOT MATCHED BY TARGET THEN
			INSERT (fileID, FolderGuid, FolderCode)
			VALUES(source.fileID, source.FolderGuid, source.FolderCode)
		WHEN NOT MATCHED BY SOURCE
			THEN DELETE  
		WHEN MATCHED
			THEN UPDATE SET target.FolderCode = source.FolderCode
		;		

	END
	ELSE
		DELETE ff
		FROM dbo.dbFileFolder ff 
		WHERE EXISTS(SELECT 1 FROM deleted WHERE id = ff.fileID)
	
END
GO