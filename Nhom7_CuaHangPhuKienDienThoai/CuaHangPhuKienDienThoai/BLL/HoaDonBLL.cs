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
        public bool insert_HoaDon(string mahd, string makh)
        {
            if(hoaDonDAL.insertHoaDonDAL(mahd, makh)!=-1)
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
