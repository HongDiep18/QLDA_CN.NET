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
        KhachHangBLL KH= new KhachHangBLL();
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
        void Load_DS_KH()
        {
            List<KhachHangDTO> ds=KH.get_ds_KH();
            //foreach(KhachHangDTO d in ds)
            //{
            //    cbo_KH.Items.Add("iuehfiuche");
            //}    
            cbo_KH.DataSource = ds;
            cbo_KH.DisplayMember = "TenKH";
            cbo_KH.ValueMember = "MaKH";
           
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
            tab_Xem.TabPages[0].Enabled = false;
            cbo_KH.SelectedItem = null;
            Load_DS_KH();
            

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
            if (lst_GioHang.Items.Count > 0)
            {
                tab_Xem.TabPages[0].Enabled = true;
                tab_Xem.SelectedTab = tab_thanhtoan;
                foreach(ListViewItem tmp in lst_GioHang.Items)
                {
                    ListViewItem item1 = new ListViewItem(new[] { tmp.SubItems[0].Text, tmp.SubItems[1].Text, tmp.SubItems[2].Text, tmp.SubItems[3].Text });
                    lstThanhToan.Items.Add(item1);
                }    
                //lst_GioHang.Clear();
            }
        }

        private void btn_Loai_Click(object sender, EventArgs e)
        {
            foreach(ListViewItem item in lst_GioHang.SelectedItems)
            {
                lst_GioHang.Items.Remove(item);
            }
            
        }

        private void cbo_KH_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtTenKH.Text = cbo_KH.SelectedValue.ToString();
            KhachHangDTO tmp = KH.Tim_1KH(txtTenKH.Text);
            txtEmail.Text = tmp.Email;
            txtDiaChi.Text = tmp.DChi;
            txtSDT.Text = tmp.SDT;

        }
        public float TongTien()
        {
            float tongtien = 0;
            foreach (ListViewItem tmp in lstThanhToan.Items)
            {
                float temp,temp1;
                if (float.TryParse(tmp.SubItems[3].Text, out temp)&& float.TryParse(tmp.SubItems[2].Text, out temp1))
                {
                    tongtien =tongtien+ (temp*temp1);
                }
                else
                {
                    // Xử lý lỗi nếu cần thiết, ví dụ: thông báo cho người dùng
                    MessageBox.Show($"Giá trị không hợp lệ: {tmp.SubItems[0].Text}");
                }
            }
            return tongtien;
        }
        public float GiamGia(bool kt)
        {
            if(kt==true)
                return (TongTien() * 5/100);
            return 0;
        }
        private void btn_thanhtoan1_Click(object sender, EventArgs e)
        {
           
            if (txtTienNhan.Text.Length > 0 && txtTenKH.Text.Length>0)
            {
                txtTongTien.Text=TongTien().ToString();
                txtGiamGia.Text=GiamGia(checkBox_KHThanThiet.Checked).ToString();
                float pt = TongTien() - GiamGia(checkBox_KHThanThiet.Checked);
                txtPhaiTra.Text=pt.ToString();
                float tt = float.Parse(txtTienNhan.Text) - pt;
                txtTienThua.Text = tt.ToString();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            HoaDonBLL hoaDonBLL = new HoaDonBLL();
            ChiTietHoaDonBLL chiTietHoaDonBLL= new ChiTietHoaDonBLL();
            //bool kq= hoaDonBLL.insert_HoaDon("HD021",txtTenKH.Text);
            foreach(ListViewItem tmp in lstThanhToan.Items)
            {
                float  temp1;
                int temp;
                if (int.TryParse(tmp.SubItems[3].Text, out temp) && float.TryParse(tmp.SubItems[2].Text, out temp1))
                {
                    ChiTietHoaDonDTO dt = new ChiTietHoaDonDTO("HD021", tmp.SubItems[0].Text, temp, temp1);
                    chiTietHoaDonBLL.Insert(dt);
                }
                
            }    
            //if(kq)
            //{
            //    MessageBox.Show("them thanh cong");
            //}
            //else
            //{
            //    MessageBox.Show("Thêm thất bại");
            //}

        }
    }
}
