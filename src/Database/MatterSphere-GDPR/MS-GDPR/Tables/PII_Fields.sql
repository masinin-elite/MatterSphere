﻿CREATE TABLE [dbo].[PII_Fields]
(
	[Id] INT NOT NULL IDENTITY (1,1) PRIMARY KEY, 
	[PII_ControlTableID] INT NOT NULL,
    [PII_Schema] NVARCHAR(125) NOT NULL, 
    [PII_TableName] NVARCHAR(250) NOT NULL, 
    [PII_ColumnName] NVARCHAR(250) NOT NULL, 
    [PII_Type] SMALLINT NOT NULL,    --0 = DELETE,1 = OBFUSCATE,2 = RELINK
    [PII_RELINKID] BIGINT NULL, 
    [PII_Obfuscation] NVARCHAR(50) NULL
)
