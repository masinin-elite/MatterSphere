"C:\Program Files[ (x86)]\Microsoft SQL Server\{VersionNumber}\DAC\bin\SqlPackage.exe" /Action:Publish ^
	/SourceFile:"{PATH}\OMSExportE3EMSDB.dacpac" ^
	/Profile:"{PATH}\OMSExportE3EMSDB.publish.xml" ^
	/TargetConnectionString:"Data Source={SERVERNAME};Initial Catalog={DATABASE};Persist Security Info=False;Integrated Security=true;" ^
	/p:BlockOnPossibleDataLoss=FALSE  /p:DropObjectsNotInSource=FALSE ^
	/p:DropPermissionsNotInSource=FALSE  /p:DropRoleMembersNotInSource=FALSE
PAUSE