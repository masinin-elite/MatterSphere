﻿IF EXISTS (SELECT * FROM sys.views WHERE object_id = OBJECT_ID(N'[config].[vwdbClient]'))
	DROP VIEW [config].[vwdbClient]
GO

CREATE VIEW [config].[vwdbClient]
AS
WITH ClientDeny( ClientID, [Deny], [Secure]) AS
(
	SELECT RUGC.ClientID
		, MAX(CASE WHEN SUBSTRING ( PC.DenyMask , 5 , 1 ) & 128 = 128 AND UGM.ID IS NOT NULL THEN 1 END) AS [Deny]
		, CASE WHEN MAX(CASE WHEN UGM.ID IS NOT NULL THEN 1 END) IS NULL THEN 1 END AS Secure
	FROM relationship.UserGroup_Client RUGC
		JOIN config.ObjectPolicy PC ON PC.ID = RUGC.PolicyID
		LEFT JOIN config.GetUserAndGroupMembershipNT_NS() UGM ON UGM.ID = RUGC.UserGroupID
		CROSS APPLY config.IsAdministratorTbl_NS() admins
	WHERE admins.IsAdmin = 0
		AND (PC.IsRemote = 0 OR PC.IsRemote IS NULL)
	GROUP BY RUGC.ClientID
)
SELECT C.*
FROM config.dbClient AS C 
	LEFT JOIN ClientDeny AS CA ON C.clID = CA.ClientID	--JOIN / APPLY to table valued function or ADO.NET dynamic SQL fails in matter centre
WHERE (CA.[Deny] IS NULL) AND (CA.Secure IS NULL)

GO
CREATE TRIGGER [config].[ClientDelete]
    ON [config].[vwdbClient]
    WITH ENCRYPTION
    INSTEAD OF DELETE
    NOT FOR REPLICATION
    AS 
BEGIN
--The script body was encrypted and cannot be reproduced here.
    RETURN
END


GO
GRANT UPDATE
    ON OBJECT::[config].[vwdbClient] TO [OMSApplicationRole]
    AS [dbo];


GO
GRANT SELECT
    ON OBJECT::[config].[vwdbClient] TO [OMSRole]
    AS [dbo];


GO
GRANT SELECT
    ON OBJECT::[config].[vwdbClient] TO [OMSApplicationRole]
    AS [dbo];


GO
GRANT SELECT
    ON OBJECT::[config].[vwdbClient] TO [OMSAdminRole]
    AS [dbo];


GO
GRANT INSERT
    ON OBJECT::[config].[vwdbClient] TO [OMSApplicationRole]
    AS [dbo];


GO
GRANT DELETE
    ON OBJECT::[config].[vwdbClient] TO [OMSApplicationRole]
    AS [dbo];

GO

DECLARE @TABLE NVARCHAR(150) = 'dbClient'
	, @VIEW_SCHEMA NVARCHAR(150) = 'config'
	, @VIEW_NAME NVARCHAR(150) = 'vwdbClient'
	, @VIEWSELECT1 nvarchar(max)
	, @VIEWFROM nvarchar(max) = ' (isnull(TBL.ISHIDDEN,0)=0 OR (config.IsPIAdministrator_NS()) = 1)'
	, @VIEW nvarchar(max)
	, @DEF NVARCHAR(MAX)
	, @TID NVARCHAR(10)
	, @WORKDEF NVARCHAR(MAX)
	, @POS1 INT
	, @POS2 INT
IF EXISTS (SELECT 1 FROM INFORMATION_SCHEMA.COLUMNS WHERE TABLE_NAME= @TABLE AND COLUMN_NAME = 'ISHIDDEN')
BEGIN

	SELECT @DEF=REPLACE( REPLACE( REPLACE( REPLACE(VIEW_DEFINITION, CHAR(10), ' '), CHAR(13), ' '), CHAR(9), ' '),'--JOIN / APPLY to table valued function or ADO.NET dynamic SQL fails in matter centre ','') FROM INFORMATION_SCHEMA.VIEWS WHERE TABLE_SCHEMA= @VIEW_SCHEMA AND TABLE_NAME = @VIEW_NAME
	SET @WORKDEF=RIGHT(@DEF,LEN(@DEF)-CHARINDEX(' FROM ',@Def))

		SET @POS1 = CHARINDEX(' AS ', @WORKDEF) +4
		SET @POS2 = CHARINDEX(' ', @WORKDEF, @POS1)
		SET @TID = SUBSTRING(@WORKDEF, @POS1, @POS2 - @POS1)
					
		IF @DEF NOT LIKE '% '+REPLACE(@VIEWFROM, '(TBL.', '('+ @TID + '.') + '%'
		BEGIN
			SET @VIEW=REPLACE(@DEF, 'CREATE ', 'ALTER ')
			SET @VIEW = @VIEW+' AND '+ REPLACE(@VIEWFROM, '(TBL.', '(' + @TID + '.')
		END
	/************************** ALTER VIEW ********************************/
	EXEC (@VIEW)
	PRINT (@VIEW)
END

GO



