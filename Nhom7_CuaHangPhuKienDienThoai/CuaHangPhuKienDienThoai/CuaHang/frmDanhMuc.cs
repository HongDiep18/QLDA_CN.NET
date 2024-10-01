using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessLayer;
using DataLayer;
namespace CuaHang
{
    public partial class frmDanhMuc : Form
    {
        public frmDanhMuc()
        {
            InitializeComponent();
        }

        private void frmChung_Load(object sender, EventArgs e)
        {
            List<DanhMuc> ds = new List<DanhMuc>();
            ConnectDanhMuc obj= new ConnectDanhMuc();
            ds = obj.get_data_DanhMuc();
            foreach (DanhMuc m in ds)
            {
                listView1.Items.Add(m.MADM).SubItems.Add(m.TENDM);
            }    

        }
    }
}
