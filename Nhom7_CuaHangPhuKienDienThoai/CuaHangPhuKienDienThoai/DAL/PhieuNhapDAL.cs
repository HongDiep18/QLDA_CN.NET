using DTO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class PhieuNhapDAL
    {
        string conStr = "Data Source=DESKTOP-JARJMT7\\SA;Initial Catalog=Nhom7_CuaHangPhuKienDienThoai;User ID=sa;Password=123";
        SqlConnection conn;
        public PhieuNhapDAL()
        {
            conn = new SqlConnection(conStr);
        }
        public bool insert_PhieuNhap(PhieuNhapDTO tmp)
        {
            string sql = "insert into PHIEUNHAP(MAPN,MANCC,TONGTIEN) values('"+tmp.MaPN+"','"+tmp.MaNCC+"',"+tmp.TongTien+")";
            conn.Open();
            SqlCommand cmd = new SqlCommand(sql, conn);
            int k1= (int)cmd.ExecuteNonQuery();
            conn.Close();
            if(k1>0)
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
