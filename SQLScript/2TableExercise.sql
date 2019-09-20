USE [Vocabulary]
GO

/****** Object:  Table [dbo].[Exercises]    Script Date: 9/20/2019 5:12:44 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Exercises](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Content] [nvarchar](max) NULL,
	[KeyWord] [nvarchar](max) NULL,
	[WordId] [int] NOT NULL,
 CONSTRAINT [PK_dbo.Exercises] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO

ALTER TABLE [dbo].[Exercises]  WITH CHECK ADD  CONSTRAINT [FK_dbo.Exercises_dbo.Words_WordId] FOREIGN KEY([WordId])
REFERENCES [dbo].[Words] ([ID])
ON DELETE CASCADE
GO

ALTER TABLE [dbo].[Exercises] CHECK CONSTRAINT [FK_dbo.Exercises_dbo.Words_WordId]
GO


