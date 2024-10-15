using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DTO;
namespace DAL
{
    public class ChiTietSanPhamDAL
    {
        DataSet ds = new DataSet();
        SqlConnection conn;
        public ChiTietSanPhamDAL()
        {
            conn = new SqlConnection("Data Source=HONGDIEP;Initial Catalog=DB_QL_PKDT;User ID=sa;Password=123");

        }
        public void OpenConnection()
        {
            if (conn.State == System.Data.ConnectionState.Closed)
            {
                conn.Open();
            }
        }
        public DataTable LoadDanhMuc()
        {
            OpenConnection();
            DataTable dt = new DataTable();
            string query = "select * from DANHMUC";
            SqlDataAdapter da = new SqlDataAdapter(query, conn);
            da.Fill(dt);
            return dt;
        }
        public bool isExists(string maSP, string maDM)
        {
            OpenConnection();
            string select = "select count(*) from SANPHAM where MASP = '" + maSP + "' and MADM  = '" + maDM + "'";

            SqlCommand cmd = new SqlCommand(select, conn);
            int kq = (int)cmd.ExecuteScalar();
            conn.Close();
            return kq > 0;
        }
        public bool fk_Delete(string maSP, string maDM)
        {
            OpenConnection();
            string select = "select count(*) from CHITIETHOADON where MASP = '" + maSP + "'";
            string select2 = "select count(*) from DANHMUC where MADM = '" + maDM + "'";

            SqlCommand cmd = new SqlCommand(select, conn);
            SqlCommand cmd2 = new SqlCommand(select2, conn);

            int kq = (int)cmd.ExecuteScalar();
            int kq2 = (int)cmd2.ExecuteScalar();
            conn.Close();

            if (kq == 0 && kq2 == 0)
                return true;
            else
                return false;
        }
        public DataTable LoadGridView()
        {
            OpenConnection();
            DataTable dt = new DataTable();
            string query = "select * from SANPHAM";
            SqlDataAdapter da = new SqlDataAdapter(query, conn);
            da.Fill(dt);
            return dt;
        }
        public bool addValue(SanPhamDTO sp)
        {
            OpenConnection();
            string insert = "insert into SANPHAM(MASP, TENSP, MOTA, GIA, SLTONKHO, MADM) values('" + sp.MaSP + "',N'" + sp.TenSP + "',N'" + sp.MoTa + "','" + sp.Gia + "','" + sp.SLTonKho + "','" + sp.MaDM + "')";
            SqlCommand cmd = new SqlCommand(insert, conn);
            int kq = cmd.ExecuteNonQuery();
            return kq > 0;
        }
        public bool deleteValue(string ma)
        {
            OpenConnection();
            string dele = "delete from SANPHAM where MASP = '" + ma + "'";
            SqlCommand cmd = new SqlCommand(dele, conn);
            int kq = cmd.ExecuteNonQuery();
            return kq > 0;
        }
        public bool editValue(SanPhamDTO sp)
        {
            OpenConnection();
            string edit = "update SANPHAM set TENSP= '" + sp.TenSP + "', MOTA = '" + sp.MoTa + "', GIA = '" + sp.Gia + "',SLTONKHO= '" + sp.SLTonKho + "' where MASP ='" + sp.MaSP + "', MADM = '" + sp.MaDM + "'";
            SqlCommand cmd = new SqlCommand(edit, conn);
            int kq = cmd.ExecuteNonQuery();
            return kq > 0;
        }
    }
}
