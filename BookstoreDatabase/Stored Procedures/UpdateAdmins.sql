CREATE PROCEDURE [dbo].[UpdateAdmins]
	@Id INT,
    @Username NVARCHAR(50),
    @Password NVARCHAR(50),
    @FirstName NVARCHAR(50),
    @LastName NVARCHAR(50)
AS
BEGIN
    UPDATE [dbo].[Users]
    SET Username = @Username, 
        Password = @Password, 
        FirstName = @FirstName, 
        LastName = @LastName
    WHERE [Id] = @Id;
END