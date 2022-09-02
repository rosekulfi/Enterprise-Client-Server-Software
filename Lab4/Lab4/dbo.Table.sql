CREATE TABLE [dbo].[Conversions]
(
	[Id] INT NOT NULL, 
    [Unit] NVARCHAR(MAX) NOT NULL, 
    [Factor] FLOAT NOT NULL,
	PRIMARY KEY CLUSTERED ([Id] ASC)
)
