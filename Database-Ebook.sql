USE [E_BOOK]
GO
/****** Object:  Table [dbo].[admin1]    Script Date: 06/16/2022 17:45:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[admin1](
	[password] [varchar](50) NOT NULL
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[documents]    Script Date: 06/16/2022 17:45:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[documents](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Data] [varbinary](max) NULL,
	[Extension] [char](10) NULL,
	[Book_Title] [varchar](100) NULL,
	[Author] [varchar](100) NULL,
	[Catagories] [varchar](100) NULL,
	[Quantity] [varchar](100) NULL,
	[FileName] [varchar](100) NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Aut_info]    Script Date: 06/16/2022 17:45:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Aut_info](
	[Id] [int] NOT NULL,
	[Firstname] [varchar](50) NULL,
	[Lastname] [varchar](50) NULL,
	[Phone] [varchar](50) NULL,
 CONSTRAINT [PK_Aut_info] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Lib_info]    Script Date: 06/16/2022 17:45:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Lib_info](
	[Id] [int] NOT NULL,
	[Firstname] [varchar](50) NULL,
	[Lastname] [varchar](50) NULL,
	[Phone] [varchar](50) NULL,
 CONSTRAINT [PK_Lib_info] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[userinfo]    Script Date: 06/16/2022 17:45:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[userinfo](
	[id] [varchar](50) NOT NULL,
	[firstname] [varchar](50) NULL,
	[lastname] [varchar](50) NULL,
	[email] [varchar](50) NULL,
	[gender] [varchar](50) NULL,
	[phone] [varchar](50) NULL,
 CONSTRAINT [PK_userinfo] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[user_account]    Script Date: 06/16/2022 17:45:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[user_account](
	[id] [varchar](50) NOT NULL,
	[username] [varchar](50) NULL,
	[password] [varchar](50) NULL,
 CONSTRAINT [PK_user_account] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Lib_acc]    Script Date: 06/16/2022 17:45:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Lib_acc](
	[Id] [int] NOT NULL,
	[Username] [varchar](50) NULL,
	[Password] [varchar](50) NULL,
 CONSTRAINT [PK_Lib_acc] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Aut_acc]    Script Date: 06/16/2022 17:45:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Aut_acc](
	[Id] [int] NOT NULL,
	[Username] [varchar](50) NULL,
	[Password] [varchar](50) NULL,
 CONSTRAINT [PK_Aut_acc] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  ForeignKey [FK_Aut_acc_Aut_info]    Script Date: 06/16/2022 17:45:20 ******/
ALTER TABLE [dbo].[Aut_acc]  WITH CHECK ADD  CONSTRAINT [FK_Aut_acc_Aut_info] FOREIGN KEY([Id])
REFERENCES [dbo].[Aut_info] ([Id])
GO
ALTER TABLE [dbo].[Aut_acc] CHECK CONSTRAINT [FK_Aut_acc_Aut_info]
GO
/****** Object:  ForeignKey [FK_Lib_acc_Lib_info]    Script Date: 06/16/2022 17:45:20 ******/
ALTER TABLE [dbo].[Lib_acc]  WITH CHECK ADD  CONSTRAINT [FK_Lib_acc_Lib_info] FOREIGN KEY([Id])
REFERENCES [dbo].[Lib_info] ([Id])
GO
ALTER TABLE [dbo].[Lib_acc] CHECK CONSTRAINT [FK_Lib_acc_Lib_info]
GO
/****** Object:  ForeignKey [FK_user_account_userinfo]    Script Date: 06/16/2022 17:45:20 ******/
ALTER TABLE [dbo].[user_account]  WITH CHECK ADD  CONSTRAINT [FK_user_account_userinfo] FOREIGN KEY([id])
REFERENCES [dbo].[userinfo] ([id])
GO
ALTER TABLE [dbo].[user_account] CHECK CONSTRAINT [FK_user_account_userinfo]
GO
