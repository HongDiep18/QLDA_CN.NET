using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class PhieuNhapBLL
    {
        PhieuNhapDAL pnDAL { get; set; }
        PhieuNhapDTO pnDTO { get; set; }
        public PhieuNhapBLL() 
        {
            pnDAL = new PhieuNhapDAL();
            pnDTO = new PhieuNhapDTO();
        }
        public bool insert(PhieuNhapDTO tmp)
        { 
            return pnDAL.insert_PhieuNhap(tmp);
        }
    }
}
