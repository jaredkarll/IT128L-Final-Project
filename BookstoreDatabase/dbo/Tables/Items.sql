CREATE TABLE [dbo].[Items]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY(1,1), 
    [Name] NVARCHAR(50) NOT NULL, 
    [Code] INT NOT NULL, 
    [Brand] NVARCHAR(50) NOT NULL, 
    [Price] INT NOT NULL, 
    [Quantity] NUMERIC NOT NULL
)
