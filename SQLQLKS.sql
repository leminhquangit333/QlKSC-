USE [master]
GO
/****** Object:  Database [QLKS]    Script Date: 19/03/2021 19:38:34 ******/
CREATE DATABASE [QLKS]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'QLKS', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.SQLEXPRESS\MSSQL\DATA\QLKS.mdf' , SIZE = 3072KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'QLKS_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.SQLEXPRESS\MSSQL\DATA\QLKS_log.ldf' , SIZE = 1024KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [QLKS] SET COMPATIBILITY_LEVEL = 120
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [QLKS].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [QLKS] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [QLKS] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [QLKS] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [QLKS] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [QLKS] SET ARITHABORT OFF 
GO
ALTER DATABASE [QLKS] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [QLKS] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [QLKS] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [QLKS] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [QLKS] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [QLKS] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [QLKS] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [QLKS] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [QLKS] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [QLKS] SET  DISABLE_BROKER 
GO
ALTER DATABASE [QLKS] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [QLKS] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [QLKS] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [QLKS] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [QLKS] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [QLKS] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [QLKS] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [QLKS] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [QLKS] SET  MULTI_USER 
GO
ALTER DATABASE [QLKS] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [QLKS] SET DB_CHAINING OFF 
GO
ALTER DATABASE [QLKS] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [QLKS] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
ALTER DATABASE [QLKS] SET DELAYED_DURABILITY = DISABLED 
GO
USE [QLKS]
GO
/****** Object:  Table [dbo].[CTDV]    Script Date: 19/03/2021 19:38:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CTDV](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[MaDV] [int] NULL,
	[MaPhieuDatPhong] [int] NULL,
	[SoLuong] [int] NULL,
 CONSTRAINT [PK_CTDV] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[DichVu]    Script Date: 19/03/2021 19:38:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DichVu](
	[MaDV] [int] NOT NULL,
	[TenDV] [nvarchar](50) NULL,
	[Gia] [bigint] NULL,
	[ThongTinDV] [nvarchar](50) NULL,
 CONSTRAINT [PK_DichVu] PRIMARY KEY CLUSTERED 
(
	[MaDV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[HoaDon]    Script Date: 19/03/2021 19:38:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[HoaDon](
	[MaHD] [int] IDENTITY(1,1) NOT NULL,
	[MaPhieuDatPhong] [int] NULL,
	[MaNV] [nvarchar](50) NULL,
	[NgayLap] [date] NULL,
	[ThanhTien] [bigint] NULL,
 CONSTRAINT [PK_HoaDon] PRIMARY KEY CLUSTERED 
(
	[MaHD] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[KhachHang]    Script Date: 19/03/2021 19:38:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[KhachHang](
	[MaKhachHang] [int] IDENTITY(1,1) NOT NULL,
	[TenKhachHang] [nvarchar](50) NULL,
	[SDT] [int] NULL,
	[CMND] [int] NULL,
 CONSTRAINT [PK_KhachHang] PRIMARY KEY CLUSTERED 
(
	[MaKhachHang] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[NhanVien]    Script Date: 19/03/2021 19:38:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NhanVien](
	[TenDangNhap] [nvarchar](50) NOT NULL,
	[MatKhau] [nvarchar](50) NULL,
	[HoTen] [nvarchar](50) NULL,
	[CMND] [int] NULL,
	[MaNV] [nvarchar](50) NOT NULL,
	[Loai] [int] NULL,
 CONSTRAINT [PK_NhanVien] PRIMARY KEY CLUSTERED 
(
	[MaNV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[PhieuDatPhong]    Script Date: 19/03/2021 19:38:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PhieuDatPhong](
	[MaPhieu] [int] IDENTITY(1,1) NOT NULL,
	[MaKhachHang] [int] NULL,
	[MaNV] [nvarchar](50) NULL,
	[NgayDat] [datetime] NULL,
	[NgayTra] [datetime] NULL,
	[TienCoc] [bigint] NULL,
	[SoPhong] [int] NULL,
	[HinhThuc] [int] NULL,
 CONSTRAINT [PK_PhieuDatPhong1] PRIMARY KEY CLUSTERED 
(
	[MaPhieu] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Phong]    Script Date: 19/03/2021 19:38:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Phong](
	[SoPhong] [int] NOT NULL,
	[Tang] [int] NULL,
	[SoGiuong] [int] NULL,
	[GiaTheoNgay] [bigint] NULL,
	[GiaTheoGio] [bigint] NULL,
 CONSTRAINT [PK_Phong] PRIMARY KEY CLUSTERED 
(
	[SoPhong] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  UserDefinedFunction [dbo].[fnKhachHang]    Script Date: 19/03/2021 19:38:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE FUNCTION [dbo].[fnKhachHang]()
RETURNS TABLE 
AS
RETURN 
(
	SELECT MaPhieu,TenKhachHang,NgayDat,SoPhong,NgayTra,TienCoc from	DBO.KhachHang,dbo.PhieuDatPhong where KhachHang.MaKhachHang = PhieuDatPhong.MaKhachHang
)

GO
INSERT [dbo].[DichVu] ([MaDV], [TenDV], [Gia], [ThongTinDV]) VALUES (1, N'abc', 30000, N'test')
SET IDENTITY_INSERT [dbo].[HoaDon] ON 

INSERT [dbo].[HoaDon] ([MaHD], [MaPhieuDatPhong], [MaNV], [NgayLap], [ThanhTien]) VALUES (2, 3, N'NV01', CAST(N'2020-09-22' AS Date), 1300000)
INSERT [dbo].[HoaDon] ([MaHD], [MaPhieuDatPhong], [MaNV], [NgayLap], [ThanhTien]) VALUES (3, 3, N'NV01', CAST(N'2021-03-17' AS Date), 770000)
INSERT [dbo].[HoaDon] ([MaHD], [MaPhieuDatPhong], [MaNV], [NgayLap], [ThanhTien]) VALUES (4, 3, N'NV01', CAST(N'2021-03-17' AS Date), 770000)
SET IDENTITY_INSERT [dbo].[HoaDon] OFF
SET IDENTITY_INSERT [dbo].[KhachHang] ON 

INSERT [dbo].[KhachHang] ([MaKhachHang], [TenKhachHang], [SDT], [CMND]) VALUES (1, N'Lê Minh Quang', 339474333, 65465456)
INSERT [dbo].[KhachHang] ([MaKhachHang], [TenKhachHang], [SDT], [CMND]) VALUES (2, N'LeMinhQuang', 32656, 165456)
INSERT [dbo].[KhachHang] ([MaKhachHang], [TenKhachHang], [SDT], [CMND]) VALUES (3, N'quang', 23423422, 341432322)
INSERT [dbo].[KhachHang] ([MaKhachHang], [TenKhachHang], [SDT], [CMND]) VALUES (4, N'quang', 23131, 42131431)
SET IDENTITY_INSERT [dbo].[KhachHang] OFF
INSERT [dbo].[NhanVien] ([TenDangNhap], [MatKhau], [HoTen], [CMND], [MaNV], [Loai]) VALUES (N'admin', N'123456', N'aaaa', 11325658, N'NV01', 1)
INSERT [dbo].[NhanVien] ([TenDangNhap], [MatKhau], [HoTen], [CMND], [MaNV], [Loai]) VALUES (N'lequang123', N'123456', N'Quang', 256322, N'NV2', 2)
SET IDENTITY_INSERT [dbo].[PhieuDatPhong] ON 

INSERT [dbo].[PhieuDatPhong] ([MaPhieu], [MaKhachHang], [MaNV], [NgayDat], [NgayTra], [TienCoc], [SoPhong], [HinhThuc]) VALUES (3, 1, N'NV01', CAST(N'2020-07-22 00:00:00.000' AS DateTime), CAST(N'2020-07-25 00:00:00.000' AS DateTime), 130000, 303, 1)
INSERT [dbo].[PhieuDatPhong] ([MaPhieu], [MaKhachHang], [MaNV], [NgayDat], [NgayTra], [TienCoc], [SoPhong], [HinhThuc]) VALUES (4, 1, N'NV01', CAST(N'2020-02-22 00:00:00.000' AS DateTime), CAST(N'2020-07-25 00:00:00.000' AS DateTime), 130000, 303, 1)
INSERT [dbo].[PhieuDatPhong] ([MaPhieu], [MaKhachHang], [MaNV], [NgayDat], [NgayTra], [TienCoc], [SoPhong], [HinhThuc]) VALUES (5, 1, N'NV01', CAST(N'2020-02-22 00:00:00.000' AS DateTime), CAST(N'2020-07-25 00:00:00.000' AS DateTime), 130000, 101, 1)
INSERT [dbo].[PhieuDatPhong] ([MaPhieu], [MaKhachHang], [MaNV], [NgayDat], [NgayTra], [TienCoc], [SoPhong], [HinhThuc]) VALUES (6, 1, N'NV01', CAST(N'2020-02-22 00:00:00.000' AS DateTime), CAST(N'2020-07-25 00:00:00.000' AS DateTime), 130000, 102, 1)
INSERT [dbo].[PhieuDatPhong] ([MaPhieu], [MaKhachHang], [MaNV], [NgayDat], [NgayTra], [TienCoc], [SoPhong], [HinhThuc]) VALUES (7, 1, N'NV01', CAST(N'2020-02-22 00:00:00.000' AS DateTime), CAST(N'2020-07-25 00:00:00.000' AS DateTime), 130000, 103, 1)
INSERT [dbo].[PhieuDatPhong] ([MaPhieu], [MaKhachHang], [MaNV], [NgayDat], [NgayTra], [TienCoc], [SoPhong], [HinhThuc]) VALUES (8, 1, N'NV01', CAST(N'2020-02-22 00:00:00.000' AS DateTime), CAST(N'2020-07-25 00:00:00.000' AS DateTime), 130000, 104, 1)
INSERT [dbo].[PhieuDatPhong] ([MaPhieu], [MaKhachHang], [MaNV], [NgayDat], [NgayTra], [TienCoc], [SoPhong], [HinhThuc]) VALUES (9, 1, N'NV01', CAST(N'2020-02-22 00:00:00.000' AS DateTime), CAST(N'2020-07-25 00:00:00.000' AS DateTime), 130000, 105, 1)
INSERT [dbo].[PhieuDatPhong] ([MaPhieu], [MaKhachHang], [MaNV], [NgayDat], [NgayTra], [TienCoc], [SoPhong], [HinhThuc]) VALUES (10, 1, N'NV01', CAST(N'2020-02-22 00:00:00.000' AS DateTime), CAST(N'2020-07-25 00:00:00.000' AS DateTime), 130000, 201, 1)
INSERT [dbo].[PhieuDatPhong] ([MaPhieu], [MaKhachHang], [MaNV], [NgayDat], [NgayTra], [TienCoc], [SoPhong], [HinhThuc]) VALUES (11, 1, N'NV01', CAST(N'2020-02-22 00:00:00.000' AS DateTime), CAST(N'2020-07-25 00:00:00.000' AS DateTime), 130000, 202, 1)
INSERT [dbo].[PhieuDatPhong] ([MaPhieu], [MaKhachHang], [MaNV], [NgayDat], [NgayTra], [TienCoc], [SoPhong], [HinhThuc]) VALUES (12, 1, N'NV01', CAST(N'2020-02-22 00:00:00.000' AS DateTime), CAST(N'2020-07-25 00:00:00.000' AS DateTime), 130000, 203, 1)
INSERT [dbo].[PhieuDatPhong] ([MaPhieu], [MaKhachHang], [MaNV], [NgayDat], [NgayTra], [TienCoc], [SoPhong], [HinhThuc]) VALUES (13, 1, N'NV01', CAST(N'2020-02-22 00:00:00.000' AS DateTime), CAST(N'2020-07-25 00:00:00.000' AS DateTime), 130000, 204, 1)
INSERT [dbo].[PhieuDatPhong] ([MaPhieu], [MaKhachHang], [MaNV], [NgayDat], [NgayTra], [TienCoc], [SoPhong], [HinhThuc]) VALUES (14, 1, N'NV01', CAST(N'2020-02-22 00:00:00.000' AS DateTime), CAST(N'2020-07-25 00:00:00.000' AS DateTime), 130000, 205, 1)
INSERT [dbo].[PhieuDatPhong] ([MaPhieu], [MaKhachHang], [MaNV], [NgayDat], [NgayTra], [TienCoc], [SoPhong], [HinhThuc]) VALUES (15, 1, N'NV01', CAST(N'2020-02-22 00:00:00.000' AS DateTime), CAST(N'2020-07-25 00:00:00.000' AS DateTime), 130000, 301, 1)
INSERT [dbo].[PhieuDatPhong] ([MaPhieu], [MaKhachHang], [MaNV], [NgayDat], [NgayTra], [TienCoc], [SoPhong], [HinhThuc]) VALUES (16, 1, N'NV01', CAST(N'2020-02-22 00:00:00.000' AS DateTime), CAST(N'2020-07-25 00:00:00.000' AS DateTime), 130000, 302, 1)
INSERT [dbo].[PhieuDatPhong] ([MaPhieu], [MaKhachHang], [MaNV], [NgayDat], [NgayTra], [TienCoc], [SoPhong], [HinhThuc]) VALUES (17, 1, N'NV01', CAST(N'2020-02-22 00:00:00.000' AS DateTime), CAST(N'2020-07-25 00:00:00.000' AS DateTime), 130000, 303, 1)
INSERT [dbo].[PhieuDatPhong] ([MaPhieu], [MaKhachHang], [MaNV], [NgayDat], [NgayTra], [TienCoc], [SoPhong], [HinhThuc]) VALUES (18, 1, N'NV01', CAST(N'2020-02-22 00:00:00.000' AS DateTime), CAST(N'2020-07-25 00:00:00.000' AS DateTime), 130000, 304, 1)
INSERT [dbo].[PhieuDatPhong] ([MaPhieu], [MaKhachHang], [MaNV], [NgayDat], [NgayTra], [TienCoc], [SoPhong], [HinhThuc]) VALUES (19, 1, N'NV01', CAST(N'2020-02-22 00:00:00.000' AS DateTime), CAST(N'2020-07-25 00:00:00.000' AS DateTime), 130000, 305, 1)
INSERT [dbo].[PhieuDatPhong] ([MaPhieu], [MaKhachHang], [MaNV], [NgayDat], [NgayTra], [TienCoc], [SoPhong], [HinhThuc]) VALUES (20, 1, N'NV01', CAST(N'2020-02-22 00:00:00.000' AS DateTime), CAST(N'2020-07-25 00:00:00.000' AS DateTime), 130000, 401, 1)
INSERT [dbo].[PhieuDatPhong] ([MaPhieu], [MaKhachHang], [MaNV], [NgayDat], [NgayTra], [TienCoc], [SoPhong], [HinhThuc]) VALUES (21, 1, N'NV01', CAST(N'2020-02-22 00:00:00.000' AS DateTime), CAST(N'2020-07-25 00:00:00.000' AS DateTime), 130000, 402, 1)
INSERT [dbo].[PhieuDatPhong] ([MaPhieu], [MaKhachHang], [MaNV], [NgayDat], [NgayTra], [TienCoc], [SoPhong], [HinhThuc]) VALUES (22, 1, N'NV01', CAST(N'2020-02-22 00:00:00.000' AS DateTime), CAST(N'2020-07-25 00:00:00.000' AS DateTime), 130000, 403, 1)
INSERT [dbo].[PhieuDatPhong] ([MaPhieu], [MaKhachHang], [MaNV], [NgayDat], [NgayTra], [TienCoc], [SoPhong], [HinhThuc]) VALUES (23, 1, N'NV01', CAST(N'2020-02-22 00:00:00.000' AS DateTime), CAST(N'2020-07-25 00:00:00.000' AS DateTime), 130000, 404, 1)
INSERT [dbo].[PhieuDatPhong] ([MaPhieu], [MaKhachHang], [MaNV], [NgayDat], [NgayTra], [TienCoc], [SoPhong], [HinhThuc]) VALUES (24, 1, N'NV01', CAST(N'2020-02-22 00:00:00.000' AS DateTime), CAST(N'2020-07-25 00:00:00.000' AS DateTime), 130000, 405, 1)
INSERT [dbo].[PhieuDatPhong] ([MaPhieu], [MaKhachHang], [MaNV], [NgayDat], [NgayTra], [TienCoc], [SoPhong], [HinhThuc]) VALUES (25, 1, N'NV01', CAST(N'2020-02-22 00:00:00.000' AS DateTime), CAST(N'2020-07-25 00:00:00.000' AS DateTime), 130000, 501, 1)
INSERT [dbo].[PhieuDatPhong] ([MaPhieu], [MaKhachHang], [MaNV], [NgayDat], [NgayTra], [TienCoc], [SoPhong], [HinhThuc]) VALUES (26, 1, N'NV01', CAST(N'2020-02-22 00:00:00.000' AS DateTime), CAST(N'2020-07-25 00:00:00.000' AS DateTime), 130000, 502, 1)
INSERT [dbo].[PhieuDatPhong] ([MaPhieu], [MaKhachHang], [MaNV], [NgayDat], [NgayTra], [TienCoc], [SoPhong], [HinhThuc]) VALUES (27, 1, N'NV01', CAST(N'2020-02-22 00:00:00.000' AS DateTime), CAST(N'2020-07-25 00:00:00.000' AS DateTime), 130000, 503, 1)
INSERT [dbo].[PhieuDatPhong] ([MaPhieu], [MaKhachHang], [MaNV], [NgayDat], [NgayTra], [TienCoc], [SoPhong], [HinhThuc]) VALUES (28, 1, N'NV01', CAST(N'2020-02-22 00:00:00.000' AS DateTime), CAST(N'2020-07-25 00:00:00.000' AS DateTime), 130000, 504, 1)
INSERT [dbo].[PhieuDatPhong] ([MaPhieu], [MaKhachHang], [MaNV], [NgayDat], [NgayTra], [TienCoc], [SoPhong], [HinhThuc]) VALUES (29, 1, N'NV01', CAST(N'2020-02-22 00:00:00.000' AS DateTime), CAST(N'2020-07-25 00:00:00.000' AS DateTime), 130000, 505, 1)
INSERT [dbo].[PhieuDatPhong] ([MaPhieu], [MaKhachHang], [MaNV], [NgayDat], [NgayTra], [TienCoc], [SoPhong], [HinhThuc]) VALUES (30, 1, N'NV01', CAST(N'2020-02-22 00:00:00.000' AS DateTime), CAST(N'2020-07-25 00:00:00.000' AS DateTime), 130000, 601, 1)
INSERT [dbo].[PhieuDatPhong] ([MaPhieu], [MaKhachHang], [MaNV], [NgayDat], [NgayTra], [TienCoc], [SoPhong], [HinhThuc]) VALUES (31, 1, N'NV01', CAST(N'2020-02-22 00:00:00.000' AS DateTime), CAST(N'2020-07-25 00:00:00.000' AS DateTime), 130000, 602, 1)
INSERT [dbo].[PhieuDatPhong] ([MaPhieu], [MaKhachHang], [MaNV], [NgayDat], [NgayTra], [TienCoc], [SoPhong], [HinhThuc]) VALUES (32, 1, N'NV01', CAST(N'2020-02-22 00:00:00.000' AS DateTime), CAST(N'2020-07-25 00:00:00.000' AS DateTime), 130000, 603, 1)
INSERT [dbo].[PhieuDatPhong] ([MaPhieu], [MaKhachHang], [MaNV], [NgayDat], [NgayTra], [TienCoc], [SoPhong], [HinhThuc]) VALUES (33, 1, N'NV01', CAST(N'2020-02-22 00:00:00.000' AS DateTime), CAST(N'2020-07-25 00:00:00.000' AS DateTime), 130000, 604, 1)
INSERT [dbo].[PhieuDatPhong] ([MaPhieu], [MaKhachHang], [MaNV], [NgayDat], [NgayTra], [TienCoc], [SoPhong], [HinhThuc]) VALUES (34, 1, N'NV01', CAST(N'2020-02-22 00:00:00.000' AS DateTime), CAST(N'2020-07-25 00:00:00.000' AS DateTime), 130000, 605, 1)
SET IDENTITY_INSERT [dbo].[PhieuDatPhong] OFF
INSERT [dbo].[Phong] ([SoPhong], [Tang], [SoGiuong], [GiaTheoNgay], [GiaTheoGio]) VALUES (101, 1, 2, 300000, 40000)
INSERT [dbo].[Phong] ([SoPhong], [Tang], [SoGiuong], [GiaTheoNgay], [GiaTheoGio]) VALUES (102, 2, 2, 300000, 40000)
INSERT [dbo].[Phong] ([SoPhong], [Tang], [SoGiuong], [GiaTheoNgay], [GiaTheoGio]) VALUES (103, 3, 2, 300000, 40000)
INSERT [dbo].[Phong] ([SoPhong], [Tang], [SoGiuong], [GiaTheoNgay], [GiaTheoGio]) VALUES (104, 4, 2, 300000, 40000)
INSERT [dbo].[Phong] ([SoPhong], [Tang], [SoGiuong], [GiaTheoNgay], [GiaTheoGio]) VALUES (105, 5, 2, 300000, 40000)
INSERT [dbo].[Phong] ([SoPhong], [Tang], [SoGiuong], [GiaTheoNgay], [GiaTheoGio]) VALUES (201, 1, 2, 300000, 40000)
INSERT [dbo].[Phong] ([SoPhong], [Tang], [SoGiuong], [GiaTheoNgay], [GiaTheoGio]) VALUES (202, 2, 2, 300000, 40000)
INSERT [dbo].[Phong] ([SoPhong], [Tang], [SoGiuong], [GiaTheoNgay], [GiaTheoGio]) VALUES (203, 3, 2, 300000, 40000)
INSERT [dbo].[Phong] ([SoPhong], [Tang], [SoGiuong], [GiaTheoNgay], [GiaTheoGio]) VALUES (204, 4, 2, 300000, 40000)
INSERT [dbo].[Phong] ([SoPhong], [Tang], [SoGiuong], [GiaTheoNgay], [GiaTheoGio]) VALUES (205, 5, 2, 300000, 40000)
INSERT [dbo].[Phong] ([SoPhong], [Tang], [SoGiuong], [GiaTheoNgay], [GiaTheoGio]) VALUES (301, 1, 2, 300000, 40000)
INSERT [dbo].[Phong] ([SoPhong], [Tang], [SoGiuong], [GiaTheoNgay], [GiaTheoGio]) VALUES (302, 2, 2, 300000, 40000)
INSERT [dbo].[Phong] ([SoPhong], [Tang], [SoGiuong], [GiaTheoNgay], [GiaTheoGio]) VALUES (303, 3, 2, 300000, 40000)
INSERT [dbo].[Phong] ([SoPhong], [Tang], [SoGiuong], [GiaTheoNgay], [GiaTheoGio]) VALUES (304, 4, 2, 300000, 40000)
INSERT [dbo].[Phong] ([SoPhong], [Tang], [SoGiuong], [GiaTheoNgay], [GiaTheoGio]) VALUES (305, 5, 2, 300000, 40000)
INSERT [dbo].[Phong] ([SoPhong], [Tang], [SoGiuong], [GiaTheoNgay], [GiaTheoGio]) VALUES (401, 1, 2, 300000, 40000)
INSERT [dbo].[Phong] ([SoPhong], [Tang], [SoGiuong], [GiaTheoNgay], [GiaTheoGio]) VALUES (402, 2, 2, 300000, 40000)
INSERT [dbo].[Phong] ([SoPhong], [Tang], [SoGiuong], [GiaTheoNgay], [GiaTheoGio]) VALUES (403, 3, 2, 300000, 40000)
INSERT [dbo].[Phong] ([SoPhong], [Tang], [SoGiuong], [GiaTheoNgay], [GiaTheoGio]) VALUES (404, 4, 2, 300000, 40000)
INSERT [dbo].[Phong] ([SoPhong], [Tang], [SoGiuong], [GiaTheoNgay], [GiaTheoGio]) VALUES (405, 5, 2, 300000, 40000)
INSERT [dbo].[Phong] ([SoPhong], [Tang], [SoGiuong], [GiaTheoNgay], [GiaTheoGio]) VALUES (501, 1, 2, 300000, 40000)
INSERT [dbo].[Phong] ([SoPhong], [Tang], [SoGiuong], [GiaTheoNgay], [GiaTheoGio]) VALUES (502, 2, 2, 300000, 40000)
INSERT [dbo].[Phong] ([SoPhong], [Tang], [SoGiuong], [GiaTheoNgay], [GiaTheoGio]) VALUES (503, 3, 2, 300000, 40000)
INSERT [dbo].[Phong] ([SoPhong], [Tang], [SoGiuong], [GiaTheoNgay], [GiaTheoGio]) VALUES (504, 4, 2, 300000, 40000)
INSERT [dbo].[Phong] ([SoPhong], [Tang], [SoGiuong], [GiaTheoNgay], [GiaTheoGio]) VALUES (505, 5, 2, 300000, 40000)
INSERT [dbo].[Phong] ([SoPhong], [Tang], [SoGiuong], [GiaTheoNgay], [GiaTheoGio]) VALUES (601, 1, 2, 300000, 40000)
INSERT [dbo].[Phong] ([SoPhong], [Tang], [SoGiuong], [GiaTheoNgay], [GiaTheoGio]) VALUES (602, 2, 2, 300000, 40000)
INSERT [dbo].[Phong] ([SoPhong], [Tang], [SoGiuong], [GiaTheoNgay], [GiaTheoGio]) VALUES (603, 3, 2, 300000, 40000)
INSERT [dbo].[Phong] ([SoPhong], [Tang], [SoGiuong], [GiaTheoNgay], [GiaTheoGio]) VALUES (604, 4, 2, 300000, 40000)
INSERT [dbo].[Phong] ([SoPhong], [Tang], [SoGiuong], [GiaTheoNgay], [GiaTheoGio]) VALUES (605, 5, 2, 300000, 40000)
ALTER TABLE [dbo].[CTDV]  WITH CHECK ADD  CONSTRAINT [FK_CTDV_DichVu] FOREIGN KEY([MaDV])
REFERENCES [dbo].[DichVu] ([MaDV])
GO
ALTER TABLE [dbo].[CTDV] CHECK CONSTRAINT [FK_CTDV_DichVu]
GO
ALTER TABLE [dbo].[CTDV]  WITH CHECK ADD  CONSTRAINT [FK_CTDV_PhieuDatPhong] FOREIGN KEY([MaPhieuDatPhong])
REFERENCES [dbo].[PhieuDatPhong] ([MaPhieu])
GO
ALTER TABLE [dbo].[CTDV] CHECK CONSTRAINT [FK_CTDV_PhieuDatPhong]
GO
ALTER TABLE [dbo].[HoaDon]  WITH CHECK ADD  CONSTRAINT [FK_HoaDon_NhanVien] FOREIGN KEY([MaNV])
REFERENCES [dbo].[NhanVien] ([MaNV])
GO
ALTER TABLE [dbo].[HoaDon] CHECK CONSTRAINT [FK_HoaDon_NhanVien]
GO
ALTER TABLE [dbo].[HoaDon]  WITH CHECK ADD  CONSTRAINT [FK_HoaDon_PhieuDatPhong] FOREIGN KEY([MaPhieuDatPhong])
REFERENCES [dbo].[PhieuDatPhong] ([MaPhieu])
GO
ALTER TABLE [dbo].[HoaDon] CHECK CONSTRAINT [FK_HoaDon_PhieuDatPhong]
GO
ALTER TABLE [dbo].[PhieuDatPhong]  WITH CHECK ADD  CONSTRAINT [FK_PhieuDatPhong_KhachHang] FOREIGN KEY([MaKhachHang])
REFERENCES [dbo].[KhachHang] ([MaKhachHang])
GO
ALTER TABLE [dbo].[PhieuDatPhong] CHECK CONSTRAINT [FK_PhieuDatPhong_KhachHang]
GO
ALTER TABLE [dbo].[PhieuDatPhong]  WITH CHECK ADD  CONSTRAINT [FK_PhieuDatPhong_NhanVien] FOREIGN KEY([MaNV])
REFERENCES [dbo].[NhanVien] ([MaNV])
GO
ALTER TABLE [dbo].[PhieuDatPhong] CHECK CONSTRAINT [FK_PhieuDatPhong_NhanVien]
GO
ALTER TABLE [dbo].[PhieuDatPhong]  WITH CHECK ADD  CONSTRAINT [FK_PhieuDatPhong_Phong] FOREIGN KEY([SoPhong])
REFERENCES [dbo].[Phong] ([SoPhong])
GO
ALTER TABLE [dbo].[PhieuDatPhong] CHECK CONSTRAINT [FK_PhieuDatPhong_Phong]
GO
USE [master]
GO
ALTER DATABASE [QLKS] SET  READ_WRITE 
GO
