using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }
        private Form CurrentFormChild;
        public string MaNV;
        public string MatKhau;
        private void OpenChildForm(Form childForm)
        {
            if (CurrentFormChild != null)
            {
                CurrentFormChild.Close();
            }
            CurrentFormChild = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panel_body.Controls.Add(childForm);
            panel_body.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }
       
        private void btn_SanPham_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmSanPham());
            label1.Text = btn_SanPham.Text;
        }
        public void loadMaNV(string ma)
        {
            MaNV = ma;
            label2.Text += ma;
        }
        public void loadTenNV(string ten)
        {
            label3.Text += ten;
        }
        public void loadMatKhau(string ten)
        {
            MatKhau = ten;
        }
        private void frmMain_Load(object sender, EventArgs e)
        {
            frmDangNhap DangNhap = new frmDangNhap();
            if (CurrentFormChild != null)
            {
                CurrentFormChild.Close();
            }
            CurrentFormChild = DangNhap;
            DangNhap.TopLevel = false;
            DangNhap.FormBorderStyle = FormBorderStyle.None;
            DangNhap.Dock = DockStyle.Fill;
            panel_body.Controls.Add(DangNhap);
            panel_body.Tag = DangNhap;
            DangNhap.BringToFront();
            DangNhap.truyenMANV = new frmDangNhap.MANV(loadMaNV);
            DangNhap.truyenTENNV = new frmDangNhap.TENNV(loadTenNV);
            DangNhap.truyenMATKHAU = new frmDangNhap.MATKHAU(loadMatKhau);
            DangNhap.Show();




        }

        private void btnNhapSanPham_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmNhapKho());
            label1.Text = btnNhapSanPham.Text;
        }

        private void btn_DanhMucSp_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmDanhMuc());
            label1.Text=btn_DanhMucSp.Text;
        }

        private void btnChiTietSP_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmChiTietSanPham(""));
            label1.Text=btnChiTietSP.Text;
        }

        private void btnKhachHang_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmKhachHang());
            label1.Text= btnKhachHang.Text;
        }

        private void btnNhanVien_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmNhanVien());
            label1.Text=btnNhanVien.Text;
        }

        private void panel_body_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
