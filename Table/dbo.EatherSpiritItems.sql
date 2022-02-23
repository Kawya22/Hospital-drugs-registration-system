﻿CREATE TABLE [dbo].[EatherSpiritItems] (
    [no]       INT           IDENTITY (1, 1) NOT NULL,
	[itemno]   AS            ('ES'+right('000000'+CONVERT([varchar](10),[no],0),(6))) PERSISTED NOT NULL,    [itemname] NVARCHAR (50) NOT NULL,
    [regdate]  DATE          NOT NULL,
    CONSTRAINT [PK_EatherSpiritItems] PRIMARY KEY CLUSTERED ([itemno] ASC)
);

