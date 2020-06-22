CREATE TABLE [dbo].[User]
(
	[id] INT NOT NULL IDENTITY, 
    [email] NVARCHAR(387) NOT NULL, 
    [password] VARBINARY(64) NOT NULL, 
    [fname] NVARCHAR(50) NOT NULL, 
    [lname] NVARCHAR(50) NOT NULL, 
    CONSTRAINT [PK-User] PRIMARY KEY ([id]),
    CONSTRAINT [UK-User-Email] UNIQUE ([email]),
)
