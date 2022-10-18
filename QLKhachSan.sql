USE [QLKhachSan]
GO
/****** Object:  Table [dbo].[CachThue]    Script Date: 10/19/2022 3:18:30 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CachThue](
	[MaCachThue] [varchar](50) NOT NULL,
	[TenCachThue] [nvarchar](50) NULL,
	[GiaTheoCachThue] [varchar](50) NULL,
	[GioNhanPhong] [datetime] NULL,
	[GioTraPhong] [datetime] NULL,
 CONSTRAINT [PK_CachThue] PRIMARY KEY CLUSTERED 
(
	[MaCachThue] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[CachTinhTien]    Script Date: 10/19/2022 3:18:30 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CachTinhTien](
	[MaCachTinhTien] [varchar](50) NOT NULL,
	[TenCachTinhTien] [nvarchar](50) NULL,
	[MaCachThue] [varchar](50) NULL,
	[GiaThueCuoiTuanVaNgayLe] [varchar](50) NULL,
	[PhuThuQuaGio] [varchar](50) NULL,
	[SoPhutLamTronThanh1Gio] [int] NULL,
 CONSTRAINT [PK_CachTinhTien] PRIMARY KEY CLUSTERED 
(
	[MaCachTinhTien] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ChucNang]    Script Date: 10/19/2022 3:18:30 AM ******/
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
/****** Object:  Table [dbo].[CTChucNang]    Script Date: 10/19/2022 3:18:30 AM ******/
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
/****** Object:  Table [dbo].[CTPhieuDatPhong_LoaiPhong]    Script Date: 10/19/2022 3:18:30 AM ******/
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
/****** Object:  Table [dbo].[CTPhieuDatPhong_Phong]    Script Date: 10/19/2022 3:18:30 AM ******/
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
/****** Object:  Table [dbo].[CTPhieuKiemKho]    Script Date: 10/19/2022 3:18:30 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CTPhieuKiemKho](
	[MaCTPKKho] [varchar](50) NOT NULL,
	[MaPhieuKiemKho] [varchar](50) NOT NULL,
	[MaMenu] [varchar](50) NULL,
	[SL] [int] NULL,
 CONSTRAINT [PK_CTPhieuNhapKho] PRIMARY KEY CLUSTERED 
(
	[MaCTPKKho] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[CTPhieuNhapKho]    Script Date: 10/19/2022 3:18:30 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CTPhieuNhapKho](
	[MaCTPhieuKiemKho] [varchar](50) NOT NULL,
	[MaPhieuKiemKho] [varchar](50) NOT NULL,
	[MaMenu] [varchar](50) NULL,
	[SL] [int] NULL,
 CONSTRAINT [PK_CTPhieuNhapKho_1] PRIMARY KEY CLUSTERED 
(
	[MaCTPhieuKiemKho] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[CTPNKho]    Script Date: 10/19/2022 3:18:30 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CTPNKho](
	[MaCTPNKho] [varchar](50) NOT NULL,
	[MaPNKho] [varchar](50) NOT NULL,
	[MaMenu] [varchar](50) NULL,
	[SL] [int] NULL,
 CONSTRAINT [PK_CTPNKho_1] PRIMARY KEY CLUSTERED 
(
	[MaCTPNKho] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[DieuChinhKho]    Script Date: 10/19/2022 3:18:30 AM ******/
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
/****** Object:  Table [dbo].[HoaDon]    Script Date: 10/19/2022 3:18:30 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[HoaDon](
	[MaHoaDon] [varchar](50) NOT NULL,
	[ThoiGianBatDau] [datetime] NULL,
	[ThoiGianKetThuc] [datetime] NULL,
	[MaCachThue] [varchar](50) NULL,
	[TienPhong] [varchar](50) NULL,
	[PhuThu] [varchar](50) NULL,
	[TraTruoc] [varchar](50) NULL,
	[ThuGiamTruKhac] [varchar](50) NULL,
	[TienMenu] [varchar](50) NULL,
	[TongTien] [varchar](50) NULL,
	[GhiChu] [nvarchar](50) NULL,
 CONSTRAINT [PK_HoaDon] PRIMARY KEY CLUSTERED 
(
	[MaHoaDon] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[HoaDon_Menu]    Script Date: 10/19/2022 3:18:30 AM ******/
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
/****** Object:  Table [dbo].[LoaiPhong]    Script Date: 10/19/2022 3:18:30 AM ******/
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
/****** Object:  Table [dbo].[Menu]    Script Date: 10/19/2022 3:18:30 AM ******/
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
/****** Object:  Table [dbo].[NhanVien]    Script Date: 10/19/2022 3:18:30 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NhanVien](
	[MaNhanVien] [varchar](50) NOT NULL,
	[TenNhanVien] [nvarchar](50) NULL,
	[SoDienThoai] [varchar](50) NULL,
	[Email] [varchar](50) NULL,
	[GioiTinh] [nvarchar](50) NULL,
	[MaTaiKhoan] [varchar](50) NULL,
 CONSTRAINT [PK_NhanVien] PRIMARY KEY CLUSTERED 
(
	[MaNhanVien] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PhieuDatPhong]    Script Date: 10/19/2022 3:18:30 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PhieuDatPhong](
	[MaPhieuDatPhong] [varchar](50) NOT NULL,
	[HoTenKhachHang] [nvarchar](50) NULL,
	[SoDienThoai] [varchar](50) NULL,
	[ThoiGianDat] [smalldatetime] NULL,
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
/****** Object:  Table [dbo].[PhieuKiemKho]    Script Date: 10/19/2022 3:18:30 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PhieuKiemKho](
	[MaPhieuKiemKho] [varchar](50) NOT NULL,
	[ThoiGianTaoPhieu] [smalldatetime] NULL,
	[TaiKhoanTaoPhieu] [varchar](50) NULL,
 CONSTRAINT [PK_PhieuKiemKho] PRIMARY KEY CLUSTERED 
(
	[MaPhieuKiemKho] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PhieuThuChi]    Script Date: 10/19/2022 3:18:30 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PhieuThuChi](
	[MaPhieuThuChi] [varchar](50) NOT NULL,
	[ThoiGian] [datetime] NULL,
	[LoaiHinh] [nvarchar](50) NULL,
	[SoTien] [varchar](50) NULL,
	[NoiDung] [nvarchar](50) NULL,
 CONSTRAINT [PK_PhieuThuChi] PRIMARY KEY CLUSTERED 
(
	[MaPhieuThuChi] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Phong]    Script Date: 10/19/2022 3:18:30 AM ******/
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
/****** Object:  Table [dbo].[PNKho]    Script Date: 10/19/2022 3:18:30 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PNKho](
	[MaPNKho] [varchar](50) NOT NULL,
	[ThoiGianNhap] [datetime] NULL,
	[MaNhanVien] [varchar](50) NULL,
	[GhiChu] [nvarchar](50) NULL,
	[UuTienHienThi] [int] NULL,
 CONSTRAINT [PK_PNKho] PRIMARY KEY CLUSTERED 
(
	[MaPNKho] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Quyen]    Script Date: 10/19/2022 3:18:30 AM ******/
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
/****** Object:  Table [dbo].[Quyen_ChucNang]    Script Date: 10/19/2022 3:18:30 AM ******/
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
/****** Object:  Table [dbo].[TaiKhoan]    Script Date: 10/19/2022 3:18:30 AM ******/
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
/****** Object:  Table [dbo].[ThietLapKhac]    Script Date: 10/19/2022 3:18:30 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ThietLapKhac](
	[TenKhachSan] [nvarchar](50) NOT NULL,
	[DiaChi] [nvarchar](50) NULL,
	[SDT] [varchar](50) NULL,
	[ThoiGian] [datetime] NULL,
	[Logo] [varchar](50) NULL,
	[Panel] [varchar](50) NULL,
 CONSTRAINT [PK_ThietLapKhac] PRIMARY KEY CLUSTERED 
(
	[TenKhachSan] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[CachThue] ([MaCachThue], [TenCachThue], [GiaTheoCachThue], [GioNhanPhong], [GioTraPhong]) VALUES (N'CT001', N'Thuê theo giờ', N'25000', CAST(N'2022-10-13T07:00:00.000' AS DateTime), CAST(N'2022-10-13T15:00:00.000' AS DateTime))
INSERT [dbo].[CachThue] ([MaCachThue], [TenCachThue], [GiaTheoCachThue], [GioNhanPhong], [GioTraPhong]) VALUES (N'CT002', N'Thuê theo ngày', N'500000', CAST(N'2022-10-13T07:00:00.000' AS DateTime), CAST(N'2022-10-15T07:00:00.000' AS DateTime))
GO
INSERT [dbo].[CachTinhTien] ([MaCachTinhTien], [TenCachTinhTien], [MaCachThue], [GiaThueCuoiTuanVaNgayLe], [PhuThuQuaGio], [SoPhutLamTronThanh1Gio]) VALUES (N'CTT001', N'Cách tính 1', N'CT001', N'600000', N'30000', 30)
INSERT [dbo].[CachTinhTien] ([MaCachTinhTien], [TenCachTinhTien], [MaCachThue], [GiaThueCuoiTuanVaNgayLe], [PhuThuQuaGio], [SoPhutLamTronThanh1Gio]) VALUES (N'CTT002', N'Cách tính 2', N'CT002', N'700000', N'35000', 30)
GO
INSERT [dbo].[ChucNang] ([MaChucNang], [TenChucNang]) VALUES (N'CN001', N'Đặt phòng')
INSERT [dbo].[ChucNang] ([MaChucNang], [TenChucNang]) VALUES (N'CN002', N'Thuê - Trả phòng')
INSERT [dbo].[ChucNang] ([MaChucNang], [TenChucNang]) VALUES (N'CN003', N'Quản lý kho')
INSERT [dbo].[ChucNang] ([MaChucNang], [TenChucNang]) VALUES (N'CN004', N'Quản lý thu chi')
INSERT [dbo].[ChucNang] ([MaChucNang], [TenChucNang]) VALUES (N'CN005', N'Quản lý hệ thống')
INSERT [dbo].[ChucNang] ([MaChucNang], [TenChucNang]) VALUES (N'CN006', N'Tài khoản')
GO
INSERT [dbo].[CTChucNang] ([MaCTCN], [TenCTCN], [MaChucNang]) VALUES (N'CTCN001', N'Cách Tính Tiền', N'CN006')
INSERT [dbo].[CTChucNang] ([MaCTCN], [TenCTCN], [MaChucNang]) VALUES (N'CTCN002', N'Loại phòng', N'CN006')
INSERT [dbo].[CTChucNang] ([MaCTCN], [TenCTCN], [MaChucNang]) VALUES (N'CTCN003', N'Phòng', N'CN006')
INSERT [dbo].[CTChucNang] ([MaCTCN], [TenCTCN], [MaChucNang]) VALUES (N'CTCN004', N'Menu', N'CN006')
INSERT [dbo].[CTChucNang] ([MaCTCN], [TenCTCN], [MaChucNang]) VALUES (N'CTCN005', N'Thống kê', N'CN006')
INSERT [dbo].[CTChucNang] ([MaCTCN], [TenCTCN], [MaChucNang]) VALUES (N'CTCN006', N'Lịch sử', N'CN006')
INSERT [dbo].[CTChucNang] ([MaCTCN], [TenCTCN], [MaChucNang]) VALUES (N'CTCN007', N'Thiết lập khác', N'CN006')
GO
INSERT [dbo].[CTPhieuDatPhong_LoaiPhong] ([MaPhieuDatPhong], [MaCTPhieuDatPhong_LoaiPhong], [MaLoaiPhong], [SLPhong]) VALUES (N'PDP001', N'CTPD001', N'LP001', 1)
GO
INSERT [dbo].[CTPhieuDatPhong_Phong] ([MaCTPhieuDatPhong_Phong], [MaPhieuDatPhong], [MaPhong]) VALUES (N'CTPDPP001', N'PDP001', N'P001')
GO
INSERT [dbo].[LoaiPhong] ([MaLoaiPhong], [TenLoaiPhong], [UuTienHienThi]) VALUES (N'LP001', N'Phòng đơn', 1)
INSERT [dbo].[LoaiPhong] ([MaLoaiPhong], [TenLoaiPhong], [UuTienHienThi]) VALUES (N'LP002', N'Phòng đôi', 2)
GO
INSERT [dbo].[NhanVien] ([MaNhanVien], [TenNhanVien], [SoDienThoai], [Email], [GioiTinh], [MaTaiKhoan]) VALUES (N'NV001', N'abc', N'0900900900', N'abc@gmail.com', N'Nam', N'TK001')
INSERT [dbo].[NhanVien] ([MaNhanVien], [TenNhanVien], [SoDienThoai], [Email], [GioiTinh], [MaTaiKhoan]) VALUES (N'NV002', N'def', N'0900900901', N'def@gmail.com', N'Nữ', N'TK002')
GO
INSERT [dbo].[PhieuDatPhong] ([MaPhieuDatPhong], [HoTenKhachHang], [SoDienThoai], [ThoiGianDat], [NgayNhanPhong], [NgayTraPhong], [TienTraTruoc], [GhiChu], [TrangThai]) VALUES (N'PDP001', N'tnmt', N'0900900900', NULL, CAST(N'2022-09-10' AS Date), CAST(N'2022-10-10' AS Date), N'1000000', NULL, NULL)
GO
INSERT [dbo].[Phong] ([MaPhong], [MaLoaiPhong], [TinhTrang], [SoKhachToiDa], [MaCachTinhTien], [UuTienHienThi]) VALUES (N'P001', N'LP001', N'Trống', 2, NULL, 1)
INSERT [dbo].[Phong] ([MaPhong], [MaLoaiPhong], [TinhTrang], [SoKhachToiDa], [MaCachTinhTien], [UuTienHienThi]) VALUES (N'P002', N'LP002', N'Trống', 4, NULL, 2)
INSERT [dbo].[Phong] ([MaPhong], [MaLoaiPhong], [TinhTrang], [SoKhachToiDa], [MaCachTinhTien], [UuTienHienThi]) VALUES (N'P003', N'LP001', N'Trống', 3, N'CTT001', 2)
GO
INSERT [dbo].[PNKho] ([MaPNKho], [ThoiGianNhap], [MaNhanVien], [GhiChu], [UuTienHienThi]) VALUES (N'D1', CAST(N'2022-10-10T00:00:00.000' AS DateTime), NULL, NULL, NULL)
GO
INSERT [dbo].[Quyen] ([MaQuyen], [TenQuyen]) VALUES (N'Q001', N'Admin')
INSERT [dbo].[Quyen] ([MaQuyen], [TenQuyen]) VALUES (N'Q002', N'Nhân viên')
GO
INSERT [dbo].[TaiKhoan] ([MaTaiKhoan], [TenTaiKhoan], [MatKhau], [MaQuyen]) VALUES (N'TK001', N'TK001', N'123456', N'Q001')
INSERT [dbo].[TaiKhoan] ([MaTaiKhoan], [TenTaiKhoan], [MatKhau], [MaQuyen]) VALUES (N'TK002', N'TK002', N'123456', N'Q002')
GO
INSERT [dbo].[ThietLapKhac] ([TenKhachSan], [DiaChi], [SDT], [ThoiGian], [Logo], [Panel]) VALUES (N'HTTTD', N'123 abc, phường 5, Q1, TPHCM', N'0900900900', CAST(N'2022-10-10T00:00:00.000' AS DateTime), N'logo.png', N'panel-design.png')
GO
ALTER TABLE [dbo].[CachTinhTien]  WITH CHECK ADD  CONSTRAINT [FK_CachTinhTien_CachThue] FOREIGN KEY([MaCachThue])
REFERENCES [dbo].[CachThue] ([MaCachThue])
GO
ALTER TABLE [dbo].[CachTinhTien] CHECK CONSTRAINT [FK_CachTinhTien_CachThue]
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
ALTER TABLE [dbo].[CTPhieuKiemKho]  WITH CHECK ADD  CONSTRAINT [FK_CTPhieuKiemKho_Menu] FOREIGN KEY([MaMenu])
REFERENCES [dbo].[Menu] ([MaMenu])
GO
ALTER TABLE [dbo].[CTPhieuKiemKho] CHECK CONSTRAINT [FK_CTPhieuKiemKho_Menu]
GO
ALTER TABLE [dbo].[CTPhieuKiemKho]  WITH CHECK ADD  CONSTRAINT [FK_CTPhieuKiemKho_PhieuKiemKho] FOREIGN KEY([MaPhieuKiemKho])
REFERENCES [dbo].[PhieuKiemKho] ([MaPhieuKiemKho])
GO
ALTER TABLE [dbo].[CTPhieuKiemKho] CHECK CONSTRAINT [FK_CTPhieuKiemKho_PhieuKiemKho]
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
ALTER TABLE [dbo].[LoaiPhong]  WITH CHECK ADD  CONSTRAINT [FK_LoaiPhong_LoaiPhong] FOREIGN KEY([MaLoaiPhong])
REFERENCES [dbo].[LoaiPhong] ([MaLoaiPhong])
GO
ALTER TABLE [dbo].[LoaiPhong] CHECK CONSTRAINT [FK_LoaiPhong_LoaiPhong]
GO
ALTER TABLE [dbo].[NhanVien]  WITH CHECK ADD  CONSTRAINT [FK_NhanVien_TaiKhoan] FOREIGN KEY([MaTaiKhoan])
REFERENCES [dbo].[TaiKhoan] ([MaTaiKhoan])
GO
ALTER TABLE [dbo].[NhanVien] CHECK CONSTRAINT [FK_NhanVien_TaiKhoan]
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
ALTER TABLE [dbo].[Phong]  WITH CHECK ADD  CONSTRAINT [FK_Phong_Phong] FOREIGN KEY([MaPhong])
REFERENCES [dbo].[Phong] ([MaPhong])
GO
ALTER TABLE [dbo].[Phong] CHECK CONSTRAINT [FK_Phong_Phong]
GO
ALTER TABLE [dbo].[PNKho]  WITH CHECK ADD  CONSTRAINT [FK_PNKho_NhanVien] FOREIGN KEY([MaNhanVien])
REFERENCES [dbo].[NhanVien] ([MaNhanVien])
GO
ALTER TABLE [dbo].[PNKho] CHECK CONSTRAINT [FK_PNKho_NhanVien]
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
