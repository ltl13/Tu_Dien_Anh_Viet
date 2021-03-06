USE [master]
GO

CREATE DATABASE DailyDictionary
GO

USE DailyDictionary
GO

CREATE TABLE Account
(
	ID INT NOT NULL IDENTITY(1,1) PRIMARY KEY,
	UserName VARCHAR(50) NOT NULL,
	DisplayName NVARCHAR(20) NOT NULL DEFAULT 'Guest',
	PassWord CHAR(64) NOT NULL,
)
GO

CREATE TABLE Picture
(
	ID INT NOT NULL REFERENCES Account(ID),
	PictureData VARBINARY(MAX) NOT NULL
)
GO

CREATE TABLE FavoriteWord
(
	ID INT NOT NULL REFERENCES Account(ID),
	English NVARCHAR(MAX),
	VietNamese NVARCHAR(MAX),
)
GO

CREATE PROC USP_Login
	@userName VARCHAR(50), 
	@passWord CHAR(64)
AS
BEGIN
	SELECT * FROM dbo.Account WHERE UserName = @userName AND PassWord = @passWord
END
GO

CREATE PROC USP_UpdateAccount
	@userName VARCHAR(50), 
	@displayName NVARCHAR(100), 
	@password CHAR(64), 
	@newPassword CHAR (64)
AS
BEGIN
	DECLARE @isRightPass INT = 0
	
	SELECT @isRightPass = COUNT(*) FROM dbo.Account WHERE UserName = @userName AND PassWord = @password
	
	IF (@isRightPass = 1)
	BEGIN
		IF (@newPassword = NULL OR @newPassword = '')
		BEGIN
			UPDATE Account SET DisplayName = @displayName WHERE UserName = @userName
		END		
		ELSE
			UPDATE Account SET DisplayName = @displayName, PassWord = @newPassword WHERE UserName = @userName
	END
END
GO

CREATE PROCEDURE USP_SaveImage
	@Id INT OUTPUT,
	@Data VARBINARY(MAX)
AS
SET NOCOUNT ON
SET XACT_ABORT ON
	DECLARE @haveImage INT = 0
	SELECT @haveImage = COUNT(*) FROM dbo.Picture WHERE ID = @Id

	IF (@haveImage = 1)
	BEGIN
		UPDATE Picture SET PictureData = @Data WHERE ID = @Id
	END
	ELSE
	BEGIN
		INSERT INTO Picture (ID, PictureData)
		VALUES (@Id ,@Data)
	END
GO