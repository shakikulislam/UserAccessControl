USE [UserAccessControlDB]
GO
/****** Object:  Table [dbo].[TableMenuList]    Script Date: 7/14/2020 11:12:17 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TableMenuList](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[MenuName] [nvarchar](50) NULL,
	[MenuParent] [nvarchar](50) NULL,
 CONSTRAINT [PK_TableMenuList] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[TableUser]    Script Date: 7/14/2020 11:12:17 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TableUser](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](50) NOT NULL,
	[UserName] [nvarchar](50) NOT NULL,
	[Password] [nvarchar](50) NOT NULL,
	[UserRole] [nvarchar](50) NULL,
 CONSTRAINT [PK_TableUser_1] PRIMARY KEY CLUSTERED 
(
	[UserName] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[TableUserRole]    Script Date: 7/14/2020 11:12:17 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TableUserRole](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[UserRole] [nvarchar](50) NULL,
	[MenuId] [nvarchar](50) NULL,
 CONSTRAINT [PK_TableUserRole] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

/****** Insert Menu List for Table [dbo].[TableMenuList] ******/
SET IDENTITY_INSERT [dbo].[TableMenuList] ON 

INSERT [dbo].[TableMenuList] ([id], [MenuName], [MenuParent]) VALUES (1, N'fileToolStripMenuItem', N'0')
INSERT [dbo].[TableMenuList] ([id], [MenuName], [MenuParent]) VALUES (2, N'exitToolStripMenuItem', N'1')
INSERT [dbo].[TableMenuList] ([id], [MenuName], [MenuParent]) VALUES (3, N'createToolStripMenuItem', N'0')
INSERT [dbo].[TableMenuList] ([id], [MenuName], [MenuParent]) VALUES (4, N'userToolStripMenuItem', N'3')
INSERT [dbo].[TableMenuList] ([id], [MenuName], [MenuParent]) VALUES (5, N'userPermitionToolStripMenuItem', N'0')
INSERT [dbo].[TableMenuList] ([id], [MenuName], [MenuParent]) VALUES (6, N'statusToolStripMenuItem', N'0')
SET IDENTITY_INSERT [dbo].[TableMenuList] OFF

/****** Insert User List for Table [dbo].[TableUser] ******/
SET IDENTITY_INSERT [dbo].[TableUser] ON 

INSERT [dbo].[TableUser] ([id], [Name], [UserName], [Password], [UserRole]) VALUES (1, N'Md Shakikul Islam', N'shakikul', N'shakikul', N'Admin')

SET IDENTITY_INSERT [dbo].[TableUser] OFF

/****** Insert Menu Permition List for Table [dbo].[TableUserRole] ******/
SET IDENTITY_INSERT [dbo].[TableUserRole] ON 

INSERT [dbo].[TableUserRole] ([id], [UserRole], [MenuId]) VALUES (1, N'Admin', N'1,2,3,4,5,6')
SET IDENTITY_INSERT [dbo].[TableUserRole] OFF
