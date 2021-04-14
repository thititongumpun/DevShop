/****** Object:  Table [dbo].[Positions]    Script Date: 4/14/2021 7:04:15 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Positions](
	[PositionId] [int] IDENTITY(1,1) NOT NULL,
	[PositionName] [nvarchar](100) NOT NULL,
	[Created] [datetime] NULL,
	[CreatedBy] [nvarchar](50) NULL,
	[LastModified] [datetime] NULL,
	[LastModifiedBy] [nvarchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[PositionId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[DeveloperPosition] ([DeveloperId], [PositionId], [Created], [CreatedBy], [LastModified], [LastModifiedBy]) VALUES (1, 2, CAST(N'2021-04-14T18:54:37.823' AS DateTime), N'admin', NULL, NULL)
GO
INSERT [dbo].[DeveloperPosition] ([DeveloperId], [PositionId], [Created], [CreatedBy], [LastModified], [LastModifiedBy]) VALUES (1, 3, CAST(N'2021-04-14T18:54:37.823' AS DateTime), N'admin', NULL, NULL)
GO
INSERT [dbo].[DeveloperPosition] ([DeveloperId], [PositionId], [Created], [CreatedBy], [LastModified], [LastModifiedBy]) VALUES (2, 1, CAST(N'2021-04-14T18:54:37.823' AS DateTime), N'admin', NULL, NULL)
GO
INSERT [dbo].[DeveloperPosition] ([DeveloperId], [PositionId], [Created], [CreatedBy], [LastModified], [LastModifiedBy]) VALUES (3, 7, CAST(N'2021-04-14T18:54:37.823' AS DateTime), N'admin', NULL, NULL)
GO
INSERT [dbo].[DeveloperPosition] ([DeveloperId], [PositionId], [Created], [CreatedBy], [LastModified], [LastModifiedBy]) VALUES (4, 3, CAST(N'2021-04-14T18:54:37.823' AS DateTime), N'admin', NULL, NULL)
GO
INSERT [dbo].[DeveloperPosition] ([DeveloperId], [PositionId], [Created], [CreatedBy], [LastModified], [LastModifiedBy]) VALUES (5, 1, CAST(N'2021-04-14T18:54:37.823' AS DateTime), N'admin', NULL, NULL)
GO
INSERT [dbo].[DeveloperPosition] ([DeveloperId], [PositionId], [Created], [CreatedBy], [LastModified], [LastModifiedBy]) VALUES (5, 2, CAST(N'2021-04-14T18:54:37.823' AS DateTime), N'admin', NULL, NULL)
GO
INSERT [dbo].[DeveloperPosition] ([DeveloperId], [PositionId], [Created], [CreatedBy], [LastModified], [LastModifiedBy]) VALUES (5, 3, CAST(N'2021-04-14T18:54:37.823' AS DateTime), N'admin', NULL, NULL)
GO
SET IDENTITY_INSERT [dbo].[Developers] ON 
GO
INSERT [dbo].[Developers] ([DeveloperId], [DeveloperName], [Email], [GithubUrl], [ImageUrl], [JoinedDate], [Status], [Created], [CreatedBy], [LastModified], [LastModifiedBy]) VALUES (1, N'นุ้ย เชิญยิ้้ม', N'nuinui@google.com', N'nuiza.com', N'aws.ssss', CAST(N'2021-04-10' AS Date), N'Y', CAST(N'2021-04-14T18:54:05.563' AS DateTime), N'admin', NULL, NULL)
GO
INSERT [dbo].[Developers] ([DeveloperId], [DeveloperName], [Email], [GithubUrl], [ImageUrl], [JoinedDate], [Status], [Created], [CreatedBy], [LastModified], [LastModifiedBy]) VALUES (2, N'หนังไก่ กรอบเกิน', N'nungkai@google.com', N'nungkai.com', N'aws.ssss', CAST(N'2021-04-10' AS Date), N'Y', CAST(N'2021-04-14T18:54:05.563' AS DateTime), N'admin', NULL, NULL)
GO
INSERT [dbo].[Developers] ([DeveloperId], [DeveloperName], [Email], [GithubUrl], [ImageUrl], [JoinedDate], [Status], [Created], [CreatedBy], [LastModified], [LastModifiedBy]) VALUES (3, N'test จัง', N'boba@google.com', N'babo.com', N'aws.ssss', CAST(N'2021-04-10' AS Date), N'Y', CAST(N'2021-04-14T18:54:05.563' AS DateTime), N'admin', NULL, NULL)
GO
INSERT [dbo].[Developers] ([DeveloperId], [DeveloperName], [Email], [GithubUrl], [ImageUrl], [JoinedDate], [Status], [Created], [CreatedBy], [LastModified], [LastModifiedBy]) VALUES (4, N'ซัดยำ วุ้นเส้น', N'sadyum@google.com', N'sadyum.com', N'aws.ssss', CAST(N'2021-04-10' AS Date), N'Y', CAST(N'2021-04-14T18:54:05.563' AS DateTime), N'admin', NULL, NULL)
GO
INSERT [dbo].[Developers] ([DeveloperId], [DeveloperName], [Email], [GithubUrl], [ImageUrl], [JoinedDate], [Status], [Created], [CreatedBy], [LastModified], [LastModifiedBy]) VALUES (5, N'ขาหมู เยอรมัน', N'kamoo@google.com', N'kamoo.com', N'aws.ssss', CAST(N'2021-04-10' AS Date), N'Y', CAST(N'2021-04-14T18:54:05.563' AS DateTime), N'admin', NULL, NULL)
GO
SET IDENTITY_INSERT [dbo].[Developers] OFF
GO
SET IDENTITY_INSERT [dbo].[Positions] ON 
GO
INSERT [dbo].[Positions] ([PositionId], [PositionName], [Created], [CreatedBy], [LastModified], [LastModifiedBy]) VALUES (1, N'Frontend', CAST(N'2021-04-14T18:47:43.627' AS DateTime), N'admin', NULL, NULL)
GO
INSERT [dbo].[Positions] ([PositionId], [PositionName], [Created], [CreatedBy], [LastModified], [LastModifiedBy]) VALUES (2, N'Backend', CAST(N'2021-04-14T18:47:43.627' AS DateTime), N'admin', NULL, NULL)
GO
INSERT [dbo].[Positions] ([PositionId], [PositionName], [Created], [CreatedBy], [LastModified], [LastModifiedBy]) VALUES (3, N'DevOps', CAST(N'2021-04-14T18:47:43.627' AS DateTime), N'admin', NULL, NULL)
GO
INSERT [dbo].[Positions] ([PositionId], [PositionName], [Created], [CreatedBy], [LastModified], [LastModifiedBy]) VALUES (4, N'Fullstack Developer', CAST(N'2021-04-14T18:47:43.627' AS DateTime), N'admin', NULL, NULL)
GO
INSERT [dbo].[Positions] ([PositionId], [PositionName], [Created], [CreatedBy], [LastModified], [LastModifiedBy]) VALUES (5, N'Business Analyst', CAST(N'2021-04-14T18:47:43.627' AS DateTime), N'admin', NULL, NULL)
GO
INSERT [dbo].[Positions] ([PositionId], [PositionName], [Created], [CreatedBy], [LastModified], [LastModifiedBy]) VALUES (6, N'UX/UI', CAST(N'2021-04-14T18:47:43.627' AS DateTime), N'admin', NULL, NULL)
GO
INSERT [dbo].[Positions] ([PositionId], [PositionName], [Created], [CreatedBy], [LastModified], [LastModifiedBy]) VALUES (7, N'Tester', CAST(N'2021-04-14T18:47:43.627' AS DateTime), N'admin', NULL, NULL)
GO
SET IDENTITY_INSERT [dbo].[Positions] OFF
GO
ALTER TABLE [dbo].[DeveloperPosition]  WITH CHECK ADD FOREIGN KEY([DeveloperId])
REFERENCES [dbo].[Developers] ([DeveloperId])
GO
ALTER TABLE [dbo].[DeveloperPosition]  WITH CHECK ADD FOREIGN KEY([PositionId])
REFERENCES [dbo].[Positions] ([PositionId])
GO
