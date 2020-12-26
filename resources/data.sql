CREATE DATABASE DailyDictionary

USE DailyDictionary

CREATE TABLE Account
(
	ID INT NOT NULL IDENTITY(1,1) PRIMARY KEY,
	UserName VARCHAR(50) NOT NULL,
	DisplayName NVARCHAR(20) NOT NULL DEFAULT 'Guest',
	PassWord CHAR(64) NOT NULL,
)
GO

CREATE TABLE Pictures (
	ID INT FOREIGN KEY REFERENCES Account(ID),
	picFileName NVARCHAR (100),
	PictureData VARBINARY (max)
)
GO

CREATE PROC USP_Login
	@userName varchar(50), 
	@passWord char(64)
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
			UPDATE dbo.Account SET DisplayName = @displayName WHERE UserName = @userName
		END		
		ELSE
			UPDATE dbo.Account SET DisplayName = @displayName, PassWord = @newPassword WHERE UserName = @userName
	END
END
GO

CREATE PROCEDURE dbo.usp_ImportImage
	@ID INT,
	@ImageFolderPath NVARCHAR (1000),
	@Filename NVARCHAR (1000)
AS
BEGIN
	DECLARE @Path2OutFile NVARCHAR (2000);
	DECLARE @tsql NVARCHAR (2000);

	SET NOCOUNT ON
	SET @Path2OutFile = CONCAT (@ImageFolderPath, '\', @Filename);
	SET @tsql = 'INSERT INTO Pictures (pictureName, picFileName, PictureData) ' +
                ' SELECT ' + '''' + @ID + '''' + ',' + '''' + @Filename + '''' + ', * ' + 
                'FROM Openrowset( Bulk ' + '''' + @Path2OutFile + '''' + ', Single_Blob) as img'

	EXEC (@tsql)

	SET NOCOUNT OFF
END
GO

CREATE PROCEDURE dbo.usp_ExportImage
	@ID INT,
	@ImageFolderPath NVARCHAR(1000),
	@Filename NVARCHAR(1000)
AS
BEGIN
   DECLARE @ImageData VARBINARY (max);
   DECLARE @Path2OutFile NVARCHAR (2000);
   DECLARE @Obj INT
	
   SET NOCOUNT ON

   SELECT @ImageData = (
         SELECT convert (VARBINARY (max), PictureData, 1)
         FROM Pictures
         WHERE ID = @ID
         );
 
   SET @Path2OutFile = CONCAT (@ImageFolderPath, '\', @Filename);

	BEGIN TRY
		EXEC sp_OACreate 'ADODB.Stream' ,@Obj OUTPUT;
		EXEC sp_OASetProperty @Obj ,'Type',1;
		EXEC sp_OAMethod @Obj,'Open';
		EXEC sp_OAMethod @Obj,'Write', NULL, @ImageData;
		EXEC sp_OAMethod @Obj,'SaveToFile', NULL, @Path2OutFile, 2;
		EXEC sp_OAMethod @Obj,'Close';
		EXEC sp_OADestroy @Obj;
	END TRY
    
	BEGIN CATCH
		EXEC sp_OADestroy @Obj;
	END CATCH
 
	SET NOCOUNT OFF
END
GO