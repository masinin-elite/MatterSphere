﻿IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[search].[GetMSPrecedentsAData]') AND type in (N'P', N'PC'))
	DROP PROCEDURE [search].[GetMSPrecedentsAData]
