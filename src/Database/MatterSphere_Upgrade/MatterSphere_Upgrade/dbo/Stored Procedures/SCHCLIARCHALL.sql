﻿CREATE PROCEDURE dbo.SCHCLIARCHALL
(
	@UI uUICultureInfo = '{default}'
	, @ARCHIVIST INT = NULL
	, @ARCHDESC NVARCHAR(100) = NULL
	, @ARCHREF NVARCHAR(50) = NULL
	, @ARCHTYPE uCodeLookup = NULL
	, @ARCHSTORAGELOC uCodeLookup = NULL
	, @CLID BIGINT 
	, @ORDERBY NVARCHAR(MAX) = NULL
)  

AS
SET TRAN ISOLATION LEVEL READ UNCOMMITTED
SET NOCOUNT ON

DECLARE @SELECT NVARCHAR(MAX)

SET @Select = N'
WITH Arch AS(
SELECT A.*
	, COALESCE(CL1.cdDesc, ''~'' + NULLIF(A.archType, '''') + ''~'') AS archTypeDesc
	, COALESCE(CL2.cdDesc, ''~'' + NULLIF(A.archStorageLoc, '''') + ''~'') AS archStorageLocDesc
	, F.fileNo
	, U.usrFullName
	, C.clNo
	, C.clName
FROM dbo.dbArchive A
	INNER JOIN dbo.dbFile F ON A.fileID = F.fileID
	INNER JOIN dbo.dbUser U ON U.usrID = A.CreatedBy
	INNER JOIN dbo.dbClient C ON c.clID = A.clID 
	LEFT OUTER JOIN dbo.GetCodeLookupDescription(''ARCHTYPE'', @UI) CL1 ON CL1.cdCode = A.archType
	LEFT OUTER JOIN dbo.GetCodeLookupDescription(''LOCTYPE'', @UI) CL2 ON CL2.cdCode = A.archStorageLoc
WHERE
	A.clID = @CLID
'

IF ISNULL(@ARCHDESC, '') <> ''
	SET @SELECT = @SELECT + N'
	AND A.archdesc LIKE ''%'' + @ARCHDESC + ''%''
'
IF ISNULL(@ARCHREF, '') <> ''
	SET @SELECT = @SELECT + N'
	AND A.archref LIKE ''%'' + @ARCHREF + ''%''
'
IF ISNULL(@ARCHTYPE, '') <> ''
	SET @SELECT = @SELECT + N'
	AND A.archtype = @ARCHTYPE
'

IF ISNULL(@ARCHSTORAGELOC, '') <> ''
	SET @SELECT = @SELECT + N'
	AND A.archStorageLoc = @ARCHSTORAGELOC
'

IF @ARCHIVIST IS NOT NULL
	SET @SELECT = @SELECT + N'
	AND A.CreatedBy = @ARCHIVIST
'

SET @SELECT = @SELECT + N'
)
SELECT *
FROM Arch
'
IF @ORDERBY IS NULL
	SET @SELECT = @SELECT + N'ORDER BY Created DESC'
ELSE 
	IF @ORDERBY NOT LIKE '%Created%'
		SET @SELECT = @SELECT + N'ORDER BY ' + @ORDERBY  + N', Created DESC'
	ELSE 
		SET @SELECT = @SELECT + N'ORDER BY ' + @ORDERBY

PRINT @Select

EXEC sp_executesql @Select,  N'@UI uUICultureInfo, @ARCHIVIST INT, @ARCHDESC NVARCHAR(100), @ARCHREF NVARCHAR(50), @ARCHTYPE uCodeLookup, @ARCHSTORAGELOC uCodeLookup, @CLID BIGINT', @UI, @ARCHIVIST, @ARCHDESC, @ARCHREF, @ARCHTYPE, @ARCHSTORAGELOC, @CLID

GO
GRANT EXECUTE
    ON OBJECT::[dbo].[SCHCLIARCHALL] TO [OMSRole]
    AS [dbo];


GO
GRANT EXECUTE
    ON OBJECT::[dbo].[SCHCLIARCHALL] TO [OMSAdminRole]
    AS [dbo];
