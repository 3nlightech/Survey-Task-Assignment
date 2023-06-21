USE [Pool_DB]
GO

/****** Object:  Table [dbo].[Survey_Test]    Script Date: 6/21/2023 12:01:52 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Survey_Test](
	[Surname] [varchar](25) NULL,
	[F_Names] [varchar](25) NULL,
	[Phone] [varchar](10) NULL,
	[Reg_Date] [datetime] NULL,
	[Age] [int] NULL,
	[Fav_Food] [varchar](50) NULL,
	[EatOut] [int] NULL,
	[WatchMovie] [int] NULL,
	[WatchTV] [int] NULL,
	[ListenRadio] [int] NULL
) ON [PRIMARY]
GO


