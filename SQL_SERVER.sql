-- Tạo cơ sở dữ liệu DB_QL_PKDT
CREATE DATABASE DB_QL_PKDT
GO

USE DB_QL_PKDT
GO


-- Tạo bảng KHACHANG
CREATE TABLE KHACHHANG
(
    MAKH CHAR(10) NOT NULL,
    TENKH NVARCHAR(50),
    EMAIL CHAR(50),
    SDT CHAR(15),
    DIACHI NVARCHAR(50),
    PASSW NVARCHAR(50),  
    CONSTRAINT PK_KHACHHANG PRIMARY KEY (MAKH)
)

-- Tạo bảng DANHMUC
CREATE TABLE DANHMUC
(
    MADM CHAR(10) NOT NULL,
    TENDM NVARCHAR(50),
    CONSTRAINT PK_DANHMUC PRIMARY KEY (MADM)
)

-- Tạo bảng SANPHAM
CREATE TABLE SANPHAM
(
    MASP CHAR(10) NOT NULL,
    TENSP NVARCHAR(50),
    MOTA NVARCHAR(200),
    GIA FLOAT,
    SLTONKHO INT,
    MADM CHAR(10),
    CONSTRAINT PK_SANPHAM PRIMARY KEY (MASP),
    CONSTRAINT FK_SANPHAM_DANHMUC FOREIGN KEY(MADM) REFERENCES DANHMUC(MADM)
)

-- Tạo bảng HOADON
CREATE TABLE HOADON
(
    MAHD CHAR(10) NOT NULL,
    MAKH CHAR(10),
    NGAYDATHANG DATE,
    TONGTIEN FLOAT,
    CONSTRAINT PK_HOADON PRIMARY KEY (MAHD),
    CONSTRAINT FK_KHACHHANG_HOADON FOREIGN KEY(MAKH) REFERENCES KHACHANG(MAKH)
)

-- Tạo bảng CHITIETHOADON
CREATE TABLE CHITIETHOADON
(
    MAHD CHAR(10) NOT NULL,
    MASP CHAR(10) NOT NULL,
    SOLUONG INT,
    GIA FLOAT,
    CONSTRAINT PK_CHITIETHOADON PRIMARY KEY (MAHD, MASP),
    CONSTRAINT FK_SANPHAM_CHITIETHOADON FOREIGN KEY(MASP) REFERENCES SANPHAM(MASP),
    CONSTRAINT FK_HOADON_CHITIETHOADON FOREIGN KEY(MAHD) REFERENCES HOADON(MAHD)
)

-- Chèn dữ liệu mẫu vào bảng KHACHANG
INSERT INTO KHACHHANG (MAKH, TENKH, EMAIL, SDT, DIACHI, PASSW) VALUES
('KH001', N'Nguyễn Văn A', 'vana@example.com', '0123456789', N'Hà Nội', 'pass123'),
('KH002', N'Trần Thị B', 'thib@example.com', '0123456790', N'Hồ Chí Minh', 'pass456'),
('KH003', N'Lê Văn C', 'le.c@example.com', '0123456711', N'Đà Nẵng', 'pass789'),
('KH004', N'Phạm Văn D', 'pham.d@example.com', '0123456722', N'Huế', 'pass012'),
('KH005', N'Vũ Thị E', 'vu.e@example.com', '0123456733', N'Hải Phòng', 'pass345'),
('KH006', N'Trịnh Văn F', 'trinh.f@example.com', '0123456744', N'Bình Định', 'pass678'),
('KH007', N'Hoàng Thị G', 'hoang.g@example.com', '0123456755', N'Quảng Nam', 'pass901'),
('KH008', N'Đinh Thị H', 'dinh.h@example.com', '0123456766', N'Nam Định', 'pass234'),
('KH009', N'Lý Văn I', 'ly.i@example.com', '0123456777', N'Lạng Sơn', 'pass567'),
('KH010', N'Đào Thị K', 'dao.k@example.com', '0123456788', N'Hà Giang', 'pass890');

-- Chèn dữ liệu mẫu vào bảng DANHMUC
INSERT INTO DANHMUC (MADM, TENDM) VALUES
('DM001', N'Phụ kiện điện thoại'),
('DM002', N'Tai nghe'),
('DM003', N'Sạc pin'),
('DM004', N'Ốp lưng điện thoại'),
('DM005', N'Cáp sạc'),
('DM006', N'Miếng dán màn hình'),
('DM007', N'Loa Bluetooth'),
('DM008', N'Bộ nhớ ngoài'),
('DM009', N'Pin dự phòng'),
('DM010', N'Bút cảm ứng');

-- Chèn dữ liệu mẫu vào bảng SANPHAM (đã xóa ANHSP)
INSERT INTO SANPHAM (MASP, TENSP, MOTA, GIA, SLTONKHO, MADM) VALUES
('SP001', N'Tai nghe Bluetooth', N'Tai nghe không dây', 500000, 100, 'DM002'),
('SP002', N'Sạc nhanh 20W', N'Sạc nhanh cho điện thoại', 300000, 150, 'DM003'),
('SP003', N'Ốp lưng iPhone 13', N'Ốp lưng chống sốc', 100000, 200, 'DM004'),
('SP004', N'Cáp sạc USB-C', N'Cáp sạc nhanh USB-C', 200000, 300, 'DM005'),
('SP005', N'Miếng dán màn hình Galaxy S21', N'Miếng dán màn hình cường lực', 50000, 250, 'DM006'),
('SP006', N'Loa Bluetooth JBL', N'Loa di động Bluetooth', 1500000, 50, 'DM007'),
('SP007', N'Thẻ nhớ 128GB', N'Thẻ nhớ microSD 128GB', 300000, 180, 'DM008'),
('SP008', N'Pin dự phòng 10,000mAh', N'Pin dự phòng dung lượng cao', 600000, 75, 'DM009'),
('SP009', N'Bút cảm ứng Apple Pencil', N'Bút cảm ứng chính hãng Apple', 2000000, 40, 'DM010'),
('SP010', N'Ốp lưng Samsung S21', N'Ốp lưng silicone mềm', 120000, 180, 'DM004');

-- Chèn dữ liệu mẫu vào bảng HOADON
INSERT INTO HOADON (MAHD, MAKH, NGAYDATHANG, TONGTIEN) VALUES
('HD001', 'KH001', '2024-01-01', 0),
('HD002', 'KH002', '2024-01-02', 0),
('HD003', 'KH003', '2024-01-03', 0),
('HD004', 'KH004', '2024-01-04', 0),
('HD005', 'KH005', '2024-01-05', 0),
('HD006', 'KH006', '2024-01-06', 0),
('HD007', 'KH007', '2024-01-07', 0),
('HD008', 'KH008', '2024-01-08', 0),
('HD009', 'KH009', '2024-01-09', 0),
('HD010', 'KH010', '2024-01-10', 0);

-- Chèn dữ liệu mẫu vào bảng CHITIETHOADON
INSERT INTO CHITIETHOADON (MAHD, MASP, SOLUONG) VALUES
('HD001', 'SP001', 2),
('HD001', 'SP003', 1),
('HD002', 'SP002', 1),
('HD002', 'SP005', 3),
('HD003', 'SP006', 1),
('HD003', 'SP007', 2),
('HD004', 'SP008', 2),
('HD004', 'SP009', 1),
('HD005', 'SP001', 1),
('HD005', 'SP004', 2),
('HD006', 'SP005', 1),
('HD006', 'SP006', 1),
('HD007', 'SP002', 1),
('HD007', 'SP003', 1),
('HD008', 'SP004', 2),
('HD008', 'SP010', 1),
('HD009', 'SP007', 2),
('HD009', 'SP008', 1),
('HD010', 'SP009', 1),
('HD010', 'SP010', 3);