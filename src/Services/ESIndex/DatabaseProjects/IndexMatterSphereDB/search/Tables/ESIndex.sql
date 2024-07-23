﻿CREATE TABLE search.ESIndex
(
	ESIndexId SMALLINT NOT NULL
	, ESIndexName NVARCHAR(128) NOT NULL
	, ESIndexType NVARCHAR(10) NOT NULL
, CONSTRAINT [PK_ESIndex] PRIMARY KEY CLUSTERED (ESIndexId ASC)
)

