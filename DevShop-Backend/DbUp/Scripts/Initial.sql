USE [master]
GO
/****** Object:  Database [DevShops]    Script Date: 4/10/2021 6:35:19 PM ******/
CREATE DATABASE [DevShops]
 CONTAINMENT = NONE
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
ALTER DATABASE [DevShops] SET  DISABLE_BROKER 
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
ALTER DATABASE [DevShops] SET READ_COMMITTED_SNAPSHOT OFF 
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
/****** Object:  Table [dbo].[DeveloperPosition]    Script Date: 4/10/2021 6:35:19 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DeveloperPosition](
	[DeveloperId] [int] NOT NULL,
	[PositionId] [int] NOT NULL,
 CONSTRAINT [PK_DeveloperPosition] PRIMARY KEY CLUSTERED 
(
	[DeveloperId] ASC,
	[PositionId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Developers]    Script Date: 4/10/2021 6:35:19 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Developers](
	[DeveloperId] [int] IDENTITY(1,1) NOT NULL,
	[DeveloperName] [nvarchar](50) NOT NULL,
	[Email] [nvarchar](50) NOT NULL,
	[GithubUrl] [nvarchar](100) NULL,
	[ImageUrl] [nvarchar](250) NULL,
	[JoinedDate] [date] NULL,
	[CreatedDate] [datetime] NULL,
	[UpdatedDate] [datetime] NULL,
	[Status] [nvarchar](20) NULL,
PRIMARY KEY CLUSTERED 
(
	[DeveloperId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Positions]    Script Date: 4/10/2021 6:35:19 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Positions](
	[PositionId] [int] IDENTITY(1,1) NOT NULL,
	[PositionName] [nvarchar](100) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[PositionId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[DeveloperPosition] ([DeveloperId], [PositionId]) VALUES (1, 2)
GO
INSERT [dbo].[DeveloperPosition] ([DeveloperId], [PositionId]) VALUES (1, 3)
GO
INSERT [dbo].[DeveloperPosition] ([DeveloperId], [PositionId]) VALUES (2, 1)
GO
INSERT [dbo].[DeveloperPosition] ([DeveloperId], [PositionId]) VALUES (4, 3)
GO
INSERT [dbo].[DeveloperPosition] ([DeveloperId], [PositionId]) VALUES (5, 1)
GO
INSERT [dbo].[DeveloperPosition] ([DeveloperId], [PositionId]) VALUES (5, 2)
GO
INSERT [dbo].[DeveloperPosition] ([DeveloperId], [PositionId]) VALUES (5, 3)
GO
SET IDENTITY_INSERT [dbo].[Developers] ON 
GO
INSERT [dbo].[Developers] ([DeveloperId], [DeveloperName], [Email], [GithubUrl], [ImageUrl], [JoinedDate], [CreatedDate], [UpdatedDate], [Status]) VALUES (1, N'นุ้ย เชิญยิ้้ม', N'nuinui@google.com', N'nuiza.com', N'aws.ssss', CAST(N'2021-04-10' AS Date), CAST(N'2021-04-10T12:58:30.453' AS DateTime), CAST(N'2021-04-10T12:58:30.453' AS DateTime), N'Y')
GO
INSERT [dbo].[Developers] ([DeveloperId], [DeveloperName], [Email], [GithubUrl], [ImageUrl], [JoinedDate], [CreatedDate], [UpdatedDate], [Status]) VALUES (2, N'หนังไก่ กรอบเกิน', N'nungkai@google.com', N'nungkai.com', N'aws.ssss', CAST(N'2021-04-10' AS Date), CAST(N'2021-04-10T13:01:41.007' AS DateTime), CAST(N'2021-04-10T13:01:41.007' AS DateTime), N'Y')
GO
INSERT [dbo].[Developers] ([DeveloperId], [DeveloperName], [Email], [GithubUrl], [ImageUrl], [JoinedDate], [CreatedDate], [UpdatedDate], [Status]) VALUES (3, N'test จัง', N'boba@google.com', N'babo.com', N'aws.ssss', CAST(N'2021-04-10' AS Date), CAST(N'2021-04-10T13:01:43.043' AS DateTime), CAST(N'2021-04-10T13:01:43.043' AS DateTime), N'Y')
GO
INSERT [dbo].[Developers] ([DeveloperId], [DeveloperName], [Email], [GithubUrl], [ImageUrl], [JoinedDate], [CreatedDate], [UpdatedDate], [Status]) VALUES (4, N'ซัดยำ วุ้นเส้น', N'sadyum@google.com', N'sadyum.com', N'aws.ssss', CAST(N'2021-04-10' AS Date), CAST(N'2021-04-10T13:01:45.143' AS DateTime), CAST(N'2021-04-10T13:01:45.143' AS DateTime), N'Y')
GO
INSERT [dbo].[Developers] ([DeveloperId], [DeveloperName], [Email], [GithubUrl], [ImageUrl], [JoinedDate], [CreatedDate], [UpdatedDate], [Status]) VALUES (5, N'ขาหมู เยอรมัน', N'kamoo@google.com', N'kamoo.com', N'aws.ssss', CAST(N'2021-04-10' AS Date), CAST(N'2021-04-10T13:01:46.670' AS DateTime), CAST(N'2021-04-10T13:01:46.670' AS DateTime), N'Y')
GO
SET IDENTITY_INSERT [dbo].[Developers] OFF
GO
SET IDENTITY_INSERT [dbo].[Positions] ON 
GO
INSERT [dbo].[Positions] ([PositionId], [PositionName]) VALUES (1, N'Frontend')
GO
INSERT [dbo].[Positions] ([PositionId], [PositionName]) VALUES (2, N'Backend')
GO
INSERT [dbo].[Positions] ([PositionId], [PositionName]) VALUES (3, N'FullStack')
GO
INSERT [dbo].[Positions] ([PositionId], [PositionName]) VALUES (4, N'DevOps')
GO
INSERT [dbo].[Positions] ([PositionId], [PositionName]) VALUES (5, N'System Analyst')
GO
INSERT [dbo].[Positions] ([PositionId], [PositionName]) VALUES (6, N'Network Engineer')
GO
SET IDENTITY_INSERT [dbo].[Positions] OFF
GO
ALTER TABLE [dbo].[DeveloperPosition]  WITH CHECK ADD FOREIGN KEY([DeveloperId])
REFERENCES [dbo].[Developers] ([DeveloperId])
GO
ALTER TABLE [dbo].[DeveloperPosition]  WITH CHECK ADD FOREIGN KEY([PositionId])
REFERENCES [dbo].[Positions] ([PositionId])
GO
USE [master]
GO
ALTER DATABASE [DevShops] SET  READ_WRITE 
GO