CREATE DATABASE 'Vocabulary'
USE [Vocabulary]
GO

/****** Object:  Table [dbo].[Words]    Script Date: 9/17/2019 5:11:21 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Words](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[English] [nvarchar](max) NULL,
	[VietnameseMeaning] [nvarchar](max) NULL,
	[PartOfSpeech] [nvarchar](max) NULL,
 CONSTRAINT [PK_dbo.Words] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO