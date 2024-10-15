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
        public bool insertHoaDonDAL(string mahd, string makh, string tong, string giamgia, string phaitra)
        {
            try
            {
                
                string sql = "insert into HOADON (MAHD,MAKH,TONGTIEN,GIAMGIA,PHAITRA) values ('" + mahd + "','" + makh + "'," + tong + "," + giamgia + "," + phaitra + ")";
                conn.Open();
                SqlCommand cmd = new SqlCommand(sql, conn);
                int kq = (int)cmd.ExecuteNonQuery();
                conn.Close();
                if(kq>0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }catch (Exception ex)
            {
                return false;
            }
        
        }
    }
}
