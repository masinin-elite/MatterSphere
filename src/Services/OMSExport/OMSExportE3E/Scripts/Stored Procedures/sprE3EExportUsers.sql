IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sprE3EExportUsers]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[sprE3EExportUsers]
GO


CREATE PROCEDURE [dbo].[sprE3EExportUsers]
AS
RAISERROR ( 'sprE3EExportUsers not used currently', 16 , 1 )
