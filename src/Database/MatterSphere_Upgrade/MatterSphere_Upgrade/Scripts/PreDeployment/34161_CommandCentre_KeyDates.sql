﻿IF COL_LENGTH('dbo.dbDateWizTypes', 'typeVersion') IS NOT NULL
BEGIN
	EXEC(N'UPDATE dbo.dbDateWizTypes SET typeEnquiry =
	CASE
		WHEN typeEnquiry = ''SCRDWZ94AEXPNEW'' THEN ''SIPDWZ94AEXPIRY''
		WHEN typeEnquiry = ''SCRDWZBANKEXNEW'' THEN ''SIPDWZBANKEXP''
		WHEN typeEnquiry = ''SCRDBRCHCONTNEW'' THEN ''SIPDWZBRCHCONT''
		WHEN typeEnquiry = ''SCRDBCHCONTENEW'' THEN ''SIPDWZBRCHCONTE''
		WHEN typeEnquiry = ''SCRDCOMPURCHNEW'' THEN ''SIPDWZCOMPPURCH''
		WHEN typeEnquiry = ''SCRDDISCRIMNEW'' THEN ''SIPDWZDISCRIMIN''
		WHEN typeEnquiry = ''SCRDLANCHARGNEW'' THEN ''SIPDWZLANDCHARG''
		WHEN typeEnquiry = ''SCRDLANDREGNEW'' THEN ''SIPDWZLANDREG''
		WHEN typeEnquiry = ''SCRDLBCNEGOTNEW'' THEN ''SIPDWZLBCNEGOT''
		WHEN typeEnquiry = ''SCRDPLIMDATENEW'' THEN ''SIPDWZPILIMDATE''
		WHEN typeEnquiry = ''SCRDLOCALSCHNEW'' THEN ''SIPDWZLOCALSCH''
		WHEN typeEnquiry = ''SCRDMTGOFFERNEW'' THEN ''SIPDWZMRTGOFFER''
		WHEN typeEnquiry = ''SCRDSTANDLNEW'' THEN ''SIPDWZSTANDARDL''
		WHEN typeEnquiry = ''SCRDUNFDISNEW'' THEN ''SIPDWZUNFAIRDIS''
	END
	WHERE typeVersion = 9')

	ALTER TABLE dbo.dbDateWizTypes DROP COLUMN typeVersion
END
GO