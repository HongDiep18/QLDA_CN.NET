using DTO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class ChiTietHoaDonDAL
    {
        string conStr = "Data Source=HONGDIEP;Initial Catalog=DB_QL_PKDT;User ID=sa;Password=123";
        SqlConnection conn;
        public ChiTietHoaDonDAL() 
        {
            conn = new SqlConnection(conStr);
        }
        public int insert_ChiTietHD(ChiTietHoaDonDTO hoaDonDTO)
        {
            int kq = -1;
            string sql = "insert into CHITIETHOADON values ('" + hoaDonDTO.MaHD + "','" + hoaDonDTO.MaSP + "'," + hoaDonDTO.SL + "," + hoaDonDTO.Gia + ")";
            conn.Open();
            SqlCommand cmd = new SqlCommand(sql, conn);
            kq= (int)cmd.ExecuteNonQuery();
            conn.Close();
            return kq;
        }
    }
}
