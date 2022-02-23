﻿CREATE TABLE [dbo].[SurgicalConsumableItems] (
    [no]       INT           IDENTITY (1, 1) NOT NULL,
    [itemno]   AS            ('SC'+right('000000'+CONVERT([varchar](10),[no],0),(6))) PERSISTED NOT NULL,
    [itemname] NVARCHAR (50) NOT NULL,
    [regdate]  DATE          NOT NULL,
    CONSTRAINT [PK_SurgicalConsumableItems] PRIMARY KEY CLUSTERED ([itemno] ASC)
);

