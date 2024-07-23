IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[GetE3EMatterUpdateXML]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
DROP FUNCTION [dbo].[GetE3EMatterUpdateXML]
GO

CREATE FUNCTION [dbo].[GetE3EMatterUpdateXML] ( @FILEID BIGINT )
RETURNS NVARCHAR ( MAX ) AS
BEGIN
DECLARE @XML NVARCHAR ( MAX ) 

--V0.1
--TODO - VALIDATE VARIABLE WIDTHS AND SOME FIELDS
--NOTE - OVERRIDES EFFECTIVE DATED DATA CURRENTLY

--OPTIONS
DECLARE @USEPROXYUSER				BIT
SET @USEPROXYUSER					= 0

--REPLACEMENT VARIABLES
--MATTER
DECLARE @MATTINDEX					NVARCHAR ( 10 ) 
DECLARE @DISPLAYNAME				NVARCHAR ( 255 )
DECLARE @MATTSTATUS					NVARCHAR ( 20 ) 
DECLARE @MATTTYPE					NVARCHAR ( 30 )
DECLARE @NARRATIVE					NVARCHAR ( MAX )
--MATTDTE
DECLARE @OFFICE						NVARCHAR ( 20 )
DECLARE @DEPARTMENT					NVARCHAR ( 20 )
DECLARE @SECTION					NVARCHAR ( 20 )
DECLARE @PRACTICEGROUP				NVARCHAR ( 20 )
DECLARE @BILLTKPR					NVARCHAR ( 10 )
DECLARE @RSPTKPR					NVARCHAR ( 10 )
DECLARE @ARRANGEMENT				NVARCHAR ( 20 )
--PROXY AND EFFECTIVEDATE
DECLARE @PROXYUSER					NVARCHAR ( 50 )
DECLARE @NEEDEFFECTIVEDATEDUPDATE BIT

SELECT 
--MATTER
	@MATTINDEX						= DBFILE.FILEEXTLINKID
	, @DISPLAYNAME					= DBFILE.FILEDESC
	, @MATTTYPE						= ISNULL ( DBFILETYPE.FILEACCCODE , 'MISSING' )
	, @NARRATIVE					= ISNULL ( FILENOTES , '' )
	, @OFFICE						= ISNULL ( DBBRANCH.BRCODE , 'MISSING' )
--MATTDATE	
	, @DEPARTMENT					= ISNULL ( DBDEPARTMENT.DEPTACCCODE , 'MISSING' )
	, @SECTION						= '000'                             --TODO - WHAT IS THIS AND WHAT IS THIS IN MATTERCENTRE
	, @PRACTICEGROUP				= 'Default'                   --TODO - WHAT IS THIS AND WHAT IS THIS IN MATTERCENTRE
	, @BILLTKPR						= ISNULL ( CONVERT ( NVARCHAR ( 10 ) , DBFEEEARNER.FEEEXTID ) , 'MISSING' )
	, @RSPTKPR						= ISNULL ( CONVERT ( NVARCHAR ( 10 ) , RESPONSIBLE.FEEEXTID ) , 'MISSING' )
	, @ARRANGEMENT					= 'Hourly'                    --TODO - WHAT IS THIS AND WHAT IS THIS IN MATTERCENTRE
--PROXY AND EFFECTIVEDATE
	, @PROXYUSER					= CASE WHEN @USEPROXYUSER = 1 THEN 'ProxyUser="' + UPDATEDBY.USRADID + '"' ELSE '' END 
	, @NEEDEFFECTIVEDATEDUPDATE		= FILEE3EEFFECTIVEDATEDNEEDUPDATE
FROM 
	DBFILE
INNER JOIN 
	DBFILETYPE ON DBFILE.FILETYPE = DBFILETYPE.TYPECODE
INNER JOIN 
	DBCLIENT ON DBCLIENT.CLID = DBFILE.CLID
INNER JOIN 
	DBFEEEARNER ON DBFEEEARNER.FEEUSRID = DBFILE.FILEPRINCIPLEID
INNER JOIN 
	DBFEEEARNER RESPONSIBLE ON RESPONSIBLE.FEEUSRID = DBFILE.FILERESPONSIBLEID
INNER JOIN 
	DBBRANCH ON DBBRANCH.BRID = DBFILE.BRID
INNER JOIN 
	DBDEPARTMENT ON DBDEPARTMENT.DEPTCODE = DBFILE.FILEDEPARTMENT
INNER JOIN 
	DBUSER UPDATEDBY ON UPDATEDBY.USRID = DBFILE.UPDATEDBY
WHERE 
	DBFILE.FILEID = @FILEID AND
	DBCLIENT.CLEXTID > 0 AND 
	DBFILE.FILEEXTLINKID > 0

--{0} is placeholder for Add/Edit logic - Service changes these values when it checks 3E for that matter
--{1} is placeholder for KeyField="EffStart" KeyValue="2012-05-02T00:00:00"
--NEEDS VALIDATION WITH ELITE
SELECT @XML = 
'<Matter_Srv xmlns="http://elite.com/schemas/transaction/process/write/Matter_Srv" ' + @PROXYUSER + '>
  <Initialize xmlns="http://elite.com/schemas/transaction/object/write/Matter">
   <Edit>
    <Matter KeyValue = "' +						@MATTINDEX					+ '">
     <Attributes>
        <DisplayName>' +	DBO.GETHTMLENCODE ( @DISPLAYNAME, 0 )			+ '</DisplayName>
        <MattType>' +		DBO.GETHTMLENCODE ( @MATTTYPE, 0 )				+ '</MattType>
        <Narrative>' +		DBO.GETHTMLENCODE ( @NARRATIVE, 0 )				+ '</Narrative>
     </Attributes>
     <Children>'
     
IF @NEEDEFFECTIVEDATEDUPDATE = 1 SET @XML = @XML +'
      <MattDate>
       <{0}>
        <MattDate {1}>
         <Attributes>
          <EffStart>{2}</EffStart>
          <Office>' +		DBO.GETHTMLENCODE ( @OFFICE, 0 )						+ '</Office>
          <Department>' +	DBO.GETHTMLENCODE ( @DEPARTMENT, 0 )					+ '</Department>
          <Section>' +							@SECTION							+ '</Section>
          <PracticeGroup>' +					@PRACTICEGROUP						+ '</PracticeGroup>
          <BillTkpr>' +							@BILLTKPR							+ '</BillTkpr>
          <RspTkpr>' +							@RSPTKPR							+ '</RspTkpr>
          <Arrangement>'+						@ARRANGEMENT						+ '</Arrangement>
         </Attributes>
        </MattDate>
       </{0}>
      </MattDate>'

SET @XML = @XML + '
     </Children>
    </Matter>
   </Edit>
  </Initialize>
</Matter_Srv>'

RETURN @XML
END
