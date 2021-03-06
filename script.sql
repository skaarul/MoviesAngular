USE [Study]
GO
/****** Object:  Table [dbo].[Actor]    Script Date: 01/12/2018 09:45:54 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Actor](
	[ActorId] [int] IDENTITY(1,1) NOT NULL,
	[ActorName] [varchar](100) NOT NULL,
	[Gender] [bit] NULL,
	[Bio] [varchar](255) NULL,
	[dateOfBirth] [datetime] NULL,
PRIMARY KEY CLUSTERED 
(
	[ActorId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Movie]    Script Date: 01/12/2018 09:45:54 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Movie](
	[MovieId] [int] IDENTITY(1,1) NOT NULL,
	[MovieName] [varchar](100) NOT NULL,
	[ReleaseYear] [int] NOT NULL,
	[Plot] [varchar](max) NULL,
	[ProducerId] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[MovieId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Movie_Actor]    Script Date: 01/12/2018 09:45:54 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Movie_Actor](
	[MovieID] [int] NOT NULL,
	[ActorID] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[MovieID] ASC,
	[ActorID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Producer]    Script Date: 01/12/2018 09:45:54 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Producer](
	[ProducerID] [int] IDENTITY(1,1) NOT NULL,
	[ProducerName] [varchar](100) NOT NULL,
	[Gender] [bit] NULL,
	[Bio] [varchar](255) NULL,
	[dateOfBirth] [datetime] NULL,
PRIMARY KEY CLUSTERED 
(
	[ProducerID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Movie]  WITH CHECK ADD FOREIGN KEY([ProducerId])
REFERENCES [dbo].[Producer] ([ProducerID])
GO
ALTER TABLE [dbo].[Movie]  WITH CHECK ADD  CONSTRAINT [FK_ProducerID] FOREIGN KEY([ProducerId])
REFERENCES [dbo].[Producer] ([ProducerID])
GO
ALTER TABLE [dbo].[Movie] CHECK CONSTRAINT [FK_ProducerID]
GO
ALTER TABLE [dbo].[Movie_Actor]  WITH CHECK ADD FOREIGN KEY([ActorID])
REFERENCES [dbo].[Actor] ([ActorId])
GO
ALTER TABLE [dbo].[Movie_Actor]  WITH CHECK ADD FOREIGN KEY([MovieID])
REFERENCES [dbo].[Movie] ([MovieId])
GO
ALTER TABLE [dbo].[Movie_Actor]  WITH CHECK ADD  CONSTRAINT [FK_ActorID] FOREIGN KEY([ActorID])
REFERENCES [dbo].[Actor] ([ActorId])
GO
ALTER TABLE [dbo].[Movie_Actor] CHECK CONSTRAINT [FK_ActorID]
GO
ALTER TABLE [dbo].[Movie_Actor]  WITH CHECK ADD  CONSTRAINT [FK_MovieID] FOREIGN KEY([MovieID])
REFERENCES [dbo].[Movie] ([MovieId])
GO
ALTER TABLE [dbo].[Movie_Actor] CHECK CONSTRAINT [FK_MovieID]
GO
