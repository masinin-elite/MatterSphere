CREATE PROCEDURE [dbo].[sprC3EExportTime] 
AS
--CHECK IF A CUSTOM VERSION EXISTS - MUST RETURN SAME COLUMNS AS STANDARD VERSION
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sprC3EExportTime_CUSTOM]') AND type in (N'P', N'PC'))
	EXEC [dbo].[sprC3EExportTime_CUSTOM]
ELSE

SELECT  
	DBTIMELEDGER.ID
	, DBO.GETE3ETIMEEXPORTXML ( DBTIMELEDGER.ID, N'C3E' ) AS TIMECARDPENDING
	, DBFILE.FILEID
	, FILEEXTLINKID AS MATTINDEX
	, FILEEXTLINKTXTID AS MATTID
FROM 
	DBTIMELEDGER
INNER JOIN 
	DBFILE ON DBTIMELEDGER.FILEID = DBFILE.FILEID
INNER JOIN 
	DBFEEEARNER ON DBFEEEARNER.FEEUSRID = DBTIMELEDGER.FEEUSRID
WHERE 
	DBTIMELEDGER.TIMETRANSFERRED = 0 AND			--NOT ALREADY TRANSFERRED 
	DBTIMELEDGER.TIMETRANSFERREDID IS NULL AND		--NO TRANSFERRED ID - CATERING FOR -1 INTERFACE FAILURES
	ISNULL(DBFILE.FILEEXTLINKID, 0) <> -1 AND		--WE HAVE A VALID MATTINDEX STORED FOR THE MATTER
	(DBFILE.FILEEXTLINKTXTID IS NOT NULL OR DBFILE.FILEEXTLINKID > 0) AND
	DBFEEEARNER.FEEEXTID IS NOT NULL				--THE FEE EARNER IS MAPPED TO A E3E TIMEKEEPER
