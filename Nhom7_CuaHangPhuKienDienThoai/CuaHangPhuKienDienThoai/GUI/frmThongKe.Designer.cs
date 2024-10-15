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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rdoThang = new System.Windows.Forms.RadioButton();
            this.rdoNam = new System.Windows.Forms.RadioButton();
            this.cbo_Thang = new System.Windows.Forms.ComboBox();
            this.cbo_Nam = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtChiPhi = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnThongKe = new System.Windows.Forms.Button();
            this.btnThongKe1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtChiPhiNhap = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cbo_Nam1 = new System.Windows.Forms.ComboBox();
            this.cbo_Thang1 = new System.Windows.Forms.ComboBox();
            this.rdo_Nam1 = new System.Windows.Forms.RadioButton();
            this.rdo_Thang1 = new System.Windows.Forms.RadioButton();
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
            this.groupBox1.Location = new System.Drawing.Point(23, 33);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(660, 180);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Doanh Thu Bán Hàng";
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
            this.groupBox2.Location = new System.Drawing.Point(23, 248);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(660, 193);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Chi Phí Nhập Hàng";
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
            // cbo_Thang
            // 
            this.cbo_Thang.FormattingEnabled = true;
            this.cbo_Thang.Location = new System.Drawing.Point(287, 34);
            this.cbo_Thang.Name = "cbo_Thang";
            this.cbo_Thang.Size = new System.Drawing.Size(81, 24);
            this.cbo_Thang.TabIndex = 2;
            // 
            // cbo_Nam
            // 
            this.cbo_Nam.FormattingEnabled = true;
            this.cbo_Nam.Location = new System.Drawing.Point(466, 34);
            this.cbo_Nam.Name = "cbo_Nam";
            this.cbo_Nam.Size = new System.Drawing.Size(81, 24);
            this.cbo_Nam.TabIndex = 3;
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(424, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Năm";
            // 
            // txtChiPhi
            // 
            this.txtChiPhi.Location = new System.Drawing.Point(114, 111);
            this.txtChiPhi.Name = "txtChiPhi";
            this.txtChiPhi.Size = new System.Drawing.Size(190, 22);
            this.txtChiPhi.TabIndex = 6;
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
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 117);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(126, 16);
            this.label4.TabIndex = 16;
            this.label4.Text = "Chi Phí Nhập Hàng :";
            // 
            // txtChiPhiNhap
            // 
            this.txtChiPhiNhap.Location = new System.Drawing.Point(162, 114);
            this.txtChiPhiNhap.Name = "txtChiPhiNhap";
            this.txtChiPhiNhap.Size = new System.Drawing.Size(171, 22);
            this.txtChiPhiNhap.TabIndex = 15;
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
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(235, 41);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 16);
            this.label6.TabIndex = 13;
            this.label6.Text = "Tháng";
            // 
            // cbo_Nam1
            // 
            this.cbo_Nam1.FormattingEnabled = true;
            this.cbo_Nam1.Location = new System.Drawing.Point(466, 37);
            this.cbo_Nam1.Name = "cbo_Nam1";
            this.cbo_Nam1.Size = new System.Drawing.Size(81, 24);
            this.cbo_Nam1.TabIndex = 12;
            // 
            // cbo_Thang1
            // 
            this.cbo_Thang1.FormattingEnabled = true;
            this.cbo_Thang1.Location = new System.Drawing.Point(287, 37);
            this.cbo_Thang1.Name = "cbo_Thang1";
            this.cbo_Thang1.Size = new System.Drawing.Size(81, 24);
            this.cbo_Thang1.TabIndex = 11;
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
            // frmThongKe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1232, 647);
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
    }
}