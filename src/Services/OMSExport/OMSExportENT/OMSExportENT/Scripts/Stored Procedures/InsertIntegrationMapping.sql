/****** Object:  StoredProcedure [dbo].[fdSprInsertIntegrationMapping]    Script Date: 07/27/2012 11:42:19 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[fdSprInsertIntegrationMapping]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[fdSprInsertIntegrationMapping]
GO

/****** Object:  StoredProcedure [dbo].[fdSprInsertIntegrationMapping]    Script Date: 07/27/2012 11:42:19 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO




CREATE PROCEDURE [dbo].[fdSprInsertIntegrationMapping]
(@INTEGRATIONSYSTEMNAME NVARCHAR ( 50 ), @INTEGRATIONENTITYNAME NVARCHAR ( 50 ), @INTERNALID NVARCHAR(50), @EXTERNALID NVARCHAR(50))
AS
SET NOCOUNT ON

--VARIABLES
DECLARE @SYSTEMID UNIQUEIDENTIFIER
DECLARE @ENTITYID UNIQUEIDENTIFIER
DECLARE @ERRORMESSAGE NVARCHAR ( 100 ) 

--CHECKS
IF ( SELECT COUNT ( * ) FROM FDDBINTEGRATIONSYSTEM WHERE NAME = @INTEGRATIONSYSTEMNAME ) = 0
BEGIN 
	SET @ERRORMESSAGE = 'Integration System not set up for ' + @INTEGRATIONSYSTEMNAME 
	RAISERROR ( @ERRORMESSAGE , 15 , 1 )
	RETURN
END 

IF ( SELECT COUNT ( * ) FROM FDDBINTEGRATIONENTITY WHERE NAME = @INTEGRATIONENTITYNAME ) = 0
BEGIN 
	SET @ERRORMESSAGE =  'Integration Entity not set up for ' + @INTEGRATIONENTITYNAME
	RAISERROR ( @ERRORMESSAGE , 15 , 1 )
	RETURN
END 

SELECT @SYSTEMID = ID FROM FDDBINTEGRATIONSYSTEM WHERE NAME = @INTEGRATIONSYSTEMNAME 
SELECT @ENTITYID = ID FROM FDDBINTEGRATIONENTITY WHERE NAME = @INTEGRATIONENTITYNAME

IF ( SELECT COUNT ( * ) FROM FDDBINTEGRATIONMAPPING WHERE ENTITYID = @ENTITYID AND SYSTEMID = @SYSTEMID AND INTERNALID = @INTERNALID ) > 0
BEGIN
	SET @ERRORMESSAGE =  'Integration Mapping table already populated for Internal ID ' + @INTERNALID
	RAISERROR ( @ERRORMESSAGE , 15 , 1 )
	RETURN
END 


--BUILD SQL TO CREATE ROW
INSERT INTO	FDDBINTEGRATIONMAPPING
(
	SYSTEMID
	, ENTITYID
	, INTERNALID
	, EXTERNALID
)

SELECT 
	@SYSTEMID
	, @ENTITYID
	, @INTERNALID
	, @EXTERNALID

--SET NOCOUNT OFF TO ENSURE ONLY RETURNS ONE ROW FOR UPDATE
SET NOCOUNT OFF



GO