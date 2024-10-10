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

        private void frmMain_Load(object sender, EventArgs e)
        {
           // panel_body.Controls.Add(frmDangNhap);
        }

        private void btnNhapSanPham_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmNhapKho());
            label1.Text = btnNhapSanPham.Text;
        }
    }
}
