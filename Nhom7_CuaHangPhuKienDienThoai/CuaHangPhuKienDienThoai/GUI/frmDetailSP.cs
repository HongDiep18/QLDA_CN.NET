using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;
using System.Data.Common;
using BLL;
using DTO;
namespace GUI
{
    public partial class frmDetailSP : Form
    {

        ChiTietSanPhamBLL detailSPBLL = new ChiTietSanPhamBLL();
        SanPhamDTO spDTO = new SanPhamDTO();
        SqlConnection conn = new SqlConnection("Data Source=HONGDIEP;Initial Catalog=DB_QL_PKDT;User ID=sa;Password=123");

        DataSet ds = new DataSet();
        public frmDetailSP()
        {
            InitializeComponent();
        }
        private void frmDetailSP_Load(object sender, EventArgs e)
        {
            LoadDanhMuc();
            LoadGridView();
            binding();
        }
        private void LoadDanhMuc()
        {
            DataTable dtDanhMuc = detailSPBLL.LoadDanhMuc();

            cboDM.DataSource = null;  //xóa lk trước khi thay dổi
            cboDM.DataSource = dtDanhMuc;
            cboDM.DisplayMember = "TENDM";
            cboDM.ValueMember = "MADM";

        }
        private void LoadGridView()
        {
            DataTable dtSP = detailSPBLL.LoadGridView();

            dgvDetail.DataSource = dtSP;
            dgvDetail.Refresh();
        }
        private void binding()
        {
            txtTen.DataBindings.Clear();
            txtTen.DataBindings.Add("Text", dgvDetail.DataSource, "TENSP");

            txtMa.DataBindings.Clear();
            txtMa.DataBindings.Add("Text", dgvDetail.DataSource, "MASP");

            txtSL.DataBindings.Clear();
            txtSL.DataBindings.Add("Text", dgvDetail.DataSource, "SLTONKHO");

            txtGia.DataBindings.Clear();
            txtGia.DataBindings.Add("Text", dgvDetail.DataSource, "GIA");

            cboDM.DataBindings.Clear();
            cboDM.DataBindings.Add("SelectedValue", dgvDetail.DataSource, "MADM");

            txtMoTa.DataBindings.Clear();
            txtMoTa.DataBindings.Add("Text", dgvDetail.DataSource, "MOTA");

        }



        private void btnAdd_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(cboDM.SelectedValue.ToString()))
            {
                MessageBox.Show("You must select a type for this ComboBox");
                return;
            }
            if (!float.TryParse(txtGia.Text.Trim(), out float gia))
            {
                MessageBox.Show("Convert Float Error");
                return;
            }
            SanPhamDTO sp = new SanPhamDTO
            {
                MaSP = txtMa.Text,
                TenSP = txtTen.Text,
                MoTa = txtMoTa.Text,
                Gia = gia,
                SLTonKho = int.Parse(txtSL.Text),
                MaDM = cboDM.SelectedValue.ToString()
            };

            bool kq = detailSPBLL.addValue(sp);
            if (kq)
            {
                MessageBox.Show("Add product success");
                LoadGridView();
                AddDataSet(sp);
            }
            else
            {
                MessageBox.Show("Add product fail");
            }

            txtMa.Clear();
            txtTen.Clear();
            txtMoTa.Clear();
            txtGia.Clear();
            txtSL.Clear();
            txtSL.Clear();
            //cboDM.Items.Clear();
        }
        private void AddDataSet(SanPhamDTO sp)
        {
            if (!ds.Tables.Contains("SANPHAM"))
            {
                DataTable dt = new DataTable("SANPHAM");
                dt.Columns.Add("MASP");
                dt.Columns.Add("TENSP");
                dt.Columns.Add("MOTA");
                dt.Columns.Add("GIA");
                dt.Columns.Add("SLTONKHO");
                dt.Columns.Add("MADM");

                ds.Tables.Add(dt);
            }

            DataRow newrow = ds.Tables["SANPHAM"].NewRow();
            newrow["MASP"] = txtMa.Text;
            newrow["TENSP"] = txtTen.Text;
            newrow["MOTA"] = txtMoTa.Text;
            newrow["GIA"] = txtGia.Text;
            newrow["SLTONKHO"] = txtSL.Text;
            newrow["MADM"] = cboDM.SelectedValue;

            ds.Tables["SANPHAM"].Rows.Add(newrow);
        }
    }
}
