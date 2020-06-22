CREATE PROCEDURE [dbo].[SP_Contact_Insert]
	@iduser INT, 
    @fname NVARCHAR(50), 
    @lname NVARCHAR(50), 
    @tel NVARCHAR(20), 
    @email NVARCHAR(387)
AS
	INSERT INTO [Contact] ([iduser], [fname], [lname], [tel], [email])
    OUTPUT inserted.id
    VALUES (@iduser, @fname, @lname, @tel, @email);