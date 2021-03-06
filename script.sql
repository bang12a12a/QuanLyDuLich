USE [CongTyDuLich]
GO
/****** Object:  Table [dbo].[CongTy]    Script Date: 20/05/2019 01:16:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CongTy](
	[MaCongTy] [nchar](10) NOT NULL,
	[TenCongTy] [nvarchar](50) NULL,
	[DiaChi] [nvarchar](50) NULL,
	[DienThoai] [nchar](100) NULL,
	[Email] [nchar](100) NULL,
	[MaPhamVi] [nchar](10) NULL,
 CONSTRAINT [PK_CongTy] PRIMARY KEY CLUSTERED 
(
	[MaCongTy] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[DangKyTour]    Script Date: 20/05/2019 01:16:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DangKyTour](
	[MaDangKy] [nchar](10) NOT NULL,
	[MaKhach] [nchar](10) NULL,
	[MaLichTour] [nchar](10) NULL,
	[NgayDangKy] [datetime] NULL,
	[SoLuongDangKy] [int] NULL,
	[ThanhTien] [int] NULL,
 CONSTRAINT [PK_DangKyTour] PRIMARY KEY CLUSTERED 
(
	[MaDangKy] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[DanhMucTour]    Script Date: 20/05/2019 01:16:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DanhMucTour](
	[MaTour] [nchar](10) NOT NULL,
	[MaCongTy] [nchar](10) NOT NULL,
	[MaPhamVi] [nchar](10) NULL,
	[TenTour] [nvarchar](50) NULL,
	[MaMua] [nchar](10) NULL,
	[SoNgay] [int] NULL,
	[DonGia] [int] NULL,
	[GhiChu] [nvarchar](500) NULL,
 CONSTRAINT [PK_DanhMucTour_1] PRIMARY KEY CLUSTERED 
(
	[MaTour] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[HDV-NgoaiNgu]    Script Date: 20/05/2019 01:16:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[HDV-NgoaiNgu](
	[MaHDV] [nchar](10) NOT NULL,
	[MaNN] [nchar](10) NOT NULL,
	[MaXepLoai] [nchar](10) NULL,
 CONSTRAINT [PK_HDV-NgoaiNgu] PRIMARY KEY CLUSTERED 
(
	[MaHDV] ASC,
	[MaNN] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[HuongDanVien]    Script Date: 20/05/2019 01:16:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[HuongDanVien](
	[MaHDV] [nchar](10) NOT NULL,
	[TenHDV] [nvarchar](50) NULL,
	[MaCongTy] [nchar](10) NULL,
	[NgaySinh] [datetime] NULL,
	[GioiTinh] [nvarchar](50) NULL,
	[MaTinh] [nchar](10) NULL,
	[MaTrinhDo] [nchar](10) NULL,
	[MaTruongDT] [nchar](10) NULL,
	[NgayVaoCongTy] [datetime] NULL,
 CONSTRAINT [PK_HuongDanVien] PRIMARY KEY CLUSTERED 
(
	[MaHDV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[KhachHang]    Script Date: 20/05/2019 01:16:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[KhachHang](
	[MaKhach] [nchar](10) NOT NULL,
	[TenKhach] [nvarchar](50) NULL,
	[DiaChi] [nvarchar](500) NULL,
	[DienThoai] [nchar](10) NULL,
	[QuocTich] [nvarchar](50) NULL,
	[GhiChu] [nvarchar](500) NULL,
 CONSTRAINT [PK_KhachHang] PRIMARY KEY CLUSTERED 
(
	[MaKhach] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[LichTour]    Script Date: 20/05/2019 01:16:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LichTour](
	[MaLichTour] [nchar](10) NOT NULL,
	[MaCongTy] [nchar](10) NOT NULL,
	[MaTour] [nchar](10) NOT NULL,
	[MaHDV] [nchar](10) NULL,
	[NgayKhoiHanh] [datetime] NULL,
	[SoNguoiDangKy] [int] NULL,
	[TongTien] [int] NULL,
	[DaKhoiHanh] [nchar](10) NULL,
 CONSTRAINT [PK_LichTour_1] PRIMARY KEY CLUSTERED 
(
	[MaLichTour] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Mua]    Script Date: 20/05/2019 01:16:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Mua](
	[MaMua] [nchar](10) NOT NULL,
	[TenMua] [nvarchar](50) NULL,
 CONSTRAINT [PK_Mua] PRIMARY KEY CLUSTERED 
(
	[MaMua] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[NgoaiNgu]    Script Date: 20/05/2019 01:16:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NgoaiNgu](
	[MaNN] [nchar](10) NOT NULL,
	[TenNN] [nvarchar](50) NULL,
 CONSTRAINT [PK_NgoaiNgu] PRIMARY KEY CLUSTERED 
(
	[MaNN] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PhamVi]    Script Date: 20/05/2019 01:16:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PhamVi](
	[MaPhamVi] [nchar](10) NOT NULL,
	[TenPhamVi] [nvarchar](50) NULL,
 CONSTRAINT [PK_PhamVi] PRIMARY KEY CLUSTERED 
(
	[MaPhamVi] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[QuocTich]    Script Date: 20/05/2019 01:16:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[QuocTich](
	[MaQuocTich] [nchar](10) NOT NULL,
	[TenQuocTich] [nvarchar](50) NULL,
 CONSTRAINT [PK_QuocTich] PRIMARY KEY CLUSTERED 
(
	[MaQuocTich] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Tinh]    Script Date: 20/05/2019 01:16:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Tinh](
	[MaTinh] [nchar](10) NOT NULL,
	[TenTinh] [nvarchar](50) NULL,
 CONSTRAINT [PK_Tinh] PRIMARY KEY CLUSTERED 
(
	[MaTinh] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TrinhDo]    Script Date: 20/05/2019 01:16:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TrinhDo](
	[MaTrinhDo] [nchar](10) NOT NULL,
	[TenTrinhDo] [nvarchar](50) NULL,
 CONSTRAINT [PK_TrinhDo] PRIMARY KEY CLUSTERED 
(
	[MaTrinhDo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TruongDaoTao]    Script Date: 20/05/2019 01:16:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TruongDaoTao](
	[MaTruongDT] [nchar](10) NOT NULL,
	[TenTruongDT] [nvarchar](50) NULL,
	[DiaChi] [nvarchar](50) NULL,
	[DienThoai] [nchar](10) NULL,
 CONSTRAINT [PK_TruongDaoTao] PRIMARY KEY CLUSTERED 
(
	[MaTruongDT] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[XepLoai]    Script Date: 20/05/2019 01:16:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[XepLoai](
	[MaXepLoai] [nchar](10) NOT NULL,
	[TenXepLoai] [nvarchar](50) NULL,
 CONSTRAINT [PK_XepLoai] PRIMARY KEY CLUSTERED 
(
	[MaXepLoai] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[CongTy] ([MaCongTy], [TenCongTy], [DiaChi], [DienThoai], [Email], [MaPhamVi]) VALUES (N'CT01      ', N'Công ty TNHH Trường Anh', N'Hà Nội', N'013262233                                                                                           ', N'TruongAn@gmail.com                                                                                  ', N'PV01      ')
INSERT [dbo].[CongTy] ([MaCongTy], [TenCongTy], [DiaChi], [DienThoai], [Email], [MaPhamVi]) VALUES (N'CT02      ', N'Công ty TNHH Long An', N'Hà Nội', N'013232312                                                                                           ', N'LongAn@gmail.com                                                                                    ', N'PV02      ')
INSERT [dbo].[DangKyTour] ([MaDangKy], [MaKhach], [MaLichTour], [NgayDangKy], [SoLuongDangKy], [ThanhTien]) VALUES (N'DK01      ', N'K01       ', N'LT01      ', CAST(N'2019-05-19T00:00:00.000' AS DateTime), 3, 300000)
INSERT [dbo].[DangKyTour] ([MaDangKy], [MaKhach], [MaLichTour], [NgayDangKy], [SoLuongDangKy], [ThanhTien]) VALUES (N'DK02      ', N'K02       ', N'LT02      ', CAST(N'2019-05-19T00:00:00.000' AS DateTime), 4, 400000)
INSERT [dbo].[DangKyTour] ([MaDangKy], [MaKhach], [MaLichTour], [NgayDangKy], [SoLuongDangKy], [ThanhTien]) VALUES (N'DK03      ', N'K02       ', N'LT01      ', CAST(N'2019-05-19T00:00:00.000' AS DateTime), 4, 40000000)
INSERT [dbo].[DanhMucTour] ([MaTour], [MaCongTy], [MaPhamVi], [TenTour], [MaMua], [SoNgay], [DonGia], [GhiChu]) VALUES (N'TR01      ', N'CT01      ', N'PV01      ', N'Du lịch Vịnh Hạ Long', N'M02       ', 5, 1000000, N'ok')
INSERT [dbo].[DanhMucTour] ([MaTour], [MaCongTy], [MaPhamVi], [TenTour], [MaMua], [SoNgay], [DonGia], [GhiChu]) VALUES (N'TR02      ', N'CT02      ', N'PV02      ', N'Du lịch Trung Quốc', N'M01       ', 6, 1000000, N'ok')
INSERT [dbo].[HDV-NgoaiNgu] ([MaHDV], [MaNN], [MaXepLoai]) VALUES (N'HDV01     ', N'NN01      ', N'XL01      ')
INSERT [dbo].[HDV-NgoaiNgu] ([MaHDV], [MaNN], [MaXepLoai]) VALUES (N'HDV02     ', N'NN02      ', N'XL02      ')
INSERT [dbo].[HuongDanVien] ([MaHDV], [TenHDV], [MaCongTy], [NgaySinh], [GioiTinh], [MaTinh], [MaTrinhDo], [MaTruongDT], [NgayVaoCongTy]) VALUES (N'HDV01     ', N'Phạm Long Châu', N'CT01      ', CAST(N'1998-01-01T00:00:00.000' AS DateTime), N'Nam', N'T01       ', N'TD01      ', N'T01       ', CAST(N'2018-01-01T00:00:00.000' AS DateTime))
INSERT [dbo].[HuongDanVien] ([MaHDV], [TenHDV], [MaCongTy], [NgaySinh], [GioiTinh], [MaTinh], [MaTrinhDo], [MaTruongDT], [NgayVaoCongTy]) VALUES (N'HDV02     ', N'Trần Như Nhuộng', N'CT02      ', CAST(N'1999-02-02T00:00:00.000' AS DateTime), N'Nam', N'T02       ', N'TD02      ', N'T02       ', CAST(N'2019-02-02T00:00:00.000' AS DateTime))
INSERT [dbo].[KhachHang] ([MaKhach], [TenKhach], [DiaChi], [DienThoai], [QuocTich], [GhiChu]) VALUES (N'K01       ', N'Trần Thần Long', N'Hà Nội', N'013316113 ', N'Việt Nam', N'ok')
INSERT [dbo].[KhachHang] ([MaKhach], [TenKhach], [DiaChi], [DienThoai], [QuocTich], [GhiChu]) VALUES (N'K02       ', N'Thiên Hạ Minh Uy', N'Hà Nội', N'012132215 ', N'Việt Nam', N'ok')
INSERT [dbo].[LichTour] ([MaLichTour], [MaCongTy], [MaTour], [MaHDV], [NgayKhoiHanh], [SoNguoiDangKy], [TongTien], [DaKhoiHanh]) VALUES (N'LT01      ', N'CT01      ', N'TR01      ', N'HDV01     ', CAST(N'2019-05-01T00:00:00.000' AS DateTime), 11, 40700000, N'1         ')
INSERT [dbo].[LichTour] ([MaLichTour], [MaCongTy], [MaTour], [MaHDV], [NgayKhoiHanh], [SoNguoiDangKy], [TongTien], [DaKhoiHanh]) VALUES (N'LT02      ', N'CT02      ', N'TR02      ', N'HDV02     ', CAST(N'2019-05-20T00:00:00.000' AS DateTime), 10, 4000000, N'0         ')
INSERT [dbo].[LichTour] ([MaLichTour], [MaCongTy], [MaTour], [MaHDV], [NgayKhoiHanh], [SoNguoiDangKy], [TongTien], [DaKhoiHanh]) VALUES (N'LT03      ', N'CT01      ', N'TR01      ', N'HDV01     ', CAST(N'2019-05-19T00:00:00.000' AS DateTime), 3, 3000000, N'0         ')
INSERT [dbo].[LichTour] ([MaLichTour], [MaCongTy], [MaTour], [MaHDV], [NgayKhoiHanh], [SoNguoiDangKy], [TongTien], [DaKhoiHanh]) VALUES (N'LT04      ', N'CT01      ', N'TR01      ', N'HDV01     ', CAST(N'2019-05-19T00:00:00.000' AS DateTime), 3, 4000000, N'0         ')
INSERT [dbo].[Mua] ([MaMua], [TenMua]) VALUES (N'M01       ', N'Mùa Xuân')
INSERT [dbo].[Mua] ([MaMua], [TenMua]) VALUES (N'M02       ', N'Mùa Hè')
INSERT [dbo].[Mua] ([MaMua], [TenMua]) VALUES (N'M03       ', N'Mùa Thu')
INSERT [dbo].[Mua] ([MaMua], [TenMua]) VALUES (N'M04       ', N'Mùa Đông')
INSERT [dbo].[NgoaiNgu] ([MaNN], [TenNN]) VALUES (N'NN01      ', N'Tiếng Anh')
INSERT [dbo].[NgoaiNgu] ([MaNN], [TenNN]) VALUES (N'NN02      ', N'Tiếng Trung')
INSERT [dbo].[NgoaiNgu] ([MaNN], [TenNN]) VALUES (N'NN03      ', N'Tiếng Hàn')
INSERT [dbo].[NgoaiNgu] ([MaNN], [TenNN]) VALUES (N'NN04      ', N'Tiếng Nhật')
INSERT [dbo].[PhamVi] ([MaPhamVi], [TenPhamVi]) VALUES (N'PV01      ', N'Trong Nước')
INSERT [dbo].[PhamVi] ([MaPhamVi], [TenPhamVi]) VALUES (N'PV02      ', N'Nước Ngoài')
INSERT [dbo].[Tinh] ([MaTinh], [TenTinh]) VALUES (N'T01       ', N'Nam Định')
INSERT [dbo].[Tinh] ([MaTinh], [TenTinh]) VALUES (N'T02       ', N'Hà Nội')
INSERT [dbo].[Tinh] ([MaTinh], [TenTinh]) VALUES (N'T03       ', N'Thái Bình')
INSERT [dbo].[Tinh] ([MaTinh], [TenTinh]) VALUES (N'T04       ', N'Đà Nẵng')
INSERT [dbo].[TrinhDo] ([MaTrinhDo], [TenTrinhDo]) VALUES (N'TD01      ', N'THPT')
INSERT [dbo].[TrinhDo] ([MaTrinhDo], [TenTrinhDo]) VALUES (N'TD02      ', N'Đại Học')
INSERT [dbo].[TruongDaoTao] ([MaTruongDT], [TenTruongDT], [DiaChi], [DienThoai]) VALUES (N'T01       ', N'Du lịch', N'Hà Nội', N'013326562 ')
INSERT [dbo].[TruongDaoTao] ([MaTruongDT], [TenTruongDT], [DiaChi], [DienThoai]) VALUES (N'T02       ', N'Cao đẳng du lịch', N'Hà Nội', N'022332232 ')
INSERT [dbo].[XepLoai] ([MaXepLoai], [TenXepLoai]) VALUES (N'XL01      ', N'Tốt')
INSERT [dbo].[XepLoai] ([MaXepLoai], [TenXepLoai]) VALUES (N'XL02      ', N'Khá')
INSERT [dbo].[XepLoai] ([MaXepLoai], [TenXepLoai]) VALUES (N'XL03      ', N'Trung Bình')
ALTER TABLE [dbo].[CongTy]  WITH CHECK ADD  CONSTRAINT [FK_CongTy_PhamVi] FOREIGN KEY([MaPhamVi])
REFERENCES [dbo].[PhamVi] ([MaPhamVi])
GO
ALTER TABLE [dbo].[CongTy] CHECK CONSTRAINT [FK_CongTy_PhamVi]
GO
ALTER TABLE [dbo].[DangKyTour]  WITH CHECK ADD  CONSTRAINT [FK_DangKyTour_KhachHang] FOREIGN KEY([MaKhach])
REFERENCES [dbo].[KhachHang] ([MaKhach])
GO
ALTER TABLE [dbo].[DangKyTour] CHECK CONSTRAINT [FK_DangKyTour_KhachHang]
GO
ALTER TABLE [dbo].[DangKyTour]  WITH CHECK ADD  CONSTRAINT [FK_DangKyTour_LichTour] FOREIGN KEY([MaLichTour])
REFERENCES [dbo].[LichTour] ([MaLichTour])
GO
ALTER TABLE [dbo].[DangKyTour] CHECK CONSTRAINT [FK_DangKyTour_LichTour]
GO
ALTER TABLE [dbo].[DanhMucTour]  WITH CHECK ADD  CONSTRAINT [FK_DanhMucTour_CongTy] FOREIGN KEY([MaCongTy])
REFERENCES [dbo].[CongTy] ([MaCongTy])
GO
ALTER TABLE [dbo].[DanhMucTour] CHECK CONSTRAINT [FK_DanhMucTour_CongTy]
GO
ALTER TABLE [dbo].[DanhMucTour]  WITH CHECK ADD  CONSTRAINT [FK_DanhMucTour_Mua] FOREIGN KEY([MaMua])
REFERENCES [dbo].[Mua] ([MaMua])
GO
ALTER TABLE [dbo].[DanhMucTour] CHECK CONSTRAINT [FK_DanhMucTour_Mua]
GO
ALTER TABLE [dbo].[DanhMucTour]  WITH CHECK ADD  CONSTRAINT [FK_DanhMucTour_PhamVi] FOREIGN KEY([MaPhamVi])
REFERENCES [dbo].[PhamVi] ([MaPhamVi])
GO
ALTER TABLE [dbo].[DanhMucTour] CHECK CONSTRAINT [FK_DanhMucTour_PhamVi]
GO
ALTER TABLE [dbo].[HDV-NgoaiNgu]  WITH CHECK ADD  CONSTRAINT [FK_HDV-NgoaiNgu_HuongDanVien] FOREIGN KEY([MaHDV])
REFERENCES [dbo].[HuongDanVien] ([MaHDV])
GO
ALTER TABLE [dbo].[HDV-NgoaiNgu] CHECK CONSTRAINT [FK_HDV-NgoaiNgu_HuongDanVien]
GO
ALTER TABLE [dbo].[HDV-NgoaiNgu]  WITH CHECK ADD  CONSTRAINT [FK_HDV-NgoaiNgu_NgoaiNgu] FOREIGN KEY([MaNN])
REFERENCES [dbo].[NgoaiNgu] ([MaNN])
GO
ALTER TABLE [dbo].[HDV-NgoaiNgu] CHECK CONSTRAINT [FK_HDV-NgoaiNgu_NgoaiNgu]
GO
ALTER TABLE [dbo].[HDV-NgoaiNgu]  WITH CHECK ADD  CONSTRAINT [FK_HDV-NgoaiNgu_XepLoai] FOREIGN KEY([MaXepLoai])
REFERENCES [dbo].[XepLoai] ([MaXepLoai])
GO
ALTER TABLE [dbo].[HDV-NgoaiNgu] CHECK CONSTRAINT [FK_HDV-NgoaiNgu_XepLoai]
GO
ALTER TABLE [dbo].[HuongDanVien]  WITH CHECK ADD  CONSTRAINT [FK_HuongDanVien_CongTy] FOREIGN KEY([MaCongTy])
REFERENCES [dbo].[CongTy] ([MaCongTy])
GO
ALTER TABLE [dbo].[HuongDanVien] CHECK CONSTRAINT [FK_HuongDanVien_CongTy]
GO
ALTER TABLE [dbo].[HuongDanVien]  WITH CHECK ADD  CONSTRAINT [FK_HuongDanVien_Tinh] FOREIGN KEY([MaTinh])
REFERENCES [dbo].[Tinh] ([MaTinh])
GO
ALTER TABLE [dbo].[HuongDanVien] CHECK CONSTRAINT [FK_HuongDanVien_Tinh]
GO
ALTER TABLE [dbo].[HuongDanVien]  WITH CHECK ADD  CONSTRAINT [FK_HuongDanVien_TrinhDo] FOREIGN KEY([MaTrinhDo])
REFERENCES [dbo].[TrinhDo] ([MaTrinhDo])
GO
ALTER TABLE [dbo].[HuongDanVien] CHECK CONSTRAINT [FK_HuongDanVien_TrinhDo]
GO
ALTER TABLE [dbo].[HuongDanVien]  WITH CHECK ADD  CONSTRAINT [FK_HuongDanVien_TruongDaoTao] FOREIGN KEY([MaTruongDT])
REFERENCES [dbo].[TruongDaoTao] ([MaTruongDT])
GO
ALTER TABLE [dbo].[HuongDanVien] CHECK CONSTRAINT [FK_HuongDanVien_TruongDaoTao]
GO
ALTER TABLE [dbo].[LichTour]  WITH CHECK ADD  CONSTRAINT [FK_LichTour_CongTy] FOREIGN KEY([MaCongTy])
REFERENCES [dbo].[CongTy] ([MaCongTy])
GO
ALTER TABLE [dbo].[LichTour] CHECK CONSTRAINT [FK_LichTour_CongTy]
GO
ALTER TABLE [dbo].[LichTour]  WITH CHECK ADD  CONSTRAINT [FK_LichTour_DanhMucTour] FOREIGN KEY([MaTour])
REFERENCES [dbo].[DanhMucTour] ([MaTour])
GO
ALTER TABLE [dbo].[LichTour] CHECK CONSTRAINT [FK_LichTour_DanhMucTour]
GO
