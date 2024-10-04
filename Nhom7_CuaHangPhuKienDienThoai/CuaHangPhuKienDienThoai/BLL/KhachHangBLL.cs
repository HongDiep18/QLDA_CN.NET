using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;
namespace BLL
{
    
    public class KhachHangBLL
    {
        KhachHangDAL KhachHangDAL { get; set; }
        KhachHangDTO KhachHangDTO { get; set; }
        
        public KhachHangBLL()
        {
            KhachHangDAL = new KhachHangDAL();
            KhachHangDTO = new KhachHangDTO();
        }
        public List<KhachHangDTO> get_ds_KH()
        {
            return KhachHangDAL.get_DanhSach_KhachHang();
        }
        public KhachHangDTO Tim_1KH(string ma)
        {
            KhachHangDTO tmp = new KhachHangDTO();
            List<KhachHangDTO> tmp_ = get_ds_KH();
            foreach(KhachHangDTO k in tmp_)
            {
                if(ma==k.MaKH)
                {
                    tmp = k;
                    return k;
                }    
            }
            return tmp;
        }
    }
}
