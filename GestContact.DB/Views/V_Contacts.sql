CREATE VIEW [dbo].[V_Contacts]
AS
	SELECT	[id],
			[iduser],
			[fname],
			[lname],
			[tel],
			[email]
	FROM [Contact]