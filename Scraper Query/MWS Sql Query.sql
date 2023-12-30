USE [scraper]
GO

/****** Object:  Table [dbo].[MWS]    Script Date: 12/30/2023 11:18:28 PM ******/
DROP TABLE [dbo].[MWS]
GO

/****** Object:  Table [dbo].[MWS]    Script Date: 12/30/2023 11:18:28 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[MWS](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Date_Added] [datetime] NOT NULL,
	[LInk_Added] [varchar](max) NOT NULL,
	[Match] [varchar](max) NOT NULL,
 CONSTRAINT [PK_MWS] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO

