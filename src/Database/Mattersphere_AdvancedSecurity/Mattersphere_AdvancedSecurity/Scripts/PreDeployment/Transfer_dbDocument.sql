﻿IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'config.dbDocument') AND type = 'SN')
BEGIN
	DROP SYNONYM  config.dbDocument
END

GO

IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'config.dbDocument') AND type = 'U')
BEGIN
	ALTER SCHEMA config TRANSFER dbo.dbDocument
END
GO