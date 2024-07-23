CREATE PROCEDURE [dbo].[sprE3EUpdateMatters]
AS
--CHECK IF A CUSTOM VERSION EXISTS - MUST RETURN SAME COLUMNS AS STANDARD VERSION
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sprE3EUpdateMatters_CUSTOM]') AND type in (N'P', N'PC'))
	EXEC [dbo].[sprE3EUpdateMatters_CUSTOM]
ELSE
SELECT
	FILEID
	, DBO.GETE3EMATTERUPDATEXML ( FILEID, N'E3E' ) AS MATTER
	, FILEEXTLINKID AS MATTINDEX
FROM 
	DBFILE
INNER JOIN 
	DBCLIENT ON DBCLIENT.CLID = DBFILE.CLID
WHERE 
	DBFILE.FILENEEDEXPORT = 1 AND
	DBFILE.FILEEXTLINKID > 0