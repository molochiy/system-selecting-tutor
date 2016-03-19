USE SST;
GO

CREATE PROC spGetUserByLogin
	@Login VARCHAR(50),
	@Password VARCHAR(50)

AS

BEGIN

	SELECT 
		Id, 
		FirstName, 
		LastName, 
		[Login], 		
		[Disabled] 
	FROM tblUser
	WHERE [Login] = @Login and [Password] = @Password and [Disabled] <> 1;

END;
GO