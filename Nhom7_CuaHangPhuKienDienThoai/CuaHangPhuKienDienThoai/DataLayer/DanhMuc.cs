using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public class DanhMuc
    {
        public string MADM { get; set; }
        public string TENDM { get; set; }
        public DanhMuc() { }
        public DanhMuc(string mADM, string tENDM)
        {
            MADM = mADM;
            TENDM = tENDM;
        }

    }
}
