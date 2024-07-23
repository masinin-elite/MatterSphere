﻿

CREATE PROCEDURE [dbo].[srepTskInComp]
(
	@UI uUICultureInfo = '{default}'
	, @FILEID bigint 
)

AS 
SET NOCOUNT ON
SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED

SELECT     
	T.tskType, 
	T.tskDesc, 
	T.tskDue, 
	CASE
	WHEN T.tskNotes IS NOT NULL THEN 'Notes: ' + Convert(nvarchar(4000), T.tskNotes)
	END AS Notes, 
	T.tskCompleted, 
	T.tskComplete,  
	T.tskActive, 
	T.Created, 
	T.Updated, 
	U.usrFullName, 
	X.cdDesc as TaskType ,
	CL.clNo, 
	F.fileNo, 
	CL.clName, 
	F.fileDesc
FROM         
	dbo.dbTasks T
INNER JOIN
	dbo.dbUser U ON T.feeusrID = U.usrID
INNER JOIN
	dbo.dbFile F ON T.fileID = F.fileID 
INNER JOIN
	dbo.dbClient CL ON F.clID = CL.clID
LEFT OUTER JOIN
	dbo.GetCodeLookUpDescription('TASKTYPE', @UI) AS X ON X.cdCode = T.tskType 
WHERE
	T.tskcomplete = 0 AND
	T.tskActive = 1 AND
	F.fileID = @FILEID

GO
GRANT EXECUTE
    ON OBJECT::[dbo].[srepTskInComp] TO [OMSRole]
    AS [dbo];


GO
GRANT EXECUTE
    ON OBJECT::[dbo].[srepTskInComp] TO [OMSAdminRole]
    AS [dbo];
