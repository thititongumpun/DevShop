USE [master]
GO
/****** Object:  Database [DevShops]    Script Date: 4/14/2021 7:04:15 PM ******/
ALTER DATABASE [DevShops] SET COMPATIBILITY_LEVEL = 140
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [DevShops].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [DevShops] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [DevShops] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [DevShops] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [DevShops] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [DevShops] SET ARITHABORT OFF 
GO
ALTER DATABASE [DevShops] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [DevShops] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [DevShops] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [DevShops] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [DevShops] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [DevShops] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [DevShops] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [DevShops] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [DevShops] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [DevShops] SET  ENABLE_BROKER 
GO
ALTER DATABASE [DevShops] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [DevShops] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [DevShops] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [DevShops] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [DevShops] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [DevShops] SET READ_COMMITTED_SNAPSHOT ON 
GO
ALTER DATABASE [DevShops] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [DevShops] SET RECOVERY FULL 
GO
ALTER DATABASE [DevShops] SET  MULTI_USER 
GO
ALTER DATABASE [DevShops] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [DevShops] SET DB_CHAINING OFF 
GO
ALTER DATABASE [DevShops] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [DevShops] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [DevShops] SET DELAYED_DURABILITY = DISABLED 
GO
EXEC sys.sp_db_vardecimal_storage_format N'DevShops', N'ON'
GO
ALTER DATABASE [DevShops] SET QUERY_STORE = OFF
GO
USE [DevShops]
GO