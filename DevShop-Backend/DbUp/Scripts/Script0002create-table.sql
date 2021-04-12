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
