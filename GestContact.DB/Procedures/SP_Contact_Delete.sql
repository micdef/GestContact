CREATE PROCEDURE [dbo].[SP_Contact_Delete]
	@id INT
AS
	DELETE FROM [Contact]
	WHERE [id] = @id;