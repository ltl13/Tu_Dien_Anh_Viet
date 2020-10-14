CREATE DATABASE UserManagement

USE UserManagement

CREATE TABLE Account
(
	UserName VARCHAR(50) PRIMARY KEY,	
	DisplayName NVARCHAR(100) NOT NULL DEFAULT N'Guest',
	PassWord VARCHAR(50) NOT NULL DEFAULT 0,
	Type INT NOT NULL  DEFAULT 0 -- 1: admin && 0: staff
)

INSERT INTO [Account]
VALUES ('ad', N'Guest', '123456', 1)

SELECT * FROM [Account] WHERE UserName = 'ad' AND PassWord = '123456'