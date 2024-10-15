using BLL;
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
    public partial class frmThongKe : Form
    {
        public frmThongKe()
        {
            InitializeComponent();
        }
        ThongKeBLL tkBLL= new ThongKeBLL();
        public void load_Thang()
        {
            List<string> ds = tkBLL.get_Month();
            foreach (string s in ds)
            {
                cbo_Thang.Items.Add(s);
            }
            List<string> ds1 = tkBLL.get_Month_CP();
            foreach (string s in ds1)
            {
                cbo_Thang1.Items.Add(s);
            }
        }
        public void load_Nam()
        {
            List<string> ds = tkBLL.get_Year();
            foreach (string s in ds)
            {
                cbo_Nam.Items.Add(s);
            }
            List<string> ds1 = tkBLL.get_Year_CP();
            foreach (string s in ds)
            {
                cbo_Nam1.Items.Add(s);
            }
        }

        private void frmThongKe_Load(object sender, EventArgs e)
        {
            load_Thang();
            load_Nam();
        }

        private void btnThongKe_Click(object sender, EventArgs e)
        {
            if(rdoThang.Checked && cbo_Nam.SelectedItem !=null && cbo_Thang.SelectedItem!=null)
            {
                txtChiPhi.Text = tkBLL.get_ChiPhi_Thang(cbo_Thang.Text, cbo_Nam.Text).ToString();
            }    
            else if (rdoNam.Checked && cbo_Nam.SelectedItem != null)
            {
                txtChiPhi.Text = tkBLL.get_ChiPhi_Nam(cbo_Nam.Text).ToString();
            }
            else
            {
                MessageBox.Show("Chọn Tháng Chọn Năm");
            }
        }

        private void btnThongKe1_Click(object sender, EventArgs e)
        {
            if (rdo_Thang1.Checked && cbo_Nam1.SelectedItem != null && cbo_Thang1.SelectedItem != null)
            {
                txtChiPhiNhap.Text = tkBLL.get_CP_Thang(cbo_Thang1.Text, cbo_Nam1.Text);
            }
            else if (rdo_Nam1.Checked && cbo_Nam1.SelectedItem != null)
            {
                txtChiPhiNhap.Text = tkBLL.get_CP_Nam( cbo_Nam1.Text);
            }
            else
            {
                MessageBox.Show("Chọn Tháng Chọn Năm");
            }
        }
    }
}
