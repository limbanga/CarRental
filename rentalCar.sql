USE [master]
GO
/****** Object:  Database [CarRental]    Script Date: 02/11/2023 20:08:46 ******/
CREATE DATABASE [CarRental]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'CarRental', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\CarRental.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'CarRental_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\CarRental_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [CarRental] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [CarRental].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [CarRental] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [CarRental] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [CarRental] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [CarRental] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [CarRental] SET ARITHABORT OFF 
GO
ALTER DATABASE [CarRental] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [CarRental] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [CarRental] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [CarRental] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [CarRental] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [CarRental] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [CarRental] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [CarRental] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [CarRental] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [CarRental] SET  DISABLE_BROKER 
GO
ALTER DATABASE [CarRental] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [CarRental] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [CarRental] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [CarRental] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [CarRental] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [CarRental] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [CarRental] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [CarRental] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [CarRental] SET  MULTI_USER 
GO
ALTER DATABASE [CarRental] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [CarRental] SET DB_CHAINING OFF 
GO
ALTER DATABASE [CarRental] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [CarRental] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [CarRental] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [CarRental] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [CarRental] SET QUERY_STORE = OFF
GO
USE [CarRental]
GO
/****** Object:  Table [dbo].[__EFMigrationsHistory]    Script Date: 02/11/2023 20:08:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[__EFMigrationsHistory](
	[MigrationId] [nvarchar](150) NOT NULL,
	[ProductVersion] [nvarchar](32) NOT NULL,
 CONSTRAINT [PK___EFMigrationsHistory] PRIMARY KEY CLUSTERED 
(
	[MigrationId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AppUsers]    Script Date: 02/11/2023 20:08:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AppUsers](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](30) NOT NULL,
	[Password] [nvarchar](100) NOT NULL,
	[Role] [int] NOT NULL,
	[IsLocked] [bit] NOT NULL,
 CONSTRAINT [PK_AppUsers] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[BookingNotes]    Script Date: 02/11/2023 20:08:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[BookingNotes](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[CustomerId] [int] NULL,
	[CarId] [int] NULL,
	[RentAt] [datetime2](7) NOT NULL,
	[ReturnAt] [datetime2](7) NOT NULL,
	[RealReturnAt] [datetime2](7) NOT NULL,
	[TotalFee] [real] NOT NULL,
	[Departure] [nvarchar](200) NOT NULL,
	[Destination] [nvarchar](200) NOT NULL,
 CONSTRAINT [PK_BookingNotes] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Cars]    Script Date: 02/11/2023 20:08:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Cars](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[NameCode] [nvarchar](15) NOT NULL,
	[Brand] [nvarchar](15) NOT NULL,
	[CarType] [int] NOT NULL,
	[BlueTooth] [bit] NOT NULL,
	[Camera360] [bit] NOT NULL,
	[CollisionSensor] [bit] NOT NULL,
	[DashCam] [bit] NOT NULL,
	[GPS] [bit] NOT NULL,
	[Map] [bit] NOT NULL,
	[MarginalCamera] [bit] NOT NULL,
	[PickupTruckTrunkCover] [bit] NOT NULL,
	[PricePerDay] [real] NOT NULL,
	[ReversingCamera] [bit] NOT NULL,
	[SpareTire] [bit] NOT NULL,
	[SpeedWarningKit] [bit] NOT NULL,
	[Sunroof] [bit] NOT NULL,
	[TireSensor] [bit] NOT NULL,
	[USB] [bit] NOT NULL,
	[FuelType] [int] NOT NULL,
	[CarName] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Cars] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Customers]    Script Date: 02/11/2023 20:08:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Customers](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](30) NOT NULL,
	[PhoneNumber] [nvarchar](15) NOT NULL,
	[Address] [nvarchar](200) NOT NULL,
 CONSTRAINT [PK_Customers] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20231020143205_Initial', N'6.0.23')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20231020154947_AddEntity', N'6.0.23')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20231022051724_ChangeBookingForgeinkey', N'6.0.23')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20231022160901_AddCarFeature', N'6.0.23')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20231026133405_AddFieldFeulType', N'6.0.23')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20231027133843_AddTotalFeeProp', N'6.0.23')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20231101152258_AddDecorate', N'6.0.23')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20231101155520_ChangeCarName', N'6.0.23')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20231101161734_AddDeparture', N'6.0.23')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20231101185047_AddRole', N'6.0.23')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20231102055449_AddIsLocked', N'6.0.23')
GO
SET IDENTITY_INSERT [dbo].[AppUsers] ON 

INSERT [dbo].[AppUsers] ([Id], [Name], [Password], [Role], [IsLocked]) VALUES (2, N'admin', N'$2a$11$xECju7O/GpEJGOlliMekJuLVwu9BTMjKSV2Jv.H3uGOS7dEg24JL6', 0, 0)
INSERT [dbo].[AppUsers] ([Id], [Name], [Password], [Role], [IsLocked]) VALUES (3, N'staff1', N'$2a$11$xz3ASlhF8O.E76778urMneimYWBMyX5C5lGRUHRSKFElTd51tjY3e', 1, 0)
INSERT [dbo].[AppUsers] ([Id], [Name], [Password], [Role], [IsLocked]) VALUES (4, N'staff2', N'$2a$11$VpOl.C6ukfustpZ6/7BeF.kFFAvXTJphV4LmBU6.0JDp0ZgioHbsa', 1, 0)
INSERT [dbo].[AppUsers] ([Id], [Name], [Password], [Role], [IsLocked]) VALUES (5, N'staff4', N'$2a$11$qsHV6tsniDcMlHkyXPi6hOSsXRo3hKBe5kkn3FxmEGAhVt7f1F56a', 1, 0)
INSERT [dbo].[AppUsers] ([Id], [Name], [Password], [Role], [IsLocked]) VALUES (6, N'staff5', N'$2a$11$tXCTyTODstEhFH8zMHgsiO5BKFsCVNqV88yIU1cn7x/TAMrAU1.SO', 1, 1)
INSERT [dbo].[AppUsers] ([Id], [Name], [Password], [Role], [IsLocked]) VALUES (7, N'staff3', N'$2a$11$Z6.VKHWNlIhYsLWuXCwaveQbgJ.c82CMxGlNdRXsJrWTrqORan1gu', 1, 1)
INSERT [dbo].[AppUsers] ([Id], [Name], [Password], [Role], [IsLocked]) VALUES (8, N'staff6', N'$2a$11$pt2OtJA4725f7ao3Mx0bpuGz/ylnymboXkqhCbACZ//q2SvtS.wXi', 1, 0)
SET IDENTITY_INSERT [dbo].[AppUsers] OFF
GO
SET IDENTITY_INSERT [dbo].[BookingNotes] ON 

INSERT [dbo].[BookingNotes] ([Id], [CustomerId], [CarId], [RentAt], [ReturnAt], [RealReturnAt], [TotalFee], [Departure], [Destination]) VALUES (7, 2, 11, CAST(N'2023-10-22T00:00:00.0000000' AS DateTime2), CAST(N'2023-10-23T00:00:00.0000000' AS DateTime2), CAST(N'2023-10-27T20:36:32.3002632' AS DateTime2), 0, N'Phú Yên', N'Lâm Đồng')
INSERT [dbo].[BookingNotes] ([Id], [CustomerId], [CarId], [RentAt], [ReturnAt], [RealReturnAt], [TotalFee], [Departure], [Destination]) VALUES (8, 3, 12, CAST(N'2023-10-26T00:07:25.5447935' AS DateTime2), CAST(N'2023-10-28T00:07:25.0000000' AS DateTime2), CAST(N'2023-10-27T20:50:11.6435688' AS DateTime2), 270, N'Sóc Trăng ', N'Đồng Tháp')
INSERT [dbo].[BookingNotes] ([Id], [CustomerId], [CarId], [RentAt], [ReturnAt], [RealReturnAt], [TotalFee], [Departure], [Destination]) VALUES (9, 7, 12, CAST(N'2023-10-26T00:15:12.8754976' AS DateTime2), CAST(N'2023-10-26T00:15:12.8735470' AS DateTime2), CAST(N'2023-10-27T21:21:19.9213350' AS DateTime2), 180, N'Đồng Tháp', N'Tiền Giang')
INSERT [dbo].[BookingNotes] ([Id], [CustomerId], [CarId], [RentAt], [ReturnAt], [RealReturnAt], [TotalFee], [Departure], [Destination]) VALUES (10, 2, 13, CAST(N'2023-10-22T16:21:32.0000000' AS DateTime2), CAST(N'2023-10-26T16:21:32.6732610' AS DateTime2), CAST(N'2023-10-27T21:21:54.4580498' AS DateTime2), 254, N'Bến Tre', N'Vĩnh Long')
INSERT [dbo].[BookingNotes] ([Id], [CustomerId], [CarId], [RentAt], [ReturnAt], [RealReturnAt], [TotalFee], [Departure], [Destination]) VALUES (12, 2, 11, CAST(N'2023-10-26T19:26:19.7958393' AS DateTime2), CAST(N'2023-10-28T19:26:19.0000000' AS DateTime2), CAST(N'2023-10-30T20:32:15.7653984' AS DateTime2), 120, N'Hà Nội', N'An Giang')
INSERT [dbo].[BookingNotes] ([Id], [CustomerId], [CarId], [RentAt], [ReturnAt], [RealReturnAt], [TotalFee], [Departure], [Destination]) VALUES (13, 6, 11, CAST(N'2023-10-25T19:27:03.0000000' AS DateTime2), CAST(N'2023-10-25T19:27:03.0000000' AS DateTime2), CAST(N'2023-10-30T20:32:20.7012830' AS DateTime2), 144, N'Trà Vinh', N'Bạc Liêu')
INSERT [dbo].[BookingNotes] ([Id], [CustomerId], [CarId], [RentAt], [ReturnAt], [RealReturnAt], [TotalFee], [Departure], [Destination]) VALUES (14, 2, 13, CAST(N'2023-10-27T17:46:24.0000000' AS DateTime2), CAST(N'2023-10-27T17:46:24.0174459' AS DateTime2), CAST(N'2023-10-30T20:32:24.7888716' AS DateTime2), 156, N'Tiền Giang', N'Kiên Giang')
INSERT [dbo].[BookingNotes] ([Id], [CustomerId], [CarId], [RentAt], [ReturnAt], [RealReturnAt], [TotalFee], [Departure], [Destination]) VALUES (17, 2, 20, CAST(N'2023-11-02T00:26:28.5818560' AS DateTime2), CAST(N'2023-11-11T00:26:28.0000000' AS DateTime2), CAST(N'2024-01-03T00:31:59.0000000' AS DateTime2), 5670, N'Hà nội', N'Quảng Nam')
INSERT [dbo].[BookingNotes] ([Id], [CustomerId], [CarId], [RentAt], [ReturnAt], [RealReturnAt], [TotalFee], [Departure], [Destination]) VALUES (18, 2, 20, CAST(N'2023-11-12T00:27:52.0000000' AS DateTime2), CAST(N'2023-11-24T00:27:52.0000000' AS DateTime2), CAST(N'2023-11-02T00:33:15.8773324' AS DateTime2), 1170, N'Long An', N'Hải Phòng')
INSERT [dbo].[BookingNotes] ([Id], [CustomerId], [CarId], [RentAt], [ReturnAt], [RealReturnAt], [TotalFee], [Departure], [Destination]) VALUES (19, 7, 17, CAST(N'2023-11-01T00:40:51.0000000' AS DateTime2), CAST(N'2023-11-15T00:40:51.0000000' AS DateTime2), CAST(N'2023-12-02T00:41:34.0000000' AS DateTime2), 2208, N'Buôn mê thuộc', N'Tiền Giang')
INSERT [dbo].[BookingNotes] ([Id], [CustomerId], [CarId], [RentAt], [ReturnAt], [RealReturnAt], [TotalFee], [Departure], [Destination]) VALUES (21, 2, 19, CAST(N'2023-06-07T00:44:37.0000000' AS DateTime2), CAST(N'2023-07-13T00:44:37.0000000' AS DateTime2), CAST(N'2023-07-21T00:45:48.0000000' AS DateTime2), 4005, N'Tây Ninh', N'Mỹ Tho')
INSERT [dbo].[BookingNotes] ([Id], [CustomerId], [CarId], [RentAt], [ReturnAt], [RealReturnAt], [TotalFee], [Departure], [Destination]) VALUES (23, 2, 20, CAST(N'2023-05-03T00:50:23.0000000' AS DateTime2), CAST(N'2023-05-05T00:50:23.0000000' AS DateTime2), CAST(N'2023-05-11T00:50:59.0000000' AS DateTime2), 810, N'Tây Ninh', N'Quảng Ninh')
INSERT [dbo].[BookingNotes] ([Id], [CustomerId], [CarId], [RentAt], [ReturnAt], [RealReturnAt], [TotalFee], [Departure], [Destination]) VALUES (24, 8, 19, CAST(N'2023-11-02T00:51:19.0521966' AS DateTime2), CAST(N'2023-11-30T00:51:19.0000000' AS DateTime2), CAST(N'2023-11-23T00:51:55.0000000' AS DateTime2), 3081, N'Kiên Giang', N'Cà Mau')
INSERT [dbo].[BookingNotes] ([Id], [CustomerId], [CarId], [RentAt], [ReturnAt], [RealReturnAt], [TotalFee], [Departure], [Destination]) VALUES (25, 2, 16, CAST(N'2023-11-02T00:57:25.1310516' AS DateTime2), CAST(N'2023-11-02T00:57:25.1292502' AS DateTime2), CAST(N'2023-11-03T00:57:54.0000000' AS DateTime2), 178, N'Vĩnh Long', N'An Giang')
INSERT [dbo].[BookingNotes] ([Id], [CustomerId], [CarId], [RentAt], [ReturnAt], [RealReturnAt], [TotalFee], [Departure], [Destination]) VALUES (26, 10, 14, CAST(N'2023-11-02T00:59:12.7567511' AS DateTime2), CAST(N'2023-12-28T00:59:12.0000000' AS DateTime2), CAST(N'9999-12-31T23:59:59.9999999' AS DateTime2), 0, N'Sài Gòn', N'Cà Mau')
INSERT [dbo].[BookingNotes] ([Id], [CustomerId], [CarId], [RentAt], [ReturnAt], [RealReturnAt], [TotalFee], [Departure], [Destination]) VALUES (27, 6, 16, CAST(N'2023-11-02T01:00:31.4649365' AS DateTime2), CAST(N'2023-11-14T01:00:31.0000000' AS DateTime2), CAST(N'9999-12-31T23:59:59.9999999' AS DateTime2), 0, N'Khánh Hòa', N'Nghệ An')
INSERT [dbo].[BookingNotes] ([Id], [CustomerId], [CarId], [RentAt], [ReturnAt], [RealReturnAt], [TotalFee], [Departure], [Destination]) VALUES (28, 6, 28, CAST(N'2023-11-02T17:25:49.0000000' AS DateTime2), CAST(N'2023-11-30T17:25:49.0000000' AS DateTime2), CAST(N'2023-12-20T17:27:50.0000000' AS DateTime2), 4271, N'Long An', N'Cần Giờ')
INSERT [dbo].[BookingNotes] ([Id], [CustomerId], [CarId], [RentAt], [ReturnAt], [RealReturnAt], [TotalFee], [Departure], [Destination]) VALUES (29, 7, 21, CAST(N'2023-11-02T17:39:08.0000000' AS DateTime2), CAST(N'2023-11-15T17:39:08.0000000' AS DateTime2), CAST(N'2023-11-30T17:41:50.0000000' AS DateTime2), 1921, N'Long An', N'Mỹ Tho')
SET IDENTITY_INSERT [dbo].[BookingNotes] OFF
GO
SET IDENTITY_INSERT [dbo].[Cars] ON 

INSERT [dbo].[Cars] ([Id], [NameCode], [Brand], [CarType], [BlueTooth], [Camera360], [CollisionSensor], [DashCam], [GPS], [Map], [MarginalCamera], [PickupTruckTrunkCover], [PricePerDay], [ReversingCamera], [SpareTire], [SpeedWarningKit], [Sunroof], [TireSensor], [USB], [FuelType], [CarName]) VALUES (11, N'51K-332.40', N'mitsubishi', 4, 0, 0, 0, 1, 1, 1, 0, 1, 24, 0, 0, 0, 0, 0, 0, 0, N'MITSUBISHI XPANDER 2021')
INSERT [dbo].[Cars] ([Id], [NameCode], [Brand], [CarType], [BlueTooth], [Camera360], [CollisionSensor], [DashCam], [GPS], [Map], [MarginalCamera], [PickupTruckTrunkCover], [PricePerDay], [ReversingCamera], [SpareTire], [SpeedWarningKit], [Sunroof], [TireSensor], [USB], [FuelType], [CarName]) VALUES (12, N'61A-688.60', N'ford', 4, 1, 0, 0, 1, 0, 1, 0, 0, 90, 0, 0, 0, 0, 0, 0, 0, N'FORD EVEREST 2019')
INSERT [dbo].[Cars] ([Id], [NameCode], [Brand], [CarType], [BlueTooth], [Camera360], [CollisionSensor], [DashCam], [GPS], [Map], [MarginalCamera], [PickupTruckTrunkCover], [PricePerDay], [ReversingCamera], [SpareTire], [SpeedWarningKit], [Sunroof], [TireSensor], [USB], [FuelType], [CarName]) VALUES (13, N'51K-682247', N'mitsubishi', 4, 0, 1, 0, 0, 1, 0, 1, 1, 39, 1, 0, 0, 1, 1, 0, 0, N'MITSUBISHI XPANDER 2023')
INSERT [dbo].[Cars] ([Id], [NameCode], [Brand], [CarType], [BlueTooth], [Camera360], [CollisionSensor], [DashCam], [GPS], [Map], [MarginalCamera], [PickupTruckTrunkCover], [PricePerDay], [ReversingCamera], [SpareTire], [SpeedWarningKit], [Sunroof], [TireSensor], [USB], [FuelType], [CarName]) VALUES (14, N'51G-584.70', N'mitsubishi', 3, 1, 1, 1, 0, 0, 1, 0, 1, 200, 1, 1, 0, 0, 1, 0, 0, N'MITSUBISHI MIRAGE 2017')
INSERT [dbo].[Cars] ([Id], [NameCode], [Brand], [CarType], [BlueTooth], [Camera360], [CollisionSensor], [DashCam], [GPS], [Map], [MarginalCamera], [PickupTruckTrunkCover], [PricePerDay], [ReversingCamera], [SpareTire], [SpeedWarningKit], [Sunroof], [TireSensor], [USB], [FuelType], [CarName]) VALUES (16, N'45A-4324.98', N'BMW', 3, 1, 1, 1, 0, 0, 1, 0, 1, 89, 1, 1, 0, 1, 0, 1, 0, N'BMW 320i 2013')
INSERT [dbo].[Cars] ([Id], [NameCode], [Brand], [CarType], [BlueTooth], [Camera360], [CollisionSensor], [DashCam], [GPS], [Map], [MarginalCamera], [PickupTruckTrunkCover], [PricePerDay], [ReversingCamera], [SpareTire], [SpeedWarningKit], [Sunroof], [TireSensor], [USB], [FuelType], [CarName]) VALUES (17, N'39D-123.43', N'VINFAST', 3, 0, 0, 0, 1, 1, 1, 0, 1, 69, 0, 0, 1, 0, 0, 1, 2, N'VINFAST VF5 2023')
INSERT [dbo].[Cars] ([Id], [NameCode], [Brand], [CarType], [BlueTooth], [Camera360], [CollisionSensor], [DashCam], [GPS], [Map], [MarginalCamera], [PickupTruckTrunkCover], [PricePerDay], [ReversingCamera], [SpareTire], [SpeedWarningKit], [Sunroof], [TireSensor], [USB], [FuelType], [CarName]) VALUES (18, N'51K-638.24', N'VINFAST ', 3, 0, 0, 1, 0, 1, 1, 1, 0, 29, 0, 1, 0, 1, 1, 1, 2, N'VINFAST VF8 ECO 2023')
INSERT [dbo].[Cars] ([Id], [NameCode], [Brand], [CarType], [BlueTooth], [Camera360], [CollisionSensor], [DashCam], [GPS], [Map], [MarginalCamera], [PickupTruckTrunkCover], [PricePerDay], [ReversingCamera], [SpareTire], [SpeedWarningKit], [Sunroof], [TireSensor], [USB], [FuelType], [CarName]) VALUES (19, N'51K-35095', N'VINFAST', 3, 1, 1, 1, 1, 1, 1, 1, 1, 89, 1, 0, 1, 1, 1, 1, 2, N'VINFAST VF E34 2022')
INSERT [dbo].[Cars] ([Id], [NameCode], [Brand], [CarType], [BlueTooth], [Camera360], [CollisionSensor], [DashCam], [GPS], [Map], [MarginalCamera], [PickupTruckTrunkCover], [PricePerDay], [ReversingCamera], [SpareTire], [SpeedWarningKit], [Sunroof], [TireSensor], [USB], [FuelType], [CarName]) VALUES (20, N'64G-434.32', N'ford', 5, 1, 1, 1, 1, 1, 1, 1, 0, 90, 1, 1, 1, 1, 1, 1, 1, N'FORD EVEREST 2019')
INSERT [dbo].[Cars] ([Id], [NameCode], [Brand], [CarType], [BlueTooth], [Camera360], [CollisionSensor], [DashCam], [GPS], [Map], [MarginalCamera], [PickupTruckTrunkCover], [PricePerDay], [ReversingCamera], [SpareTire], [SpeedWarningKit], [Sunroof], [TireSensor], [USB], [FuelType], [CarName]) VALUES (21, N'51H-331.47', N'MAZDA', 1, 0, 0, 0, 1, 1, 1, 1, 0, 49, 0, 1, 1, 1, 1, 1, 0, N'MAZDA 3 LUXURY 2021')
INSERT [dbo].[Cars] ([Id], [NameCode], [Brand], [CarType], [BlueTooth], [Camera360], [CollisionSensor], [DashCam], [GPS], [Map], [MarginalCamera], [PickupTruckTrunkCover], [PricePerDay], [ReversingCamera], [SpareTire], [SpeedWarningKit], [Sunroof], [TireSensor], [USB], [FuelType], [CarName]) VALUES (27, N'61A-688.65', N'VINFAST', 3, 0, 1, 0, 1, 1, 1, 1, 1, 29, 0, 1, 1, 1, 1, 0, 2, N'VF 5 Plus+')
INSERT [dbo].[Cars] ([Id], [NameCode], [Brand], [CarType], [BlueTooth], [Camera360], [CollisionSensor], [DashCam], [GPS], [Map], [MarginalCamera], [PickupTruckTrunkCover], [PricePerDay], [ReversingCamera], [SpareTire], [SpeedWarningKit], [Sunroof], [TireSensor], [USB], [FuelType], [CarName]) VALUES (28, N'62D-136.48', N'VINFAST', 4, 1, 0, 1, 0, 0, 1, 1, 1, 79, 1, 1, 1, 1, 1, 1, 2, N'VINFAST LUX SA 2.0 2021')
INSERT [dbo].[Cars] ([Id], [NameCode], [Brand], [CarType], [BlueTooth], [Camera360], [CollisionSensor], [DashCam], [GPS], [Map], [MarginalCamera], [PickupTruckTrunkCover], [PricePerDay], [ReversingCamera], [SpareTire], [SpeedWarningKit], [Sunroof], [TireSensor], [USB], [FuelType], [CarName]) VALUES (34, N'51K-110.47Y', N'ford', 3, 1, 1, 1, 1, 1, 1, 1, 0, 90, 1, 1, 1, 1, 1, 1, 1, N'HYUNDAI ACCENT 2021')
INSERT [dbo].[Cars] ([Id], [NameCode], [Brand], [CarType], [BlueTooth], [Camera360], [CollisionSensor], [DashCam], [GPS], [Map], [MarginalCamera], [PickupTruckTrunkCover], [PricePerDay], [ReversingCamera], [SpareTire], [SpeedWarningKit], [Sunroof], [TireSensor], [USB], [FuelType], [CarName]) VALUES (35, N'76A-166.30Y', N'MAZDA', 5, 0, 0, 0, 1, 1, 1, 1, 0, 49, 0, 1, 1, 1, 1, 1, 0, N'SUZUKI XL7 2020')
SET IDENTITY_INSERT [dbo].[Cars] OFF
GO
SET IDENTITY_INSERT [dbo].[Customers] ON 

INSERT [dbo].[Customers] ([Id], [Name], [PhoneNumber], [Address]) VALUES (2, N'Huỳnh Thanh Liêm', N'092312946', N'Long An')
INSERT [dbo].[Customers] ([Id], [Name], [PhoneNumber], [Address]) VALUES (3, N'Nguyễn Trần Duy', N'0432782344', N'Vũng Tàu')
INSERT [dbo].[Customers] ([Id], [Name], [PhoneNumber], [Address]) VALUES (4, N'Thanh Trâm', N'0234876255', N'Buôn Mê Thuộc')
INSERT [dbo].[Customers] ([Id], [Name], [PhoneNumber], [Address]) VALUES (6, N'Trần Hữu Quang Trường', N'038343424', N'Nghệ An')
INSERT [dbo].[Customers] ([Id], [Name], [PhoneNumber], [Address]) VALUES (7, N'Yến Nhi', N'090838425', N'Mỹ Tho')
INSERT [dbo].[Customers] ([Id], [Name], [PhoneNumber], [Address]) VALUES (8, N'Đặng Minh Tiến', N'039842235', N'Vĩnh Long')
INSERT [dbo].[Customers] ([Id], [Name], [PhoneNumber], [Address]) VALUES (9, N'Nguyễn Trung Thành', N'0884237892', N'Bến Lức')
INSERT [dbo].[Customers] ([Id], [Name], [PhoneNumber], [Address]) VALUES (10, N'Trần Văn Huy', N'0732875234', N'Thủ Thừa')
INSERT [dbo].[Customers] ([Id], [Name], [PhoneNumber], [Address]) VALUES (19, N'Nguyễn Văn Linh', N'04327823345', N'TPHCM')
INSERT [dbo].[Customers] ([Id], [Name], [PhoneNumber], [Address]) VALUES (20, N'Huỳnh Thanh Liêm', N'01213124', N'Lai Châu')
SET IDENTITY_INSERT [dbo].[Customers] OFF
GO
/****** Object:  Index [IX_BookingNotes_CarId]    Script Date: 02/11/2023 20:08:47 ******/
CREATE NONCLUSTERED INDEX [IX_BookingNotes_CarId] ON [dbo].[BookingNotes]
(
	[CarId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_BookingNotes_CustomerId]    Script Date: 02/11/2023 20:08:47 ******/
CREATE NONCLUSTERED INDEX [IX_BookingNotes_CustomerId] ON [dbo].[BookingNotes]
(
	[CustomerId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
ALTER TABLE [dbo].[AppUsers] ADD  DEFAULT ((0)) FOR [Role]
GO
ALTER TABLE [dbo].[AppUsers] ADD  DEFAULT (CONVERT([bit],(0))) FOR [IsLocked]
GO
ALTER TABLE [dbo].[BookingNotes] ADD  DEFAULT (CONVERT([real],(0))) FOR [TotalFee]
GO
ALTER TABLE [dbo].[BookingNotes] ADD  DEFAULT (N'') FOR [Departure]
GO
ALTER TABLE [dbo].[BookingNotes] ADD  DEFAULT (N'') FOR [Destination]
GO
ALTER TABLE [dbo].[Cars] ADD  DEFAULT ((0)) FOR [CarType]
GO
ALTER TABLE [dbo].[Cars] ADD  DEFAULT (CONVERT([bit],(0))) FOR [BlueTooth]
GO
ALTER TABLE [dbo].[Cars] ADD  DEFAULT (CONVERT([bit],(0))) FOR [Camera360]
GO
ALTER TABLE [dbo].[Cars] ADD  DEFAULT (CONVERT([bit],(0))) FOR [CollisionSensor]
GO
ALTER TABLE [dbo].[Cars] ADD  DEFAULT (CONVERT([bit],(0))) FOR [DashCam]
GO
ALTER TABLE [dbo].[Cars] ADD  DEFAULT (CONVERT([bit],(0))) FOR [GPS]
GO
ALTER TABLE [dbo].[Cars] ADD  DEFAULT (CONVERT([bit],(0))) FOR [Map]
GO
ALTER TABLE [dbo].[Cars] ADD  DEFAULT (CONVERT([bit],(0))) FOR [MarginalCamera]
GO
ALTER TABLE [dbo].[Cars] ADD  DEFAULT (CONVERT([bit],(0))) FOR [PickupTruckTrunkCover]
GO
ALTER TABLE [dbo].[Cars] ADD  DEFAULT (CONVERT([real],(0))) FOR [PricePerDay]
GO
ALTER TABLE [dbo].[Cars] ADD  DEFAULT (CONVERT([bit],(0))) FOR [ReversingCamera]
GO
ALTER TABLE [dbo].[Cars] ADD  DEFAULT (CONVERT([bit],(0))) FOR [SpareTire]
GO
ALTER TABLE [dbo].[Cars] ADD  DEFAULT (CONVERT([bit],(0))) FOR [SpeedWarningKit]
GO
ALTER TABLE [dbo].[Cars] ADD  DEFAULT (CONVERT([bit],(0))) FOR [Sunroof]
GO
ALTER TABLE [dbo].[Cars] ADD  DEFAULT (CONVERT([bit],(0))) FOR [TireSensor]
GO
ALTER TABLE [dbo].[Cars] ADD  DEFAULT (CONVERT([bit],(0))) FOR [USB]
GO
ALTER TABLE [dbo].[Cars] ADD  DEFAULT ((0)) FOR [FuelType]
GO
ALTER TABLE [dbo].[Cars] ADD  DEFAULT (N'') FOR [CarName]
GO
ALTER TABLE [dbo].[BookingNotes]  WITH CHECK ADD  CONSTRAINT [FK_BookingNotes_Cars_CarId] FOREIGN KEY([CarId])
REFERENCES [dbo].[Cars] ([Id])
GO
ALTER TABLE [dbo].[BookingNotes] CHECK CONSTRAINT [FK_BookingNotes_Cars_CarId]
GO
ALTER TABLE [dbo].[BookingNotes]  WITH CHECK ADD  CONSTRAINT [FK_BookingNotes_Customers_CustomerId] FOREIGN KEY([CustomerId])
REFERENCES [dbo].[Customers] ([Id])
GO
ALTER TABLE [dbo].[BookingNotes] CHECK CONSTRAINT [FK_BookingNotes_Customers_CustomerId]
GO
USE [master]
GO
ALTER DATABASE [CarRental] SET  READ_WRITE 
GO
