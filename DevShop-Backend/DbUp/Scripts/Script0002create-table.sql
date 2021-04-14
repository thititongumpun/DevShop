/****** Object:  Table [dbo].[DeveloperPosition]    Script Date: 4/14/2021 7:04:15 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DeveloperPosition](
	[DeveloperId] [int] NOT NULL,
	[PositionId] [int] NOT NULL,
	[Created] [datetime] NULL,
	[CreatedBy] [nvarchar](50) NULL,
	[LastModified] [datetime] NULL,
	[LastModifiedBy] [nvarchar](50) NULL,
 CONSTRAINT [PK_DeveloperPosition] PRIMARY KEY CLUSTERED 
(
	[DeveloperId] ASC,
	[PositionId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Developers]    Script Date: 4/14/2021 7:04:15 PM ******/
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
	[Status] [nvarchar](20) NULL,
	[Created] [datetime] NULL,
	[CreatedBy] [nvarchar](50) NULL,
	[LastModified] [datetime] NULL,
	[LastModifiedBy] [nvarchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[DeveloperId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO