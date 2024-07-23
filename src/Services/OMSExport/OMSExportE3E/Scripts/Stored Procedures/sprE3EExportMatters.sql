
/****** Object:  StoredProcedure [dbo].[sprE3EExportMatters]    Script Date: 12/12/2011 11:06:10 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sprE3EExportMatters]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[sprE3EExportMatters]
GO



CREATE PROCEDURE [dbo].[sprE3EExportMatters]
AS
--CHECK IF A CUSTOM VERSION EXISTS - MUST RETURN SAME COLUMNS AS STANDARD VERSION
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sprE3EExportMatters_CUSTOM]') AND type in (N'P', N'PC'))
	EXEC [dbo].[sprE3EExportMatters_CUSTOM]
ELSE
SELECT
	FILEID
	, DBO.GETE3EMATTEREXPORTXML ( FILEID ) AS MATTER
FROM 
	DBFILE
INNER JOIN 
	DBCLIENT ON DBCLIENT.CLID = DBFILE.CLID
WHERE 
	DBFILE.FILENEEDEXPORT = 1 AND
	ISNULL ( DBCLIENT.CLEXTID , 0 ) > 0 AND
	DBFILE.FILEEXTLINKID IS NULL