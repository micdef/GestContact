CREATE PROCEDURE [dbo].[SP_User_Check]
	@email NVARCHAR(50),
	@password NVARCHAR(50)
AS
	SELECT [id], [email], [fname], [lname] FROM [User] WHERE [email] = @email AND [password] = dbo.F_HashPassword(@password);