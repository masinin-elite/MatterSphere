﻿CREATE PROCEDURE [dbo].[sprC3EUpdateContacts]
AS
--CHECK IF A CUSTOM VERSION EXISTS - MUST RETURN SAME COLUMNS AS STANDARD VERSION
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sprC3EUpdateContacts_CUSTOM]') AND type in (N'P', N'PC'))
	EXEC [dbo].[sprC3EUpdateContacts_CUSTOM]
ELSE

SELECT
	--TODO - Get Entity?  Address?
	CONTID
	, CASE CHARINDEX ( 'GeneralType="Company"' , TYPEXML )  
		WHEN 0 THEN 'EntityPerson'	--CASE SENSITIVE
		ELSE 'EntityOrg'			--CASE SENSITIVE 
	END AS ENTITYTYPE
	, CASE CHARINDEX ( 'GeneralType="Company"' , TYPEXML )  
		WHEN 0 THEN DBO.GETE3EENTITYPERSONUPDATEXML ( CONTID, N'C3E' )
		ELSE DBO.GETE3EENTITYORGUPDATEXML ( CONTID, N'C3E' )
	END AS ENTITYXML
	, CONTEXTID AS ENTITYINDEX
	, CONTEXTTXTID AS ENTITYID
FROM
	DBCONTACT
INNER JOIN 
	DBCONTACTTYPE ON DBCONTACT.CONTTYPECODE = DBCONTACTTYPE.TYPECODE
WHERE 
	CONTNEEDEXPORT = 1 AND
	(CONTEXTTXTID IS NOT NULL OR ISNULL(CONTEXTID, 0) > 0)
