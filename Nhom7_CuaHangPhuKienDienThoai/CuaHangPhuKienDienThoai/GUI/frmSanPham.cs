using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;
using BLL;
namespace GUI
{
    public partial class frmSanPham : Form
    {

        SanPhamBLL SP = new SanPhamBLL();
        
        public frmSanPham()
        {
            InitializeComponent();
        }
        bool kiemtrasl(string tmp)
        {
            foreach(ListViewItem item in lst_GioHang.Items)
            {
                if (item.SubItems[0].Text ==tmp)
                {
                    int sl = int.Parse(item.SubItems[3].Text) + 1;
                    item.SubItems[3].Text = sl.ToString();
                    return true; 
                }
            }
            return false;
        }
        private void frmSanPham_Load(object sender, EventArgs e)
        {
            tab_Xem.SelectedIndex = 1;
            List<SanPhamDTO> ds = SP.get_data();
            foreach (SanPhamDTO d in ds)
            {
                ListViewItem subitem = new ListViewItem(new[] { d.MaSP, d.TenSP, d.Gia.ToString(), d.MoTa });
                lst_SanPham.Items.Add(subitem);
            }

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            foreach(ListViewItem item in lst_SanPham.SelectedItems)
            {
                if (kiemtrasl(item.SubItems[0].Text)==false)
                {
                    ListViewItem item1 = new ListViewItem(new[] { item.SubItems[0].Text, item.SubItems[1].Text, item.SubItems[2].Text, "1" });
                    lst_GioHang.Items.Add(item1);
                }
               
            }    
            
        }

        private void btn_ThanhToan_Click(object sender, EventArgs e)
        {
            tab_Xem.SelectedTab = tab_thanhtoan;
            //lst_GioHang.Clear();
        }

        private void btn_Loai_Click(object sender, EventArgs e)
        {
            foreach(ListViewItem item in lst_GioHang.SelectedItems)
            {
                lst_GioHang.Items.Remove(item);
            }
            
        }
    }
}
