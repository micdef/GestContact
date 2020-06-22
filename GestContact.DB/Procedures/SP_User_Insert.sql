CREATE PROCEDURE [dbo].[SP_User_Insert]
	@password NVARCHAR(50),
	@firstname NVARCHAR(50),
	@lastname NVARCHAR(50),
	@email NVARCHAR(387)
AS
	INSERT INTO [User] ([fname], [lname], [email], [password]) 
	OUTPUT inserted.id 
	VALUES (@firstname, @lastname, @email, dbo.F_HashPassword(@password));