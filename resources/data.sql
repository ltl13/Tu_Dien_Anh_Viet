CREATE DATABASE DailyDictionary

USE DailyDictionary

CREATE TABLE Account
(
	ID INT NOT NULL IDENTITY(1,1) PRIMARY KEY,
	UserName VARCHAR(50) NOT NULL,
	DisplayName NVARCHAR(100) NOT NULL DEFAULT N'Guest',
	PassWord CHAR(64) NOT NULL,
	Type TINYINT NOT NULL  DEFAULT 0 -- 1: admin && 0: staff
)

CREATE PROC USP_Login
@userName varchar(50), @passWord char(64)
AS
BEGIN
	SELECT * FROM dbo.Account WHERE UserName = @userName AND PassWord = @passWord
END

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
			UPDATE dbo.Account SET DisplayName = @displayName WHERE UserName = @userName
		END		
		ELSE
			UPDATE dbo.Account SET DisplayName = @displayName, PassWord = @newPassword WHERE UserName = @userName
	END
END