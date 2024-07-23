IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[GetE3EClientExportXML]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
DROP FUNCTION [dbo].[GetE3EClientExportXML]
GO

CREATE FUNCTION [dbo].[GetE3EClientExportXML] ( @CLID BIGINT )
RETURNS NVARCHAR ( MAX ) AS
BEGIN
DECLARE @XML NVARCHAR ( MAX ) 

--V0.1

--SIMPLY BUILD THE STRING TO COLLECT DATA TO SEND THROUGH TO WEBSERVICE
--THIS ALLOWS FOR EASE OF CUSTOMISATION AT SITE IF USING FWBS OMS EXPORT SERVICE

--OPTIONS
DECLARE @USEPROXYUSER				BIT
SET @USEPROXYUSER					= 0

--REPLACEMENT VARIABLES
--CLIENT
DECLARE @ENTITY						NVARCHAR ( 10 )		--ENTITY.ENTINDEX
DECLARE @NUMBER						NVARCHAR ( 12 ) 
DECLARE @DISPLAYNAME				NVARCHAR ( 128 )
DECLARE @CLISTATUSTYPE				NVARCHAR ( 16 )
DECLARE @OPENDATE					NVARCHAR ( 19 )
DECLARE @OPENTKPR					NVARCHAR ( 10 ) 
DECLARE @ISPAYOR					NVARCHAR ( 1 )
DECLARE @INVOICESITE				NVARCHAR ( 13 )		--TO CATER FOR REPLACEMENT VARIABLE
DECLARE @NARRATIVE					NVARCHAR ( MAX )
DECLARE @VATREGISTRATION			NVARCHAR ( 64 )	
DECLARE @LOADSOURCE					NVARCHAR ( 15 ) 
DECLARE @LOADNUMBER					NVARCHAR ( 21 )		--MAX LENGTH OF A NEGATIVE BIGINT 
--CLIDATE
DECLARE @BILLTKPR					NVARCHAR ( 10 )
DECLARE @RSPTKPR					NVARCHAR ( 10 )
DECLARE @SPVTKPR					NVARCHAR ( 10 )
DECLARE @OFFICE						NVARCHAR ( 16 )
--PROXY
DECLARE @PROXYUSER					NVARCHAR ( 50 )

--POPULATE THE VARIABLES
SELECT 
--CLIENT
	@ENTITY							= ISNULL ( CONVERT ( NVARCHAR ( 10 ) , DBCONTACT.CONTEXTID ) , '%ENTITY%' ) -- IF NULL, THEN THE REPLACEMENT OCCURS IN THE SERVICE AS CREATED AT THE SAME TIME
	, @NUMBER						= CLNO
	, @DISPLAYNAME					= ISNULL ( CLNAME , 'MISSING' )
	, @CLISTATUSTYPE				= 'Pending'
	, @OPENDATE						= CONVERT ( NVARCHAR ( 11 ) , DBO.UTCTOLOCALTIME ( DBCLIENT.CREATED ), 0 )
	, @OPENTKPR						= ISNULL ( CONVERT ( NVARCHAR ( 10 ) , DBFEEEARNER.FEEEXTID ) , 'MISSING' )
	, @ISPAYOR						= '1' 
	, @INVOICESITE					= '%INVOICESITE%'	--THIS IS REPLACED IN SERVICE CODE BY EITHER ENTITY'S DEFAULT SITE ALREADY AVAILABLE, OR THE ENTITY JUST CREATED
	, @NARRATIVE					= ISNULL ( DBCLIENT.CLNOTES , '' )
	, @VATREGISTRATION				= ISNULL ( DBCONTACTCOMPANY.CONTVATREGNO  , '' )
	, @LOADSOURCE					= 'MatterSphere'
	, @LOADNUMBER					= CONVERT ( NVARCHAR ( 21 ) , DBCLIENT.CLID ) 
--CLIDATE	
	, @BILLTKPR						= ISNULL ( CONVERT ( NVARCHAR ( 10 ) , DBFEEEARNER.FEEEXTID ) , 'MISSING' ) 
	, @RSPTKPR						= ISNULL ( CONVERT ( NVARCHAR ( 10 ) , DBFEEEARNER.FEEEXTID ) , 'MISSING' ) 
	, @SPVTKPR						= ISNULL ( CONVERT ( NVARCHAR ( 10 ) , DBFEEEARNER.FEEEXTID ) , 'MISSING' ) 
	, @OFFICE						= ISNULL ( DBBRANCH.BRCODE , 'MISSING' )
--PROXY	
	, @PROXYUSER					= CASE WHEN @USEPROXYUSER = 1 THEN 'ProxyUser="' + CREATEDBY.USRADID + '"' ELSE '' END 
FROM 
	DBCLIENT
LEFT JOIN --GET DEFAULT CONTACT TO SEE IF IT'S A COMPANY
	DBCONTACTCOMPANY ON DBCLIENT.CLDEFAULTCONTACT = DBCONTACTCOMPANY.CONTID
INNER JOIN 
	DBFEEEARNER ON DBFEEEARNER.FEEUSRID = DBCLIENT.FEEUSRID
INNER JOIN 
	DBBRANCH ON DBBRANCH.BRID = DBCLIENT.BRID
INNER JOIN 
	DBCONTACT ON DBCONTACT.CONTID = DBCLIENT.CLDEFAULTCONTACT
INNER JOIN 
	DBUSER CREATEDBY ON CREATEDBY.USRID = DBCLIENT.CREATEDBY
WHERE 
	CLID = @CLID


SELECT @XML = 
'<Client_Srv xmlns="http://elite.com/schemas/transaction/process/write/Client_Srv" ' + @PROXYUSER + '>
  <Initialize xmlns="http://elite.com/schemas/transaction/object/write/Client">
   <Add>
    <Client>
     <Attributes>
      <Entity>' +								@ENTITY						+ '</Entity>
      <Number>' +								@NUMBER						+ '</Number>
      <DisplayName>' +		DBO.GETHTMLENCODE ( @DISPLAYNAME, 0 )			+ '</DisplayName>
	  <CliStatusType>' +						@CLISTATUSTYPE				+ '</CliStatusType>
	  <OpenDate>' +								@OPENDATE					+ '</OpenDate>
      <OpenTkpr>' +								@OPENTKPR					+ '</OpenTkpr>
      <IsPayor>' +								@ISPAYOR					+ '</IsPayor>
      <InvoiceSite>' +							@INVOICESITE				+ '</InvoiceSite>
	  <Narrative>' +		DBO.GETHTMLENCODE ( @NARRATIVE, 0 )				+ '</Narrative>
	  <VATRegistration>' +	DBO.GETHTMLENCODE ( @VATREGISTRATION, 0 )		+ '</VATRegistration>
	  <LoadSource>' + 							@LOADSOURCE					+ '</LoadSource>
	  <LoadNumber>' +							@LOADNUMBER					+ '</LoadNumber>
	  <PayorTaxNum>' +		DBO.GETHTMLENCODE ( @VATREGISTRATION, 0 )		+ '</PayorTaxNum>
     </Attributes>
     <Children>
      <CliDate>
       <Edit>
        <CliDate Position="0">
         <Attributes>
	      <BillTkpr>' +							@BILLTKPR					+ '</BillTkpr>
	      <RspTkpr>' +							@RSPTKPR					+ '</RspTkpr>
	      <SpvTkpr>' +							@SPVTKPR					+ '</SpvTkpr>
	      <Office>' +		DBO.GETHTMLENCODE ( @OFFICE, 0 )				+ '</Office>
         </Attributes>
        </CliDate>
       </Edit>	
      </CliDate>			
     </Children>		
    </Client>
   </Add>
  </Initialize>
 </Client_Srv>'


RETURN @XML
END
GO