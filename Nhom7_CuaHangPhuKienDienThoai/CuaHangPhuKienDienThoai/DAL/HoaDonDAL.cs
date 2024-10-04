using DTO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class HoaDonDAL
    {
        string conStr = "Data Source=DESKTOP-JARJMT7\\SA;Initial Catalog=Nhom7_CuaHangPhuKienDienThoai;User ID=sa;Password=123";
        SqlConnection conn;
        public HoaDonDAL()
        {
            conn = new SqlConnection(conStr);
        }
        public int insertHoaDonDAL(string mahd, string makh)
        {
            int kq = -1;
            string sql = "insert into HOADON (MAHD,MAKH) values ('"+mahd+"','"+makh+"')";
            conn.Open();
            SqlCommand cmd = new SqlCommand(sql, conn);
            kq = (int)cmd.ExecuteNonQuery();
            conn.Close();
            return kq;
        }
    }
}
