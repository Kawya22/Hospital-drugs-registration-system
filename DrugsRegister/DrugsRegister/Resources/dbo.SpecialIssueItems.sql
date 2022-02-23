CREATE TABLE [dbo].[SpecialIssueItems] (
    [no]       INT           IDENTITY (1, 1) NOT NULL,
	[itemno] AS 'WD' + RIGHT('00000' + CAST([no] AS NCHAR(5)), 5) PERSISTED,
    [itemname] NVARCHAR (50) NOT NULL,
    [regdate]  DATE          NOT NULL,
    CONSTRAINT [PK_SpecialIssueItems] PRIMARY KEY CLUSTERED ([itemno] ASC)
);

