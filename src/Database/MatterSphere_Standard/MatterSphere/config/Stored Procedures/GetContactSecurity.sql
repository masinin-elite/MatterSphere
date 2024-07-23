﻿

CREATE PROCEDURE [config].[GetContactSecurity]
	@contactID bigint ,
	@ui uCodeLookup = '{default}'

AS
SET NOCOUNT ON
SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED

SELECT DISTINCT
	UGM.[ID] as [ID] ,
	UGM.[Name] as GroupName,
	COALESCE(CL.cdDesc, '~' + NULLIF(MP.[SecurableType], '') + '~') as [SecurableType] ,
	MP.[Permission] as [Permission] ,
	Permission as PermissionCode ,
	MP.[Allow] ,
	MP.[Deny] ,
	MP.[Byte] ,
	MP.[BitValue] ,
	MP.[MajorType] ,
	MP.[NodeLevel] ,
	CASE PT.[Type] WHEN 'EXPLICITOBJ' THEN NULL ELSE UGC.[PolicyID] END as [PolicyID]

FROM
	[config].[GetUserAndGroupMembership]() UGM
JOIN
	[relationship].[UserGroup_Contact] UGC ON UGC.[UserGroupID] = UGM.[ID]
JOIN 
	[config].[ObjectPolicy] PT ON PT.[ID] = UGC.[PolicyID]
CROSS APPLY 
	[config].[MaskToPermissions] ( PT.[AllowMask] , PT.[DenyMask] ) MP
LEFT JOIN
	[dbo].[GetCodeLookupDescription] ( 'SECURABLE', @ui ) CL ON CL.[cdCode] = MP.[SecurableType]

WHERE 
	UGC.[ContactID] = @contactID
ORDER BY 
	MP.NodeLevel



GO
GRANT EXECUTE
    ON OBJECT::[config].[GetContactSecurity] TO [OMSRole]
    AS [dbo];


GO
GRANT EXECUTE
    ON OBJECT::[config].[GetContactSecurity] TO [OMSAdminRole]
    AS [dbo];
