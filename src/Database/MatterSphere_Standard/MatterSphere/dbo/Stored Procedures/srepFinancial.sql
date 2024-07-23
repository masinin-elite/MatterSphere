﻿

CREATE PROCEDURE [dbo].[srepFinancial]
(
	@UI uUICultureInfo = '{default}'
	, @FILETYPE nvarchar(15) = NULL
	, @POSTINGTYPE int = NULL
	, @DEPARTMENT nvarchar(15) = NULL
	, @ENTRYTYPE int = NULL
	, @FUNDINGTYPE nvarchar(15) = NULL
	, @LACAT nvarchar(15) = NULL
	, @FEEEARNER int = NULL
	, @STARTDATE datetime = NULL
	, @ENDDATE datetime = NULL
)

AS 

DECLARE @SELECT nvarchar(1900)
DECLARE @WHERE nvarchar(2000)
DECLARE @ORDERBY nvarchar(100)

--- SET THE SELECT STATEMENT
SET @SELECT = N'
SET NOCOUNT ON
SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED
SELECT     
	CL.clNo + ''/'' + F.fileNo AS Ref
	, F.fileDesc
	, CL.clNo
	, CL.clName
	, FL.finDesc
	, FL.finItemDate
	, FL.finVat
	, FL.finValue
	, FL.finGross
	, FL.finPaid
	, U.usrInits
	, U.usrFullName
FROM 
	dbFinancialLedger FL
INNER JOIN
	dbFile F ON F.fileID = FL.fileID
INNER JOIN
	dbClient CL ON CL.clID = F.clID
INNER JOIN
	dbUser U ON U.usrID = F.filePrincipleID
LEFT OUTER JOIN
	dbPostingType PT ON PT.postID = FL.postID '

---- SET THE WHERE STATEMENT
SET @WHERE = ''

--- FILE TYPE CLAUSE
IF(@FILETYPE IS NOT NULL)
BEGIN
	SET @WHERE = @WHERE + ' F.fileType = @FILETYPE '
END

--- POSTING TYPE CLAUSE
IF(@POSTINGTYPE IS NOT NULL)
BEGIN
	IF(@WHERE <> '')
	BEGIN
		SET @WHERE = @WHERE + ' AND FL.postID = @POSTINGTYPE '
	END
	ELSE
	BEGIN
		SET @WHERE = @WHERE + ' FL.postID = @POSTINGTYPE '
	END
END

--- DEPARTMENT CLAUSE
IF(@DEPARTMENT IS NOT NULL)
BEGIN
	IF(@WHERE <> '')
	BEGIN
		SET @WHERE = @WHERE + ' AND F.fileDepartment = @DEPARTMENT '
	END
	ELSE
	BEGIN
		SET @WHERE = @WHERE + ' F.fileDepartment = @DEPARTMENT '
	END
END

--- ENTRY TYPE CLAUSE
IF(@ENTRYTYPE IS NOT NULL)
BEGIN
	IF(@WHERE <> '')
	BEGIN
		SET @WHERE = @WHERE + ' AND FL.finEntryID = @ENTRYTYPE '
	END
	ELSE
	BEGIN
		SET @WHERE = @WHERE + ' FL.finentryID = @ENTRYTYPE '
	END
END

--- FUNDING TYPE CLAUSE
IF(@FUNDINGTYPE IS NOT NULL)
BEGIN
	IF(@WHERE <> '')
	BEGIN
		SET @WHERE = @WHERE + ' AND F.fileFundCode = @FUNDINGTYPE '
	END
	ELSE
	BEGIN
		SET @WHERE = @WHERE + ' F.fileFundCode = @FUNDINGTYPE '
	END
END

--- LEGAL AID CATEGORY CLAUSE
IF(@LACAT IS NOT NULL)
BEGIN
	IF(@WHERE <> '')
	BEGIN
		SET @WHERE = @WHERE + ' AND F.fileLACategory = @LACAT '
	END
	ELSE
	BEGIN
		SET @WHERE = @WHERE + ' F.fileLACategory = @LACAT '
	END
END

--- FEE EARNER CLAUSE
IF(@FEEEARNER IS NOT NULL)
BEGIN
	IF(@WHERE <> '')
	BEGIN
		SET @WHERE = @WHERE + ' AND F.filePrincipleID = @FEEEARNER '
	END
	ELSE
	BEGIN
		SET @WHERE = @WHERE + ' F.filePrincipleID = @FEEEARNER '
	END
END

--- FINANCIAL ITEM START DATE AND END DATE
IF(@STARTDATE IS NOT NULL)
BEGIN
	IF(@WHERE <> '')
	BEGIN
		SET @WHERE = @WHERE + ' AND (FL.finItemDate >= @STARTDATE AND FL.finItemDate < @ENDDATE) '
	END
	ELSE
	BEGIN
		SET @WHERE = @WHERE + ' (FL.finItemDate >= @STARTDATE AND FL.finItemDate < @ENDDATE) '
	END
END

--- BUILD THE WHERE CLAUSE
IF @WHERE <> ''
BEGIN
	SET @WHERE = N' WHERE ' + @WHERE
END

DECLARE @SQL nvarchar(4000)
--- ADD THE CLAUSES TOGETHER
SET @SQL = Rtrim(@SELECT) + Rtrim(@WHERE)

-- DEBUG PRINT
-- PRINT @SQL

EXEC sp_executesql @SQL, 
N'
	@UI uUICultureInfo
	, @FILETYPE nvarchar(15)
	, @POSTINGTYPE int
	, @DEPARTMENT nvarchar(15)
	, @ENTRYTYPE int
	, @FUNDINGTYPE nvarchar(15)
	, @LACAT nvarchar(15)
	, @FEEEARNER int
	, @STARTDATE datetime
	, @ENDDATE datetime '
	, @UI
	, @FILETYPE
	, @POSTINGTYPE
	, @DEPARTMENT
	, @ENTRYTYPE
	, @FUNDINGTYPE
	, @LACAT
	, @FEEEARNER
	, @STARTDATE
	, @ENDDATE

GO
GRANT EXECUTE
    ON OBJECT::[dbo].[srepFinancial] TO [OMSRole]
    AS [dbo];


GO
GRANT EXECUTE
    ON OBJECT::[dbo].[srepFinancial] TO [OMSAdminRole]
    AS [dbo];

