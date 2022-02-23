CREATE TABLE [dbo].[DispenseryItems] (
    [no]       INT           IDENTITY (1, 1) NOT NULL,
    [itemno]   AS            ('Ds'+right('000000'+CONVERT([varchar](10),[no],0),(6))) PERSISTED NOT NULL,
    [itemname] NVARCHAR (50) NOT NULL,
    [regdate]  DATE          NOT NULL,
    CONSTRAINT [PK_Dispensery] PRIMARY KEY CLUSTERED ([itemno] ASC)
);

