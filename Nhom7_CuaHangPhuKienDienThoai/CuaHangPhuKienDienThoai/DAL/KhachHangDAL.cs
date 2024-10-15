using DTO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
namespace DAL
{
    public class KhachHangDAL
    {
<<<<<<< HEAD
        string conStr = "Data Source=HONGDIEP;Initial Catalog=Nhom7_CuaHangPhuKienDienThoai;User ID=sa;Password=123";
=======
        string conStr = "Data Source=HONGDIEP;Initial Catalog=DB_QL_PKDT;User ID=sa;Password=123";
>>>>>>> 017fb19194f544d3fc2d51eebc6d44bf6340a58b
        SqlConnection conn;
        public KhachHangDAL()
        {
            conn = new SqlConnection(conStr);
        }

        public List<KhachHangDTO> get_DanhSach_KhachHang()
        {
            List<KhachHangDTO> ds = new List<KhachHangDTO>();
            string sql = "select * from KHACHANG";
            conn.Open();
            SqlCommand cmd = new SqlCommand(sql, conn);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                string ma = dr[0].ToString();
                string ten = dr[1].ToString();
                string email = dr[2].ToString();
                string sdt = dr[3].ToString();
                string dchi = dr[4].ToString();
                string passw = dr[5].ToString();
                KhachHangDTO tmp = new KhachHangDTO(ma, ten, email, sdt, dchi, passw);
                ds.Add(tmp);
            }
            conn.Close();
            return ds;
        }
        public bool KT_TrungMaKH(string ma)
        {
            string sql = "select count(*) from KHACHANG where MAKH='" + ma + "'";
            conn.Open();
            SqlCommand cmd= new SqlCommand(sql, conn);
            int kt=(int)cmd.ExecuteScalar();
            conn.Close();
            if (kt > 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        public bool InsertKH(string ma, string ten, string email, string sdt, string dc)
        {
            string sql = "insert into KHACHANG values ('" + ma + "','" + ten + "','" + email + "','" + sdt + "','" + dc + "')";
            conn.Open();
            SqlCommand cmd=new SqlCommand(sql, conn);
            int kt = (int)cmd.ExecuteNonQuery();
            conn.Close();
            if (kt > 0)
            {
                return true;
            }
            else
            {
                return false;
            }    
        }
        public bool Xoa_KH(KhachHangDTO tmp)
        {
            string sql = "delete from KHACHANG where MAKH='"+tmp.MaKH+"'";
            conn.Open();
            SqlCommand cmd = new SqlCommand(sql, conn);
            int kt = (int)cmd.ExecuteNonQuery();
            conn.Close();
            if (kt > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool Sua_KH(KhachHangDTO tmp)
        {
            string sql = "update KHACHANG set TENKH='" + tmp.TenKH + "',EMAIL='" + tmp.Email + "',SDT='" + tmp.SDT + "',DIACHI='" + tmp.DChi + "' where MAKH='" + tmp.MaKH + "'";
            conn.Open();
            SqlCommand cmd = new SqlCommand(sql, conn);
            int kt = (int)cmd.ExecuteNonQuery();
            conn.Close();
            if (kt > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
