﻿
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


IF NOT EXISTS (SELECT * FROM sys.database_principals WHERE name = N'OMSApplicationRole' AND type = 'A')
	CREATE APPLICATION ROLE [OMSApplicationRole] WITH PASSWORD = 'M@tterCentre' , DEFAULT_SCHEMA = [dbo]
GO


SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER OFF
GO


