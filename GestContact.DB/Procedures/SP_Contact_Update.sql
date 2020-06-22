CREATE PROCEDURE [dbo].[SP_Contact_Update]
	@id INT, 
    @fname NVARCHAR(50), 
    @lname NVARCHAR(50), 
    @tel NVARCHAR(20),
    @email NVARCHAR(387) 
AS
	UPDATE [Contact]
    SET [fname] = @fname,
        [lname] = @lname,
        [tel] = @tel,
        [email] = @email
    WHERE [id] = @id;