CREATE PROCEDURE [dbo].[Proc_Adduser]
	@Username NVARCHAR(25),
	@Password NVARCHAR(25),
	@Money BIGINT,
	@IP NVARCHAR(50),
	@Email NVARCHAR(200),
	@Level INT
AS
	DECLARE @UserID INT
	INSERT INTO Users(Pseudo,Password,IP,Email,Money) VALUES (@Username,@Password,@IP,@Email,@Money)
	SET @UserID = (SELECT MAX(@@IDENTITY) FROM Users)
	INSERT INTO MUserIcon(UserID,IconId) SELECT @UserID,IconID FROM Icon WHERE Level LIKE 1
