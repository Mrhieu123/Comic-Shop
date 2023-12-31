USE [master]
GO
/****** Object:  Database [ComicShop]    Script Date: 7/21/2023 2:45:04 PM ******/
CREATE DATABASE [ComicShop]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'ComicShop', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\ComicShop.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'ComicShop_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\ComicShop_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [ComicShop] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [ComicShop].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [ComicShop] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [ComicShop] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [ComicShop] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [ComicShop] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [ComicShop] SET ARITHABORT OFF 
GO
ALTER DATABASE [ComicShop] SET AUTO_CLOSE ON 
GO
ALTER DATABASE [ComicShop] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [ComicShop] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [ComicShop] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [ComicShop] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [ComicShop] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [ComicShop] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [ComicShop] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [ComicShop] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [ComicShop] SET  ENABLE_BROKER 
GO
ALTER DATABASE [ComicShop] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [ComicShop] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [ComicShop] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [ComicShop] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [ComicShop] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [ComicShop] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [ComicShop] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [ComicShop] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [ComicShop] SET  MULTI_USER 
GO
ALTER DATABASE [ComicShop] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [ComicShop] SET DB_CHAINING OFF 
GO
ALTER DATABASE [ComicShop] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [ComicShop] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [ComicShop] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [ComicShop] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [ComicShop] SET QUERY_STORE = OFF
GO
USE [ComicShop]
GO
/****** Object:  Table [dbo].[Cart]    Script Date: 7/21/2023 2:45:04 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Cart](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[CartId] [varchar](50) NULL,
	[ProductId] [int] NULL,
	[Count] [int] NULL,
	[DateCreate] [datetime] NULL,
 CONSTRAINT [PK_Cart] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Category]    Script Date: 7/21/2023 2:45:04 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Category](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](max) NULL,
 CONSTRAINT [PK_Category] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Order]    Script Date: 7/21/2023 2:45:04 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Order](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[UserId] [int] NULL,
	[OrderDate] [date] NULL,
	[FullName] [nvarchar](max) NULL,
	[Address] [nvarchar](max) NULL,
	[Phone] [nvarchar](max) NULL,
	[Total] [numeric](10, 2) NULL,
 CONSTRAINT [PK_Order] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[OrderDetail]    Script Date: 7/21/2023 2:45:04 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[OrderDetail](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[OrderId] [int] NULL,
	[ProductId] [int] NULL,
	[Quantity] [int] NULL,
	[Status] [bit] NULL,
	[UnitPrice] [numeric](10, 2) NULL,
 CONSTRAINT [PK_OrderDetail] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Product]    Script Date: 7/21/2023 2:45:04 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Product](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[Cid] [int] NULL,
	[Title] [nvarchar](max) NULL,
	[Price] [decimal](18, 0) NULL,
	[ProductURL] [nvarchar](max) NULL,
	[Author] [nvarchar](max) NULL,
 CONSTRAINT [PK_Product] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[User]    Script Date: 7/21/2023 2:45:04 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[User](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[UserName] [nvarchar](max) NOT NULL,
	[Password] [nvarchar](max) NOT NULL,
	[FirstName] [nvarchar](max) NOT NULL,
	[LastName] [nvarchar](max) NOT NULL,
	[Address] [nvarchar](max) NULL,
	[Phone] [nvarchar](max) NULL,
	[Email] [nvarchar](max) NULL,
	[Role] [int] NULL,
	[Status] [bit] NULL,
 CONSTRAINT [PK_User] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Category] ON 

INSERT [dbo].[Category] ([id], [Name]) VALUES (1, N'Action')
INSERT [dbo].[Category] ([id], [Name]) VALUES (2, N'Adult')
INSERT [dbo].[Category] ([id], [Name]) VALUES (3, N'Adventure')
INSERT [dbo].[Category] ([id], [Name]) VALUES (4, N'Harem')
INSERT [dbo].[Category] ([id], [Name]) VALUES (11, N'Bussiness')
INSERT [dbo].[Category] ([id], [Name]) VALUES (12, N'Others')
SET IDENTITY_INSERT [dbo].[Category] OFF
GO
SET IDENTITY_INSERT [dbo].[Order] ON 

INSERT [dbo].[Order] ([id], [UserId], [OrderDate], [FullName], [Address], [Phone], [Total]) VALUES (3, 1, CAST(N'2023-07-12' AS Date), N'hieu', N'hieu', N'0977824798', CAST(10.00 AS Numeric(10, 2)))
INSERT [dbo].[Order] ([id], [UserId], [OrderDate], [FullName], [Address], [Phone], [Total]) VALUES (4, 1, CAST(N'2023-07-12' AS Date), N'hiu', N'hiu', N'0977824798', CAST(30.00 AS Numeric(10, 2)))
INSERT [dbo].[Order] ([id], [UserId], [OrderDate], [FullName], [Address], [Phone], [Total]) VALUES (6, 1, CAST(N'2023-07-17' AS Date), N'hiu', N'hiu', N'0977824798', CAST(10.00 AS Numeric(10, 2)))
INSERT [dbo].[Order] ([id], [UserId], [OrderDate], [FullName], [Address], [Phone], [Total]) VALUES (8, 1, CAST(N'2023-07-18' AS Date), N'Hieu', N'Ham-Yen', N'0977824798', CAST(10.00 AS Numeric(10, 2)))
INSERT [dbo].[Order] ([id], [UserId], [OrderDate], [FullName], [Address], [Phone], [Total]) VALUES (10, 1, CAST(N'2023-07-18' AS Date), N'Hieu', N'Ham-Yen', N'0977824798', CAST(10.00 AS Numeric(10, 2)))
INSERT [dbo].[Order] ([id], [UserId], [OrderDate], [FullName], [Address], [Phone], [Total]) VALUES (11, 1, CAST(N'2023-07-18' AS Date), N'Hieu', N'Ham-Yen', N'0977824798', CAST(30.00 AS Numeric(10, 2)))
INSERT [dbo].[Order] ([id], [UserId], [OrderDate], [FullName], [Address], [Phone], [Total]) VALUES (12, 1, CAST(N'2023-07-18' AS Date), N'Nam', N'Tuyen-Quang', N'0977824798', CAST(6.00 AS Numeric(10, 2)))
INSERT [dbo].[Order] ([id], [UserId], [OrderDate], [FullName], [Address], [Phone], [Total]) VALUES (13, 7, CAST(N'2023-07-21' AS Date), N'hung', N'hhhh', N'0977824777', CAST(12.00 AS Numeric(10, 2)))
INSERT [dbo].[Order] ([id], [UserId], [OrderDate], [FullName], [Address], [Phone], [Total]) VALUES (14, 1, CAST(N'2023-07-21' AS Date), N'Hieu', N'Ham-Yen', N'0977824798', CAST(8.00 AS Numeric(10, 2)))
SET IDENTITY_INSERT [dbo].[Order] OFF
GO
SET IDENTITY_INSERT [dbo].[OrderDetail] ON 

INSERT [dbo].[OrderDetail] ([id], [OrderId], [ProductId], [Quantity], [Status], [UnitPrice]) VALUES (16, 12, 14, 1, 1, CAST(6.00 AS Numeric(10, 2)))
INSERT [dbo].[OrderDetail] ([id], [OrderId], [ProductId], [Quantity], [Status], [UnitPrice]) VALUES (17, 13, 11, 3, 1, CAST(4.00 AS Numeric(10, 2)))
INSERT [dbo].[OrderDetail] ([id], [OrderId], [ProductId], [Quantity], [Status], [UnitPrice]) VALUES (18, 14, 11, 2, 1, CAST(4.00 AS Numeric(10, 2)))
SET IDENTITY_INSERT [dbo].[OrderDetail] OFF
GO
SET IDENTITY_INSERT [dbo].[Product] ON 

INSERT [dbo].[Product] ([id], [Cid], [Title], [Price], [ProductURL], [Author]) VALUES (11, 1, N'Hello', CAST(4 AS Decimal(18, 0)), N'image15.jpg', N'Hieu')
INSERT [dbo].[Product] ([id], [Cid], [Title], [Price], [ProductURL], [Author]) VALUES (12, 1, N'2Hand', CAST(4 AS Decimal(18, 0)), N'imge13.jpg', N'Hung')
INSERT [dbo].[Product] ([id], [Cid], [Title], [Price], [ProductURL], [Author]) VALUES (13, 2, N'Big', CAST(5 AS Decimal(18, 0)), N'image10.jpg', N'Quang')
INSERT [dbo].[Product] ([id], [Cid], [Title], [Price], [ProductURL], [Author]) VALUES (14, 3, N'He', CAST(6 AS Decimal(18, 0)), N'image25.jpg', N'Nam')
INSERT [dbo].[Product] ([id], [Cid], [Title], [Price], [ProductURL], [Author]) VALUES (15, 11, N'one', CAST(5 AS Decimal(18, 0)), N'image36.jpg', N'hieu')
SET IDENTITY_INSERT [dbo].[Product] OFF
GO
SET IDENTITY_INSERT [dbo].[User] ON 

INSERT [dbo].[User] ([id], [UserName], [Password], [FirstName], [LastName], [Address], [Phone], [Email], [Role], [Status]) VALUES (1, N'hieu', N'123', N'Pham Minh', N'Hieu', N'Ham-Yen', N'0977824798', N'hieu@gmail.com', 1, 1)
INSERT [dbo].[User] ([id], [UserName], [Password], [FirstName], [LastName], [Address], [Phone], [Email], [Role], [Status]) VALUES (7, N'hung', N'123', N'nguyen', N'hung', N'hhhh', N'0977824777', N'hung@gmail.com', 2, 1)
SET IDENTITY_INSERT [dbo].[User] OFF
GO
ALTER TABLE [dbo].[User] ADD  DEFAULT ((1)) FOR [Status]
GO
ALTER TABLE [dbo].[Cart]  WITH CHECK ADD  CONSTRAINT [FK_Cart_Product] FOREIGN KEY([ProductId])
REFERENCES [dbo].[Product] ([id])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Cart] CHECK CONSTRAINT [FK_Cart_Product]
GO
ALTER TABLE [dbo].[Order]  WITH CHECK ADD  CONSTRAINT [FK_Oder_User] FOREIGN KEY([UserId])
REFERENCES [dbo].[User] ([id])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Order] CHECK CONSTRAINT [FK_Oder_User]
GO
ALTER TABLE [dbo].[OrderDetail]  WITH CHECK ADD  CONSTRAINT [FK_OrderDetail_Order] FOREIGN KEY([OrderId])
REFERENCES [dbo].[Order] ([id])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[OrderDetail] CHECK CONSTRAINT [FK_OrderDetail_Order]
GO
ALTER TABLE [dbo].[OrderDetail]  WITH CHECK ADD  CONSTRAINT [FK_OrderDetail_Product] FOREIGN KEY([ProductId])
REFERENCES [dbo].[Product] ([id])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[OrderDetail] CHECK CONSTRAINT [FK_OrderDetail_Product]
GO
ALTER TABLE [dbo].[Product]  WITH CHECK ADD  CONSTRAINT [FK_Product_Category] FOREIGN KEY([Cid])
REFERENCES [dbo].[Category] ([id])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Product] CHECK CONSTRAINT [FK_Product_Category]
GO
USE [master]
GO
ALTER DATABASE [ComicShop] SET  READ_WRITE 
GO
