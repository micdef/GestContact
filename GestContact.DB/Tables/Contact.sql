CREATE TABLE [dbo].[Contact]
(
	[id] INT NOT NULL IDENTITY, 
    [iduser] INT NOT NULL, 
    [fname] NVARCHAR(50) NOT NULL, 
    [lname] NVARCHAR(50) NOT NULL, 
    [tel] NVARCHAR(20) NOT NULL, 
    [email] NVARCHAR(387) NOT NULL, 
    CONSTRAINT [PK-Contact-ID] PRIMARY KEY ([id]), 
    CONSTRAINT [FK-Contact-IDUser] FOREIGN KEY ([iduser]) REFERENCES [User]([id])
)