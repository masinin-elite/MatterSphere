﻿DECLARE @ID BIGINT = (SELECT TOP 1 ID FROM dbo.dbFileFolderTreeData ORDER BY ID)
IF NOT EXISTS (SELECT 1 FROM dbo.dbFileFolder)
BEGIN

	WHILE @ID IS NOT NULL
	BEGIN
		UPDATE dbo.dbFileFolderTreeData
		SET treeXML = treeXML
		WHERE ID = @ID
		
		SET @ID = (SELECT TOP 1 ID FROM dbo.dbFileFolderTreeData WHERE ID > @ID ORDER BY ID)
	END

END 