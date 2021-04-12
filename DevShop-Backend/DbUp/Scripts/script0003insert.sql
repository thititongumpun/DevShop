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
-- USE [master]
-- GO
-- ALTER DATABASE [DevShops] SET  READ_WRITE 
-- GO 