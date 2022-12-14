USE [QLKhachSan]
GO
/****** Object:  Table [dbo].[CachThue]    Script Date: 2022-12-01 19:42:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CachThue](
	[CachThue] [varchar](50) NOT NULL,
	[TenCachThue] [nvarchar](50) NULL,
 CONSTRAINT [PK_CachThue] PRIMARY KEY CLUSTERED 
(
	[CachThue] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[CachTinhTien]    Script Date: 2022-12-01 19:42:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CachTinhTien](
	[MaCachTinhTien] [varchar](50) NOT NULL,
	[TenCachTinhTien] [nvarchar](50) NULL,
	[GiaThueCuoiTuanVaNgayLe] [varchar](50) NULL,
	[PhuThuQuaGio] [varchar](50) NULL,
	[SoPhutLamTronThanh1Gio] [int] NULL,
 CONSTRAINT [PK_CachTinhTien] PRIMARY KEY CLUSTERED 
(
	[MaCachTinhTien] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[CachTinhTien_CachThue]    Script Date: 2022-12-01 19:42:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CachTinhTien_CachThue](
	[MaCachTinhTien] [varchar](50) NOT NULL,
	[MaCachThue] [varchar](50) NOT NULL,
	[GiaTheoCachThue] [varchar](50) NULL,
	[GioNhanPhong] [time](7) NULL,
	[GioTraPhong] [time](7) NULL,
 CONSTRAINT [PK_CachTinhTien_CachThue] PRIMARY KEY CLUSTERED 
(
	[MaCachTinhTien] ASC,
	[MaCachThue] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ChucNang]    Script Date: 2022-12-01 19:42:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ChucNang](
	[MaChucNang] [varchar](50) NOT NULL,
	[TenChucNang] [nvarchar](50) NULL,
 CONSTRAINT [PK_ChucNang] PRIMARY KEY CLUSTERED 
(
	[MaChucNang] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[CTChucNang]    Script Date: 2022-12-01 19:42:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CTChucNang](
	[MaCTCN] [varchar](50) NOT NULL,
	[TenCTCN] [nvarchar](50) NULL,
	[MaChucNang] [varchar](50) NULL,
 CONSTRAINT [PK_CTChucNang] PRIMARY KEY CLUSTERED 
(
	[MaCTCN] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[CTPhieuDatPhong_LoaiPhong]    Script Date: 2022-12-01 19:42:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CTPhieuDatPhong_LoaiPhong](
	[MaPhieuDatPhong] [varchar](50) NOT NULL,
	[MaCTPhieuDatPhong_LoaiPhong] [varchar](50) NOT NULL,
	[MaLoaiPhong] [varchar](50) NULL,
	[SLPhong] [int] NULL,
 CONSTRAINT [PK_CTPhieuDatPhong] PRIMARY KEY CLUSTERED 
(
	[MaPhieuDatPhong] ASC,
	[MaCTPhieuDatPhong_LoaiPhong] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[CTPhieuDatPhong_Phong]    Script Date: 2022-12-01 19:42:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CTPhieuDatPhong_Phong](
	[MaCTPhieuDatPhong_Phong] [varchar](50) NOT NULL,
	[MaPhieuDatPhong] [varchar](50) NOT NULL,
	[MaPhong] [varchar](50) NOT NULL,
 CONSTRAINT [PK_CTPhieuDatPhong_Phong] PRIMARY KEY CLUSTERED 
(
	[MaCTPhieuDatPhong_Phong] ASC,
	[MaPhieuDatPhong] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[CTPNKho]    Script Date: 2022-12-01 19:42:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CTPNKho](
	[MaPNKho] [varchar](50) NOT NULL,
	[MaMenu] [varchar](50) NOT NULL,
	[SL] [int] NULL,
 CONSTRAINT [PK_CTPNKho_1] PRIMARY KEY CLUSTERED 
(
	[MaPNKho] ASC,
	[MaMenu] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[DieuChinhKho]    Script Date: 2022-12-01 19:42:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DieuChinhKho](
	[MaDieuChinhKho] [varchar](50) NOT NULL,
	[ThoiGianDieuChinh] [smalldatetime] NULL,
	[TongSLDieuChinh] [int] NULL,
 CONSTRAINT [PK_DieuChinhKho] PRIMARY KEY CLUSTERED 
(
	[MaDieuChinhKho] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[DieuChinhKho_Menu]    Script Date: 2022-12-01 19:42:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DieuChinhKho_Menu](
	[MaDieuChinhKho] [varchar](50) NOT NULL,
	[MaMenu] [varchar](50) NOT NULL,
	[SLThucTe] [int] NULL,
	[SLDieuChinh] [int] NULL,
 CONSTRAINT [PK_DieuChinhKho_Menu] PRIMARY KEY CLUSTERED 
(
	[MaDieuChinhKho] ASC,
	[MaMenu] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[HoaDon]    Script Date: 2022-12-01 19:42:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[HoaDon](
	[MaHoaDon] [varchar](50) NOT NULL,
	[MaPhong] [varchar](50) NULL,
	[ThoiGianBatDau] [smalldatetime] NULL,
	[ThoiGianKetThuc] [smalldatetime] NULL,
	[MaCachThue] [varchar](50) NULL,
	[TienPhong] [varchar](50) NULL,
	[PhuThu] [varchar](50) NULL,
	[TraTruoc] [varchar](50) NULL,
	[ThuGiamTruKhac] [varchar](50) NULL,
	[TienMenu] [varchar](50) NULL,
	[GhiChu] [nvarchar](50) NULL,
	[TaiKhoanNhanPhong] [varchar](50) NULL,
	[TaiKhoanTraPhong] [varchar](50) NULL,
 CONSTRAINT [PK_HoaDon] PRIMARY KEY CLUSTERED 
(
	[MaHoaDon] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[HoaDon_Menu]    Script Date: 2022-12-01 19:42:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[HoaDon_Menu](
	[MaMenu] [varchar](50) NOT NULL,
	[MaHoaDon] [varchar](50) NOT NULL,
	[SL] [int] NULL,
 CONSTRAINT [PK_HoaDon_Menu] PRIMARY KEY CLUSTERED 
(
	[MaMenu] ASC,
	[MaHoaDon] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[LoaiPhong]    Script Date: 2022-12-01 19:42:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LoaiPhong](
	[MaLoaiPhong] [varchar](50) NOT NULL,
	[TenLoaiPhong] [nvarchar](50) NULL,
	[UuTienHienThi] [int] NULL,
 CONSTRAINT [PK_LoaiPhong] PRIMARY KEY CLUSTERED 
(
	[MaLoaiPhong] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Menu]    Script Date: 2022-12-01 19:42:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Menu](
	[MaMenu] [varchar](50) NOT NULL,
	[TenMenu] [nvarchar](50) NULL,
	[LoaiMenu] [nvarchar](50) NULL,
	[GiaNhap] [varchar](50) NULL,
	[GiaBan] [varchar](50) NULL,
	[UuTienHienThi] [int] NULL,
 CONSTRAINT [PK_Menu] PRIMARY KEY CLUSTERED 
(
	[MaMenu] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PhieuDatPhong]    Script Date: 2022-12-01 19:42:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PhieuDatPhong](
	[MaPhieuDatPhong] [varchar](50) NOT NULL,
	[HoTenKhachHang] [nvarchar](50) NULL,
	[SoDienThoai] [varchar](50) NULL,
	[NgayNhanPhong] [date] NULL,
	[NgayTraPhong] [date] NULL,
	[TienTraTruoc] [varchar](50) NULL,
	[GhiChu] [nvarchar](50) NULL,
	[TrangThai] [nvarchar](50) NULL,
 CONSTRAINT [PK_PhieuDatPhong] PRIMARY KEY CLUSTERED 
(
	[MaPhieuDatPhong] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PhieuThuChi]    Script Date: 2022-12-01 19:42:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PhieuThuChi](
	[MaPhieuThuChi] [varchar](50) NOT NULL,
	[ThoiGian] [smalldatetime] NULL,
	[LoaiHinh] [nvarchar](50) NULL,
	[SoTien] [varchar](50) NULL,
	[NoiDung] [nvarchar](50) NULL,
 CONSTRAINT [PK_PhieuThuChi] PRIMARY KEY CLUSTERED 
(
	[MaPhieuThuChi] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Phong]    Script Date: 2022-12-01 19:42:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Phong](
	[MaPhong] [varchar](50) NOT NULL,
	[MaLoaiPhong] [varchar](50) NULL,
	[TinhTrang] [nvarchar](50) NULL,
	[SoKhachToiDa] [int] NULL,
	[MaCachTinhTien] [varchar](50) NULL,
	[UuTienHienThi] [int] NULL,
 CONSTRAINT [PK_Phong] PRIMARY KEY CLUSTERED 
(
	[MaPhong] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PNKho]    Script Date: 2022-12-01 19:42:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PNKho](
	[MaPNKho] [varchar](50) NOT NULL,
	[ThoiGianNhap] [smalldatetime] NULL,
	[GhiChu] [nvarchar](50) NULL,
 CONSTRAINT [PK_PNKho] PRIMARY KEY CLUSTERED 
(
	[MaPNKho] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Quyen]    Script Date: 2022-12-01 19:42:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Quyen](
	[MaQuyen] [varchar](50) NOT NULL,
	[TenQuyen] [nvarchar](50) NULL,
 CONSTRAINT [PK_Quyen] PRIMARY KEY CLUSTERED 
(
	[MaQuyen] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Quyen_ChucNang]    Script Date: 2022-12-01 19:42:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Quyen_ChucNang](
	[MaQuyen] [varchar](50) NOT NULL,
	[MaChucNang] [varchar](50) NOT NULL,
 CONSTRAINT [PK_Quyen_ChucNang] PRIMARY KEY CLUSTERED 
(
	[MaQuyen] ASC,
	[MaChucNang] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TaiKhoan]    Script Date: 2022-12-01 19:42:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TaiKhoan](
	[MaTaiKhoan] [varchar](50) NOT NULL,
	[TenTaiKhoan] [varchar](50) NULL,
	[MatKhau] [varchar](50) NULL,
	[MaQuyen] [varchar](50) NULL,
 CONSTRAINT [PK_TaiKhoan] PRIMARY KEY CLUSTERED 
(
	[MaTaiKhoan] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ThietLapKhac]    Script Date: 2022-12-01 19:42:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ThietLapKhac](
	[TenKhachSan] [nvarchar](50) NOT NULL,
	[DiaChi] [nvarchar](50) NULL,
	[SDT] [varchar](50) NULL,
	[ThoiGian] [smalldatetime] NULL,
	[Logo] [varchar](50) NULL,
	[Panel] [varchar](50) NULL,
 CONSTRAINT [PK_ThietLapKhac] PRIMARY KEY CLUSTERED 
(
	[TenKhachSan] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[CachThue] ([CachThue], [TenCachThue]) VALUES (N'CT001', N'Thuê theo giờ')
INSERT [dbo].[CachThue] ([CachThue], [TenCachThue]) VALUES (N'CT002', N'Thuê theo ngày')
GO
INSERT [dbo].[CachTinhTien] ([MaCachTinhTien], [TenCachTinhTien], [GiaThueCuoiTuanVaNgayLe], [PhuThuQuaGio], [SoPhutLamTronThanh1Gio]) VALUES (N'CTT001', N'Cách tính 1', N'300,000-300,000-300,000-400,000', N'30,000', 30)
INSERT [dbo].[CachTinhTien] ([MaCachTinhTien], [TenCachTinhTien], [GiaThueCuoiTuanVaNgayLe], [PhuThuQuaGio], [SoPhutLamTronThanh1Gio]) VALUES (N'CTT002', N'Cách tính 2', N'400,000-400,000-400,000-500,000', N'35,000', 30)
INSERT [dbo].[CachTinhTien] ([MaCachTinhTien], [TenCachTinhTien], [GiaThueCuoiTuanVaNgayLe], [PhuThuQuaGio], [SoPhutLamTronThanh1Gio]) VALUES (N'CTT003', N'a', N'100,000-100,000-100,000-100,000', N'30,000', 30)
GO
INSERT [dbo].[CachTinhTien_CachThue] ([MaCachTinhTien], [MaCachThue], [GiaTheoCachThue], [GioNhanPhong], [GioTraPhong]) VALUES (N'CTT001', N'CT001', N'25,000', CAST(N'07:00:00' AS Time), CAST(N'17:00:00' AS Time))
INSERT [dbo].[CachTinhTien_CachThue] ([MaCachTinhTien], [MaCachThue], [GiaTheoCachThue], [GioNhanPhong], [GioTraPhong]) VALUES (N'CTT001', N'CT002', N'250,000', CAST(N'07:00:00' AS Time), CAST(N'17:00:00' AS Time))
INSERT [dbo].[CachTinhTien_CachThue] ([MaCachTinhTien], [MaCachThue], [GiaTheoCachThue], [GioNhanPhong], [GioTraPhong]) VALUES (N'CTT003', N'CT001', N'10,000', CAST(N'07:00:00' AS Time), CAST(N'17:00:00' AS Time))
INSERT [dbo].[CachTinhTien_CachThue] ([MaCachTinhTien], [MaCachThue], [GiaTheoCachThue], [GioNhanPhong], [GioTraPhong]) VALUES (N'CTT003', N'CT002', N'100,000', CAST(N'07:00:00' AS Time), CAST(N'17:00:00' AS Time))
GO
INSERT [dbo].[ChucNang] ([MaChucNang], [TenChucNang]) VALUES (N'CN001', N'Đặt phòng')
INSERT [dbo].[ChucNang] ([MaChucNang], [TenChucNang]) VALUES (N'CN002', N'Thuê - Trả phòng')
INSERT [dbo].[ChucNang] ([MaChucNang], [TenChucNang]) VALUES (N'CN003', N'Quản lý kho')
INSERT [dbo].[ChucNang] ([MaChucNang], [TenChucNang]) VALUES (N'CN004', N'Quản lý thu chi')
INSERT [dbo].[ChucNang] ([MaChucNang], [TenChucNang]) VALUES (N'CN005', N'Quản lý hệ thống')
INSERT [dbo].[ChucNang] ([MaChucNang], [TenChucNang]) VALUES (N'CN006', N'Tài khoản')
GO
INSERT [dbo].[CTChucNang] ([MaCTCN], [TenCTCN], [MaChucNang]) VALUES (N'CTCN001', N'Cách Tính Tiền', N'CN005')
INSERT [dbo].[CTChucNang] ([MaCTCN], [TenCTCN], [MaChucNang]) VALUES (N'CTCN002', N'Loại phòng', N'CN005')
INSERT [dbo].[CTChucNang] ([MaCTCN], [TenCTCN], [MaChucNang]) VALUES (N'CTCN003', N'Phòng', N'CN005')
INSERT [dbo].[CTChucNang] ([MaCTCN], [TenCTCN], [MaChucNang]) VALUES (N'CTCN004', N'Menu', N'CN005')
INSERT [dbo].[CTChucNang] ([MaCTCN], [TenCTCN], [MaChucNang]) VALUES (N'CTCN005', N'Thống kê', N'CN005')
INSERT [dbo].[CTChucNang] ([MaCTCN], [TenCTCN], [MaChucNang]) VALUES (N'CTCN006', N'Lịch sử', N'CN005')
INSERT [dbo].[CTChucNang] ([MaCTCN], [TenCTCN], [MaChucNang]) VALUES (N'CTCN007', N'Thiết lập khác', N'CN006')
GO
INSERT [dbo].[CTPhieuDatPhong_LoaiPhong] ([MaPhieuDatPhong], [MaCTPhieuDatPhong_LoaiPhong], [MaLoaiPhong], [SLPhong]) VALUES (N'PDP001', N'CTPD001', N'LP001', 1)
INSERT [dbo].[CTPhieuDatPhong_LoaiPhong] ([MaPhieuDatPhong], [MaCTPhieuDatPhong_LoaiPhong], [MaLoaiPhong], [SLPhong]) VALUES (N'PDP001', N'CTPD004', N'LP002', 0)
INSERT [dbo].[CTPhieuDatPhong_LoaiPhong] ([MaPhieuDatPhong], [MaCTPhieuDatPhong_LoaiPhong], [MaLoaiPhong], [SLPhong]) VALUES (N'PDP002', N'CTPD002', N'LP001', 1)
INSERT [dbo].[CTPhieuDatPhong_LoaiPhong] ([MaPhieuDatPhong], [MaCTPhieuDatPhong_LoaiPhong], [MaLoaiPhong], [SLPhong]) VALUES (N'PDP002', N'CTPD003', N'LP002', 2)
GO
INSERT [dbo].[CTPhieuDatPhong_Phong] ([MaCTPhieuDatPhong_Phong], [MaPhieuDatPhong], [MaPhong]) VALUES (N'CTPDPP002', N'PDP002', N'P002')
INSERT [dbo].[CTPhieuDatPhong_Phong] ([MaCTPhieuDatPhong_Phong], [MaPhieuDatPhong], [MaPhong]) VALUES (N'CTPDPP003', N'PDP002', N'P001')
INSERT [dbo].[CTPhieuDatPhong_Phong] ([MaCTPhieuDatPhong_Phong], [MaPhieuDatPhong], [MaPhong]) VALUES (N'CTPDPP006', N'PDP001', N'P001')
GO
INSERT [dbo].[CTPNKho] ([MaPNKho], [MaMenu], [SL]) VALUES (N'PNK001', N'MN001', 20)
INSERT [dbo].[CTPNKho] ([MaPNKho], [MaMenu], [SL]) VALUES (N'PNK001', N'MN002', 20)
INSERT [dbo].[CTPNKho] ([MaPNKho], [MaMenu], [SL]) VALUES (N'PNK002', N'MN001', 2)
INSERT [dbo].[CTPNKho] ([MaPNKho], [MaMenu], [SL]) VALUES (N'PNK002', N'MN002', 2)
GO
INSERT [dbo].[DieuChinhKho] ([MaDieuChinhKho], [ThoiGianDieuChinh], [TongSLDieuChinh]) VALUES (N'DCK001', CAST(N'2022-11-02T22:21:00' AS SmallDateTime), 3)
INSERT [dbo].[DieuChinhKho] ([MaDieuChinhKho], [ThoiGianDieuChinh], [TongSLDieuChinh]) VALUES (N'DCK002', CAST(N'2022-11-02T22:27:00' AS SmallDateTime), 4)
GO
INSERT [dbo].[DieuChinhKho_Menu] ([MaDieuChinhKho], [MaMenu], [SLThucTe], [SLDieuChinh]) VALUES (N'DCK001', N'MN001', 23, 1)
INSERT [dbo].[DieuChinhKho_Menu] ([MaDieuChinhKho], [MaMenu], [SLThucTe], [SLDieuChinh]) VALUES (N'DCK001', N'MN002', 24, 2)
INSERT [dbo].[DieuChinhKho_Menu] ([MaDieuChinhKho], [MaMenu], [SLThucTe], [SLDieuChinh]) VALUES (N'DCK002', N'MN001', 25, 2)
INSERT [dbo].[DieuChinhKho_Menu] ([MaDieuChinhKho], [MaMenu], [SLThucTe], [SLDieuChinh]) VALUES (N'DCK002', N'MN002', 26, 2)
GO
INSERT [dbo].[HoaDon] ([MaHoaDon], [MaPhong], [ThoiGianBatDau], [ThoiGianKetThuc], [MaCachThue], [TienPhong], [PhuThu], [TraTruoc], [ThuGiamTruKhac], [TienMenu], [GhiChu], [TaiKhoanNhanPhong], [TaiKhoanTraPhong]) VALUES (N'HD001', N'P001', CAST(N'2022-10-13T22:00:00' AS SmallDateTime), CAST(N'2022-10-10T00:00:00' AS SmallDateTime), N'CT001', N'1,150,000', N'50,000', N'100,000', N'', N'30,000', N'', N'TK001', N'TK001')
INSERT [dbo].[HoaDon] ([MaHoaDon], [MaPhong], [ThoiGianBatDau], [ThoiGianKetThuc], [MaCachThue], [TienPhong], [PhuThu], [TraTruoc], [ThuGiamTruKhac], [TienMenu], [GhiChu], [TaiKhoanNhanPhong], [TaiKhoanTraPhong]) VALUES (N'HD002', N'P002', CAST(N'2022-10-13T00:00:00' AS SmallDateTime), CAST(N'2022-10-24T23:30:00' AS SmallDateTime), N'CT001', N'7,175,000', N'', N'100,000', N'', N'44,000', N'a', N'TK002', N'TK002')
INSERT [dbo].[HoaDon] ([MaHoaDon], [MaPhong], [ThoiGianBatDau], [ThoiGianKetThuc], [MaCachThue], [TienPhong], [PhuThu], [TraTruoc], [ThuGiamTruKhac], [TienMenu], [GhiChu], [TaiKhoanNhanPhong], [TaiKhoanTraPhong]) VALUES (N'HD004', N'P001', CAST(N'2022-10-25T16:15:00' AS SmallDateTime), CAST(N'2022-10-25T16:57:00' AS SmallDateTime), N'CT001', N'25,000', N'', N'', N'', N'', N'', N'TK001', N'TK001')
INSERT [dbo].[HoaDon] ([MaHoaDon], [MaPhong], [ThoiGianBatDau], [ThoiGianKetThuc], [MaCachThue], [TienPhong], [PhuThu], [TraTruoc], [ThuGiamTruKhac], [TienMenu], [GhiChu], [TaiKhoanNhanPhong], [TaiKhoanTraPhong]) VALUES (N'HD005', N'P002', CAST(N'2022-09-10T22:00:00' AS SmallDateTime), CAST(N'2022-09-20T00:00:00' AS SmallDateTime), N'CT001', N'1,150,000', N'50,000', N'100,000', N'', N'30,000', N'', N'TK001', N'TK002')
INSERT [dbo].[HoaDon] ([MaHoaDon], [MaPhong], [ThoiGianBatDau], [ThoiGianKetThuc], [MaCachThue], [TienPhong], [PhuThu], [TraTruoc], [ThuGiamTruKhac], [TienMenu], [GhiChu], [TaiKhoanNhanPhong], [TaiKhoanTraPhong]) VALUES (N'HD006', N'P003', CAST(N'2022-11-04T07:51:00' AS SmallDateTime), CAST(N'2022-11-04T09:07:00' AS SmallDateTime), N'CT002', N'50,000', N'0', N'', N'', N'0', N'', N'TK001', N'TK001')
INSERT [dbo].[HoaDon] ([MaHoaDon], [MaPhong], [ThoiGianBatDau], [ThoiGianKetThuc], [MaCachThue], [TienPhong], [PhuThu], [TraTruoc], [ThuGiamTruKhac], [TienMenu], [GhiChu], [TaiKhoanNhanPhong], [TaiKhoanTraPhong]) VALUES (N'HD007', N'P004', CAST(N'2022-11-04T09:07:00' AS SmallDateTime), NULL, N'CT001', N'', N'', N'', N'', N'', N'', N'TK001', NULL)
GO
INSERT [dbo].[HoaDon_Menu] ([MaMenu], [MaHoaDon], [SL]) VALUES (N'MN001', N'HD001', 5)
INSERT [dbo].[HoaDon_Menu] ([MaMenu], [MaHoaDon], [SL]) VALUES (N'MN001', N'HD002', 3)
INSERT [dbo].[HoaDon_Menu] ([MaMenu], [MaHoaDon], [SL]) VALUES (N'MN002', N'HD002', 2)
GO
INSERT [dbo].[LoaiPhong] ([MaLoaiPhong], [TenLoaiPhong], [UuTienHienThi]) VALUES (N'LP001', N'Phòng đơn', 1)
INSERT [dbo].[LoaiPhong] ([MaLoaiPhong], [TenLoaiPhong], [UuTienHienThi]) VALUES (N'LP002', N'Phòng đôi', 2)
INSERT [dbo].[LoaiPhong] ([MaLoaiPhong], [TenLoaiPhong], [UuTienHienThi]) VALUES (N'LP003', N'Phòng VIP', 3)
GO
INSERT [dbo].[Menu] ([MaMenu], [TenMenu], [LoaiMenu], [GiaNhap], [GiaBan], [UuTienHienThi]) VALUES (N'1', N'11', N'1', N'1', N'1', 1)
INSERT [dbo].[Menu] ([MaMenu], [TenMenu], [LoaiMenu], [GiaNhap], [GiaBan], [UuTienHienThi]) VALUES (N'MN001', N'Nước suối', N'Đồ uống', N'5,000', N'10,000', 1)
INSERT [dbo].[Menu] ([MaMenu], [TenMenu], [LoaiMenu], [GiaNhap], [GiaBan], [UuTienHienThi]) VALUES (N'MN002', N'Snack', N'Đồ ăn', N'3,000', N'7,000', 2)
GO
INSERT [dbo].[PhieuDatPhong] ([MaPhieuDatPhong], [HoTenKhachHang], [SoDienThoai], [NgayNhanPhong], [NgayTraPhong], [TienTraTruoc], [GhiChu], [TrangThai]) VALUES (N'PDP001', N'tnmt', N'0900900900', CAST(N'2022-09-10' AS Date), CAST(N'2022-10-10' AS Date), N'1,000,000', N'', N'Đã nhận phòng')
INSERT [dbo].[PhieuDatPhong] ([MaPhieuDatPhong], [HoTenKhachHang], [SoDienThoai], [NgayNhanPhong], [NgayTraPhong], [TienTraTruoc], [GhiChu], [TrangThai]) VALUES (N'PDP002', N'abc', N'0900900901', CAST(N'2022-09-11' AS Date), CAST(N'2022-09-12' AS Date), N'500,000', NULL, N'Chưa nhận phòng')
GO
INSERT [dbo].[PhieuThuChi] ([MaPhieuThuChi], [ThoiGian], [LoaiHinh], [SoTien], [NoiDung]) VALUES (N'PTC001', CAST(N'2022-11-03T00:00:00' AS SmallDateTime), N'Chi', N'100,000,000', N'Mặt bằng')
GO
INSERT [dbo].[Phong] ([MaPhong], [MaLoaiPhong], [TinhTrang], [SoKhachToiDa], [MaCachTinhTien], [UuTienHienThi]) VALUES (N'P001', N'LP001', N'Phòng đang thuê', 2, N'CTT001', 1)
INSERT [dbo].[Phong] ([MaPhong], [MaLoaiPhong], [TinhTrang], [SoKhachToiDa], [MaCachTinhTien], [UuTienHienThi]) VALUES (N'P002', N'LP002', N'Phòng đang thuê', 4, N'CTT002', 2)
INSERT [dbo].[Phong] ([MaPhong], [MaLoaiPhong], [TinhTrang], [SoKhachToiDa], [MaCachTinhTien], [UuTienHienThi]) VALUES (N'P003', N'LP001', N'Phòng chờ dọn', 3, N'CTT001', 2)
INSERT [dbo].[Phong] ([MaPhong], [MaLoaiPhong], [TinhTrang], [SoKhachToiDa], [MaCachTinhTien], [UuTienHienThi]) VALUES (N'P004', N'LP002', N'Phòng đang thuê', 2, N'CTT002', 2)
GO
INSERT [dbo].[PNKho] ([MaPNKho], [ThoiGianNhap], [GhiChu]) VALUES (N'PNK001', CAST(N'2022-10-10T00:00:00' AS SmallDateTime), N'')
INSERT [dbo].[PNKho] ([MaPNKho], [ThoiGianNhap], [GhiChu]) VALUES (N'PNK002', CAST(N'2022-10-20T00:00:00' AS SmallDateTime), N'')
GO
INSERT [dbo].[Quyen] ([MaQuyen], [TenQuyen]) VALUES (N'Q001', N'Admin')
INSERT [dbo].[Quyen] ([MaQuyen], [TenQuyen]) VALUES (N'Q002', N'Nhân viên')
GO
INSERT [dbo].[Quyen_ChucNang] ([MaQuyen], [MaChucNang]) VALUES (N'Q001', N'CN001')
INSERT [dbo].[Quyen_ChucNang] ([MaQuyen], [MaChucNang]) VALUES (N'Q001', N'CN002')
INSERT [dbo].[Quyen_ChucNang] ([MaQuyen], [MaChucNang]) VALUES (N'Q001', N'CN003')
INSERT [dbo].[Quyen_ChucNang] ([MaQuyen], [MaChucNang]) VALUES (N'Q001', N'CN004')
INSERT [dbo].[Quyen_ChucNang] ([MaQuyen], [MaChucNang]) VALUES (N'Q001', N'CN005')
INSERT [dbo].[Quyen_ChucNang] ([MaQuyen], [MaChucNang]) VALUES (N'Q001', N'CN006')
INSERT [dbo].[Quyen_ChucNang] ([MaQuyen], [MaChucNang]) VALUES (N'Q002', N'CN001')
INSERT [dbo].[Quyen_ChucNang] ([MaQuyen], [MaChucNang]) VALUES (N'Q002', N'CN002')
INSERT [dbo].[Quyen_ChucNang] ([MaQuyen], [MaChucNang]) VALUES (N'Q002', N'CN003')
INSERT [dbo].[Quyen_ChucNang] ([MaQuyen], [MaChucNang]) VALUES (N'Q002', N'CN004')
INSERT [dbo].[Quyen_ChucNang] ([MaQuyen], [MaChucNang]) VALUES (N'Q002', N'CN005')
INSERT [dbo].[Quyen_ChucNang] ([MaQuyen], [MaChucNang]) VALUES (N'Q002', N'CN006')
GO
INSERT [dbo].[TaiKhoan] ([MaTaiKhoan], [TenTaiKhoan], [MatKhau], [MaQuyen]) VALUES (N'TK001', N'TK001', N'5vdnZz6dgLAmbilegzFLoQ==', N'Q001')
INSERT [dbo].[TaiKhoan] ([MaTaiKhoan], [TenTaiKhoan], [MatKhau], [MaQuyen]) VALUES (N'TK002', N'TK002', N'5vdnZz6dgLAmbilegzFLoQ==', N'Q002')
GO
INSERT [dbo].[ThietLapKhac] ([TenKhachSan], [DiaChi], [SDT], [ThoiGian], [Logo], [Panel]) VALUES (N'HTTTD', N'123 abc, phường 5, Q1, TPHCM', N'0900900900', CAST(N'2022-10-10T00:00:00' AS SmallDateTime), N'logo.png', N'panel-design.png')
GO
ALTER TABLE [dbo].[CachTinhTien_CachThue]  WITH CHECK ADD  CONSTRAINT [FK_CachTinhTien_CachThue_CachThue] FOREIGN KEY([MaCachThue])
REFERENCES [dbo].[CachThue] ([CachThue])
GO
ALTER TABLE [dbo].[CachTinhTien_CachThue] CHECK CONSTRAINT [FK_CachTinhTien_CachThue_CachThue]
GO
ALTER TABLE [dbo].[CachTinhTien_CachThue]  WITH CHECK ADD  CONSTRAINT [FK_CachTinhTien_CachThue_CachTinhTien] FOREIGN KEY([MaCachTinhTien])
REFERENCES [dbo].[CachTinhTien] ([MaCachTinhTien])
GO
ALTER TABLE [dbo].[CachTinhTien_CachThue] CHECK CONSTRAINT [FK_CachTinhTien_CachThue_CachTinhTien]
GO
ALTER TABLE [dbo].[CTChucNang]  WITH CHECK ADD  CONSTRAINT [FK_CTChucNang_ChucNang] FOREIGN KEY([MaChucNang])
REFERENCES [dbo].[ChucNang] ([MaChucNang])
GO
ALTER TABLE [dbo].[CTChucNang] CHECK CONSTRAINT [FK_CTChucNang_ChucNang]
GO
ALTER TABLE [dbo].[CTPhieuDatPhong_LoaiPhong]  WITH CHECK ADD  CONSTRAINT [FK_CTPhieuDatPhong_LoaiPhong] FOREIGN KEY([MaLoaiPhong])
REFERENCES [dbo].[LoaiPhong] ([MaLoaiPhong])
GO
ALTER TABLE [dbo].[CTPhieuDatPhong_LoaiPhong] CHECK CONSTRAINT [FK_CTPhieuDatPhong_LoaiPhong]
GO
ALTER TABLE [dbo].[CTPhieuDatPhong_LoaiPhong]  WITH CHECK ADD  CONSTRAINT [FK_CTPhieuDatPhong_PhieuDatPhong] FOREIGN KEY([MaPhieuDatPhong])
REFERENCES [dbo].[PhieuDatPhong] ([MaPhieuDatPhong])
GO
ALTER TABLE [dbo].[CTPhieuDatPhong_LoaiPhong] CHECK CONSTRAINT [FK_CTPhieuDatPhong_PhieuDatPhong]
GO
ALTER TABLE [dbo].[CTPhieuDatPhong_Phong]  WITH CHECK ADD  CONSTRAINT [FK_CTPhieuDatPhong_Phong_PhieuDatPhong] FOREIGN KEY([MaPhieuDatPhong])
REFERENCES [dbo].[PhieuDatPhong] ([MaPhieuDatPhong])
GO
ALTER TABLE [dbo].[CTPhieuDatPhong_Phong] CHECK CONSTRAINT [FK_CTPhieuDatPhong_Phong_PhieuDatPhong]
GO
ALTER TABLE [dbo].[CTPhieuDatPhong_Phong]  WITH CHECK ADD  CONSTRAINT [FK_CTPhieuDatPhong_Phong_Phong] FOREIGN KEY([MaPhong])
REFERENCES [dbo].[Phong] ([MaPhong])
GO
ALTER TABLE [dbo].[CTPhieuDatPhong_Phong] CHECK CONSTRAINT [FK_CTPhieuDatPhong_Phong_Phong]
GO
ALTER TABLE [dbo].[CTPNKho]  WITH CHECK ADD  CONSTRAINT [FK_CTPNKho_Menu] FOREIGN KEY([MaMenu])
REFERENCES [dbo].[Menu] ([MaMenu])
GO
ALTER TABLE [dbo].[CTPNKho] CHECK CONSTRAINT [FK_CTPNKho_Menu]
GO
ALTER TABLE [dbo].[CTPNKho]  WITH CHECK ADD  CONSTRAINT [FK_CTPNKho_PNKho] FOREIGN KEY([MaPNKho])
REFERENCES [dbo].[PNKho] ([MaPNKho])
GO
ALTER TABLE [dbo].[CTPNKho] CHECK CONSTRAINT [FK_CTPNKho_PNKho]
GO
ALTER TABLE [dbo].[DieuChinhKho_Menu]  WITH CHECK ADD  CONSTRAINT [FK_DieuChinhKho_Menu_DieuChinhKho] FOREIGN KEY([MaDieuChinhKho])
REFERENCES [dbo].[DieuChinhKho] ([MaDieuChinhKho])
GO
ALTER TABLE [dbo].[DieuChinhKho_Menu] CHECK CONSTRAINT [FK_DieuChinhKho_Menu_DieuChinhKho]
GO
ALTER TABLE [dbo].[DieuChinhKho_Menu]  WITH CHECK ADD  CONSTRAINT [FK_DieuChinhKho_Menu_Menu] FOREIGN KEY([MaMenu])
REFERENCES [dbo].[Menu] ([MaMenu])
GO
ALTER TABLE [dbo].[DieuChinhKho_Menu] CHECK CONSTRAINT [FK_DieuChinhKho_Menu_Menu]
GO
ALTER TABLE [dbo].[HoaDon]  WITH CHECK ADD  CONSTRAINT [FK_HoaDon_Phong] FOREIGN KEY([MaPhong])
REFERENCES [dbo].[Phong] ([MaPhong])
GO
ALTER TABLE [dbo].[HoaDon] CHECK CONSTRAINT [FK_HoaDon_Phong]
GO
ALTER TABLE [dbo].[HoaDon]  WITH CHECK ADD  CONSTRAINT [FK_HoaDon_TaiKhoan] FOREIGN KEY([TaiKhoanNhanPhong])
REFERENCES [dbo].[TaiKhoan] ([MaTaiKhoan])
GO
ALTER TABLE [dbo].[HoaDon] CHECK CONSTRAINT [FK_HoaDon_TaiKhoan]
GO
ALTER TABLE [dbo].[HoaDon_Menu]  WITH CHECK ADD  CONSTRAINT [FK_HoaDon_Menu_HoaDon] FOREIGN KEY([MaHoaDon])
REFERENCES [dbo].[HoaDon] ([MaHoaDon])
GO
ALTER TABLE [dbo].[HoaDon_Menu] CHECK CONSTRAINT [FK_HoaDon_Menu_HoaDon]
GO
ALTER TABLE [dbo].[HoaDon_Menu]  WITH CHECK ADD  CONSTRAINT [FK_HoaDon_Menu_Menu] FOREIGN KEY([MaMenu])
REFERENCES [dbo].[Menu] ([MaMenu])
GO
ALTER TABLE [dbo].[HoaDon_Menu] CHECK CONSTRAINT [FK_HoaDon_Menu_Menu]
GO
ALTER TABLE [dbo].[Phong]  WITH CHECK ADD  CONSTRAINT [FK_Phong_CachTinhTien] FOREIGN KEY([MaCachTinhTien])
REFERENCES [dbo].[CachTinhTien] ([MaCachTinhTien])
GO
ALTER TABLE [dbo].[Phong] CHECK CONSTRAINT [FK_Phong_CachTinhTien]
GO
ALTER TABLE [dbo].[Phong]  WITH CHECK ADD  CONSTRAINT [FK_Phong_LoaiPhong] FOREIGN KEY([MaLoaiPhong])
REFERENCES [dbo].[LoaiPhong] ([MaLoaiPhong])
GO
ALTER TABLE [dbo].[Phong] CHECK CONSTRAINT [FK_Phong_LoaiPhong]
GO
ALTER TABLE [dbo].[Quyen_ChucNang]  WITH CHECK ADD  CONSTRAINT [FK_Quyen_ChucNang_ChucNang] FOREIGN KEY([MaChucNang])
REFERENCES [dbo].[ChucNang] ([MaChucNang])
GO
ALTER TABLE [dbo].[Quyen_ChucNang] CHECK CONSTRAINT [FK_Quyen_ChucNang_ChucNang]
GO
ALTER TABLE [dbo].[Quyen_ChucNang]  WITH CHECK ADD  CONSTRAINT [FK_Quyen_ChucNang_Quyen] FOREIGN KEY([MaQuyen])
REFERENCES [dbo].[Quyen] ([MaQuyen])
GO
ALTER TABLE [dbo].[Quyen_ChucNang] CHECK CONSTRAINT [FK_Quyen_ChucNang_Quyen]
GO
ALTER TABLE [dbo].[TaiKhoan]  WITH CHECK ADD  CONSTRAINT [FK_TaiKhoan_Quyen] FOREIGN KEY([MaQuyen])
REFERENCES [dbo].[Quyen] ([MaQuyen])
GO
ALTER TABLE [dbo].[TaiKhoan] CHECK CONSTRAINT [FK_TaiKhoan_Quyen]
GO
