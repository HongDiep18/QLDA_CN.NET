using BLL;
using DTO;
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
    public partial class frmChiTietSanPham : Form
    {
        public string loai;
        public frmChiTietSanPham(string loai)
        {
            InitializeComponent();
            this.loai = loai;
        }

        private void frmChiTietSanPham_Load(object sender, EventArgs e)
        {
            listView_SanPham.Items.Clear();
            if(loai !="")
            {
                btnEdit.Enabled = false;
                btnXoa.Enabled = false;
                txtSL.Enabled = false;
            }
            Loadsp();
            //loadDanhMuc();
            
        }
        public void Loadsp()
        {
            SanPhamBLL spBLL= new SanPhamBLL();
            List<SanPhamDTO> ds = spBLL.get_data();
            foreach(SanPhamDTO d in ds)
            {
                string[] itm = { d.MaSP, d.TenSP, d.SLTonKo.ToString(), d.Gia.ToString(),d.MoTa, d.MaDM };
                ListViewItem item = new ListViewItem(itm);
                listView_SanPham.Items.Add(item);
            }    
        }
        public void loadDanhMuc()
        {
            DanhMucDLL dmBLL = new DanhMucDLL();
            cboDM.DataSource = dmBLL.getData();
            cboDM.DisplayMember = "TenDM";
            cboDM.ValueMember = "MaDM";
        }

        private void listView_SanPham_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach(ListViewItem item in listView_SanPham.SelectedItems)
            {
                txtMa.Text = item.SubItems[0].Text;
                txtTen.Text = item.SubItems[1].Text;
                txtSL.Text = item.SubItems[2].Text;
                txtGia.Text = item.SubItems[3].Text;
                txtMoTa.Text = item.SubItems[4].Text;
                cboDM.Text = item.SubItems[5].Text;
                //Bitmap bm = new Bitmap(Application.StartupPath + "\\Imgs\\" + txtMa.Text.Trim() + ".jpg");
                Bitmap bm = new Bitmap("C:\\Users\\vuxec\\OneDrive\\Máy tính\\DoAnDotNet\\Nhom7_CuaHangPhuKienDienThoai\\CuaHangPhuKienDienThoai\\GUI\\Imgs\\"+txtMa.Text.Trim()+".jpg");
                pictureBox_Anh.Image = bm;
                //MessageBox.Show(Application.StartupPath + "\\Imgs\\" + txtMa.Text.Trim() + ".jpg");

            }
            
        }
        public void Load_SP_TheoDanhMuc(string ma)
        {
            SanPhamBLL spBLL = new SanPhamBLL();
            List<SanPhamDTO> ds = new List<SanPhamDTO>();
            ds = spBLL.get_data_theoDM(ma);
            foreach (SanPhamDTO d in ds)
            {
                string[] itm = { d.MaSP, d.TenSP, d.SLTonKo.ToString(), d.Gia.ToString(), d.MoTa, d.MaDM };
                ListViewItem item = new ListViewItem(itm);
                listView_SanPham.Items.Add(item);
            }
        }
        private void cboDM_SelectedIndexChanged(object sender, EventArgs e)
        {
            listView_SanPham.Items.Clear();
            Load_SP_TheoDanhMuc(cboDM.SelectedValue.ToString());
        }

        private void cboDM_Click(object sender, EventArgs e)
        {
            loadDanhMuc();
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            frmChiTietSanPham_Load(sender, e);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if(cboDM.SelectedValue==null)
            {
                SanPhamDTO sp = new SanPhamDTO(txtMa.Text, txtTen.Text, txtMoTa.Text, float.Parse(txtGia.Text),/*int.Parse(txtSL.Text)*/0, cboDM.Text);// thêm sản phẩm mới thì số lượng tồn là 0, thông qua thao tác nhập sản phẩm để điều chỉnh số lượng
                SanPhamBLL spBLL = new SanPhamBLL();
                if (spBLL.insert_sanPham(sp))
                {
                    MessageBox.Show("Thêm Thành Công");
                }
                else
                {
                    MessageBox.Show("Thêm thất bại, Kiểm tra mã sản phẩm và nhập đầy đủ thông tin");
                }
            }
            else
            {
                SanPhamDTO sp = new SanPhamDTO(txtMa.Text, txtTen.Text, txtMoTa.Text, float.Parse(txtGia.Text),/*int.Parse(txtSL.Text)*/0, cboDM.SelectedValue.ToString());// thêm sản phẩm mới thì số lượng tồn là 0, thông qua thao tác nhập sản phẩm để điều chỉnh số lượng
                SanPhamBLL spBLL = new SanPhamBLL();
                if (spBLL.insert_sanPham(sp))
                {
                    MessageBox.Show("Thêm Thành Công");
                }
                else
                {
                    MessageBox.Show("Thêm thất bại, Kiểm tra mã sản phẩm và nhập đầy đủ thông tin");
                }
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            SanPhamBLL spBLL= new SanPhamBLL();
            if(listView_SanPham.SelectedItems!=null)
            {
                if(spBLL.Xoa_SP(txtMa.Text))
                {
                    MessageBox.Show("Xóa thành công");
                }
                else
                {
                    MessageBox.Show("Xóa Thất Bại, do sản phẩm còn trong kho và liên quan đến Hóa Đơn, Phiếu Nhập");
                }
            }
            else
            {
                MessageBox.Show("Chọn sản phẩm cần xóa");
            }

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            SanPhamBLL spBLL = new SanPhamBLL();
            if (listView_SanPham.SelectedItems != null)
            {
                SanPhamDTO tmp = new SanPhamDTO(txtMa.Text,txtTen.Text,txtMoTa.Text,float.Parse(txtGia.Text),int.Parse(txtSL.Text),cboDM.Text);
                if (spBLL.Sua_SP(tmp))
                {
                    MessageBox.Show("Sửa thành công");
                }
                else
                {
                    MessageBox.Show("Sửa Thất Bại");
                }
            }
            else
            {
                MessageBox.Show("Chọn sản phẩm cần Sửa");
            }
        }
    }
}
