USE [Vai]
GO
/****** Object:  Table [dbo].[Process]    Script Date: 11/07/2021 2:17:44 am ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Process](
	[ProcessId] [int] IDENTITY(1,1) NOT NULL,
	[Client] [nvarchar](50) NOT NULL,
	[Robot] [nvarchar](50) NOT NULL,
	[Description] [nvarchar](500) NOT NULL,
	[StartTime] [datetime2](7) NOT NULL,
	[Status] [nvarchar](50) NOT NULL,
	[Priority] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Process] PRIMARY KEY CLUSTERED 
(
	[ProcessId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO