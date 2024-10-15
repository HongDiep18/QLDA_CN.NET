USE [Nhom7_CuaHangPhuKienDienThoai]
GO
/****** Object:  Table [dbo].[CHITIETHOADON]    Script Date: 10/15/2024 11:52:38 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CHITIETHOADON](
	[MAHD] [char](10) NOT NULL,
	[MASP] [char](10) NOT NULL,
	[SOLUONG] [int] NULL,
	[GIA] [float] NULL,
 CONSTRAINT [PK_CHITIETHOADON] PRIMARY KEY CLUSTERED 
(
	[MAHD] ASC,
	[MASP] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[CHITIETPN]    Script Date: 10/15/2024 11:52:38 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CHITIETPN](
	[MAPN] [char](10) NOT NULL,
	[MASP] [char](10) NOT NULL,
	[SL] [int] NULL,
	[GIA] [float] NULL,
	[THANHTIEN] [float] NULL,
 CONSTRAINT [PK_CHITIETPN] PRIMARY KEY CLUSTERED 
(
	[MAPN] ASC,
	[MASP] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[DANHMUC]    Script Date: 10/15/2024 11:52:38 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DANHMUC](
	[MADM] [char](10) NOT NULL,
	[TENDM] [nvarchar](50) NULL,
 CONSTRAINT [PK_DANHMUC] PRIMARY KEY CLUSTERED 
(
	[MADM] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[HOADON]    Script Date: 10/15/2024 11:52:38 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[HOADON](
	[MAHD] [char](10) NOT NULL,
	[MAKH] [char](10) NULL,
	[NGAYDATHANG] [date] NULL,
	[TONGTIEN] [float] NULL,
	[GIAMGIA] [float] NULL,
	[PHAITRA] [float] NULL,
 CONSTRAINT [PK_HOADON] PRIMARY KEY CLUSTERED 
(
	[MAHD] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[KHACHANG]    Script Date: 10/15/2024 11:52:38 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[KHACHANG](
	[MAKH] [char](10) NOT NULL,
	[TENKH] [nvarchar](50) NULL,
	[EMAIL] [char](50) NULL,
	[SDT] [char](15) NULL,
	[DIACHI] [nvarchar](50) NULL,
 CONSTRAINT [PK_KHACHHANG] PRIMARY KEY CLUSTERED 
(
	[MAKH] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[NHACC]    Script Date: 10/15/2024 11:52:38 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NHACC](
	[MANCC] [char](10) NOT NULL,
	[TENNCC] [nvarchar](50) NULL,
	[DIACHI] [nvarchar](100) NULL,
	[SDT] [char](15) NULL,
	[EMAIL] [char](20) NULL,
 CONSTRAINT [PK_NCC] PRIMARY KEY CLUSTERED 
(
	[MANCC] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[NHANVIEN]    Script Date: 10/15/2024 11:52:38 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NHANVIEN](
	[MANV] [char](10) NOT NULL,
	[TENNV] [nvarchar](50) NULL,
	[CHUCVU] [char](20) NULL,
	[SDT] [char](15) NULL,
	[EMAIL] [char](30) NULL,
	[LUONG] [float] NULL,
	[MATKHAU] [char](20) NULL,
 CONSTRAINT [PK_NHANVIEN] PRIMARY KEY CLUSTERED 
(
	[MANV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PHIEUNHAP]    Script Date: 10/15/2024 11:52:38 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PHIEUNHAP](
	[MAPN] [char](10) NOT NULL,
	[MANCC] [char](10) NULL,
	[NGAYNHAP] [date] NULL,
	[TONGTIEN] [float] NULL,
 CONSTRAINT [PK_PHIEUNNHAP] PRIMARY KEY CLUSTERED 
(
	[MAPN] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[SANPHAM]    Script Date: 10/15/2024 11:52:38 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SANPHAM](
	[MASP] [char](10) NOT NULL,
	[TENSP] [nvarchar](50) NULL,
	[MOTA] [nvarchar](200) NULL,
	[GIA] [float] NULL,
	[SLTONKHO] [int] NULL,
	[MADM] [char](10) NULL,
 CONSTRAINT [PK_SANPHAM] PRIMARY KEY CLUSTERED 
(
	[MASP] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[CHITIETHOADON] ([MAHD], [MASP], [SOLUONG], [GIA]) VALUES (N'HD001     ', N'SP008     ', 1, 420000)
INSERT [dbo].[CHITIETHOADON] ([MAHD], [MASP], [SOLUONG], [GIA]) VALUES (N'HD002     ', N'SP005     ', 1, 100000)
INSERT [dbo].[CHITIETHOADON] ([MAHD], [MASP], [SOLUONG], [GIA]) VALUES (N'HD002     ', N'SP006     ', 1, 120000)
INSERT [dbo].[CHITIETHOADON] ([MAHD], [MASP], [SOLUONG], [GIA]) VALUES (N'HD002     ', N'SP007     ', 1, 300000)
INSERT [dbo].[CHITIETHOADON] ([MAHD], [MASP], [SOLUONG], [GIA]) VALUES (N'HD002     ', N'SP008     ', 1, 420000)
INSERT [dbo].[CHITIETHOADON] ([MAHD], [MASP], [SOLUONG], [GIA]) VALUES (N'HD003     ', N'SP004     ', 1, 500000)
INSERT [dbo].[CHITIETHOADON] ([MAHD], [MASP], [SOLUONG], [GIA]) VALUES (N'HD004     ', N'SP001     ', 1, 100000)
INSERT [dbo].[CHITIETHOADON] ([MAHD], [MASP], [SOLUONG], [GIA]) VALUES (N'HD004     ', N'SP002     ', 1, 120000)
GO
INSERT [dbo].[CHITIETPN] ([MAPN], [MASP], [SL], [GIA], [THANHTIEN]) VALUES (N'PN001     ', N'SP005     ', 10, 100000, 1000000)
INSERT [dbo].[CHITIETPN] ([MAPN], [MASP], [SL], [GIA], [THANHTIEN]) VALUES (N'PN001     ', N'SP006     ', 10, 100000, 1000000)
INSERT [dbo].[CHITIETPN] ([MAPN], [MASP], [SL], [GIA], [THANHTIEN]) VALUES (N'PN001     ', N'SP007     ', 10, 100000, 1000000)
INSERT [dbo].[CHITIETPN] ([MAPN], [MASP], [SL], [GIA], [THANHTIEN]) VALUES (N'PN001     ', N'SP008     ', 10, 100000, 1000000)
INSERT [dbo].[CHITIETPN] ([MAPN], [MASP], [SL], [GIA], [THANHTIEN]) VALUES (N'PNN004    ', N'SP001     ', 10, 200000, 2000000)
INSERT [dbo].[CHITIETPN] ([MAPN], [MASP], [SL], [GIA], [THANHTIEN]) VALUES (N'PNN004    ', N'SP002     ', 10, 200000, 2000000)
INSERT [dbo].[CHITIETPN] ([MAPN], [MASP], [SL], [GIA], [THANHTIEN]) VALUES (N'PNN004    ', N'SP004     ', 10, 200000, 2000000)
INSERT [dbo].[CHITIETPN] ([MAPN], [MASP], [SL], [GIA], [THANHTIEN]) VALUES (N'PNN004    ', N'SP009     ', 10, 200000, 2000000)
INSERT [dbo].[CHITIETPN] ([MAPN], [MASP], [SL], [GIA], [THANHTIEN]) VALUES (N'PNN004    ', N'SP015     ', 10, 200000, 2000000)
INSERT [dbo].[CHITIETPN] ([MAPN], [MASP], [SL], [GIA], [THANHTIEN]) VALUES (N'PNN004    ', N'SP016     ', 10, 200000, 2000000)
INSERT [dbo].[CHITIETPN] ([MAPN], [MASP], [SL], [GIA], [THANHTIEN]) VALUES (N'PNN004    ', N'SP018     ', 10, 200000, 2000000)
INSERT [dbo].[CHITIETPN] ([MAPN], [MASP], [SL], [GIA], [THANHTIEN]) VALUES (N'PNN004    ', N'SP019     ', 10, 200000, 2000000)
INSERT [dbo].[CHITIETPN] ([MAPN], [MASP], [SL], [GIA], [THANHTIEN]) VALUES (N'PNN004    ', N'SP020     ', 10, 200000, 2000000)
GO
INSERT [dbo].[DANHMUC] ([MADM], [TENDM]) VALUES (N'DM001     ', N'Tai Nghe')
INSERT [dbo].[DANHMUC] ([MADM], [TENDM]) VALUES (N'DM002     ', N'Ốp Lưng Điện Thoại')
INSERT [dbo].[DANHMUC] ([MADM], [TENDM]) VALUES (N'DM003     ', N'Kính cường lực')
INSERT [dbo].[DANHMUC] ([MADM], [TENDM]) VALUES (N'DM004     ', N'Sạc dự phòng')
INSERT [dbo].[DANHMUC] ([MADM], [TENDM]) VALUES (N'DM005     ', N'Cáp sạc')
INSERT [dbo].[DANHMUC] ([MADM], [TENDM]) VALUES (N'DM006     ', N'Đế sạc không dây')
INSERT [dbo].[DANHMUC] ([MADM], [TENDM]) VALUES (N'DM007     ', N'Bộ chuyển đổi âm thanh')
INSERT [dbo].[DANHMUC] ([MADM], [TENDM]) VALUES (N'DM008     ', N'Giá đỡ điện thoại')
INSERT [dbo].[DANHMUC] ([MADM], [TENDM]) VALUES (N'DM009     ', N'Balo/ Túi đựng điện thoại')
INSERT [dbo].[DANHMUC] ([MADM], [TENDM]) VALUES (N'DM010     ', N'Bộ phụ kiện chụp ảnh')
GO
INSERT [dbo].[HOADON] ([MAHD], [MAKH], [NGAYDATHANG], [TONGTIEN], [GIAMGIA], [PHAITRA]) VALUES (N'HD001     ', N'KH007     ', CAST(N'2024-10-15' AS Date), 420000, 0, 420000)
INSERT [dbo].[HOADON] ([MAHD], [MAKH], [NGAYDATHANG], [TONGTIEN], [GIAMGIA], [PHAITRA]) VALUES (N'HD002     ', N'KH007     ', CAST(N'2024-10-15' AS Date), 940000, 0, 940000)
INSERT [dbo].[HOADON] ([MAHD], [MAKH], [NGAYDATHANG], [TONGTIEN], [GIAMGIA], [PHAITRA]) VALUES (N'HD003     ', N'KH007     ', CAST(N'2024-10-15' AS Date), 500000, 0, 500000)
INSERT [dbo].[HOADON] ([MAHD], [MAKH], [NGAYDATHANG], [TONGTIEN], [GIAMGIA], [PHAITRA]) VALUES (N'HD004     ', N'KH010     ', CAST(N'2024-10-15' AS Date), 220000, 0, 220000)
GO
INSERT [dbo].[KHACHANG] ([MAKH], [TENKH], [EMAIL], [SDT], [DIACHI]) VALUES (N'KH002     ', N'Trần Thị B', N'tranthib@example.com                              ', N'0987654321     ', N'456 Đường DEF, Quận 2, TP.HCM')
INSERT [dbo].[KHACHANG] ([MAKH], [TENKH], [EMAIL], [SDT], [DIACHI]) VALUES (N'KH003     ', N'Lê Văn C', N'levanc@example.com                                ', N'0123456780     ', N'789 Đường GHI, Quận 3, TP.HCM')
INSERT [dbo].[KHACHANG] ([MAKH], [TENKH], [EMAIL], [SDT], [DIACHI]) VALUES (N'KH004     ', N'Phạm Thị D', N'phamthid@example.com                              ', N'0987654310     ', N'321 Đường JKL, Quận 4, TP.HCM')
INSERT [dbo].[KHACHANG] ([MAKH], [TENKH], [EMAIL], [SDT], [DIACHI]) VALUES (N'KH005     ', N'Hoàng Văn E', N'hoangvane@example.com                             ', N'0123456798     ', N'654 Đường MNO, Quận 5, TP.HCM')
INSERT [dbo].[KHACHANG] ([MAKH], [TENKH], [EMAIL], [SDT], [DIACHI]) VALUES (N'KH006     ', N'Nguyễn Thị F', N'nguyenthif@example.com                            ', N'0912345678     ', N'111 Đường PQR, Quận 6, TP.HCM')
INSERT [dbo].[KHACHANG] ([MAKH], [TENKH], [EMAIL], [SDT], [DIACHI]) VALUES (N'KH007     ', N'Trần Văn G', N'tranvang@example.com                              ', N'0923456789     ', N'222 Đường STU, Quận 7, TP.HCM')
INSERT [dbo].[KHACHANG] ([MAKH], [TENKH], [EMAIL], [SDT], [DIACHI]) VALUES (N'KH008     ', N'Lê Thị H', N'lethih@example.com                                ', N'0934567890     ', N'333 Đường VWX, Quận 8, TP.HCM')
INSERT [dbo].[KHACHANG] ([MAKH], [TENKH], [EMAIL], [SDT], [DIACHI]) VALUES (N'KH009     ', N'Phạm Văn I', N'phamvani@example.com                              ', N'0945678901     ', N'444 Đường YZA, Quận 9, TP.HCM')
INSERT [dbo].[KHACHANG] ([MAKH], [TENKH], [EMAIL], [SDT], [DIACHI]) VALUES (N'KH010     ', N'Hoàng Thị J', N'hoangthij@example.com                             ', N'0956789012     ', N'555 Đường BCD, Quận 10, TP.HCM')
INSERT [dbo].[KHACHANG] ([MAKH], [TENKH], [EMAIL], [SDT], [DIACHI]) VALUES (N'KH011     ', N'Nguyễn Văn K', N'nguyenvank@example.com                            ', N'0967890123     ', N'666 Đường EFG, Quận 11, TP.HCM')
INSERT [dbo].[KHACHANG] ([MAKH], [TENKH], [EMAIL], [SDT], [DIACHI]) VALUES (N'KH012     ', N'Trần Thị L', N'tranthil@example.com                              ', N'0978901234     ', N'777 Đường HIJ, Quận 12, TP.HCM')
INSERT [dbo].[KHACHANG] ([MAKH], [TENKH], [EMAIL], [SDT], [DIACHI]) VALUES (N'KH013     ', N'Lê Văn M', N'levanm@example.com                                ', N'0989012345     ', N'888 Đường KLM, Quận 13, TP.HCM')
INSERT [dbo].[KHACHANG] ([MAKH], [TENKH], [EMAIL], [SDT], [DIACHI]) VALUES (N'KH014     ', N'Phạm Thị N', N'phamthin@example.com                              ', N'0990123456     ', N'999 Đường NOP, Quận 14, TP.HCM')
GO
INSERT [dbo].[NHACC] ([MANCC], [TENNCC], [DIACHI], [SDT], [EMAIL]) VALUES (N'NCC001    ', N'Công ty TNHH ABC', N'123 Đường A, Quận 1, TP.HCM', N'0123456789     ', N'info@abc.com        ')
INSERT [dbo].[NHACC] ([MANCC], [TENNCC], [DIACHI], [SDT], [EMAIL]) VALUES (N'NCC002    ', N'Công ty CP XYZ', N'456 Đường B, Quận 2, TP.HCM', N'0987654321     ', N'contact@xyz.com     ')
INSERT [dbo].[NHACC] ([MANCC], [TENNCC], [DIACHI], [SDT], [EMAIL]) VALUES (N'NCC003    ', N'Công ty TNHH DEF', N'789 Đường C, Quận 3, TP.HCM', N'0123456790     ', N'support@def.com     ')
INSERT [dbo].[NHACC] ([MANCC], [TENNCC], [DIACHI], [SDT], [EMAIL]) VALUES (N'NCC004    ', N'Công ty cổ phần GHI', N'321 Đường D, Quận 4, TP.HCM', N'0987654310     ', N'sales@ghi.com       ')
INSERT [dbo].[NHACC] ([MANCC], [TENNCC], [DIACHI], [SDT], [EMAIL]) VALUES (N'NCC005    ', N'Công ty TNHH JKL', N'654 Đường E, Quận 5, TP.HCM', N'0123456780     ', N'hello@jkl.com       ')
INSERT [dbo].[NHACC] ([MANCC], [TENNCC], [DIACHI], [SDT], [EMAIL]) VALUES (N'NCC006    ', N'Công ty TNHH MNO', N'111 Đường F, Quận 6, TP.HCM', N'0912345678     ', N'info@mno.com        ')
INSERT [dbo].[NHACC] ([MANCC], [TENNCC], [DIACHI], [SDT], [EMAIL]) VALUES (N'NCC007    ', N'Công ty CP PQR', N'222 Đường G, Quận 7, TP.HCM', N'0923456789     ', N'contact@pqr.com     ')
INSERT [dbo].[NHACC] ([MANCC], [TENNCC], [DIACHI], [SDT], [EMAIL]) VALUES (N'NCC008    ', N'Công ty TNHH STU', N'333 Đường H, Quận 8, TP.HCM', N'0934567890     ', N'support@stu.com     ')
INSERT [dbo].[NHACC] ([MANCC], [TENNCC], [DIACHI], [SDT], [EMAIL]) VALUES (N'NCC009    ', N'Công ty cổ phần VWX', N'444 Đường I, Quận 9, TP.HCM', N'0945678901     ', N'sales@vwx.com       ')
INSERT [dbo].[NHACC] ([MANCC], [TENNCC], [DIACHI], [SDT], [EMAIL]) VALUES (N'NCC010    ', N'Công ty TNHH YZA', N'555 Đường J, Quận 10, TP.HCM', N'0956789012     ', N'hello@yza.com       ')
INSERT [dbo].[NHACC] ([MANCC], [TENNCC], [DIACHI], [SDT], [EMAIL]) VALUES (N'NCC011    ', N'Công ty TNHH BCD', N'666 Đường K, Quận 11, TP.HCM', N'0967890123     ', N'info@bcd.com        ')
INSERT [dbo].[NHACC] ([MANCC], [TENNCC], [DIACHI], [SDT], [EMAIL]) VALUES (N'NCC012    ', N'Công ty CP EFG', N'777 Đường L, Quận 12, TP.HCM', N'0978901234     ', N'contact@efg.com     ')
INSERT [dbo].[NHACC] ([MANCC], [TENNCC], [DIACHI], [SDT], [EMAIL]) VALUES (N'NCC013    ', N'Công ty TNHH HIJ', N'888 Đường M, Quận 13, TP.HCM', N'0989012345     ', N'support@hij.com     ')
INSERT [dbo].[NHACC] ([MANCC], [TENNCC], [DIACHI], [SDT], [EMAIL]) VALUES (N'NCC014    ', N'Công ty cổ phần KLM', N'999 Đường N, Quận 14, TP.HCM', N'0990123456     ', N'sales@klm.com       ')
INSERT [dbo].[NHACC] ([MANCC], [TENNCC], [DIACHI], [SDT], [EMAIL]) VALUES (N'NCC015    ', N'Công ty TNHH NOP', N'000 Đường O, Quận 15, TP.HCM', N'0901234567     ', N'hello@nop.com       ')
INSERT [dbo].[NHACC] ([MANCC], [TENNCC], [DIACHI], [SDT], [EMAIL]) VALUES (N'NCC016    ', N'Công ty TNHH MTV124', N'222 Ðu?ng G, Qu?n 7, TP.HCM', N'09234567893    ', N'contact231@pqr.com  ')
GO
INSERT [dbo].[NHANVIEN] ([MANV], [TENNV], [CHUCVU], [SDT], [EMAIL], [LUONG], [MATKHAU]) VALUES (N'NV001     ', N'Nguyễn Văn A', N'NVBH                ', N'0123456789     ', N'nva@example.com               ', 5000000, N'123                 ')
INSERT [dbo].[NHANVIEN] ([MANV], [TENNV], [CHUCVU], [SDT], [EMAIL], [LUONG], [MATKHAU]) VALUES (N'NV002     ', N'Trần Thị B', N'QL                  ', N'0987654321     ', N'ttb@example.com               ', 7000000, N'123                 ')
INSERT [dbo].[NHANVIEN] ([MANV], [TENNV], [CHUCVU], [SDT], [EMAIL], [LUONG], [MATKHAU]) VALUES (N'NV003     ', N'Phạm Văn C', N'NVKHO               ', N'0112233445     ', N'pvc@example.com               ', 9000000, N'123                 ')
GO
INSERT [dbo].[PHIEUNHAP] ([MAPN], [MANCC], [NGAYNHAP], [TONGTIEN]) VALUES (N'PN001     ', N'NCC003    ', CAST(N'2024-10-15' AS Date), 4000000)
INSERT [dbo].[PHIEUNHAP] ([MAPN], [MANCC], [NGAYNHAP], [TONGTIEN]) VALUES (N'PNN004    ', N'NCC007    ', CAST(N'2024-10-15' AS Date), 18000000)
GO
INSERT [dbo].[SANPHAM] ([MASP], [TENSP], [MOTA], [GIA], [SLTONKHO], [MADM]) VALUES (N'SP001     ', N'Ốp Lưng SSGLS 23', N'Dành Cho SamSung S23', 100000, 9, N'DM002     ')
INSERT [dbo].[SANPHAM] ([MASP], [TENSP], [MOTA], [GIA], [SLTONKHO], [MADM]) VALUES (N'SP002     ', N'Ốp lưng silicone cho iPhone 14', N'Dành cho Iphone 14 PRM', 120000, 9, N'DM002     ')
INSERT [dbo].[SANPHAM] ([MASP], [TENSP], [MOTA], [GIA], [SLTONKHO], [MADM]) VALUES (N'SP003     ', N'Tai nghe Bluetooth Sony WH-1000XM4', N'Tai nghe không dây kết nối blt50', 200000, 0, N'DM001     ')
INSERT [dbo].[SANPHAM] ([MASP], [TENSP], [MOTA], [GIA], [SLTONKHO], [MADM]) VALUES (N'SP004     ', N'Tai nghe in-ear Apple AirPods Pro', N'Dành cho Iphone kết nối không dây', 500000, 9, N'DM001     ')
INSERT [dbo].[SANPHAM] ([MASP], [TENSP], [MOTA], [GIA], [SLTONKHO], [MADM]) VALUES (N'SP005     ', N'Cáp sạc Lightning cho iPhone', N'Dành cho Iphone 15W', 100000, 9, N'DM005     ')
INSERT [dbo].[SANPHAM] ([MASP], [TENSP], [MOTA], [GIA], [SLTONKHO], [MADM]) VALUES (N'SP006     ', N'Cáp sạc USB-C cho Android', N'Dành cho Android 50W', 120000, 9, N'DM005     ')
INSERT [dbo].[SANPHAM] ([MASP], [TENSP], [MOTA], [GIA], [SLTONKHO], [MADM]) VALUES (N'SP007     ', N'Đế sạc không dây Samsung Fast Charge', N'Hỗ trợ đầy đủ thiết bị android', 300000, 9, N'DM006     ')
INSERT [dbo].[SANPHAM] ([MASP], [TENSP], [MOTA], [GIA], [SLTONKHO], [MADM]) VALUES (N'SP008     ', N'Đế sạc không dây Anker PowerWave', N'An toàn cho mọi thiết bị', 420000, 8, N'DM006     ')
INSERT [dbo].[SANPHAM] ([MASP], [TENSP], [MOTA], [GIA], [SLTONKHO], [MADM]) VALUES (N'SP009     ', N'Bộ chuyển đổi USB-C sang jack 3.5mm', N'Hỗ trợ cắm ti nghe', 120000, 10, N'DM007     ')
INSERT [dbo].[SANPHAM] ([MASP], [TENSP], [MOTA], [GIA], [SLTONKHO], [MADM]) VALUES (N'SP010     ', N'Bộ chuyển đổi Lightning sang jack 3.5mm', N'Dành cho Iphone', 120000, 0, N'DM007     ')
INSERT [dbo].[SANPHAM] ([MASP], [TENSP], [MOTA], [GIA], [SLTONKHO], [MADM]) VALUES (N'SP011     ', N'Giá đỡ để bàn cho điện thoại', N'Dành cho Bàn cố định', 120000, 0, N'DM008     ')
INSERT [dbo].[SANPHAM] ([MASP], [TENSP], [MOTA], [GIA], [SLTONKHO], [MADM]) VALUES (N'SP012     ', N'Giá đỡ điện thoại gắn xe hơi', N'Dành cho hỗ trợ trên xe oto', 220000, 0, N'DM008     ')
INSERT [dbo].[SANPHAM] ([MASP], [TENSP], [MOTA], [GIA], [SLTONKHO], [MADM]) VALUES (N'SP013     ', N'Lens macro cho điện thoại', N'Dành cho Thiết bị di động', 420000, 0, N'DM010     ')
INSERT [dbo].[SANPHAM] ([MASP], [TENSP], [MOTA], [GIA], [SLTONKHO], [MADM]) VALUES (N'SP014     ', N'Tripod mini cho điện thoại', N'Dành cho Thiết bị di động', 320000, 0, N'DM010     ')
INSERT [dbo].[SANPHAM] ([MASP], [TENSP], [MOTA], [GIA], [SLTONKHO], [MADM]) VALUES (N'SP015     ', N'Balo đa năng cho điện thoại và laptop', N'Không chống nước', 120000, 10, N'DM009     ')
INSERT [dbo].[SANPHAM] ([MASP], [TENSP], [MOTA], [GIA], [SLTONKHO], [MADM]) VALUES (N'SP016     ', N'Túi đeo chéo chống nước đựng điện thoại', N'Chống nước', 220000, 10, N'DM009     ')
INSERT [dbo].[SANPHAM] ([MASP], [TENSP], [MOTA], [GIA], [SLTONKHO], [MADM]) VALUES (N'SP017     ', N'Kính Cường Lực 9H cho iPhone 14', N'Dành cho Iphone 14 PRM', 20000, 0, N'DM003     ')
INSERT [dbo].[SANPHAM] ([MASP], [TENSP], [MOTA], [GIA], [SLTONKHO], [MADM]) VALUES (N'SP018     ', N'Kính Cường Lực Full Màn cho Galaxy S22', N' Thiết kế ôm sát, bảo vệ toàn màn hình.', 40000, 10, N'DM003     ')
INSERT [dbo].[SANPHAM] ([MASP], [TENSP], [MOTA], [GIA], [SLTONKHO], [MADM]) VALUES (N'SP019     ', N'Sạc Dự Phòng 10000mAh Anker', N'10000mAh, đủ để sạc đầy hầu hết smartphone từ 1 đến 2 lần.', 520000, 10, N'DM004     ')
INSERT [dbo].[SANPHAM] ([MASP], [TENSP], [MOTA], [GIA], [SLTONKHO], [MADM]) VALUES (N'SP020     ', N'Sạc Dự Phòng Kiêm Đèn Pin Xiaomi', N'20000mAh, phù hợp cho các chuyến đi dài.', 320000, 10, N'DM004     ')
GO
ALTER TABLE [dbo].[CHITIETHOADON]  WITH CHECK ADD  CONSTRAINT [FK_HOADON_CHITIETHOADON] FOREIGN KEY([MAHD])
REFERENCES [dbo].[HOADON] ([MAHD])
GO
ALTER TABLE [dbo].[CHITIETHOADON] CHECK CONSTRAINT [FK_HOADON_CHITIETHOADON]
GO
ALTER TABLE [dbo].[CHITIETHOADON]  WITH CHECK ADD  CONSTRAINT [FK_SANPHAM_CHITIETHOADON] FOREIGN KEY([MASP])
REFERENCES [dbo].[SANPHAM] ([MASP])
GO
ALTER TABLE [dbo].[CHITIETHOADON] CHECK CONSTRAINT [FK_SANPHAM_CHITIETHOADON]
GO
ALTER TABLE [dbo].[CHITIETPN]  WITH CHECK ADD  CONSTRAINT [FK_PHIEUNHAP_CHITIETPN] FOREIGN KEY([MAPN])
REFERENCES [dbo].[PHIEUNHAP] ([MAPN])
GO
ALTER TABLE [dbo].[CHITIETPN] CHECK CONSTRAINT [FK_PHIEUNHAP_CHITIETPN]
GO
ALTER TABLE [dbo].[CHITIETPN]  WITH CHECK ADD  CONSTRAINT [FK_SANPHAM_CHITIETPN] FOREIGN KEY([MASP])
REFERENCES [dbo].[SANPHAM] ([MASP])
GO
ALTER TABLE [dbo].[CHITIETPN] CHECK CONSTRAINT [FK_SANPHAM_CHITIETPN]
GO
ALTER TABLE [dbo].[HOADON]  WITH CHECK ADD  CONSTRAINT [FK_KHACHHANG_HOADON] FOREIGN KEY([MAKH])
REFERENCES [dbo].[KHACHANG] ([MAKH])
GO
ALTER TABLE [dbo].[HOADON] CHECK CONSTRAINT [FK_KHACHHANG_HOADON]
GO
ALTER TABLE [dbo].[PHIEUNHAP]  WITH CHECK ADD  CONSTRAINT [FK_PHIEUNHAP_NCC] FOREIGN KEY([MANCC])
REFERENCES [dbo].[NHACC] ([MANCC])
GO
ALTER TABLE [dbo].[PHIEUNHAP] CHECK CONSTRAINT [FK_PHIEUNHAP_NCC]
GO
ALTER TABLE [dbo].[SANPHAM]  WITH CHECK ADD  CONSTRAINT [FK_SANPHAM_DANHMUC] FOREIGN KEY([MADM])
REFERENCES [dbo].[DANHMUC] ([MADM])
GO
ALTER TABLE [dbo].[SANPHAM] CHECK CONSTRAINT [FK_SANPHAM_DANHMUC]
GO
