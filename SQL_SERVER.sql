CREATE TABLE KHACHANG
(
	MAKH CHAR(10) NOT NULL,
	TENKH NVARCHAR (50),
	EMAIL CHAR(50),
	SDT CHAR (15),
	DIACHI NVARCHAR (50)
	CONSTRAINT PK_KHACHHANG PRIMARY KEY (MAKH)
)
CREATE TABLE DANHMUC
(
	MADM CHAR(10) NOT NULL,
	TENDM NVARCHAR (50),
	
	CONSTRAINT PK_DANHMUC PRIMARY KEY (MADM)
)

CREATE TABLE SANPHAM
(
	MASP CHAR(10) NOT NULL,
	TENSP NVARCHAR (50),
	MOTA NVARCHAR(200),
	GIA FLOAT,
	SLTONKHO INT,
	MADM CHAR(10)

	CONSTRAINT PK_SANPHAM PRIMARY KEY (MASP),
	CONSTRAINT FK_SANPHAM_DANHMUC FOREIGN KEY(MADM) REFERENCES DANHMUC(MADM)
)

CREATE TABLE HOADON
(
	MAHD CHAR(10) NOT NULL,
	MAKH CHAR(10) ,
	NGAYDATHANG  DATE,
	TONGTIEN FLOAT,
	CONSTRAINT PK_HOADON PRIMARY KEY (MAHD),
	CONSTRAINT FK_KHACHHANG_HOADON FOREIGN KEY(MAKH) REFERENCES KHACHANG(MAKH)
)

CREATE TABLE CHITIETHOADON
(
	MAHD CHAR(10) NOT NULL,
	MASP CHAR(10) NOT NULL,
	SOLUONG INT,
	GIA FLOAT,
	CONSTRAINT PK_CHITIETHOADON PRIMARY KEY (MAHD,MASP),
	CONSTRAINT FK_SANPHAM_CHITIETHOADON FOREIGN KEY(MASP) REFERENCES SANPHAM(MASP),
	CONSTRAINT FK_HOADON_CHITIETHOADON FOREIGN KEY(MAHD) REFERENCES HOADON(MAHD)
)
INSERT INTO KHACHANG (MAKH, TENKH, EMAIL, SDT, DIACHI) VALUES
('KH001', 'Nguyễn Văn A', 'vana@example.com', '0123456789', 'Hà Nội'),
('KH002', 'Trần Thị B', 'thib@example.com', '0123456790', 'Hồ Chí Minh'),
('KH003', 'Lê Văn C', 'vanc@example.com', '0123456791', 'Đà Nẵng'),
('KH004', 'Phạm Thị D', 'thid@example.com', '0123456792', 'Nha Trang'),
('KH005', 'Nguyễn Văn E', 'vane@example.com', '0123456793', 'Cần Thơ'),
('KH006', 'Trần Văn F', 'vanf@example.com', '0123456794', 'Hải Phòng'),
('KH007', 'Lê Thị G', 'thig@example.com', '0123456795', 'Biên Hòa'),
('KH008', 'Phạm Văn H', 'vanh@example.com', '0123456796', 'Vũng Tàu'),
('KH009', 'Nguyễn Thị I', 'thi@example.com', '0123456797', 'Bắc Ninh'),
('KH010', 'Trần Văn J', 'vanj@example.com', '0123456798', 'Nam Định'),
('KH011', 'Lê Văn K', 'vank@example.com', '0123456799', 'Quảng Ninh'),
('KH012', 'Phạm Thị L', 'thil@example.com', '0123456700', 'Đồng Nai'),
('KH013', 'Nguyễn Văn M', 'vanm@example.com', '0123456701', 'Thừa Thiên Huế'),
('KH014', 'Trần Thị N', 'thin@example.com', '0123456702', 'Hà Tĩnh'),
('KH015', 'Lê Văn O', 'vano@example.com', '0123456703', 'Hưng Yên'),
('KH016', 'Phạm Thị P', 'thip@example.com', '0123456704', 'Bắc Giang'),
('KH017', 'Nguyễn Văn Q', 'vanq@example.com', '0123456705', 'Ninh Bình'),
('KH018', 'Trần Văn R', 'vanr@example.com', '0123456706', 'Lạng Sơn'),
('KH019', 'Lê Thị S', 'this@example.com', '0123456707', 'Thái Nguyên'),
('KH020', 'Phạm Văn T', 'vant@example.com', '0123456708', 'Kiên Giang');

INSERT INTO DANHMUC (MADM, TENDM) VALUES
('DM001', 'Phụ kiện điện thoại'),
('DM002', 'Tai nghe'),
('DM003', 'Sạc nhanh'),
('DM004', 'Ốp lưng'),
('DM005', 'Kính cường lực'),
('DM006', 'Cáp sạc'),
('DM007', 'Pin dự phòng'),
('DM008', 'Giá đỡ'),
('DM009', 'Móc khóa'),
('DM010', 'Đế tản nhiệt'),
('DM011', 'Bộ vệ sinh'),
('DM012', 'Băng keo dán'),
('DM013', 'Bộ chuyển đổi'),
('DM014', 'Thiết bị điều khiển'),
('DM015', 'Đồng hồ thông minh'),
('DM016', 'Phụ kiện chơi game'),
('DM017', 'Phụ kiện máy ảnh'),
('DM018', 'Phụ kiện xe hơi'),
('DM019', 'Phụ kiện cho trẻ em'),
('DM020', 'Phụ kiện thời trang');

INSERT INTO SANPHAM (MASP, TENSP, MOTA, GIA, SLTONKHO, MADM) VALUES
('SP001', 'Tai nghe Bluetooth', 'Tai nghe không dây', 500000, 100, 'DM002'),
('SP002', 'Sạc nhanh 20W', 'Sạc nhanh cho điện thoại', 300000, 150, 'DM003'),
('SP003', 'Ốp lưng TPU', 'Ốp lưng cho điện thoại', 200000, 200, 'DM004'),
('SP004', 'Kính cường lực', 'Kính bảo vệ màn hình', 150000, 250, 'DM005'),
('SP005', 'Cáp sạc Type-C', 'Cáp sạc nhanh Type-C', 100000, 300, 'DM006'),
('SP006', 'Pin dự phòng 10000mAh', 'Pin dự phòng di động', 400000, 80, 'DM007'),
('SP007', 'Giá đỡ điện thoại', 'Giá đỡ cho điện thoại', 250000, 120, 'DM008'),
('SP008', 'Móc khóa thiết kế', 'Móc khóa thời trang', 50000, 500, 'DM009'),
('SP009', 'Đế tản nhiệt', 'Đế tản nhiệt cho điện thoại', 350000, 60, 'DM010'),
('SP010', 'Bộ vệ sinh điện thoại', 'Bộ vệ sinh màn hình', 70000, 400, 'DM011'),
('SP011', 'Băng keo dán', 'Băng keo dán màn hình', 30000, 600, 'DM012'),
('SP012', 'Bộ chuyển đổi USB-C', 'Chuyển đổi USB-C sang USB', 80000, 350, 'DM013'),
('SP013', 'Thiết bị điều khiển từ xa', 'Điều khiển từ xa cho điện thoại', 450000, 90, 'DM014'),
('SP014', 'Đồng hồ thông minh', 'Đồng hồ thông minh kết nối', 1500000, 40, 'DM015'),
('SP015', 'Phụ kiện chơi game', 'Phụ kiện cho game thủ', 600000, 70, 'DM016'),
('SP016', 'Phụ kiện máy ảnh', 'Phụ kiện cho camera', 800000, 30, 'DM017'),
('SP017', 'Phụ kiện xe hơi', 'Phụ kiện cho ô tô', 900000, 50, 'DM018'),
('SP018', 'Phụ kiện cho trẻ em', 'Phụ kiện an toàn cho trẻ', 200000, 200, 'DM019'),
('SP019', 'Phụ kiện thời trang', 'Phụ kiện thời trang cho điện thoại', 300000, 150, 'DM020'),
('SP020', 'Tai nghe có dây', 'Tai nghe kết nối dây', 150000, 250, 'DM002');






CREATE TRIGGER CAPNHAT_TONGTIEN
ON CHITIETHOADON
FOR INSERT
AS
	UPDATE CHITIETHOADON
	SET GIA=(SELECT GIA FROM SANPHAM WHERE MASP=(SELECT MASP FROM inserted))
	UPDATE HOADON
	SET TONGTIEN=
				(
					SELECT SUM(SOLUONG*GIA)
					FROM CHITIETHOADON
					WHERE MAHD=(SELECT MAHD FROM inserted)
					GROUP BY MAHD
				)
	WHERE MAHD=(SELECT MAHD FROM inserted)

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
('HD010', 'KH010', '2024-01-10', 0),
('HD011', 'KH011', '2024-01-11', 0),
('HD012', 'KH012', '2024-01-12', 0),
('HD013', 'KH013', '2024-01-13', 0),
('HD014', 'KH014', '2024-01-14', 0),
('HD015', 'KH015', '2024-01-15', 0),
('HD016', 'KH016', '2024-01-16', 0),
('HD017', 'KH017', '2024-01-17', 0),
('HD018', 'KH018', '2024-01-18', 0),
('HD019', 'KH019', '2024-01-19', 0),
('HD020', 'KH020', '2024-01-20', 0);

SELECT * FROM HOADON

INSERT INTO CHITIETHOADON (MAHD, MASP, SOLUONG) VALUES('HD001', 'SP001', 2)
INSERT INTO CHITIETHOADON (MAHD, MASP, SOLUONG) VALUES('HD001', 'SP003', 1)
INSERT INTO CHITIETHOADON (MAHD, MASP, SOLUONG) VALUES('HD002', 'SP002', 1)
INSERT INTO CHITIETHOADON (MAHD, MASP, SOLUONG) VALUES('HD002', 'SP004', 2)
INSERT INTO CHITIETHOADON (MAHD, MASP, SOLUONG) VALUES('HD003', 'SP005', 3)
INSERT INTO CHITIETHOADON (MAHD, MASP, SOLUONG) VALUES('HD003', 'SP006', 1)
INSERT INTO CHITIETHOADON (MAHD, MASP, SOLUONG) VALUES('HD004', 'SP007', 1)
INSERT INTO CHITIETHOADON (MAHD, MASP, SOLUONG) VALUES('HD004', 'SP008', 3)
INSERT INTO CHITIETHOADON (MAHD, MASP, SOLUONG) VALUES('HD005', 'SP009', 2)
INSERT INTO CHITIETHOADON (MAHD, MASP, SOLUONG) VALUES('HD005', 'SP010', 1)
INSERT INTO CHITIETHOADON (MAHD, MASP, SOLUONG) VALUES('HD006', 'SP011', 4)
INSERT INTO CHITIETHOADON (MAHD, MASP, SOLUONG) VALUES('HD006', 'SP012', 2)
INSERT INTO CHITIETHOADON (MAHD, MASP, SOLUONG) VALUES('HD007', 'SP013', 1)
INSERT INTO CHITIETHOADON (MAHD, MASP, SOLUONG) VALUES('HD007', 'SP014', 1)
INSERT INTO CHITIETHOADON (MAHD, MASP, SOLUONG) VALUES('HD008', 'SP015', 2)
INSERT INTO CHITIETHOADON (MAHD, MASP, SOLUONG) VALUES('HD008', 'SP016', 1)
INSERT INTO CHITIETHOADON (MAHD, MASP, SOLUONG) VALUES('HD009', 'SP017', 3)
INSERT INTO CHITIETHOADON (MAHD, MASP, SOLUONG) VALUES('HD009', 'SP018', 2)
INSERT INTO CHITIETHOADON (MAHD, MASP, SOLUONG) VALUES('HD010', 'SP019', 1)
INSERT INTO CHITIETHOADON (MAHD, MASP, SOLUONG) VALUES('HD010', 'SP020', 5)