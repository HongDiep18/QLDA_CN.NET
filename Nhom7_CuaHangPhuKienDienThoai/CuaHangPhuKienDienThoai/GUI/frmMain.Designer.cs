﻿namespace GUI
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
            this.panel_left = new System.Windows.Forms.Panel();
            this.btnChiTietSP = new System.Windows.Forms.Button();
            this.btn_DanhMucSp = new System.Windows.Forms.Button();
            this.btnNhapSanPham = new System.Windows.Forms.Button();
            this.btn_SanPham = new System.Windows.Forms.Button();
            this.pictureBox_logo = new System.Windows.Forms.PictureBox();
            this.panel_top = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnKhachHang = new System.Windows.Forms.Button();
            this.panel_left.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_logo)).BeginInit();
            this.panel_top.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_body
            // 
            this.panel_body.BackColor = System.Drawing.Color.Transparent;
            this.panel_body.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_body.Location = new System.Drawing.Point(143, 75);
            this.panel_body.Name = "panel_body";
            this.panel_body.Size = new System.Drawing.Size(1278, 570);
            this.panel_body.TabIndex = 5;
            // 
            // panel_left
            // 
            this.panel_left.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel_left.Controls.Add(this.btnKhachHang);
            this.panel_left.Controls.Add(this.btnChiTietSP);
            this.panel_left.Controls.Add(this.btn_DanhMucSp);
            this.panel_left.Controls.Add(this.btnNhapSanPham);
            this.panel_left.Controls.Add(this.btn_SanPham);
            this.panel_left.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel_left.Location = new System.Drawing.Point(0, 75);
            this.panel_left.Name = "panel_left";
            this.panel_left.Size = new System.Drawing.Size(143, 570);
            this.panel_left.TabIndex = 3;
            // 
            // btnChiTietSP
            // 
            this.btnChiTietSP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChiTietSP.Location = new System.Drawing.Point(0, 217);
            this.btnChiTietSP.Name = "btnChiTietSP";
            this.btnChiTietSP.Size = new System.Drawing.Size(143, 74);
            this.btnChiTietSP.TabIndex = 4;
            this.btnChiTietSP.Text = "Chi Tiết Sản Phẩm";
            this.btnChiTietSP.UseVisualStyleBackColor = true;
            this.btnChiTietSP.Click += new System.EventHandler(this.btnChiTietSP_Click);
            // 
            // btn_DanhMucSp
            // 
            this.btn_DanhMucSp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_DanhMucSp.Location = new System.Drawing.Point(0, 145);
            this.btn_DanhMucSp.Name = "btn_DanhMucSp";
            this.btn_DanhMucSp.Size = new System.Drawing.Size(143, 74);
            this.btn_DanhMucSp.TabIndex = 3;
            this.btn_DanhMucSp.Text = "Danh Mục Sản Phẩm";
            this.btn_DanhMucSp.UseVisualStyleBackColor = true;
            this.btn_DanhMucSp.Click += new System.EventHandler(this.btn_DanhMucSp_Click);
            // 
            // btnNhapSanPham
            // 
            this.btnNhapSanPham.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNhapSanPham.Location = new System.Drawing.Point(0, 73);
            this.btnNhapSanPham.Name = "btnNhapSanPham";
            this.btnNhapSanPham.Size = new System.Drawing.Size(143, 74);
            this.btnNhapSanPham.TabIndex = 2;
            this.btnNhapSanPham.Text = "Nhập Sản Phẩm";
            this.btnNhapSanPham.UseVisualStyleBackColor = true;
            this.btnNhapSanPham.Click += new System.EventHandler(this.btnNhapSanPham_Click);
            // 
            // btn_SanPham
            // 
            this.btn_SanPham.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_SanPham.Location = new System.Drawing.Point(0, 1);
            this.btn_SanPham.Name = "btn_SanPham";
            this.btn_SanPham.Size = new System.Drawing.Size(143, 74);
            this.btn_SanPham.TabIndex = 1;
            this.btn_SanPham.Text = "Danh Sánh Sản Phẩm";
            this.btn_SanPham.UseVisualStyleBackColor = true;
            this.btn_SanPham.Click += new System.EventHandler(this.btn_SanPham_Click);
            // 
            // pictureBox_logo
            // 
            this.pictureBox_logo.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_logo.Image")));
            this.pictureBox_logo.Location = new System.Drawing.Point(0, 0);
            this.pictureBox_logo.Name = "pictureBox_logo";
            this.pictureBox_logo.Size = new System.Drawing.Size(143, 81);
            this.pictureBox_logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_logo.TabIndex = 0;
            this.pictureBox_logo.TabStop = false;
            // 
            // panel_top
            // 
            this.panel_top.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel_top.Controls.Add(this.label1);
            this.panel_top.Controls.Add(this.pictureBox_logo);
            this.panel_top.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_top.Location = new System.Drawing.Point(0, 0);
            this.panel_top.Name = "panel_top";
            this.panel_top.Size = new System.Drawing.Size(1421, 75);
            this.panel_top.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(174, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 35);
            this.label1.TabIndex = 0;
            this.label1.Text = "Home";
            // 
            // btnKhachHang
            // 
            this.btnKhachHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKhachHang.Location = new System.Drawing.Point(0, 289);
            this.btnKhachHang.Name = "btnKhachHang";
            this.btnKhachHang.Size = new System.Drawing.Size(143, 74);
            this.btnKhachHang.TabIndex = 5;
            this.btnKhachHang.Text = "Khách Hàng";
            this.btnKhachHang.UseVisualStyleBackColor = true;
            this.btnKhachHang.Click += new System.EventHandler(this.btnKhachHang_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1421, 645);
            this.Controls.Add(this.panel_body);
            this.Controls.Add(this.panel_left);
            this.Controls.Add(this.panel_top);
            this.Name = "frmMain";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.frmMain_Load);
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
        private System.Windows.Forms.Button btnNhapSanPham;
        private System.Windows.Forms.Button btn_DanhMucSp;
        private System.Windows.Forms.Button btnChiTietSP;
        private System.Windows.Forms.Button btnKhachHang;
    }
}

