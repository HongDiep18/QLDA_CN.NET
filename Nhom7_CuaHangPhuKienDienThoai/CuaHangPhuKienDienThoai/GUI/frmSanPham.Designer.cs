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
            this.tab_Xem = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tab_thanhtoan = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.lst_GioHang = new System.Windows.Forms.ListView();
            this.label2 = new System.Windows.Forms.Label();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnThem = new System.Windows.Forms.Button();
            this.btn_Loai = new System.Windows.Forms.Button();
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btn_ThanhToan = new System.Windows.Forms.Button();
            this.tab_Xem.SuspendLayout();
            this.tabPage1.SuspendLayout();
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
            this.lst_SanPham.Location = new System.Drawing.Point(6, 43);
            this.lst_SanPham.Name = "lst_SanPham";
            this.lst_SanPham.Size = new System.Drawing.Size(556, 454);
            this.lst_SanPham.TabIndex = 0;
            this.lst_SanPham.UseCompatibleStateImageBehavior = false;
            this.lst_SanPham.View = System.Windows.Forms.View.Details;
            // 
            // tab_Xem
            // 
            this.tab_Xem.Controls.Add(this.tab_thanhtoan);
            this.tab_Xem.Controls.Add(this.tabPage1);
            this.tab_Xem.Location = new System.Drawing.Point(13, 13);
            this.tab_Xem.Name = "tab_Xem";
            this.tab_Xem.SelectedIndex = 0;
            this.tab_Xem.Size = new System.Drawing.Size(1154, 541);
            this.tab_Xem.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btn_ThanhToan);
            this.tabPage1.Controls.Add(this.btn_Loai);
            this.tabPage1.Controls.Add(this.btnThem);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.lst_GioHang);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.lst_SanPham);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1146, 512);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Sản Phẩm";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tab_thanhtoan
            // 
            this.tab_thanhtoan.Location = new System.Drawing.Point(4, 25);
            this.tab_thanhtoan.Name = "tab_thanhtoan";
            this.tab_thanhtoan.Padding = new System.Windows.Forms.Padding(3);
            this.tab_thanhtoan.Size = new System.Drawing.Size(1146, 512);
            this.tab_thanhtoan.TabIndex = 1;
            this.tab_thanhtoan.Text = "Thanh Toán";
            this.tab_thanhtoan.UseVisualStyleBackColor = true;
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(727, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Giỏ Hàng";
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
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lst_SanPham;
        private System.Windows.Forms.TabControl tab_Xem;
        private System.Windows.Forms.TabPage tabPage1;
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
    }
}