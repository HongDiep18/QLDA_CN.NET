using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class NhaCungCapBLL
    {
        public NhaCungCapDAL nccDAL { get; set; }
        public NhaCungCapDTO nccDTO { get; set; }
        public NhaCungCapBLL()
        {
            nccDAL = new NhaCungCapDAL();
            nccDTO = new NhaCungCapDTO();
        }
        public List<NhaCungCapDTO> GetAll()
        {
            return nccDAL.get_ds_NCC();
        }
        public bool addValue(NhaCungCapDTO ncc)
        {
            return nccDAL.addValue(ncc);
        }
        public bool editValue(NhaCungCapDTO ncc)
        {
            return nccDAL.editValue(ncc);
        }
        public bool deleteValue(string ma)
        {
            return nccDAL.deleteValue(ma);
        }
    }
}
