﻿

CREATE PROCEDURE [dbo].[srepMilestoneDates]
(@UI uUICultureInfo='{default}',
@msplan nvarchar(50) = null,
@filestat nvarchar(50) = null,
@Source nvarchar(50) = null,
@brID nvarchar(50)= null,
@FundingType nvarchar(50) = null,
@feePrincipleID int = null)
AS 

declare @Select nvarchar(1900)
declare @Where nvarchar(2000)
declare @orderby nvarchar(100)

--- Select Statement for the base Query
set @select = N'SELECT     dbo.dbFile.fileNo, dbo.dbClient.clNo, replace(dbo.dbFile.fileDesc, char(13) + char(10), '', '') as fileDesc, dbo.dbClient.clName, dbo.dbUser.usrInits, dbo.dbUser.usrFullName, dbo.dbFile.brID, 
                      dbo.dbFile.fileFundCode, dbo.dbClient.clSource, 
                      dbo.dbFile.fileStatus, dbo.dbMSData_OMS2K.*
FROM         dbo.dbFile INNER JOIN
                      dbo.dbMSData_OMS2K ON dbo.dbFile.fileID = dbo.dbMSData_OMS2K.fileID INNER JOIN
                      dbo.dbClient ON dbo.dbFile.clID = dbo.dbClient.clID INNER JOIN
                      dbo.dbUser ON dbo.dbFile.filePrincipleID = dbo.dbUser.usrID'

---- Debug Print
PRINT @SELECT

---- Build Where Clause
SET @WHERE = ''

if coalesce(@msplan, '') <> ''
BEGIN
   IF @where <> '' 
	BEGIN
	     set @where = @where + ' AND dbo.dbmsdata_oms2k.mscode = ''' + @msplan + ''''
	END
   ELSE
	BEGIN
	     set @where = @where + ' dbo.dbmsdata_oms2k.mscode = ''' + @msplan + ''''
	END
END

if coalesce(@filestat, '') <> ''
BEGIN
   IF @where <> '' 
	BEGIN
	     set @where = @where + ' AND dbo.dbfile.filestatus = ''' + @filestat + ''''
	END
   ELSE
	BEGIN
	     set @where = @where + ' dbo.dbfile.Filestatus = ''' + @filestat + ''''
	END
END

if coalesce(@source, '') <> ''
BEGIN
   IF @where <> '' 
	BEGIN
	     set @where = @where + ' AND dbo.dbclient.clsource = ''' + @source + ''''
	END
   ELSE
	BEGIN
	     set @where = @where + ' dbo.dbclient.clsource = ''' + @source + ''''
	END
END

if coalesce(@brID, '') <> ''
BEGIN
   IF @where <> ''
	BEGIN
	    set @where = @where + ' AND dbo.dbfile.brID = ' + @brID 
	END
   ELSE
	BEGIN
	    set @where = @where + ' dbo.dbfile.brID = ' + @brID 
	END
END

if coalesce(@FundingType, '') <> ''
BEGIN
   IF @where <> ''
	BEGIN
	    set @where = @where + ' AND dbo.dbfile.fileFundCode = ''' + @FundingType + ''''
	END
   ELSE
	BEGIN
	    set @where = @where + ' dbo.dbfile.fileFundCode = ''' + @FundingType + ''''
	END
END   

if not @FeePrincipleID is null
BEGIN
   IF @where <> ''
	BEGIN
	    set @where = @where + ' AND dbo.dbfile.filePrincipleID = ' + convert(nvarchar, @FeePrincipleID)
	END
   ELSE
	BEGIN
	    set @where = @where + ' dbo.dbfile.filePrincipleID = ' + convert(nvarchar, @FeePrincipleID)
	END
END  

--- Add Where Clause
if @where <> ''
BEGIN
	set @where = N' WHERE ' + @where
END

---- Build OrderBy Clause
set @orderby = N''

declare @sql nvarchar(4000)
--- Add Statements together
set @sql = @select + @where + @orderby

--- Debug Print
print @sql


exec sp_executesql @sql, N'@UI nvarchar(10)', @UI

GO
GRANT EXECUTE
    ON OBJECT::[dbo].[srepMilestoneDates] TO [OMSRole]
    AS [dbo];


GO
GRANT EXECUTE
    ON OBJECT::[dbo].[srepMilestoneDates] TO [OMSAdminRole]
    AS [dbo];
