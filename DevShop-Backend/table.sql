USE [DevShops]
GO

/****** Object:  Table [dbo].[Developers]    Script Date: 4/10/2021 2:55:39 PM ******/
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
PRIMARY KEY CLUSTERED 
(
	[DeveloperId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
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



