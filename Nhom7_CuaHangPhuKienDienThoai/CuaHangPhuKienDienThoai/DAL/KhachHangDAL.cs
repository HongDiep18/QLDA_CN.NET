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
        string conStr = "Data Source=DESKTOP-JARJMT7\\SA;Initial Catalog=Nhom7_CuaHangPhuKienDienThoai;User ID=sa;Password=123";
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
               
                KhachHangDTO tmp = new KhachHangDTO(ma, ten, email, sdt, dchi);
                ds.Add(tmp);
            }
            conn.Close();
            return ds;
        }
    }
}
