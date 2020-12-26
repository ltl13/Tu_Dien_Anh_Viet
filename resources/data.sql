USE [master]
GO
/****** Object:  Database [DailyDictionary]    Script Date: 26/12/2020 5:33:44 CH ******/
CREATE DATABASE [DailyDictionary]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'DailyDictionary', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\DailyDictionary.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'DailyDictionary_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\DailyDictionary_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [DailyDictionary] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [DailyDictionary].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [DailyDictionary] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [DailyDictionary] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [DailyDictionary] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [DailyDictionary] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [DailyDictionary] SET ARITHABORT OFF 
GO
ALTER DATABASE [DailyDictionary] SET AUTO_CLOSE ON 
GO
ALTER DATABASE [DailyDictionary] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [DailyDictionary] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [DailyDictionary] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [DailyDictionary] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [DailyDictionary] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [DailyDictionary] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [DailyDictionary] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [DailyDictionary] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [DailyDictionary] SET  ENABLE_BROKER 
GO
ALTER DATABASE [DailyDictionary] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [DailyDictionary] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [DailyDictionary] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [DailyDictionary] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [DailyDictionary] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [DailyDictionary] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [DailyDictionary] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [DailyDictionary] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [DailyDictionary] SET  MULTI_USER 
GO
ALTER DATABASE [DailyDictionary] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [DailyDictionary] SET DB_CHAINING OFF 
GO
ALTER DATABASE [DailyDictionary] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [DailyDictionary] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [DailyDictionary] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [DailyDictionary] SET QUERY_STORE = OFF
GO
USE [DailyDictionary]
GO
/****** Object:  Table [dbo].[Account]    Script Date: 26/12/2020 5:33:44 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Account](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[UserName] [varchar](50) NOT NULL,
	[DisplayName] [nvarchar](20) NOT NULL,
	[PassWord] [char](64) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Picture]    Script Date: 26/12/2020 5:33:44 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Picture](
	[ID] [int] NOT NULL,
	[PictureData] [varbinary](max) NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
ALTER TABLE [dbo].[Account] ADD  DEFAULT ('Guest') FOR [DisplayName]
GO
ALTER TABLE [dbo].[Picture]  WITH CHECK ADD FOREIGN KEY([ID])
REFERENCES [dbo].[Account] ([ID])
GO
/****** Object:  StoredProcedure [dbo].[USP_Login]    Script Date: 26/12/2020 5:33:44 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[USP_Login]
	@userName varchar(50), 
	@passWord char(64)
AS
BEGIN
	SELECT * FROM dbo.Account WHERE UserName = @userName AND PassWord = @passWord
END
GO
/****** Object:  StoredProcedure [dbo].[USP_SaveImage]    Script Date: 26/12/2020 5:33:44 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[USP_SaveImage]
	@Id int OUTPUT,
	@Data varbinary(MAX)
AS
SET NOCOUNT ON
SET XACT_ABORT ON

IF @Id IS NULL OR @Id <= 0
BEGIN
SELECT @Id = ISNULL(MAX([Id]),0) + 1 FROM [dbo].[Picture]
END

INSERT INTO [dbo].[Picture] (ID, PictureData)
VALUES (@Id ,@Data)
GO
/****** Object:  StoredProcedure [dbo].[USP_UpdateAccount]    Script Date: 26/12/2020 5:33:44 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[USP_UpdateAccount]
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
USE [master]
GO
ALTER DATABASE [DailyDictionary] SET  READ_WRITE 
GO
