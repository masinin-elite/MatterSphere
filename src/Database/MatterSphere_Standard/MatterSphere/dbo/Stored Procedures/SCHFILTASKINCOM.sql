﻿CREATE PROCEDURE dbo.SCHFILTASKINCOM
(
	@UI uUICultureInfo = '{default}'
	, @FILEID BIGINT 
	, @ORDERBY NVARCHAR(MAX) = NULL
)  
AS
SET TRAN ISOLATION LEVEL READ UNCOMMITTED
SET NOCOUNT ON

DECLARE @SELECT NVARCHAR(MAX)
	, @NODUPCOLUMNS NVARCHAR(MAX) = (
SELECT '
	, U.' + COLUMN_NAME
FROM INFORMATION_SCHEMA.COLUMNS
WHERE TABLE_NAME = 'dbuser'
	AND TABLE_SCHEMA = 'dbo'
AND COLUMN_NAME NOT IN (
SELECT COLUMN_NAME 
FROM INFORMATION_SCHEMA.COLUMNS
WHERE TABLE_NAME IN ('dbuser', 'dbtasks')
	AND TABLE_SCHEMA = 'dbo'
GROUP BY COLUMN_NAME
HAVING COUNT(*) > 1
)
FOR XML PATH(''), TYPE).value('.','NVARCHAR(MAX)')

SET @SELECT = N'
WITH Res AS
(

SELECT 
	T.*' + @NODUPCOLUMNS + N'
	, COALESCE(CL1.cdDesc, ''~'' + NULLIF(T.tsktype, '''') + ''~'') AS [tsktypedesc]
FROM dbo.dbtasks T
	INNER JOIN dbo.dbUser U ON U.usrid = T.feeusrid  
	LEFT OUTER JOIN dbo.GetCodeLookupDescription (''TASKTYPE'', @UI) CL1 ON CL1.cdCode = T.tsktype
WHERE T.fileID = @FILEID 
	AND T.tskCompleted IS NULL
)
SELECT *
FROM Res
'

IF @ORDERBY IS NULL
	SET  @SELECT =  @SELECT + N'ORDER BY tskdue'
ELSE 
	IF @ORDERBY NOT LIKE '%tskdue%'
		SET  @SELECT =  @SELECT + N'ORDER BY ' + @ORDERBY  + N', tskdue'
	ELSE 
		SET  @SELECT =  @SELECT + N'ORDER BY ' + @ORDERBY

EXEC sp_executesql @SELECT, N'@UI uUICultureInfo, @FILEID BIGINT', @UI, @FILEID

GO

GRANT EXECUTE
    ON OBJECT::[dbo].[SCHFILTASKINCOM] TO [OMSRole]
    AS [dbo];


GO
GRANT EXECUTE
    ON OBJECT::[dbo].[SCHFILTASKINCOM] TO [OMSAdminRole]
    AS [dbo];