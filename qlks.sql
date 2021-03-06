USE [HotelDatabase]
GO
/****** Object:  Table [dbo].[DICH_VU]    Script Date: 03/01/2020 4:13:55 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DICH_VU](
	[MaDV] [varchar](5) NOT NULL,
	[TenDV] [nvarchar](30) NOT NULL,
	[DonGia] [float] NOT NULL,
 CONSTRAINT [PK_DICH_VU] PRIMARY KEY CLUSTERED 
(
	[MaDV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[HOA_DON]    Script Date: 03/01/2020 4:13:55 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[HOA_DON](
	[MaHoaDon] [int] IDENTITY(1,1) NOT NULL,
	[MaThuePhong] [int] NULL,
	[TongTien] [decimal](18, 0) NULL,
 CONSTRAINT [PK_HOA_DON] PRIMARY KEY CLUSTERED 
(
	[MaHoaDon] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[LOAI_PHONG]    Script Date: 03/01/2020 4:13:55 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LOAI_PHONG](
	[MaLoai] [varchar](5) NOT NULL,
	[TenLoai] [nvarchar](20) NOT NULL,
	[DonGiaNgay] [float] NOT NULL,
	[DonGiaGio] [float] NOT NULL,
 CONSTRAINT [PK_LOAI_PHONG] PRIMARY KEY CLUSTERED 
(
	[MaLoai] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[NHAN_VIEN]    Script Date: 03/01/2020 4:13:55 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NHAN_VIEN](
	[MaNhanVien] [int] IDENTITY(1,1) NOT NULL,
	[TenNhanVien] [nvarchar](30) NOT NULL,
	[SoDienThoai] [varchar](15) NULL,
	[DiaChi] [nvarchar](300) NULL,
	[TenDangNhap] [varchar](10) NOT NULL,
	[MatKhau] [varchar](20) NOT NULL,
	[MaPhanQuyen] [int] NOT NULL,
 CONSTRAINT [PK_NHAN_VIEN] PRIMARY KEY CLUSTERED 
(
	[MaNhanVien] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PHAN_QUYEN]    Script Date: 03/01/2020 4:13:55 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PHAN_QUYEN](
	[MaPhanQuyen] [int] NOT NULL,
	[TenPhanQuyen] [nvarchar](15) NULL,
 CONSTRAINT [PK_PHAN_QUYEN] PRIMARY KEY CLUSTERED 
(
	[MaPhanQuyen] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PHONG]    Script Date: 03/01/2020 4:13:55 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PHONG](
	[MaPhong] [varchar](10) NOT NULL,
	[MaLoai] [varchar](5) NOT NULL,
	[TinhTrang] [bit] NULL,
 CONSTRAINT [PK_PHONG] PRIMARY KEY CLUSTERED 
(
	[MaPhong] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[THUE_DICH_VU]    Script Date: 03/01/2020 4:13:55 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[THUE_DICH_VU](
	[MaPhieu] [int] IDENTITY(1,1) NOT NULL,
	[MaDV] [varchar](5) NOT NULL,
	[SoLuong] [int] NOT NULL,
	[DonGia] [float] NOT NULL,
	[MaThuePhong] [int] NOT NULL,
 CONSTRAINT [PK_THUE_DICH_VU] PRIMARY KEY CLUSTERED 
(
	[MaPhieu] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[THUE_PHONG]    Script Date: 03/01/2020 4:13:55 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[THUE_PHONG](
	[MaThuePhong] [int] IDENTITY(1,1) NOT NULL,
	[TenKhachHang] [nvarchar](50) NOT NULL,
	[SoCCCD] [varchar](15) NOT NULL,
	[NgayGioThue] [datetime] NULL,
	[NgayGioTra] [datetime] NULL,
	[LoaiThue] [int] NOT NULL,
	[MaPhong] [varchar](10) NOT NULL,
 CONSTRAINT [PK_PHIEU_THUE_PHONG] PRIMARY KEY CLUSTERED 
(
	[MaThuePhong] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[DICH_VU] ([MaDV], [TenDV], [DonGia]) VALUES (N'DV01', N'Meal', 150000)
INSERT [dbo].[DICH_VU] ([MaDV], [TenDV], [DonGia]) VALUES (N'DV02', N'Bar Service', 100000)
INSERT [dbo].[DICH_VU] ([MaDV], [TenDV], [DonGia]) VALUES (N'DV03', N'Car Service', 250000)
INSERT [dbo].[DICH_VU] ([MaDV], [TenDV], [DonGia]) VALUES (N'DV04', N'Safebox', 350000)
INSERT [dbo].[DICH_VU] ([MaDV], [TenDV], [DonGia]) VALUES (N'DV05', N'Laundry Service', 1000000)
SET IDENTITY_INSERT [dbo].[HOA_DON] ON 

INSERT [dbo].[HOA_DON] ([MaHoaDon], [MaThuePhong], [TongTien]) VALUES (1, 5, CAST(5200000 AS Decimal(18, 0)))
INSERT [dbo].[HOA_DON] ([MaHoaDon], [MaThuePhong], [TongTien]) VALUES (3, 9, CAST(4300000 AS Decimal(18, 0)))
INSERT [dbo].[HOA_DON] ([MaHoaDon], [MaThuePhong], [TongTien]) VALUES (4, 10, CAST(56000000 AS Decimal(18, 0)))
INSERT [dbo].[HOA_DON] ([MaHoaDon], [MaThuePhong], [TongTien]) VALUES (6, 12, CAST(750000 AS Decimal(18, 0)))
INSERT [dbo].[HOA_DON] ([MaHoaDon], [MaThuePhong], [TongTien]) VALUES (7, 13, CAST(0 AS Decimal(18, 0)))
INSERT [dbo].[HOA_DON] ([MaHoaDon], [MaThuePhong], [TongTien]) VALUES (8, 15, CAST(0 AS Decimal(18, 0)))
INSERT [dbo].[HOA_DON] ([MaHoaDon], [MaThuePhong], [TongTien]) VALUES (9, 14, CAST(0 AS Decimal(18, 0)))
INSERT [dbo].[HOA_DON] ([MaHoaDon], [MaThuePhong], [TongTien]) VALUES (10, 11, CAST(0 AS Decimal(18, 0)))
INSERT [dbo].[HOA_DON] ([MaHoaDon], [MaThuePhong], [TongTien]) VALUES (11, 3, CAST(12500000 AS Decimal(18, 0)))
INSERT [dbo].[HOA_DON] ([MaHoaDon], [MaThuePhong], [TongTien]) VALUES (12, 7, CAST(24000000 AS Decimal(18, 0)))
INSERT [dbo].[HOA_DON] ([MaHoaDon], [MaThuePhong], [TongTien]) VALUES (13, 6, CAST(4300000 AS Decimal(18, 0)))
INSERT [dbo].[HOA_DON] ([MaHoaDon], [MaThuePhong], [TongTien]) VALUES (14, 8, CAST(5200000 AS Decimal(18, 0)))
INSERT [dbo].[HOA_DON] ([MaHoaDon], [MaThuePhong], [TongTien]) VALUES (15, 17, CAST(650000 AS Decimal(18, 0)))
INSERT [dbo].[HOA_DON] ([MaHoaDon], [MaThuePhong], [TongTien]) VALUES (16, 18, CAST(1000000 AS Decimal(18, 0)))
INSERT [dbo].[HOA_DON] ([MaHoaDon], [MaThuePhong], [TongTien]) VALUES (18, 21, CAST(2000000 AS Decimal(18, 0)))
INSERT [dbo].[HOA_DON] ([MaHoaDon], [MaThuePhong], [TongTien]) VALUES (19, 20, CAST(1000000 AS Decimal(18, 0)))
INSERT [dbo].[HOA_DON] ([MaHoaDon], [MaThuePhong], [TongTien]) VALUES (20, 22, CAST(9400000 AS Decimal(18, 0)))
INSERT [dbo].[HOA_DON] ([MaHoaDon], [MaThuePhong], [TongTien]) VALUES (21, 23, CAST(1150000 AS Decimal(18, 0)))
INSERT [dbo].[HOA_DON] ([MaHoaDon], [MaThuePhong], [TongTien]) VALUES (23, 25, CAST(1000000 AS Decimal(18, 0)))
INSERT [dbo].[HOA_DON] ([MaHoaDon], [MaThuePhong], [TongTien]) VALUES (24, 26, CAST(1350000 AS Decimal(18, 0)))
INSERT [dbo].[HOA_DON] ([MaHoaDon], [MaThuePhong], [TongTien]) VALUES (25, 27, CAST(220000 AS Decimal(18, 0)))
INSERT [dbo].[HOA_DON] ([MaHoaDon], [MaThuePhong], [TongTien]) VALUES (26, 28, CAST(2000000 AS Decimal(18, 0)))
INSERT [dbo].[HOA_DON] ([MaHoaDon], [MaThuePhong], [TongTien]) VALUES (27, 29, CAST(2000000 AS Decimal(18, 0)))
INSERT [dbo].[HOA_DON] ([MaHoaDon], [MaThuePhong], [TongTien]) VALUES (28, 30, CAST(2000000 AS Decimal(18, 0)))
INSERT [dbo].[HOA_DON] ([MaHoaDon], [MaThuePhong], [TongTien]) VALUES (29, 31, CAST(1000000 AS Decimal(18, 0)))
INSERT [dbo].[HOA_DON] ([MaHoaDon], [MaThuePhong], [TongTien]) VALUES (30, 32, CAST(1000000 AS Decimal(18, 0)))
INSERT [dbo].[HOA_DON] ([MaHoaDon], [MaThuePhong], [TongTien]) VALUES (31, 33, CAST(220000 AS Decimal(18, 0)))
INSERT [dbo].[HOA_DON] ([MaHoaDon], [MaThuePhong], [TongTien]) VALUES (32, 34, CAST(220000 AS Decimal(18, 0)))
INSERT [dbo].[HOA_DON] ([MaHoaDon], [MaThuePhong], [TongTien]) VALUES (33, 35, CAST(220000 AS Decimal(18, 0)))
INSERT [dbo].[HOA_DON] ([MaHoaDon], [MaThuePhong], [TongTien]) VALUES (34, 36, CAST(220000 AS Decimal(18, 0)))
INSERT [dbo].[HOA_DON] ([MaHoaDon], [MaThuePhong], [TongTien]) VALUES (37, 38, CAST(5500000 AS Decimal(18, 0)))
INSERT [dbo].[HOA_DON] ([MaHoaDon], [MaThuePhong], [TongTien]) VALUES (38, 40, CAST(4000000 AS Decimal(18, 0)))
INSERT [dbo].[HOA_DON] ([MaHoaDon], [MaThuePhong], [TongTien]) VALUES (39, 41, CAST(1000000 AS Decimal(18, 0)))
INSERT [dbo].[HOA_DON] ([MaHoaDon], [MaThuePhong], [TongTien]) VALUES (1019, 1021, CAST(1250000 AS Decimal(18, 0)))
INSERT [dbo].[HOA_DON] ([MaHoaDon], [MaThuePhong], [TongTien]) VALUES (1020, 1024, CAST(48250000 AS Decimal(18, 0)))
SET IDENTITY_INSERT [dbo].[HOA_DON] OFF
INSERT [dbo].[LOAI_PHONG] ([MaLoai], [TenLoai], [DonGiaNgay], [DonGiaGio]) VALUES (N'DLX', N'Deluxe', 2000000, 1000000)
INSERT [dbo].[LOAI_PHONG] ([MaLoai], [TenLoai], [DonGiaNgay], [DonGiaGio]) VALUES (N'STD', N'Standard', 440000, 220000)
INSERT [dbo].[LOAI_PHONG] ([MaLoai], [TenLoai], [DonGiaNgay], [DonGiaGio]) VALUES (N'SUP', N'Superior', 1000000, 500000)
INSERT [dbo].[LOAI_PHONG] ([MaLoai], [TenLoai], [DonGiaNgay], [DonGiaGio]) VALUES (N'SUT', N'Suite', 4000000, 2000000)
SET IDENTITY_INSERT [dbo].[NHAN_VIEN] ON 

INSERT [dbo].[NHAN_VIEN] ([MaNhanVien], [TenNhanVien], [SoDienThoai], [DiaChi], [TenDangNhap], [MatKhau], [MaPhanQuyen]) VALUES (6, N'Phạm Thế Giầu', N'0962130388', N'Hải Dương', N'admin', N'admin', 0)
INSERT [dbo].[NHAN_VIEN] ([MaNhanVien], [TenNhanVien], [SoDienThoai], [DiaChi], [TenDangNhap], [MatKhau], [MaPhanQuyen]) VALUES (7, N'Vũ Thanh Lâm', N'0965465865', N'Hải Phòng', N'lvchhv', N'1234', 0)
SET IDENTITY_INSERT [dbo].[NHAN_VIEN] OFF
INSERT [dbo].[PHAN_QUYEN] ([MaPhanQuyen], [TenPhanQuyen]) VALUES (0, N'admin')
INSERT [dbo].[PHAN_QUYEN] ([MaPhanQuyen], [TenPhanQuyen]) VALUES (1, N'employee')
INSERT [dbo].[PHAN_QUYEN] ([MaPhanQuyen], [TenPhanQuyen]) VALUES (2, N'guest')
INSERT [dbo].[PHONG] ([MaPhong], [MaLoai], [TinhTrang]) VALUES (N'DLX000', N'DLX', 1)
INSERT [dbo].[PHONG] ([MaPhong], [MaLoai], [TinhTrang]) VALUES (N'DLX002', N'DLX', 1)
INSERT [dbo].[PHONG] ([MaPhong], [MaLoai], [TinhTrang]) VALUES (N'DLX003', N'DLX', 1)
INSERT [dbo].[PHONG] ([MaPhong], [MaLoai], [TinhTrang]) VALUES (N'DLX004', N'DLX', 1)
INSERT [dbo].[PHONG] ([MaPhong], [MaLoai], [TinhTrang]) VALUES (N'DLX005', N'DLX', 1)
INSERT [dbo].[PHONG] ([MaPhong], [MaLoai], [TinhTrang]) VALUES (N'DLX006', N'DLX', 1)
INSERT [dbo].[PHONG] ([MaPhong], [MaLoai], [TinhTrang]) VALUES (N'DLX007', N'DLX', 1)
INSERT [dbo].[PHONG] ([MaPhong], [MaLoai], [TinhTrang]) VALUES (N'DLX008', N'DLX', 1)
INSERT [dbo].[PHONG] ([MaPhong], [MaLoai], [TinhTrang]) VALUES (N'DLX009', N'DLX', 1)
INSERT [dbo].[PHONG] ([MaPhong], [MaLoai], [TinhTrang]) VALUES (N'DLX010', N'DLX', 1)
INSERT [dbo].[PHONG] ([MaPhong], [MaLoai], [TinhTrang]) VALUES (N'STD001', N'STD', 1)
INSERT [dbo].[PHONG] ([MaPhong], [MaLoai], [TinhTrang]) VALUES (N'STD002', N'STD', 1)
INSERT [dbo].[PHONG] ([MaPhong], [MaLoai], [TinhTrang]) VALUES (N'STD003', N'STD', 1)
INSERT [dbo].[PHONG] ([MaPhong], [MaLoai], [TinhTrang]) VALUES (N'STD004', N'STD', 1)
INSERT [dbo].[PHONG] ([MaPhong], [MaLoai], [TinhTrang]) VALUES (N'STD005', N'STD', 1)
INSERT [dbo].[PHONG] ([MaPhong], [MaLoai], [TinhTrang]) VALUES (N'STD006', N'STD', 1)
INSERT [dbo].[PHONG] ([MaPhong], [MaLoai], [TinhTrang]) VALUES (N'STD007', N'STD', 1)
INSERT [dbo].[PHONG] ([MaPhong], [MaLoai], [TinhTrang]) VALUES (N'STD008', N'STD', 1)
INSERT [dbo].[PHONG] ([MaPhong], [MaLoai], [TinhTrang]) VALUES (N'STD009', N'STD', 1)
INSERT [dbo].[PHONG] ([MaPhong], [MaLoai], [TinhTrang]) VALUES (N'STD010', N'STD', 1)
INSERT [dbo].[PHONG] ([MaPhong], [MaLoai], [TinhTrang]) VALUES (N'STD011', N'STD', 1)
INSERT [dbo].[PHONG] ([MaPhong], [MaLoai], [TinhTrang]) VALUES (N'STD012', N'STD', 1)
INSERT [dbo].[PHONG] ([MaPhong], [MaLoai], [TinhTrang]) VALUES (N'SUP001', N'SUP', 1)
INSERT [dbo].[PHONG] ([MaPhong], [MaLoai], [TinhTrang]) VALUES (N'SUP002', N'SUP', 1)
INSERT [dbo].[PHONG] ([MaPhong], [MaLoai], [TinhTrang]) VALUES (N'SUP003', N'SUP', 1)
INSERT [dbo].[PHONG] ([MaPhong], [MaLoai], [TinhTrang]) VALUES (N'SUP004', N'SUP', 1)
INSERT [dbo].[PHONG] ([MaPhong], [MaLoai], [TinhTrang]) VALUES (N'SUP005', N'SUP', 1)
INSERT [dbo].[PHONG] ([MaPhong], [MaLoai], [TinhTrang]) VALUES (N'SUP006', N'SUP', 1)
INSERT [dbo].[PHONG] ([MaPhong], [MaLoai], [TinhTrang]) VALUES (N'SUP007', N'SUP', 1)
INSERT [dbo].[PHONG] ([MaPhong], [MaLoai], [TinhTrang]) VALUES (N'SUP008', N'SUP', 1)
INSERT [dbo].[PHONG] ([MaPhong], [MaLoai], [TinhTrang]) VALUES (N'SUP009', N'SUP', 1)
INSERT [dbo].[PHONG] ([MaPhong], [MaLoai], [TinhTrang]) VALUES (N'SUP010', N'SUP', 1)
INSERT [dbo].[PHONG] ([MaPhong], [MaLoai], [TinhTrang]) VALUES (N'SUT001', N'SUT', 1)
INSERT [dbo].[PHONG] ([MaPhong], [MaLoai], [TinhTrang]) VALUES (N'SUT002', N'SUT', 0)
INSERT [dbo].[PHONG] ([MaPhong], [MaLoai], [TinhTrang]) VALUES (N'SUT003', N'SUT', 1)
INSERT [dbo].[PHONG] ([MaPhong], [MaLoai], [TinhTrang]) VALUES (N'SUT004', N'SUT', 1)
INSERT [dbo].[PHONG] ([MaPhong], [MaLoai], [TinhTrang]) VALUES (N'SUT005', N'SUT', 1)
INSERT [dbo].[PHONG] ([MaPhong], [MaLoai], [TinhTrang]) VALUES (N'SUT006', N'SUT', 1)
INSERT [dbo].[PHONG] ([MaPhong], [MaLoai], [TinhTrang]) VALUES (N'SUT007', N'SUT', 1)
INSERT [dbo].[PHONG] ([MaPhong], [MaLoai], [TinhTrang]) VALUES (N'SUT008', N'SUT', 1)
INSERT [dbo].[PHONG] ([MaPhong], [MaLoai], [TinhTrang]) VALUES (N'SUT009', N'SUT', 1)
INSERT [dbo].[PHONG] ([MaPhong], [MaLoai], [TinhTrang]) VALUES (N'SUT010', N'SUT', 1)
INSERT [dbo].[PHONG] ([MaPhong], [MaLoai], [TinhTrang]) VALUES (N'SUT011', N'SUT', 1)
SET IDENTITY_INSERT [dbo].[THUE_DICH_VU] ON 

INSERT [dbo].[THUE_DICH_VU] ([MaPhieu], [MaDV], [SoLuong], [DonGia], [MaThuePhong]) VALUES (1, N'DV02', 4, 400000, 8)
INSERT [dbo].[THUE_DICH_VU] ([MaPhieu], [MaDV], [SoLuong], [DonGia], [MaThuePhong]) VALUES (2, N'DV01', 3, 450000, 8)
INSERT [dbo].[THUE_DICH_VU] ([MaPhieu], [MaDV], [SoLuong], [DonGia], [MaThuePhong]) VALUES (3, N'DV04', 1, 350000, 8)
INSERT [dbo].[THUE_DICH_VU] ([MaPhieu], [MaDV], [SoLuong], [DonGia], [MaThuePhong]) VALUES (4, N'DV03', 2, 500000, 3)
INSERT [dbo].[THUE_DICH_VU] ([MaPhieu], [MaDV], [SoLuong], [DonGia], [MaThuePhong]) VALUES (5, N'DV01', 2, 300000, 9)
INSERT [dbo].[THUE_DICH_VU] ([MaPhieu], [MaDV], [SoLuong], [DonGia], [MaThuePhong]) VALUES (6, N'DV01', 2, 300000, 6)
INSERT [dbo].[THUE_DICH_VU] ([MaPhieu], [MaDV], [SoLuong], [DonGia], [MaThuePhong]) VALUES (9, N'DV03', 3, 750000, 12)
INSERT [dbo].[THUE_DICH_VU] ([MaPhieu], [MaDV], [SoLuong], [DonGia], [MaThuePhong]) VALUES (10, N'DV01', 2, 300000, 17)
INSERT [dbo].[THUE_DICH_VU] ([MaPhieu], [MaDV], [SoLuong], [DonGia], [MaThuePhong]) VALUES (11, N'DV04', 1, 350000, 17)
INSERT [dbo].[THUE_DICH_VU] ([MaPhieu], [MaDV], [SoLuong], [DonGia], [MaThuePhong]) VALUES (14, N'DV01', 1, 150000, 23)
INSERT [dbo].[THUE_DICH_VU] ([MaPhieu], [MaDV], [SoLuong], [DonGia], [MaThuePhong]) VALUES (15, N'DV01', 0, 0, 22)
INSERT [dbo].[THUE_DICH_VU] ([MaPhieu], [MaDV], [SoLuong], [DonGia], [MaThuePhong]) VALUES (17, N'DV04', 1, 350000, 26)
INSERT [dbo].[THUE_DICH_VU] ([MaPhieu], [MaDV], [SoLuong], [DonGia], [MaThuePhong]) VALUES (19, N'DV02', 0, 0, 38)
INSERT [dbo].[THUE_DICH_VU] ([MaPhieu], [MaDV], [SoLuong], [DonGia], [MaThuePhong]) VALUES (1015, N'DV03', 1, 250000, 1021)
INSERT [dbo].[THUE_DICH_VU] ([MaPhieu], [MaDV], [SoLuong], [DonGia], [MaThuePhong]) VALUES (1016, N'DV01', 2, 300000, 1024)
INSERT [dbo].[THUE_DICH_VU] ([MaPhieu], [MaDV], [SoLuong], [DonGia], [MaThuePhong]) VALUES (1017, N'DV01', 1, 150000, 1024)
INSERT [dbo].[THUE_DICH_VU] ([MaPhieu], [MaDV], [SoLuong], [DonGia], [MaThuePhong]) VALUES (1018, N'DV02', 2, 200000, 1024)
INSERT [dbo].[THUE_DICH_VU] ([MaPhieu], [MaDV], [SoLuong], [DonGia], [MaThuePhong]) VALUES (1019, N'DV02', 7, 700000, 1024)
INSERT [dbo].[THUE_DICH_VU] ([MaPhieu], [MaDV], [SoLuong], [DonGia], [MaThuePhong]) VALUES (1021, N'DV05', 3, 1000000, 1026)
INSERT [dbo].[THUE_DICH_VU] ([MaPhieu], [MaDV], [SoLuong], [DonGia], [MaThuePhong]) VALUES (1024, N'DV03', 1, 250000, 1026)
SET IDENTITY_INSERT [dbo].[THUE_DICH_VU] OFF
SET IDENTITY_INSERT [dbo].[THUE_PHONG] ON 

INSERT [dbo].[THUE_PHONG] ([MaThuePhong], [TenKhachHang], [SoCCCD], [NgayGioThue], [NgayGioTra], [LoaiThue], [MaPhong]) VALUES (3, N'Vân Anh', N'030056998966', CAST(N'2019-12-28T00:00:00.000' AS DateTime), CAST(N'2019-12-31T19:20:00.000' AS DateTime), 1, N'SUT001')
INSERT [dbo].[THUE_PHONG] ([MaThuePhong], [TenKhachHang], [SoCCCD], [NgayGioThue], [NgayGioTra], [LoaiThue], [MaPhong]) VALUES (5, N'Nguyễn Hoàng Gia Mạnh', N'085696965699', CAST(N'2019-12-29T00:00:00.000' AS DateTime), CAST(N'2019-12-31T00:00:00.000' AS DateTime), 1, N'DLX003')
INSERT [dbo].[THUE_PHONG] ([MaThuePhong], [TenKhachHang], [SoCCCD], [NgayGioThue], [NgayGioTra], [LoaiThue], [MaPhong]) VALUES (6, N'Trung Quân', N'056989698999', CAST(N'2019-12-29T00:00:00.000' AS DateTime), CAST(N'2019-12-31T19:21:00.000' AS DateTime), 1, N'DLX004')
INSERT [dbo].[THUE_PHONG] ([MaThuePhong], [TenKhachHang], [SoCCCD], [NgayGioThue], [NgayGioTra], [LoaiThue], [MaPhong]) VALUES (7, N'Giau', N'056936889655', CAST(N'2019-12-25T00:00:00.000' AS DateTime), CAST(N'2019-12-31T19:20:00.000' AS DateTime), 1, N'SUT001')
INSERT [dbo].[THUE_PHONG] ([MaThuePhong], [TenKhachHang], [SoCCCD], [NgayGioThue], [NgayGioTra], [LoaiThue], [MaPhong]) VALUES (8, N'Phạm Thanh Hùng', N'030065965689', CAST(N'2019-12-29T00:00:00.000' AS DateTime), CAST(N'2019-12-31T19:24:00.000' AS DateTime), 1, N'DLX005')
INSERT [dbo].[THUE_PHONG] ([MaThuePhong], [TenKhachHang], [SoCCCD], [NgayGioThue], [NgayGioTra], [LoaiThue], [MaPhong]) VALUES (9, N'Đinh Văn Đông', N'020005689689', CAST(N'2019-12-29T00:00:00.000' AS DateTime), CAST(N'2019-12-31T18:59:00.000' AS DateTime), 1, N'DLX010')
INSERT [dbo].[THUE_PHONG] ([MaThuePhong], [TenKhachHang], [SoCCCD], [NgayGioThue], [NgayGioTra], [LoaiThue], [MaPhong]) VALUES (10, N'Đinh Văn Toàn', N'020005682222', CAST(N'2019-12-03T00:00:00.000' AS DateTime), CAST(N'2019-12-31T19:04:00.000' AS DateTime), 1, N'DLX010')
INSERT [dbo].[THUE_PHONG] ([MaThuePhong], [TenKhachHang], [SoCCCD], [NgayGioThue], [NgayGioTra], [LoaiThue], [MaPhong]) VALUES (11, N'Đồng Quang Linh', N'030056965696', CAST(N'2019-12-31T00:00:00.000' AS DateTime), CAST(N'2019-12-31T19:19:00.000' AS DateTime), 1, N'DLX003')
INSERT [dbo].[THUE_PHONG] ([MaThuePhong], [TenKhachHang], [SoCCCD], [NgayGioThue], [NgayGioTra], [LoaiThue], [MaPhong]) VALUES (12, N'Lê Sỹ Đức Mạnh', N'036655558969', CAST(N'2019-12-31T00:00:00.000' AS DateTime), CAST(N'2019-12-31T19:13:00.000' AS DateTime), 1, N'DLX002')
INSERT [dbo].[THUE_PHONG] ([MaThuePhong], [TenKhachHang], [SoCCCD], [NgayGioThue], [NgayGioTra], [LoaiThue], [MaPhong]) VALUES (13, N'Vũ Thanh Lâm', N'036656896999', CAST(N'2019-12-31T00:00:00.000' AS DateTime), CAST(N'2019-12-31T19:14:00.000' AS DateTime), 1, N'STD005')
INSERT [dbo].[THUE_PHONG] ([MaThuePhong], [TenKhachHang], [SoCCCD], [NgayGioThue], [NgayGioTra], [LoaiThue], [MaPhong]) VALUES (14, N'Văn Mai Hương', N'069936995699', CAST(N'2019-12-31T00:00:00.000' AS DateTime), CAST(N'2019-12-31T19:17:00.000' AS DateTime), 1, N'STD004')
INSERT [dbo].[THUE_PHONG] ([MaThuePhong], [TenKhachHang], [SoCCCD], [NgayGioThue], [NgayGioTra], [LoaiThue], [MaPhong]) VALUES (15, N'Vũ Trọng Phụng', N'030026558966', CAST(N'2019-12-31T00:00:00.000' AS DateTime), CAST(N'2019-12-31T19:15:00.000' AS DateTime), 1, N'DLX007')
INSERT [dbo].[THUE_PHONG] ([MaThuePhong], [TenKhachHang], [SoCCCD], [NgayGioThue], [NgayGioTra], [LoaiThue], [MaPhong]) VALUES (17, N'Phạm Thế Giầu', N'020099001566', CAST(N'2019-12-31T19:40:00.000' AS DateTime), CAST(N'2019-12-31T19:41:00.000' AS DateTime), 1, N'DLX003')
INSERT [dbo].[THUE_PHONG] ([MaThuePhong], [TenKhachHang], [SoCCCD], [NgayGioThue], [NgayGioTra], [LoaiThue], [MaPhong]) VALUES (18, N'Vũ Thanh Lâm', N'065596668699', CAST(N'2019-12-31T19:45:00.000' AS DateTime), CAST(N'2019-12-31T19:48:00.000' AS DateTime), 0, N'DLX010')
INSERT [dbo].[THUE_PHONG] ([MaThuePhong], [TenKhachHang], [SoCCCD], [NgayGioThue], [NgayGioTra], [LoaiThue], [MaPhong]) VALUES (20, N'Natasha', N'0222256996999', CAST(N'2020-01-01T06:52:00.000' AS DateTime), CAST(N'2020-01-01T08:31:00.000' AS DateTime), 1, N'SUP010')
INSERT [dbo].[THUE_PHONG] ([MaThuePhong], [TenKhachHang], [SoCCCD], [NgayGioThue], [NgayGioTra], [LoaiThue], [MaPhong]) VALUES (21, N'Bé Na', N'030025665699', CAST(N'2020-01-01T07:37:00.000' AS DateTime), CAST(N'2020-01-01T08:29:00.000' AS DateTime), 1, N'DLX008')
INSERT [dbo].[THUE_PHONG] ([MaThuePhong], [TenKhachHang], [SoCCCD], [NgayGioThue], [NgayGioTra], [LoaiThue], [MaPhong]) VALUES (22, N'Hà Lan', N'025636896969', CAST(N'2020-01-01T00:00:00.000' AS DateTime), CAST(N'2020-01-01T08:35:00.000' AS DateTime), 0, N'DLX003')
INSERT [dbo].[THUE_PHONG] ([MaThuePhong], [TenKhachHang], [SoCCCD], [NgayGioThue], [NgayGioTra], [LoaiThue], [MaPhong]) VALUES (23, N'Cô Hồng', N'056878966969', CAST(N'2020-01-01T07:42:00.000' AS DateTime), CAST(N'2020-01-01T08:36:00.000' AS DateTime), 0, N'DLX004')
INSERT [dbo].[THUE_PHONG] ([MaThuePhong], [TenKhachHang], [SoCCCD], [NgayGioThue], [NgayGioTra], [LoaiThue], [MaPhong]) VALUES (25, N'La Lin', N'085636996366', CAST(N'2020-01-01T08:40:00.000' AS DateTime), CAST(N'2020-01-01T08:42:00.000' AS DateTime), 0, N'DLX009')
INSERT [dbo].[THUE_PHONG] ([MaThuePhong], [TenKhachHang], [SoCCCD], [NgayGioThue], [NgayGioTra], [LoaiThue], [MaPhong]) VALUES (26, N'Ngạn', N'000000000000', CAST(N'2020-01-01T08:44:00.000' AS DateTime), CAST(N'2020-01-01T08:45:00.000' AS DateTime), 0, N'DLX002')
INSERT [dbo].[THUE_PHONG] ([MaThuePhong], [TenKhachHang], [SoCCCD], [NgayGioThue], [NgayGioTra], [LoaiThue], [MaPhong]) VALUES (27, N'Bỉ', N'111111111111', CAST(N'2020-01-01T08:46:00.000' AS DateTime), CAST(N'2020-01-01T08:46:00.000' AS DateTime), 0, N'STD001')
INSERT [dbo].[THUE_PHONG] ([MaThuePhong], [TenKhachHang], [SoCCCD], [NgayGioThue], [NgayGioTra], [LoaiThue], [MaPhong]) VALUES (28, N'Hoa', N'222222222222', CAST(N'2020-01-01T08:47:00.000' AS DateTime), CAST(N'2020-01-01T08:48:00.000' AS DateTime), 0, N'SUT007')
INSERT [dbo].[THUE_PHONG] ([MaThuePhong], [TenKhachHang], [SoCCCD], [NgayGioThue], [NgayGioTra], [LoaiThue], [MaPhong]) VALUES (29, N'Tada', N'33333333333', CAST(N'2020-01-01T08:49:00.000' AS DateTime), CAST(N'2020-01-01T08:49:00.000' AS DateTime), 0, N'SUT011')
INSERT [dbo].[THUE_PHONG] ([MaThuePhong], [TenKhachHang], [SoCCCD], [NgayGioThue], [NgayGioTra], [LoaiThue], [MaPhong]) VALUES (30, N'Duck', N'363636363636', CAST(N'2020-01-01T08:52:00.000' AS DateTime), CAST(N'2020-01-01T08:53:00.000' AS DateTime), 0, N'SUT008')
INSERT [dbo].[THUE_PHONG] ([MaThuePhong], [TenKhachHang], [SoCCCD], [NgayGioThue], [NgayGioTra], [LoaiThue], [MaPhong]) VALUES (31, N'Phạm Minh Hoàng', N'0899636639999', CAST(N'2020-01-01T09:03:00.000' AS DateTime), CAST(N'2020-01-01T09:03:00.000' AS DateTime), 0, N'DLX006')
INSERT [dbo].[THUE_PHONG] ([MaThuePhong], [TenKhachHang], [SoCCCD], [NgayGioThue], [NgayGioTra], [LoaiThue], [MaPhong]) VALUES (32, N'Ket', N'056696669899', CAST(N'2020-01-01T09:04:00.000' AS DateTime), CAST(N'2020-01-01T09:05:00.000' AS DateTime), 0, N'DLX009')
INSERT [dbo].[THUE_PHONG] ([MaThuePhong], [TenKhachHang], [SoCCCD], [NgayGioThue], [NgayGioTra], [LoaiThue], [MaPhong]) VALUES (33, N'Mão', N'063366665555', CAST(N'2020-01-01T09:12:00.000' AS DateTime), CAST(N'2020-01-01T09:12:00.000' AS DateTime), 0, N'STD005')
INSERT [dbo].[THUE_PHONG] ([MaThuePhong], [TenKhachHang], [SoCCCD], [NgayGioThue], [NgayGioTra], [LoaiThue], [MaPhong]) VALUES (34, N'Hoa Cải', N'086699995555', CAST(N'2020-01-01T09:18:00.000' AS DateTime), CAST(N'2020-01-01T09:18:00.000' AS DateTime), 0, N'STD001')
INSERT [dbo].[THUE_PHONG] ([MaThuePhong], [TenKhachHang], [SoCCCD], [NgayGioThue], [NgayGioTra], [LoaiThue], [MaPhong]) VALUES (35, N'Hoa Cứt Lợn', N'011155552222', CAST(N'2020-01-01T09:22:00.000' AS DateTime), CAST(N'2020-01-01T09:22:00.000' AS DateTime), 0, N'STD002')
INSERT [dbo].[THUE_PHONG] ([MaThuePhong], [TenKhachHang], [SoCCCD], [NgayGioThue], [NgayGioTra], [LoaiThue], [MaPhong]) VALUES (36, N'Alo', N'55666', CAST(N'2020-01-01T09:23:00.000' AS DateTime), CAST(N'2020-01-01T09:23:00.000' AS DateTime), 0, N'STD006')
INSERT [dbo].[THUE_PHONG] ([MaThuePhong], [TenKhachHang], [SoCCCD], [NgayGioThue], [NgayGioTra], [LoaiThue], [MaPhong]) VALUES (38, N'Tadaaaa', N'036633666699', CAST(N'2020-01-01T11:02:00.000' AS DateTime), CAST(N'2020-01-01T17:11:00.000' AS DateTime), 0, N'DLX003')
INSERT [dbo].[THUE_PHONG] ([MaThuePhong], [TenKhachHang], [SoCCCD], [NgayGioThue], [NgayGioTra], [LoaiThue], [MaPhong]) VALUES (40, N'Jpeace', N'056636669999', CAST(N'2020-01-01T19:11:00.000' AS DateTime), CAST(N'2020-01-01T19:12:00.000' AS DateTime), 1, N'SUT006')
INSERT [dbo].[THUE_PHONG] ([MaThuePhong], [TenKhachHang], [SoCCCD], [NgayGioThue], [NgayGioTra], [LoaiThue], [MaPhong]) VALUES (41, N'Bé Xoài', N'0556335', CAST(N'2020-01-01T19:36:00.000' AS DateTime), CAST(N'2020-01-01T19:37:00.000' AS DateTime), 0, N'DLX008')
INSERT [dbo].[THUE_PHONG] ([MaThuePhong], [TenKhachHang], [SoCCCD], [NgayGioThue], [NgayGioTra], [LoaiThue], [MaPhong]) VALUES (1021, N'Ngô Thanh Vân', N'036696669999', CAST(N'2020-01-02T10:12:00.000' AS DateTime), CAST(N'2020-01-02T10:13:00.000' AS DateTime), 0, N'DLX009')
INSERT [dbo].[THUE_PHONG] ([MaThuePhong], [TenKhachHang], [SoCCCD], [NgayGioThue], [NgayGioTra], [LoaiThue], [MaPhong]) VALUES (1024, N'idsckckncdnk', N'025453535553', CAST(N'2020-01-02T00:00:00.000' AS DateTime), CAST(N'2020-01-02T18:04:00.000' AS DateTime), 0, N'DLX002')
INSERT [dbo].[THUE_PHONG] ([MaThuePhong], [TenKhachHang], [SoCCCD], [NgayGioThue], [NgayGioTra], [LoaiThue], [MaPhong]) VALUES (1026, N'Nguyễn Minh Huyền', N'032233332222', CAST(N'2020-01-03T00:00:00.000' AS DateTime), CAST(N'2020-01-03T08:16:00.000' AS DateTime), 1, N'SUT002')
SET IDENTITY_INSERT [dbo].[THUE_PHONG] OFF
ALTER TABLE [dbo].[HOA_DON]  WITH CHECK ADD  CONSTRAINT [FK_HOA_DON_THUE_PHONG] FOREIGN KEY([MaThuePhong])
REFERENCES [dbo].[THUE_PHONG] ([MaThuePhong])
GO
ALTER TABLE [dbo].[HOA_DON] CHECK CONSTRAINT [FK_HOA_DON_THUE_PHONG]
GO
ALTER TABLE [dbo].[NHAN_VIEN]  WITH CHECK ADD  CONSTRAINT [FK_NHAN_VIEN_PHAN_QUYEN] FOREIGN KEY([MaPhanQuyen])
REFERENCES [dbo].[PHAN_QUYEN] ([MaPhanQuyen])
GO
ALTER TABLE [dbo].[NHAN_VIEN] CHECK CONSTRAINT [FK_NHAN_VIEN_PHAN_QUYEN]
GO
ALTER TABLE [dbo].[PHONG]  WITH CHECK ADD  CONSTRAINT [FK_PHONG_LOAI_PHONG] FOREIGN KEY([MaLoai])
REFERENCES [dbo].[LOAI_PHONG] ([MaLoai])
GO
ALTER TABLE [dbo].[PHONG] CHECK CONSTRAINT [FK_PHONG_LOAI_PHONG]
GO
ALTER TABLE [dbo].[THUE_DICH_VU]  WITH CHECK ADD  CONSTRAINT [FK_THUE_DICH_VU_DICH_VU] FOREIGN KEY([MaDV])
REFERENCES [dbo].[DICH_VU] ([MaDV])
GO
ALTER TABLE [dbo].[THUE_DICH_VU] CHECK CONSTRAINT [FK_THUE_DICH_VU_DICH_VU]
GO
ALTER TABLE [dbo].[THUE_DICH_VU]  WITH CHECK ADD  CONSTRAINT [FK_THUE_DICH_VU_THUE_PHONG] FOREIGN KEY([MaThuePhong])
REFERENCES [dbo].[THUE_PHONG] ([MaThuePhong])
GO
ALTER TABLE [dbo].[THUE_DICH_VU] CHECK CONSTRAINT [FK_THUE_DICH_VU_THUE_PHONG]
GO
ALTER TABLE [dbo].[THUE_PHONG]  WITH CHECK ADD  CONSTRAINT [FK_THUE_PHONG_PHONG] FOREIGN KEY([MaPhong])
REFERENCES [dbo].[PHONG] ([MaPhong])
GO
ALTER TABLE [dbo].[THUE_PHONG] CHECK CONSTRAINT [FK_THUE_PHONG_PHONG]
GO
