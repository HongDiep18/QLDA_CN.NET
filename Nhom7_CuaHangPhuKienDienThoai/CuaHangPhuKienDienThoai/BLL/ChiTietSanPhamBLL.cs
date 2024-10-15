using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DAL;
using DTO;
namespace BLL
{
    public class ChiTietSanPhamBLL
    {
        ChiTietSanPhamDAL detailSP = new ChiTietSanPhamDAL();
        public DataTable LoadDanhMuc()
        {
            return detailSP.LoadDanhMuc();
        }
        public DataTable LoadGridView()
        {
            return detailSP.LoadGridView();
        }
        public bool addValue(SanPhamDTO sp)
        {
            if(!detailSP.isExists(sp.MaSP, sp.MaDM))
            {
                return detailSP.addValue(sp);
            }
            return false;
        }
        public bool deleteValue(string ma)
        {
            SanPhamDTO sp = new SanPhamDTO();
            if(detailSP.fk_Delete(sp.MaSP, sp.MaDM))
            {
                return detailSP.deleteValue(ma);
            }
            return false;
        }
        public bool editValue(SanPhamDTO sp)
        {
            return detailSP.editValue(sp);
        }
    }
}
