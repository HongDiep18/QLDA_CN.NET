using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using System.Data.SqlClient;
namespace DAL
{
    public class SanPhamDAL
    {
        string conStr = "Data Source=HONGDIEP;Initial Catalog=DB_QL_PKDT;User ID=sa;Password=123";
        SqlConnection conn;
        public SanPhamDAL() 
        {
            conn = new SqlConnection(conStr);
        }
        public List<SanPhamDTO>get_DanhSachSP()
        {
            List<SanPhamDTO> ds = new List<SanPhamDTO>();
            string sql = "select * from SANPHAM";
            conn.Open();
            SqlCommand cmd = new SqlCommand(sql, conn);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                string ma = dr[0].ToString();
                string ten = dr[1].ToString();
                string mota = dr[2].ToString();
                string gia = dr[3].ToString();
                string sl = dr[4].ToString();
                string madm = dr[5].ToString();
                SanPhamDTO tmp = new SanPhamDTO(ma,ten, mota, float.Parse(gia), int.Parse(sl),madm);
                ds.Add(tmp);
            }
            conn.Close();
            return ds;
        }

    }
}
