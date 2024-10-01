using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer;
using System.Data.SqlClient;
namespace BusinessLayer
{
    public class ConnectDanhMuc
    {
        string conStr = "Data Source=DESKTOP-JARJMT7\\SA;Initial Catalog=Nhom7_CuaHangPhuKienDienThoai;User ID=sa;Password=123";
        public List<DanhMuc> get_data_DanhMuc()
        {
            List<DanhMuc> ds= new List<DanhMuc>();
            SqlConnection con = new SqlConnection(conStr);
            con.Open();

            string sql = "select * from DANHMUC";
            SqlCommand cmd = new SqlCommand(sql, con);
            SqlDataReader rd = cmd.ExecuteReader();
            while (rd.Read())
            {
                string madm = rd[0].ToString();
                string tendm= rd[1].ToString();
                DanhMuc tmp = new DanhMuc(madm,tendm);
                ds.Add(tmp);
            }
            con.Close();
            return ds;

        }
        
    }
}
