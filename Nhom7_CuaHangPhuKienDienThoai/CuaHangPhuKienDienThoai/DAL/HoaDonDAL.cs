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
<<<<<<< HEAD
        string conStr = "Data Source=HONGDIEP;Initial Catalog=Nhom7_CuaHangPhuKienDienThoai;User ID=sa;Password=123";
=======
        string conStr = "Data Source=HONGDIEP;Initial Catalog=DB_QL_PKDT;User ID=sa;Password=123";
>>>>>>> 017fb19194f544d3fc2d51eebc6d44bf6340a58b
        SqlConnection conn;
        public HoaDonDAL()
        {
            conn = new SqlConnection(conStr);
        }
        public int insertHoaDonDAL(string mahd, string makh,string tong, string giamgia, string phaitra)
        {
            int kq = -1;
            string sql = "insert into HOADON (MAHD,MAKH,TONGTIEN,GIAMGIA,PHAITRA) values ('"+mahd+"','"+makh+"',"+tong+","+giamgia+","+phaitra+")";
            conn.Open();
            SqlCommand cmd = new SqlCommand(sql, conn);
            kq = (int)cmd.ExecuteNonQuery();
            conn.Close();
            return kq;
        }
    }
}
