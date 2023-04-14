CREATE PROCEDURE [dbo].[UpdateItem]
    @Id int,
    @Name NVARCHAR(50),
    @Code INT,
    @Brand NVARCHAR(50),
    @Price INT,
    @Quantity NUMERIC(18)
AS
BEGIN
    UPDATE [dbo].[Items]
    SET [Name] = @Name,
        [Code] = @Code,
        [Brand] = @Brand,
        [Price] = @Price,
        [Quantity] = @Quantity
    WHERE [Id] = @Id;
END