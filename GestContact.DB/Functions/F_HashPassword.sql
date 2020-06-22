CREATE FUNCTION [dbo].[F_HashPassword]
(
	@pwd NVARCHAR(50)
)
RETURNS VARBINARY(64)
AS
BEGIN
	RETURN HASHBYTES('SHA2_512', [dbo].F_PreSalt() + @pwd + [dbo].F_PostSalt());
END