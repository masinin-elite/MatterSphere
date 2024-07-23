CREATE PROCEDURE [dbo].[sprC3EExportClients]
AS
--CHECK IF A CUSTOM VERSION EXISTS - MUST RETURN SAME COLUMNS AS STANDARD VERSION
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sprC3EExportClients_CUSTOM]') AND type in (N'P', N'PC'))
	EXEC [dbo].[sprC3EExportClients_CUSTOM]
ELSE

SELECT 
	DBCLIENT.CLID
	--TODO - Get Entity?  Address?
	, DBCLIENT.CLDEFAULTCONTACT AS DEFAULTCONTACTID
	, DBO.GETE3EENTITYPERSONEXPORTXML ( DBCLIENT.CLDEFAULTCONTACT, N'C3E' ) AS ENTITYPERSON	
	, DBO.GETE3EENTITYORGEXPORTXML ( DBCLIENT.CLDEFAULTCONTACT, N'C3E' ) AS ENTITYORG
	, DBO.GetE3EClientExportXML ( DBCLIENT.CLID, N'C3E' ) AS CLIENT
	, CONTEXTID AS ENTITYINDEX
	, CONTEXTTXTID AS ENTITYID
	
FROM         
	DBCLIENT
INNER JOIN 
	DBCONTACT ON DBCONTACT.CONTID = DBCLIENT.CLDEFAULTCONTACT
WHERE 
	DBCLIENT.clneedexport = 1 AND
	ISNULL(DBCLIENT.clextID, 0) = 0 AND DBCLIENT.clexttxtID IS NULL AND
	(DBCONTACT.contExtTxtID IS NOT NULL OR DBCONTACT.contExtID > 0)
