CREATE VIEW [dbo].[V_Users]
AS 
	SELECT	[id],
			[email],
			[fname],
			[lname]
	FROM [User]
