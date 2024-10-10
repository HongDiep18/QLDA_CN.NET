using DTO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class NhaCungCapDAL
    {
        string conStr = "Data Source=DESKTOP-JARJMT7\\SA;Initial Catalog=Nhom7_CuaHangPhuKienDienThoai;User ID=sa;Password=123";
        SqlConnection conn;
        public NhaCungCapDAL() 
        {
            conn = new SqlConnection(conStr);
        }
        public List<NhaCungCapDTO> get_ds_NCC()
        {
            List<NhaCungCapDTO> ds_= new List<NhaCungCapDTO>();
            string sql = "select * from NHACC";
            conn.Open();
            SqlCommand cmd = new SqlCommand(sql, conn);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                string ma = reader[0].ToString();
                string ten = reader[1].ToString();
                string dc = reader[2].ToString();
                string sdt = reader[3].ToString();
                string email = reader[4].ToString();
                NhaCungCapDTO tmp = new NhaCungCapDTO(ma,ten,dc,sdt,email);
                ds_.Add(tmp);
            }
            conn.Close();
            return ds_;
        }
        
    }
}
