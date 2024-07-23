﻿

CREATE PROCEDURE [dbo].[MatterMergeDelete_dbFileEvents]
AS
SET NOCOUNT ON

DECLARE @fileID bigint, @newFileID bigint, @logID int, @logXML xml, @logString nvarchar(MAX)
DECLARE @logTable table (ID bigint ) 

SELECT @fileID = OldFileID, @logID = LogID, @newFileID = NewFileID, @logString = CONVERT(nvarchar(MAX), ExecutionXML) FROM dbo.GetMatterMergeDeleteRecord() 


BEGIN TRY
BEGIN TRANSACTION
	
	IF (@newFileID IS NULL)
	BEGIN
		DELETE dbo.dbFileEvents
		OUTPUT deleted.evID INTO @logTable
		WHERE fileID = @fileID
	END
	ELSE
	BEGIN
		UPDATE dbo.dbFileEvents SET fileID = @newFileID 
		OUTPUT deleted.evID INTO @logTable
		WHERE fileID = @fileID
	END
	
	
	IF @@ROWCOUNT > 0
	BEGIN
		SET @logXML = ( SELECT (SELECT ID as evID FROM @logTable FOR XML PATH(''), TYPE ) FOR XML PATH('dbFileEvents'))
		IF (@logString = '<log/>')
			UPDATE dbo.dbMatterMergeDelete SET ExecutionXML = '<log>' + CONVERT(nvarchar(MAX), @logXML) + '</log>' WHERE logID = @logID
		ELSE
			UPDATE dbo.dbMatterMergeDelete SET ExecutionXML = REPLACE (Convert(nvarchar(MAX) , ExecutionXML) , '</log>' , Convert(nvarchar(MAX) , @logXML) + '</log>') WHERE logID = @logID
	END
	
COMMIT TRANSACTION	
END TRY

BEGIN CATCH
IF @@Trancount <> 0
BEGIN
	ROLLBACK TRANSACTION
END
DECLARE @err nvarchar(MAX) 
SET @err = ERROR_MESSAGE()
UPDATE dbo.dbMatterMergeDelete SET ExecutionStatus = 2, ExecutionError = @err WHERE LogID = @logID
RAISERROR('Failed to merge - delete record', 16,1)
END CATCH

GO
GRANT EXECUTE
    ON OBJECT::[dbo].[MatterMergeDelete_dbFileEvents] TO [OMSRole]
    AS [dbo];


GO
GRANT EXECUTE
    ON OBJECT::[dbo].[MatterMergeDelete_dbFileEvents] TO [OMSAdminRole]
    AS [dbo];
