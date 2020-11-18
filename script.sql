USE [DBLibraryTEST]
GO
/****** Object:  Table [dbo].[Authors]    Script Date: 18.11.2020 16:01:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Authors](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[FirstName] [nvarchar](50) NOT NULL,
	[SecondName] [nvarchar](50) NOT NULL,
	[MiddleName] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Authors] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Book_Author]    Script Date: 18.11.2020 16:01:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Book_Author](
	[ID_Authors] [int] NOT NULL,
	[ID_Books] [int] NOT NULL,
 CONSTRAINT [PK_AuthorsAndBooks] PRIMARY KEY CLUSTERED 
(
	[ID_Authors] ASC,
	[ID_Books] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Books]    Script Date: 18.11.2020 16:01:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Books](
	[Id] [int] NOT NULL,
	[TypeBook] [int] NULL,
	[Name] [nvarchar](100) NOT NULL,
	[Detailes] [nvarchar](50) NULL,
 CONSTRAINT [PK_Books] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Authors] ON 

INSERT [dbo].[Authors] ([Id], [FirstName], [SecondName], [MiddleName]) VALUES (1, N'Александр', N'Пушкин', N'Сергеевич')
INSERT [dbo].[Authors] ([Id], [FirstName], [SecondName], [MiddleName]) VALUES (2, N'Фёдор', N'Достоевсикй', N'Михайлович')
INSERT [dbo].[Authors] ([Id], [FirstName], [SecondName], [MiddleName]) VALUES (3, N'Лев', N'Толстой', N'Николаевич')
SET IDENTITY_INSERT [dbo].[Authors] OFF
GO
INSERT [dbo].[Book_Author] ([ID_Authors], [ID_Books]) VALUES (1, 1)
INSERT [dbo].[Book_Author] ([ID_Authors], [ID_Books]) VALUES (2, 2)
INSERT [dbo].[Book_Author] ([ID_Authors], [ID_Books]) VALUES (3, 3)
INSERT [dbo].[Book_Author] ([ID_Authors], [ID_Books]) VALUES (3, 4)
GO
INSERT [dbo].[Books] ([Id], [TypeBook], [Name], [Detailes]) VALUES (1, 1, N'Капитанская дочка', N'1886')
INSERT [dbo].[Books] ([Id], [TypeBook], [Name], [Detailes]) VALUES (2, 1, N'Преступление и наказание', N'1886')
INSERT [dbo].[Books] ([Id], [TypeBook], [Name], [Detailes]) VALUES (3, 2, N'Война и Мир (Том 1)', N'1836')
INSERT [dbo].[Books] ([Id], [TypeBook], [Name], [Detailes]) VALUES (4, 2, N'Война и Мир (Том 2)', N'1840')
INSERT [dbo].[Books] ([Id], [TypeBook], [Name], [Detailes]) VALUES (5, 3, N'Недоросль', N'1866')
GO
ALTER TABLE [dbo].[Book_Author]  WITH CHECK ADD  CONSTRAINT [FK_Book_Author_Authors] FOREIGN KEY([ID_Authors])
REFERENCES [dbo].[Authors] ([Id])
GO
ALTER TABLE [dbo].[Book_Author] CHECK CONSTRAINT [FK_Book_Author_Authors]
GO
ALTER TABLE [dbo].[Book_Author]  WITH CHECK ADD  CONSTRAINT [FK_Book_Author_Books] FOREIGN KEY([ID_Authors])
REFERENCES [dbo].[Books] ([Id])
GO
ALTER TABLE [dbo].[Book_Author] CHECK CONSTRAINT [FK_Book_Author_Books]
GO
ALTER TABLE [dbo].[Books]  WITH CHECK ADD  CONSTRAINT [FK_Books_Genre] FOREIGN KEY([TypeBook])
REFERENCES [dbo].[Genre] ([Id])
GO
ALTER TABLE [dbo].[Books] CHECK CONSTRAINT [FK_Books_Genre]
GO
