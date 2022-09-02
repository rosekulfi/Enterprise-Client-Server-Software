CREATE TABLE [dbo].[Products] (
    [Id]      INT            NOT NULL,
    [Product] NVARCHAR (MAX) NOT NULL,
    [ProductAdded] NVARCHAR(MAX) NULL, 
    PRIMARY KEY CLUSTERED ([Id] ASC)
);

