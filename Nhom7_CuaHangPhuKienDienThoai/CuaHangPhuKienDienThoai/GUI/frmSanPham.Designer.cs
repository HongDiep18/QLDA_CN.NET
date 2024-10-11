namespace GUI
{
    partial class frmSanPham
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lst_SanPham = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tab_Xem = new System.Windows.Forms.TabControl();
            this.tab_thanhtoan = new System.Windows.Forms.TabPage();
            this.lstThanhToan = new System.Windows.Forms.ListView();
            this.columnHeader13 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader14 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader15 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader16 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtTienThua = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtPhaiTra = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtGiamGia = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtTongTien = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtTienNhan = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.checkBox_KHThanThiet = new System.Windows.Forms.CheckBox();
            this.btnHuy = new System.Windows.Forms.Button();
            this.btn_XuatHoaDon = new System.Windows.Forms.Button();
            this.btn_thanhtoan1 = new System.Windows.Forms.Button();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtSDT = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtTenKH = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cbo_KH = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tab_MuaHang = new System.Windows.Forms.TabPage();
            this.btn_ThanhToan = new System.Windows.Forms.Button();
            this.btn_Loai = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.lst_GioHang = new System.Windows.Forms.ListView();
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tab_Xem.SuspendLayout();
            this.tab_thanhtoan.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tab_MuaHang.SuspendLayout();
            this.SuspendLayout();
            // 
            // lst_SanPham
            // 
            this.lst_SanPham.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.lst_SanPham.FullRowSelect = true;
            this.lst_SanPham.HideSelection = false;
            this.lst_SanPham.Location = new System.Drawing.Point(10, 40);
            this.lst_SanPham.Name = "lst_SanPham";
            this.lst_SanPham.Size = new System.Drawing.Size(556, 454);
            this.lst_SanPham.TabIndex = 0;
            this.lst_SanPham.UseCompatibleStateImageBehavior = false;
            this.lst_SanPham.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Mã SP";
            this.columnHeader1.Width = 54;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Tên SP";
            this.columnHeader2.Width = 144;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Giá";
            this.columnHeader3.Width = 115;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Mô Tả";
            this.columnHeader4.Width = 231;
            // 
            // tab_Xem
            // 
            this.tab_Xem.Controls.Add(this.tab_thanhtoan);
            this.tab_Xem.Controls.Add(this.tab_MuaHang);
            this.tab_Xem.Controls.Add(this.tabPage1);
            this.tab_Xem.Controls.Add(this.tabPage2);
            this.tab_Xem.Location = new System.Drawing.Point(12, 12);
            this.tab_Xem.Name = "tab_Xem";
            this.tab_Xem.SelectedIndex = 0;
            this.tab_Xem.Size = new System.Drawing.Size(1154, 541);
            this.tab_Xem.TabIndex = 1;
            // 
            // tab_thanhtoan
            // 
            this.tab_thanhtoan.Controls.Add(this.lstThanhToan);
            this.tab_thanhtoan.Controls.Add(this.groupBox1);
            this.tab_thanhtoan.Controls.Add(this.checkBox_KHThanThiet);
            this.tab_thanhtoan.Controls.Add(this.btnHuy);
            this.tab_thanhtoan.Controls.Add(this.btn_XuatHoaDon);
            this.tab_thanhtoan.Controls.Add(this.btn_thanhtoan1);
            this.tab_thanhtoan.Controls.Add(this.txtDiaChi);
            this.tab_thanhtoan.Controls.Add(this.label8);
            this.tab_thanhtoan.Controls.Add(this.txtEmail);
            this.tab_thanhtoan.Controls.Add(this.label7);
            this.tab_thanhtoan.Controls.Add(this.txtSDT);
            this.tab_thanhtoan.Controls.Add(this.label6);
            this.tab_thanhtoan.Controls.Add(this.txtTenKH);
            this.tab_thanhtoan.Controls.Add(this.label5);
            this.tab_thanhtoan.Controls.Add(this.label4);
            this.tab_thanhtoan.Controls.Add(this.cbo_KH);
            this.tab_thanhtoan.Controls.Add(this.label3);
            this.tab_thanhtoan.Location = new System.Drawing.Point(4, 25);
            this.tab_thanhtoan.Name = "tab_thanhtoan";
            this.tab_thanhtoan.Padding = new System.Windows.Forms.Padding(3);
            this.tab_thanhtoan.Size = new System.Drawing.Size(1146, 512);
            this.tab_thanhtoan.TabIndex = 1;
            this.tab_thanhtoan.Text = "Thanh Toán";
            this.tab_thanhtoan.UseVisualStyleBackColor = true;
            // 
            // lstThanhToan
            // 
            this.lstThanhToan.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader13,
            this.columnHeader14,
            this.columnHeader15,
            this.columnHeader16});
            this.lstThanhToan.FullRowSelect = true;
            this.lstThanhToan.HideSelection = false;
            this.lstThanhToan.Location = new System.Drawing.Point(6, 39);
            this.lstThanhToan.Name = "lstThanhToan";
            this.lstThanhToan.Size = new System.Drawing.Size(391, 441);
            this.lstThanhToan.TabIndex = 17;
            this.lstThanhToan.UseCompatibleStateImageBehavior = false;
            this.lstThanhToan.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader13
            // 
            this.columnHeader13.Text = "Mã SP";
            // 
            // columnHeader14
            // 
            this.columnHeader14.Text = "Tên SP";
            this.columnHeader14.Width = 98;
            // 
            // columnHeader15
            // 
            this.columnHeader15.Text = "Giá";
            // 
            // columnHeader16
            // 
            this.columnHeader16.Text = "Số Lượng";
            this.columnHeader16.Width = 109;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtTienThua);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.txtPhaiTra);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.txtGiamGia);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.txtTongTien);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.txtTienNhan);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Location = new System.Drawing.Point(485, 234);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(623, 163);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thanh Toán";
            // 
            // txtTienThua
            // 
            this.txtTienThua.Enabled = false;
            this.txtTienThua.Location = new System.Drawing.Point(428, 120);
            this.txtTienThua.Name = "txtTienThua";
            this.txtTienThua.Size = new System.Drawing.Size(160, 22);
            this.txtTienThua.TabIndex = 26;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(333, 123);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(68, 16);
            this.label12.TabIndex = 25;
            this.label12.Text = "Tiền Thừa";
            // 
            // txtPhaiTra
            // 
            this.txtPhaiTra.Enabled = false;
            this.txtPhaiTra.Location = new System.Drawing.Point(147, 117);
            this.txtPhaiTra.Name = "txtPhaiTra";
            this.txtPhaiTra.Size = new System.Drawing.Size(160, 22);
            this.txtPhaiTra.TabIndex = 24;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(12, 120);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(58, 16);
            this.label13.TabIndex = 23;
            this.label13.Text = "Phải Trả";
            // 
            // txtGiamGia
            // 
            this.txtGiamGia.Enabled = false;
            this.txtGiamGia.Location = new System.Drawing.Point(428, 76);
            this.txtGiamGia.Name = "txtGiamGia";
            this.txtGiamGia.Size = new System.Drawing.Size(160, 22);
            this.txtGiamGia.TabIndex = 22;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(333, 79);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(63, 16);
            this.label11.TabIndex = 21;
            this.label11.Text = "Giảm Giá";
            // 
            // txtTongTien
            // 
            this.txtTongTien.Enabled = false;
            this.txtTongTien.Location = new System.Drawing.Point(147, 73);
            this.txtTongTien.Name = "txtTongTien";
            this.txtTongTien.Size = new System.Drawing.Size(160, 22);
            this.txtTongTien.TabIndex = 20;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(12, 76);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(69, 16);
            this.label10.TabIndex = 19;
            this.label10.Text = "Tổng Tiền";
            // 
            // txtTienNhan
            // 
            this.txtTienNhan.Location = new System.Drawing.Point(147, 33);
            this.txtTienNhan.Name = "txtTienNhan";
            this.txtTienNhan.Size = new System.Drawing.Size(441, 22);
            this.txtTienNhan.TabIndex = 18;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 36);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(89, 16);
            this.label9.TabIndex = 17;
            this.label9.Text = "Số Tiền Nhận";
            // 
            // checkBox_KHThanThiet
            // 
            this.checkBox_KHThanThiet.AutoSize = true;
            this.checkBox_KHThanThiet.Location = new System.Drawing.Point(485, 207);
            this.checkBox_KHThanThiet.Name = "checkBox_KHThanThiet";
            this.checkBox_KHThanThiet.Size = new System.Drawing.Size(169, 20);
            this.checkBox_KHThanThiet.TabIndex = 15;
            this.checkBox_KHThanThiet.Text = "Khách Hàng Thân Thiết";
            this.checkBox_KHThanThiet.UseVisualStyleBackColor = true;
            // 
            // btnHuy
            // 
            this.btnHuy.Location = new System.Drawing.Point(930, 422);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(169, 58);
            this.btnHuy.TabIndex = 14;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.UseVisualStyleBackColor = true;
            // 
            // btn_XuatHoaDon
            // 
            this.btn_XuatHoaDon.Location = new System.Drawing.Point(708, 422);
            this.btn_XuatHoaDon.Name = "btn_XuatHoaDon";
            this.btn_XuatHoaDon.Size = new System.Drawing.Size(169, 58);
            this.btn_XuatHoaDon.TabIndex = 13;
            this.btn_XuatHoaDon.Text = "Xuất Hóa Đơn";
            this.btn_XuatHoaDon.UseVisualStyleBackColor = true;
            this.btn_XuatHoaDon.Click += new System.EventHandler(this.btn_XuatHoaDon_Click);
            // 
            // btn_thanhtoan1
            // 
            this.btn_thanhtoan1.Location = new System.Drawing.Point(486, 422);
            this.btn_thanhtoan1.Name = "btn_thanhtoan1";
            this.btn_thanhtoan1.Size = new System.Drawing.Size(169, 58);
            this.btn_thanhtoan1.TabIndex = 12;
            this.btn_thanhtoan1.Text = "Thanh Toán";
            this.btn_thanhtoan1.UseVisualStyleBackColor = true;
            this.btn_thanhtoan1.Click += new System.EventHandler(this.btn_thanhtoan1_Click);
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Location = new System.Drawing.Point(632, 168);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(476, 22);
            this.txtDiaChi.TabIndex = 11;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(482, 171);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(49, 16);
            this.label8.TabIndex = 10;
            this.label8.Text = "Địa Chỉ";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(632, 140);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(476, 22);
            this.txtEmail.TabIndex = 9;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(482, 143);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 16);
            this.label7.TabIndex = 8;
            this.label7.Text = "Email";
            // 
            // txtSDT
            // 
            this.txtSDT.Location = new System.Drawing.Point(632, 112);
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.Size = new System.Drawing.Size(476, 22);
            this.txtSDT.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(482, 115);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 16);
            this.label6.TabIndex = 6;
            this.label6.Text = "SDT";
            // 
            // txtTenKH
            // 
            this.txtTenKH.Location = new System.Drawing.Point(632, 84);
            this.txtTenKH.Name = "txtTenKH";
            this.txtTenKH.Size = new System.Drawing.Size(476, 22);
            this.txtTenKH.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(482, 87);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(102, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "Mã Khách Hàng";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(482, 56);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Tên Khách Hàng";
            // 
            // cbo_KH
            // 
            this.cbo_KH.FormattingEnabled = true;
            this.cbo_KH.Location = new System.Drawing.Point(632, 52);
            this.cbo_KH.Name = "cbo_KH";
            this.cbo_KH.Size = new System.Drawing.Size(476, 24);
            this.cbo_KH.TabIndex = 2;
            this.cbo_KH.SelectedIndexChanged += new System.EventHandler(this.cbo_KH_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(219, 16);
            this.label3.TabIndex = 1;
            this.label3.Text = "Danh sách hàng hóa cần thanh toán";
            // 
            // tab_MuaHang
            // 
            this.tab_MuaHang.Controls.Add(this.btn_ThanhToan);
            this.tab_MuaHang.Controls.Add(this.btn_Loai);
            this.tab_MuaHang.Controls.Add(this.btnThem);
            this.tab_MuaHang.Controls.Add(this.label2);
            this.tab_MuaHang.Controls.Add(this.lst_GioHang);
            this.tab_MuaHang.Controls.Add(this.label1);
            this.tab_MuaHang.Controls.Add(this.lst_SanPham);
            this.tab_MuaHang.Location = new System.Drawing.Point(4, 25);
            this.tab_MuaHang.Name = "tab_MuaHang";
            this.tab_MuaHang.Padding = new System.Windows.Forms.Padding(3);
            this.tab_MuaHang.Size = new System.Drawing.Size(1146, 512);
            this.tab_MuaHang.TabIndex = 0;
            this.tab_MuaHang.Text = "Sản Phẩm";
            this.tab_MuaHang.UseVisualStyleBackColor = true;
            // 
            // btn_ThanhToan
            // 
            this.btn_ThanhToan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ThanhToan.Location = new System.Drawing.Point(579, 280);
            this.btn_ThanhToan.Name = "btn_ThanhToan";
            this.btn_ThanhToan.Size = new System.Drawing.Size(126, 91);
            this.btn_ThanhToan.TabIndex = 6;
            this.btn_ThanhToan.Text = "Thanh Toán";
            this.btn_ThanhToan.UseVisualStyleBackColor = true;
            this.btn_ThanhToan.Click += new System.EventHandler(this.btn_ThanhToan_Click);
            // 
            // btn_Loai
            // 
            this.btn_Loai.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Loai.Location = new System.Drawing.Point(579, 160);
            this.btn_Loai.Name = "btn_Loai";
            this.btn_Loai.Size = new System.Drawing.Size(126, 91);
            this.btn_Loai.TabIndex = 5;
            this.btn_Loai.Text = "Loại";
            this.btn_Loai.UseVisualStyleBackColor = true;
            this.btn_Loai.Click += new System.EventHandler(this.btn_Loai_Click);
            // 
            // btnThem
            // 
            this.btnThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.Location = new System.Drawing.Point(579, 43);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(126, 91);
            this.btnThem.TabIndex = 4;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(727, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Giỏ Hàng";
            // 
            // lst_GioHang
            // 
            this.lst_GioHang.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8});
            this.lst_GioHang.FullRowSelect = true;
            this.lst_GioHang.HideSelection = false;
            this.lst_GioHang.Location = new System.Drawing.Point(727, 43);
            this.lst_GioHang.Name = "lst_GioHang";
            this.lst_GioHang.Size = new System.Drawing.Size(391, 454);
            this.lst_GioHang.TabIndex = 2;
            this.lst_GioHang.UseCompatibleStateImageBehavior = false;
            this.lst_GioHang.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Mã SP";
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Tên SP";
            this.columnHeader6.Width = 98;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Giá";
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Số Lượng";
            this.columnHeader8.Width = 109;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Danh sách sản phẩm";
            // 
            // tabPage1
            // 
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Size = new System.Drawing.Size(1146, 512);
            this.tabPage1.TabIndex = 2;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Size = new System.Drawing.Size(1146, 512);
            this.tabPage2.TabIndex = 3;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // frmSanPham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1185, 592);
            this.Controls.Add(this.tab_Xem);
            this.Name = "frmSanPham";
            this.Text = "frmSanPham";
            this.Load += new System.EventHandler(this.frmSanPham_Load);
            this.tab_Xem.ResumeLayout(false);
            this.tab_thanhtoan.ResumeLayout(false);
            this.tab_thanhtoan.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tab_MuaHang.ResumeLayout(false);
            this.tab_MuaHang.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lst_SanPham;
        private System.Windows.Forms.TabControl tab_Xem;
        private System.Windows.Forms.TabPage tab_MuaHang;
        private System.Windows.Forms.TabPage tab_thanhtoan;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListView lst_GioHang;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.Button btn_Loai;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.Button btn_ThanhToan;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbo_KH;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btn_XuatHoaDon;
        private System.Windows.Forms.Button btn_thanhtoan1;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtSDT;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtTenKH;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox checkBox_KHThanThiet;
        private System.Windows.Forms.TextBox txtTienThua;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtPhaiTra;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtGiamGia;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtTongTien;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtTienNhan;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ListView lstThanhToan;
        private System.Windows.Forms.ColumnHeader columnHeader13;
        private System.Windows.Forms.ColumnHeader columnHeader14;
        private System.Windows.Forms.ColumnHeader columnHeader15;
        private System.Windows.Forms.ColumnHeader columnHeader16;
    }
}