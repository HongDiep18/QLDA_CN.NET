using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class HoaDonBLL
    {
        HoaDonDTO hoaDonDTO { get; set; }
        HoaDonDAL hoaDonDAL { get; set;}
        public HoaDonBLL() { 
            hoaDonDAL= new HoaDonDAL();
            hoaDonDTO= new HoaDonDTO(); 
        }
        public bool insert_HoaDon(string mahd, string makh,string tong, string giam, string phaitra)
        {
            if(hoaDonDAL.insertHoaDonDAL(mahd, makh,tong,giam,phaitra))
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
