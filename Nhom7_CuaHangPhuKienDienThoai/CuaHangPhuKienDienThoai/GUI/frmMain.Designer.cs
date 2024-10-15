namespace GUI
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.panel_body = new System.Windows.Forms.Panel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tàiKhoảnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.đăngXuấtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.đổiMậtKhẩuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel_left = new System.Windows.Forms.Panel();
<<<<<<< HEAD
            this.btnNhanVien = new System.Windows.Forms.Button();
            this.btnKhachHang = new System.Windows.Forms.Button();
            this.btnChiTietSP = new System.Windows.Forms.Button();
            this.btn_DanhMucSp = new System.Windows.Forms.Button();
            this.btnNhapSanPham = new System.Windows.Forms.Button();
=======
            this.btn_Detail_SP = new System.Windows.Forms.Button();
>>>>>>> 017fb19194f544d3fc2d51eebc6d44bf6340a58b
            this.btn_SanPham = new System.Windows.Forms.Button();
            this.pictureBox_logo = new System.Windows.Forms.PictureBox();
            this.panel_top = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnQlCC = new System.Windows.Forms.Button();
            this.panel_body.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.panel_left.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_logo)).BeginInit();
            this.panel_top.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_body
            // 
            this.panel_body.BackColor = System.Drawing.Color.Transparent;
            this.panel_body.Controls.Add(this.menuStrip1);
            this.panel_body.Dock = System.Windows.Forms.DockStyle.Fill;
<<<<<<< HEAD
            this.panel_body.Location = new System.Drawing.Point(158, 75);
            this.panel_body.Name = "panel_body";
            this.panel_body.Size = new System.Drawing.Size(1263, 624);
=======
            this.panel_body.Location = new System.Drawing.Point(143, 84);
            this.panel_body.Name = "panel_body";
            this.panel_body.Size = new System.Drawing.Size(1278, 561);
>>>>>>> 017fb19194f544d3fc2d51eebc6d44bf6340a58b
            this.panel_body.TabIndex = 5;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tàiKhoảnToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1263, 29);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tàiKhoảnToolStripMenuItem
            // 
            this.tàiKhoảnToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.đăngXuấtToolStripMenuItem,
            this.đổiMậtKhẩuToolStripMenuItem});
            this.tàiKhoảnToolStripMenuItem.Name = "tàiKhoảnToolStripMenuItem";
            this.tàiKhoảnToolStripMenuItem.Size = new System.Drawing.Size(90, 25);
            this.tàiKhoảnToolStripMenuItem.Text = "Tài Khoản";
            // 
            // đăngXuấtToolStripMenuItem
            // 
            this.đăngXuấtToolStripMenuItem.Name = "đăngXuấtToolStripMenuItem";
            this.đăngXuấtToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.đăngXuấtToolStripMenuItem.Text = "Đăng Xuất";
            this.đăngXuấtToolStripMenuItem.Click += new System.EventHandler(this.đăngXuấtToolStripMenuItem_Click);
            // 
            // đổiMậtKhẩuToolStripMenuItem
            // 
            this.đổiMậtKhẩuToolStripMenuItem.Name = "đổiMậtKhẩuToolStripMenuItem";
            this.đổiMậtKhẩuToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.đổiMậtKhẩuToolStripMenuItem.Text = "Đổi Mật Khẩu";
            this.đổiMậtKhẩuToolStripMenuItem.Click += new System.EventHandler(this.đổiMậtKhẩuToolStripMenuItem_Click);
            // 
            // panel_left
            // 
            this.panel_left.BackColor = System.Drawing.SystemColors.ActiveCaption;
<<<<<<< HEAD
            this.panel_left.Controls.Add(this.btnQlCC);
            this.panel_left.Controls.Add(this.btnNhanVien);
            this.panel_left.Controls.Add(this.btnKhachHang);
            this.panel_left.Controls.Add(this.btnChiTietSP);
            this.panel_left.Controls.Add(this.btn_DanhMucSp);
            this.panel_left.Controls.Add(this.btnNhapSanPham);
=======
            this.panel_left.Controls.Add(this.btn_Detail_SP);
>>>>>>> 017fb19194f544d3fc2d51eebc6d44bf6340a58b
            this.panel_left.Controls.Add(this.btn_SanPham);
            this.panel_left.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel_left.Location = new System.Drawing.Point(0, 84);
            this.panel_left.Name = "panel_left";
<<<<<<< HEAD
            this.panel_left.Size = new System.Drawing.Size(158, 624);
            this.panel_left.TabIndex = 3;
            // 
            // btnNhanVien
            // 
            this.btnNhanVien.Enabled = false;
            this.btnNhanVien.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNhanVien.Location = new System.Drawing.Point(0, 287);
            this.btnNhanVien.Name = "btnNhanVien";
            this.btnNhanVien.Size = new System.Drawing.Size(158, 74);
            this.btnNhanVien.TabIndex = 6;
            this.btnNhanVien.Text = "Nhân Viên";
            this.btnNhanVien.UseVisualStyleBackColor = true;
            this.btnNhanVien.Click += new System.EventHandler(this.btnNhanVien_Click);
            // 
            // btnKhachHang
            // 
            this.btnKhachHang.Enabled = false;
            this.btnKhachHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKhachHang.Location = new System.Drawing.Point(0, 215);
            this.btnKhachHang.Name = "btnKhachHang";
            this.btnKhachHang.Size = new System.Drawing.Size(158, 74);
            this.btnKhachHang.TabIndex = 5;
            this.btnKhachHang.Text = "Khách Hàng";
            this.btnKhachHang.UseVisualStyleBackColor = true;
            this.btnKhachHang.Click += new System.EventHandler(this.btnKhachHang_Click);
            // 
            // btnChiTietSP
            // 
            this.btnChiTietSP.Enabled = false;
            this.btnChiTietSP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChiTietSP.Location = new System.Drawing.Point(0, 143);
            this.btnChiTietSP.Name = "btnChiTietSP";
            this.btnChiTietSP.Size = new System.Drawing.Size(158, 74);
            this.btnChiTietSP.TabIndex = 4;
            this.btnChiTietSP.Text = "Chi Tiết Sản Phẩm";
            this.btnChiTietSP.UseVisualStyleBackColor = true;
            this.btnChiTietSP.Click += new System.EventHandler(this.btnChiTietSP_Click);
            // 
            // btn_DanhMucSp
            // 
            this.btn_DanhMucSp.Enabled = false;
            this.btn_DanhMucSp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_DanhMucSp.Location = new System.Drawing.Point(0, 71);
            this.btn_DanhMucSp.Name = "btn_DanhMucSp";
            this.btn_DanhMucSp.Size = new System.Drawing.Size(158, 74);
            this.btn_DanhMucSp.TabIndex = 3;
            this.btn_DanhMucSp.Text = "Danh Mục Sản Phẩm";
            this.btn_DanhMucSp.UseVisualStyleBackColor = true;
            this.btn_DanhMucSp.Click += new System.EventHandler(this.btn_DanhMucSp_Click);
            // 
            // btnNhapSanPham
            // 
            this.btnNhapSanPham.Enabled = false;
            this.btnNhapSanPham.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNhapSanPham.Location = new System.Drawing.Point(0, 357);
            this.btnNhapSanPham.Name = "btnNhapSanPham";
            this.btnNhapSanPham.Size = new System.Drawing.Size(158, 74);
            this.btnNhapSanPham.TabIndex = 2;
            this.btnNhapSanPham.Text = "Nhập Sản Phẩm";
            this.btnNhapSanPham.UseVisualStyleBackColor = true;
            this.btnNhapSanPham.Click += new System.EventHandler(this.btnNhapSanPham_Click);
=======
            this.panel_left.Size = new System.Drawing.Size(143, 561);
            this.panel_left.TabIndex = 3;
            // 
            // btn_Detail_SP
            // 
            this.btn_Detail_SP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn_Detail_SP.Location = new System.Drawing.Point(0, 80);
            this.btn_Detail_SP.Name = "btn_Detail_SP";
            this.btn_Detail_SP.Size = new System.Drawing.Size(143, 74);
            this.btn_Detail_SP.TabIndex = 2;
            this.btn_Detail_SP.Text = "Chi Tiết Sản Phẩm";
            this.btn_Detail_SP.UseVisualStyleBackColor = true;
            this.btn_Detail_SP.Click += new System.EventHandler(this.btn_Detail_SP_Click);
>>>>>>> 017fb19194f544d3fc2d51eebc6d44bf6340a58b
            // 
            // btn_SanPham
            // 
            this.btn_SanPham.Enabled = false;
            this.btn_SanPham.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_SanPham.Location = new System.Drawing.Point(0, 1);
            this.btn_SanPham.Name = "btn_SanPham";
            this.btn_SanPham.Size = new System.Drawing.Size(158, 74);
            this.btn_SanPham.TabIndex = 1;
            this.btn_SanPham.Text = "Danh Sách Sản Phẩm";
            this.btn_SanPham.UseVisualStyleBackColor = true;
            this.btn_SanPham.Click += new System.EventHandler(this.btn_SanPham_Click);
            // 
            // pictureBox_logo
            // 
            this.pictureBox_logo.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_logo.Image")));
            this.pictureBox_logo.Location = new System.Drawing.Point(0, 0);
            this.pictureBox_logo.Name = "pictureBox_logo";
            this.pictureBox_logo.Size = new System.Drawing.Size(158, 75);
            this.pictureBox_logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_logo.TabIndex = 0;
            this.pictureBox_logo.TabStop = false;
            // 
            // panel_top
            // 
            this.panel_top.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel_top.Controls.Add(this.label3);
            this.panel_top.Controls.Add(this.label2);
            this.panel_top.Controls.Add(this.label1);
            this.panel_top.Controls.Add(this.pictureBox_logo);
            this.panel_top.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_top.Location = new System.Drawing.Point(0, 0);
            this.panel_top.Name = "panel_top";
            this.panel_top.Size = new System.Drawing.Size(1421, 84);
            this.panel_top.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.Location = new System.Drawing.Point(1096, 47);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tên Nhân Viên :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.Location = new System.Drawing.Point(1096, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mã Nhân Viên :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
<<<<<<< HEAD
            this.label1.Location = new System.Drawing.Point(203, 18);
=======
            this.label1.Location = new System.Drawing.Point(228, 19);
>>>>>>> 017fb19194f544d3fc2d51eebc6d44bf6340a58b
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 35);
            this.label1.TabIndex = 0;
            this.label1.Text = "Home";
            // 
            // btnQlCC
            // 
            this.btnQlCC.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnQlCC.Location = new System.Drawing.Point(0, 427);
            this.btnQlCC.Name = "btnQlCC";
            this.btnQlCC.Size = new System.Drawing.Size(158, 74);
            this.btnQlCC.TabIndex = 1;
            this.btnQlCC.Text = "Nhà Cung Cấp";
            this.btnQlCC.UseVisualStyleBackColor = true;
            this.btnQlCC.Click += new System.EventHandler(this.btnQlCC_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1421, 699);
            this.Controls.Add(this.panel_body);
            this.Controls.Add(this.panel_left);
            this.Controls.Add(this.panel_top);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMain";
            this.Text = "frmTrangChu";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.panel_body.ResumeLayout(false);
            this.panel_body.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel_left.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_logo)).EndInit();
            this.panel_top.ResumeLayout(false);
            this.panel_top.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_body;
        private System.Windows.Forms.Panel panel_left;
        private System.Windows.Forms.Button btn_SanPham;
        private System.Windows.Forms.PictureBox pictureBox_logo;
        private System.Windows.Forms.Panel panel_top;
        private System.Windows.Forms.Label label1;
<<<<<<< HEAD
        private System.Windows.Forms.Button btnNhapSanPham;
        private System.Windows.Forms.Button btn_DanhMucSp;
        private System.Windows.Forms.Button btnChiTietSP;
        private System.Windows.Forms.Button btnKhachHang;
        private System.Windows.Forms.Button btnNhanVien;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tàiKhoảnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem đăngXuấtToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem đổiMậtKhẩuToolStripMenuItem;
        private System.Windows.Forms.Button btnQlCC;
=======
        private System.Windows.Forms.Button btn_Detail_SP;
>>>>>>> 017fb19194f544d3fc2d51eebc6d44bf6340a58b
    }
}

