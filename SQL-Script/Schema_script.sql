USE [master]
GO
/****** Object:  Database [ZobiTest]    Script Date: 11/1/2019 6:04:56 PM ******/
CREATE DATABASE [ZobiTest]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'ZobiTest', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.MSSQLSERVER\MSSQL\DATA\ZobiTest.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'ZobiTest_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.MSSQLSERVER\MSSQL\DATA\ZobiTest.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO
ALTER DATABASE [ZobiTest] SET COMPATIBILITY_LEVEL = 140
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [ZobiTest].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [ZobiTest] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [ZobiTest] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [ZobiTest] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [ZobiTest] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [ZobiTest] SET ARITHABORT OFF 
GO
ALTER DATABASE [ZobiTest] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [ZobiTest] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [ZobiTest] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [ZobiTest] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [ZobiTest] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [ZobiTest] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [ZobiTest] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [ZobiTest] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [ZobiTest] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [ZobiTest] SET  DISABLE_BROKER 
GO
ALTER DATABASE [ZobiTest] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [ZobiTest] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [ZobiTest] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [ZobiTest] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [ZobiTest] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [ZobiTest] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [ZobiTest] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [ZobiTest] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [ZobiTest] SET  MULTI_USER 
GO
ALTER DATABASE [ZobiTest] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [ZobiTest] SET DB_CHAINING OFF 
GO
ALTER DATABASE [ZobiTest] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [ZobiTest] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [ZobiTest] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [ZobiTest] SET QUERY_STORE = OFF
GO
USE [ZobiTest]
GO
ALTER DATABASE SCOPED CONFIGURATION SET IDENTITY_CACHE = ON;
GO
ALTER DATABASE SCOPED CONFIGURATION SET LEGACY_CARDINALITY_ESTIMATION = OFF;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET LEGACY_CARDINALITY_ESTIMATION = PRIMARY;
GO
ALTER DATABASE SCOPED CONFIGURATION SET MAXDOP = 0;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET MAXDOP = PRIMARY;
GO
ALTER DATABASE SCOPED CONFIGURATION SET PARAMETER_SNIFFING = ON;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET PARAMETER_SNIFFING = PRIMARY;
GO
ALTER DATABASE SCOPED CONFIGURATION SET QUERY_OPTIMIZER_HOTFIXES = OFF;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET QUERY_OPTIMIZER_HOTFIXES = PRIMARY;
GO
USE [ZobiTest]
GO
/****** Object:  UserDefinedFunction [dbo].[SplitString]    Script Date: 11/1/2019 6:04:56 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE FUNCTION [dbo].[SplitString]
(    
      @Input NVARCHAR(MAX),
      @Character CHAR(1)
)
RETURNS @Output TABLE (
      Item NVARCHAR(1000)
)
AS
BEGIN
      DECLARE @StartIndex INT, @EndIndex INT
 
      SET @StartIndex = 1
      IF SUBSTRING(@Input, LEN(@Input) - 1, LEN(@Input)) <> @Character
      BEGIN
            SET @Input = @Input + @Character
      END
 
      WHILE CHARINDEX(@Character, @Input) > 0
      BEGIN
            SET @EndIndex = CHARINDEX(@Character, @Input)
           
            INSERT INTO @Output(Item)
            SELECT SUBSTRING(@Input, @StartIndex, @EndIndex - 1)
           
            SET @Input = SUBSTRING(@Input, @EndIndex + 1, LEN(@Input))
      END
 
      RETURN
END

GO
/****** Object:  Table [dbo].[Projects]    Script Date: 11/1/2019 6:04:56 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Projects](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Ref] [varchar](100) NOT NULL,
	[Auth] [bit] NULL,
	[Stage] [varchar](100) NULL,
	[Status_Date] [date] NULL,
	[BRAG] [varchar](100) NULL,
	[Type] [varchar](100) NULL,
	[Title] [varchar](100) NULL,
	[Lead] [varchar](100) NULL,
	[SRO] [varchar](100) NULL,
	[FY] [varchar](10) NULL,
	[Influencable_Spend] [numeric](10, 3) NULL,
	[Annual_Forecast] [numeric](10, 3) NULL,
	[In_Year_Forecasr] [numeric](10, 3) NULL,
	[Lever] [varchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  StoredProcedure [dbo].[GetProjectData]    Script Date: 11/1/2019 6:04:56 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[GetProjectData] (
@FY    VARCHAR(200), 
@Type  VARCHAR(200), 
@Lead  VARCHAR(200), 
@Month VARCHAR(200), 
@Lever VARCHAR(200), 
@BRAG  VARCHAR(200), 
@Stage VARCHAR(200) 
)
AS 
  BEGIN 
      SET nocount ON; 

      DECLARE @sql			NVARCHAR(max); 
      DECLARE @dynamicqry1	VARCHAR(500) 
      DECLARE @dynamicqry2	VARCHAR(1000) 
      DECLARE @dynamicqry3	VARCHAR(500) 
      DECLARE @dbFY			VARCHAR(500) 
      DECLARE @dbType		VARCHAR(500) 
      DECLARE @dbLead		VARCHAR(500) 
      DECLARE @dbMonth		VARCHAR(500) 
      DECLARE @dbLever		VARCHAR(500) 
      DECLARE @dbBRAG		VARCHAR(500) 
      DECLARE @dbStage		VARCHAR(500) 

      --declare @StartDate date 
      --declare @EndDate date 
      --SET @StartDate='1901-01-01 00:00:00.000' 
      --SET @EndDate=CAST(GETDATE() as date) 
      SET @dynamicqry1 = N'select Id ,Ref ,Auth ,Stage ,Status_Date ,BRAG ,Type ,Title ,Lead ,SRO ,FY ,Influencable_Spend ,Annual_Forecast ,In_Year_Forecasr ,Lever                FROM dbo.Projects    WHERE Id is not null   '; 
      SET @dynamicqry3 = ' ORDER BY Status_Date DESC'; 
      SET @dynamicqry2 = '' 

      -- @FY Condition Check 
      IF( Len(@FY) > 0 ) 
        BEGIN 
            SET @dbFY = 
            ' AND ISNULL(FY,'''') in ( select item from dbo.SplitString(''' 
            + @FY + ''','',''))' 
            --set @dbFY = ' AND ISNULL(FY,'''') in ('+ LEFT(@FYData, LEN(@FYData) - 1)  +')' 
            SET @dynamicqry2 = @dynamicqry2 + @dbFY 
        END 
      ELSE 
        BEGIN 
            SET @dynamicqry2 = @dynamicqry2 + '' 
        END 

      -- @Type Condition Check 
      IF( Len(@Type) > 0 ) 
        BEGIN 
            SET @dbType = 
            ' AND ISNULL(Type,'''') in ( select item from dbo.SplitString(''' 
            + @Type + ''','',''))' 
            --set @dbType = ' AND ISNULL(Type,'''') in ('+ LEFT(@TypeData, LEN(@TypeData) - 1)  +')' 
            SET @dynamicqry2 = @dynamicqry2 + @dbType 
        END 
      ELSE 
        BEGIN 
            SET @dynamicqry2 = @dynamicqry2 + '' 
        END 

      -- @Lead Condition Check 
      IF( Len(@Lead) > 0 ) 
        BEGIN 
            SET @dbLead = 
            ' AND ISNULL(Lead,'''') in ( select item from dbo.SplitString(''' 
            + @Lead + ''','',''))' 
            --set @dbLead = ' AND ISNULL(Lead,'''') in ('+ LEFT(@LeadData, LEN(@LeadData) - 1)  +')' 
            SET @dynamicqry2 = @dynamicqry2 + @dbLead 
        END 
      ELSE 
        BEGIN 
            SET @dynamicqry2 = @dynamicqry2 + '' 
        END 

      -- @Month Condition Check 
      --IF( Len(@Month) > 0 ) 
      --  BEGIN 
      --      --SET @dbMonth = 
      --      --' AND ISNULL(Month,'''') in ( select item from dbo.SplitString(''' 
      --      --+ @Month + ''','',''))' 
      --      --set @dbMonth = ' AND ISNULL(Month,'''') in ('+ LEFT(@MonthData, LEN(@MonthData) - 1)  +')' 
      --      SET @dynamicqry2 = @dynamicqry2 + @dbMonth 
      --  END 
      --ELSE 
      --  BEGIN 
      --      SET @dynamicqry2 = @dynamicqry2 + '' 
      --  END 

      -- @Lever Condition Check 
      IF( Len(@Lever) > 0 ) 
        BEGIN 
            SET @dbLever = 
            ' AND ISNULL(Lever,'''') in ( select item from dbo.SplitString(''' 
            + @Lever + ''','',''))' 
            --set @dbLever = ' AND ISNULL(Lever,'''') in ('+ LEFT(@LeverData, LEN(@LeverData) - 1)  +')' 
            SET @dynamicqry2 = @dynamicqry2 + @dbLever 
        END 
      ELSE 
        BEGIN 
            SET @dynamicqry2 = @dynamicqry2 + '' 
        END 

      -- @BRAG Condition Check 
      IF( Len(@BRAG) > 0 ) 
        BEGIN 
            SET @dbBRAG = 
            ' AND ISNULL(BRAG,'''') in ( select item from dbo.SplitString(''' 
            + @BRAG + ''','',''))' 
            --set @dbBRAG = ' AND ISNULL(BRAG,'''') in ('+ LEFT(@BRAGData, LEN(@BRAGData) - 1)  +')' 
            SET @dynamicqry2 = @dynamicqry2 + @dbBRAG 
        END 
      ELSE 
        BEGIN 
            SET @dynamicqry2 = @dynamicqry2 + '' 
        END 

      -- @Stage Condition Check 
      IF( Len(@Stage) > 0 ) 
        BEGIN 
            SET @dbStage = 
            ' AND ISNULL(Stage,'''') in ( select item from dbo.SplitString(''' 
            + @Stage + ''','',''))' 
            --set @dbStage = ' AND ISNULL(Stage,'''') in ('+ LEFT(@StageData, LEN(@StageData) - 1)  +')' 
            SET @dynamicqry2 = @dynamicqry2 + @dbStage 
        END 
      ELSE 
        BEGIN 
            SET @dynamicqry2 = @dynamicqry2 + '' 
        END 

      SET @sql = @dynamicqry1 + @dynamicqry2 + @dynamicqry3 

      PRINT @sql 

      EXEC Sp_executesql 
        @sql; 
  END 
--exec GetProjectData @FY='',@Type='',@Lead='',@Month='',@Lever='Compare & Save',@BRAG='RED,AMBER',@Stage=''
GO
USE [master]
GO
ALTER DATABASE [ZobiTest] SET  READ_WRITE 
GO
