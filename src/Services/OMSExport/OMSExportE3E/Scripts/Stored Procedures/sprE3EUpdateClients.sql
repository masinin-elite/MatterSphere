IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sprE3EUpdateClients]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[sprE3EUpdateClients]
GO

CREATE PROCEDURE [dbo].[sprE3EUpdateClients]
AS
--CHECK IF A CUSTOM VERSION EXISTS - MUST RETURN SAME COLUMNS AS STANDARD VERSION
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sprE3EUpdateClients_CUSTOM]') AND type in (N'P', N'PC'))
	EXEC [dbo].[sprE3EUpdateClients_CUSTOM]
ELSE
SELECT 
	DBCLIENT.CLID
	--TODO - Get Entity?  Address?
	, DBO.GETE3ECLIENTUPDATEXML ( DBCLIENT.CLID ) AS CLIENT
	, CONTEXTID AS ENTITYINDEX
	, CLEXTID AS CLIENTINDEX
FROM         
	DBO.DBCLIENT
INNER JOIN 
	DBCONTACT ON DBCONTACT.CONTID = DBCLIENT.CLDEFAULTCONTACT
WHERE 
	CLNEEDEXPORT = 1 and 
	CLEXTID > 0	AND			-- NEGATIVE NUMBERS USED TO INDICATE AN ERROR OR PART CREATION
	DBCONTACT.CONTEXTID > 0