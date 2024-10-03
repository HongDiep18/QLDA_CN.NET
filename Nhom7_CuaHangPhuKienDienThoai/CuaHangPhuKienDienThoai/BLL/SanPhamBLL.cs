using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;
namespace BLL
{
    public class SanPhamBLL
    {
        public SanPhamDAL sanphamDAL { get; set; }
        public SanPhamDTO sanphamDTO { get; set; }
        public SanPhamBLL() 
        {
            sanphamDAL = new SanPhamDAL();
            sanphamDTO = new SanPhamDTO();
        }
        public List<SanPhamDTO>get_data()
        {
            return sanphamDAL.get_DanhSachSP();
        }
    }
}
