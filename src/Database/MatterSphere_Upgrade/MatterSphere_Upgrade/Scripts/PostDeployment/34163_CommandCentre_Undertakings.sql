﻿IF NOT EXISTS ( SELECT 'RESOURCE' , 'ADDUNDERTAKING', '{default}' , NULL INTERSECT SELECT cdType , cdCode , cdUICultureInfo , cdAddLink FROM dbo.dbCodeLookup )
BEGIN
	INSERT dbo.dbCodeLookup ( cdType , cdCode , cdUICultureInfo , cdDesc , cdSystem , cdDeletable , cdAddLink , cdHelp , cdNotes , cdGroup )
	VALUES ( 'RESOURCE' , 'ADDUNDERTAKING' , '{default}' , 'Add New Undertaking' , 0 , 1 , NULL , NULL , NULL , 0)
END

IF NOT EXISTS ( SELECT 'RESOURCE' , 'NEWUNDERTAKING', '{default}' , NULL INTERSECT SELECT cdType , cdCode , cdUICultureInfo , cdAddLink FROM dbo.dbCodeLookup )
BEGIN
	INSERT dbo.dbCodeLookup ( cdType , cdCode , cdUICultureInfo , cdDesc , cdSystem , cdDeletable , cdAddLink , cdHelp , cdNotes , cdGroup )
	VALUES ( 'RESOURCE' , 'NEWUNDERTAKING' , '{default}' , 'New Undertaking' , 0 , 1 , NULL , NULL , NULL , 0)
END

IF NOT EXISTS ( SELECT 'RESOURCE' , 'EDITUNDERTAKING', '{default}' , NULL INTERSECT SELECT cdType , cdCode , cdUICultureInfo , cdAddLink FROM dbo.dbCodeLookup )
BEGIN
	INSERT dbo.dbCodeLookup ( cdType , cdCode , cdUICultureInfo , cdDesc , cdSystem , cdDeletable , cdAddLink , cdHelp , cdNotes , cdGroup )
	VALUES ( 'RESOURCE' , 'EDITUNDERTAKING' , '{default}' , 'Edit Undertaking' , 0 , 1 , NULL , NULL , NULL , 0)
END

DECLARE @xml XML;

DECLARE @T TABLE (rn INT PRIMARY KEY, lookup NVARCHAR(100), hidebuttons NVARCHAR(5))

DECLARE @rn INT
	, @lookup NVARCHAR(100)
	, @hidebuttons NVARCHAR(5)
	, @updated BIT = 0

SET @xml = (SELECT typeXML  FROM dbo.dbFileType WHERE typeCode = 'TEMPLATE')

INSERT INTO @T (rn, lookup, hidebuttons)
SELECT  ROW_NUMBER() OVER ( ORDER BY node ) AS rn,
    node.value('@lookup', 'NVARCHAR(100)') AS lookup,
    node.value('@hidebuttons', 'NVARCHAR(5)') AS hidebuttons
FROM    @xml.nodes('/Config/Dialog/Tabs/Tab') x ( node )

DELETE @T WHERE lookup NOT IN ('CLUNDERTAKINGS')

SET @rn = (SELECT TOP 1 rn FROM @T ORDER BY rn)
WHILE @rn IS NOT NULL
BEGIN
	SET @hidebuttons = (SELECT hidebuttons FROM @T WHERE rn = @rn)
	IF @hidebuttons IS NULL
	BEGIN
		SET @xml.modify('insert attribute hidebuttons {"True"} into (/Config/Dialog/Tabs/Tab[sql:variable("@rn")])[1]')
		SET @updated = 1
	END
	SET @rn = (SELECT TOP 1 rn FROM @T WHERE rn > @rn ORDER BY rn)
END

IF @updated = 1
	UPDATE dbo.dbFileType
		SET typeXML = CAST(@xml AS NVARCHAR(MAX))
	WHERE typeCode = 'TEMPLATE'