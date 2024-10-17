namespace GUI
{
    partial class frmThongKe
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnThongKe = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtChiPhi = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbo_Nam = new System.Windows.Forms.ComboBox();
            this.cbo_Thang = new System.Windows.Forms.ComboBox();
            this.rdoNam = new System.Windows.Forms.RadioButton();
            this.rdoThang = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnThongKe1 = new System.Windows.Forms.Button();
            this.rdo_Thang1 = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.rdo_Nam1 = new System.Windows.Forms.RadioButton();
            this.txtChiPhiNhap = new System.Windows.Forms.TextBox();
            this.cbo_Thang1 = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cbo_Nam1 = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.listView_HOADON = new System.Windows.Forms.ListView();
            this.label7 = new System.Windows.Forms.Label();
            this.listView_PHIEUNHAP = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader10 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnThongKe);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtChiPhi);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cbo_Nam);
            this.groupBox1.Controls.Add(this.cbo_Thang);
            this.groupBox1.Controls.Add(this.rdoNam);
            this.groupBox1.Controls.Add(this.rdoThang);
            this.groupBox1.Location = new System.Drawing.Point(23, 65);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(580, 235);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Doanh Thu Bán Hàng";
            // 
            // btnThongKe
            // 
            this.btnThongKe.Location = new System.Drawing.Point(354, 94);
            this.btnThongKe.Name = "btnThongKe";
            this.btnThongKe.Size = new System.Drawing.Size(193, 53);
            this.btnThongKe.TabIndex = 8;
            this.btnThongKe.Text = "Thống Kê";
            this.btnThongKe.UseVisualStyleBackColor = true;
            this.btnThongKe.Click += new System.EventHandler(this.btnThongKe_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "Doanh Thu :";
            // 
            // txtChiPhi
            // 
            this.txtChiPhi.Location = new System.Drawing.Point(114, 111);
            this.txtChiPhi.Name = "txtChiPhi";
            this.txtChiPhi.Size = new System.Drawing.Size(190, 22);
            this.txtChiPhi.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(424, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Năm";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(235, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Tháng";
            // 
            // cbo_Nam
            // 
            this.cbo_Nam.FormattingEnabled = true;
            this.cbo_Nam.Location = new System.Drawing.Point(466, 34);
            this.cbo_Nam.Name = "cbo_Nam";
            this.cbo_Nam.Size = new System.Drawing.Size(81, 24);
            this.cbo_Nam.TabIndex = 3;
            // 
            // cbo_Thang
            // 
            this.cbo_Thang.FormattingEnabled = true;
            this.cbo_Thang.Location = new System.Drawing.Point(287, 34);
            this.cbo_Thang.Name = "cbo_Thang";
            this.cbo_Thang.Size = new System.Drawing.Size(81, 24);
            this.cbo_Thang.TabIndex = 2;
            // 
            // rdoNam
            // 
            this.rdoNam.AutoSize = true;
            this.rdoNam.Location = new System.Drawing.Point(19, 73);
            this.rdoNam.Name = "rdoNam";
            this.rdoNam.Size = new System.Drawing.Size(153, 20);
            this.rdoNam.TabIndex = 1;
            this.rdoNam.Text = "Thống Kê Theo Năm";
            this.rdoNam.UseVisualStyleBackColor = true;
            // 
            // rdoThang
            // 
            this.rdoThang.AutoSize = true;
            this.rdoThang.Location = new System.Drawing.Point(19, 36);
            this.rdoThang.Name = "rdoThang";
            this.rdoThang.Size = new System.Drawing.Size(163, 20);
            this.rdoThang.TabIndex = 0;
            this.rdoThang.Text = "Thống Kê Theo Tháng";
            this.rdoThang.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnThongKe1);
            this.groupBox2.Controls.Add(this.rdo_Thang1);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.rdo_Nam1);
            this.groupBox2.Controls.Add(this.txtChiPhiNhap);
            this.groupBox2.Controls.Add(this.cbo_Thang1);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.cbo_Nam1);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Location = new System.Drawing.Point(23, 331);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(580, 253);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Chi Phí Nhập Hàng";
            // 
            // btnThongKe1
            // 
            this.btnThongKe1.Location = new System.Drawing.Point(354, 97);
            this.btnThongKe1.Name = "btnThongKe1";
            this.btnThongKe1.Size = new System.Drawing.Size(193, 53);
            this.btnThongKe1.TabIndex = 17;
            this.btnThongKe1.Text = "Thống Kê";
            this.btnThongKe1.UseVisualStyleBackColor = true;
            this.btnThongKe1.Click += new System.EventHandler(this.btnThongKe1_Click);
            // 
            // rdo_Thang1
            // 
            this.rdo_Thang1.AutoSize = true;
            this.rdo_Thang1.Location = new System.Drawing.Point(19, 39);
            this.rdo_Thang1.Name = "rdo_Thang1";
            this.rdo_Thang1.Size = new System.Drawing.Size(163, 20);
            this.rdo_Thang1.TabIndex = 9;
            this.rdo_Thang1.Text = "Thống Kê Theo Tháng";
            this.rdo_Thang1.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 117);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(126, 16);
            this.label4.TabIndex = 16;
            this.label4.Text = "Chi Phí Nhập Hàng :";
            // 
            // rdo_Nam1
            // 
            this.rdo_Nam1.AutoSize = true;
            this.rdo_Nam1.Location = new System.Drawing.Point(19, 76);
            this.rdo_Nam1.Name = "rdo_Nam1";
            this.rdo_Nam1.Size = new System.Drawing.Size(153, 20);
            this.rdo_Nam1.TabIndex = 10;
            this.rdo_Nam1.Text = "Thống Kê Theo Năm";
            this.rdo_Nam1.UseVisualStyleBackColor = true;
            // 
            // txtChiPhiNhap
            // 
            this.txtChiPhiNhap.Location = new System.Drawing.Point(162, 114);
            this.txtChiPhiNhap.Name = "txtChiPhiNhap";
            this.txtChiPhiNhap.Size = new System.Drawing.Size(171, 22);
            this.txtChiPhiNhap.TabIndex = 15;
            // 
            // cbo_Thang1
            // 
            this.cbo_Thang1.FormattingEnabled = true;
            this.cbo_Thang1.Location = new System.Drawing.Point(287, 37);
            this.cbo_Thang1.Name = "cbo_Thang1";
            this.cbo_Thang1.Size = new System.Drawing.Size(81, 24);
            this.cbo_Thang1.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(424, 41);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 16);
            this.label5.TabIndex = 14;
            this.label5.Text = "Năm";
            // 
            // cbo_Nam1
            // 
            this.cbo_Nam1.FormattingEnabled = true;
            this.cbo_Nam1.Location = new System.Drawing.Point(466, 37);
            this.cbo_Nam1.Name = "cbo_Nam1";
            this.cbo_Nam1.Size = new System.Drawing.Size(81, 24);
            this.cbo_Nam1.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(235, 41);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 16);
            this.label6.TabIndex = 13;
            this.label6.Text = "Tháng";
            // 
            // listView_HOADON
            // 
            this.listView_HOADON.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8,
            this.columnHeader9,
            this.columnHeader10});
            this.listView_HOADON.HideSelection = false;
            this.listView_HOADON.Location = new System.Drawing.Point(648, 63);
            this.listView_HOADON.Name = "listView_HOADON";
            this.listView_HOADON.Size = new System.Drawing.Size(534, 237);
            this.listView_HOADON.TabIndex = 2;
            this.listView_HOADON.UseCompatibleStateImageBehavior = false;
            this.listView_HOADON.View = System.Windows.Forms.View.Details;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(645, 44);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(79, 16);
            this.label7.TabIndex = 3;
            this.label7.Text = "Danh Sách :";
            // 
            // listView_PHIEUNHAP
            // 
            this.listView_PHIEUNHAP.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.listView_PHIEUNHAP.HideSelection = false;
            this.listView_PHIEUNHAP.Location = new System.Drawing.Point(648, 331);
            this.listView_PHIEUNHAP.Name = "listView_PHIEUNHAP";
            this.listView_PHIEUNHAP.Size = new System.Drawing.Size(534, 253);
            this.listView_PHIEUNHAP.TabIndex = 4;
            this.listView_PHIEUNHAP.UseCompatibleStateImageBehavior = false;
            this.listView_PHIEUNHAP.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "MAPN";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "MANCC";
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Ngày Nhập";
            this.columnHeader3.Width = 100;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Tiền Nhập";
            this.columnHeader4.Width = 100;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Mã NV";
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "MAHD";
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "MAKH";
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "NGAYMUA";
            this.columnHeader8.Width = 117;
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "Tiền";
            // 
            // columnHeader10
            // 
            this.columnHeader10.Text = "MANV";
            // 
            // frmThongKe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1267, 647);
            this.Controls.Add(this.listView_PHIEUNHAP);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.listView_HOADON);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmThongKe";
            this.Text = "frmThongKe";
            this.Load += new System.EventHandler(this.frmThongKe_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnThongKe;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtChiPhi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbo_Nam;
        private System.Windows.Forms.ComboBox cbo_Thang;
        private System.Windows.Forms.RadioButton rdoNam;
        private System.Windows.Forms.RadioButton rdoThang;
        private System.Windows.Forms.Button btnThongKe1;
        private System.Windows.Forms.RadioButton rdo_Thang1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton rdo_Nam1;
        private System.Windows.Forms.TextBox txtChiPhiNhap;
        private System.Windows.Forms.ComboBox cbo_Thang1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbo_Nam1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ListView listView_HOADON;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ListView listView_PHIEUNHAP;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.ColumnHeader columnHeader10;
    }
}