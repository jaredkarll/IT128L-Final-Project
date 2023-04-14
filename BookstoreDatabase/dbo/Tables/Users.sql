CREATE TABLE [dbo].[Users]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY (1,1), 
    [Username] NVARCHAR(50) NULL, 
    [Password] NVARCHAR(50) NULL, 
    [FirstName] NVARCHAR(50) NULL, 
    [LastName] NVARCHAR(50) NULL
)
