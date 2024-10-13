﻿using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class NhanVienBLL
    {
        public NhanVienDAL nvDAL { get; set; }
        public NhanVienBLL() 
        { 
            nvDAL = new NhanVienDAL();
        }
        public List<NhanVienDTO>get_ds_nv()
        {
            return nvDAL.getdata();
        }
        public bool Them_NV(NhanVienDTO nv)
        {
            return nvDAL.insert_NV(nv);
        }
        public bool Xoa_NV(NhanVienDTO nv)
        {
            return nvDAL.Xoa_NV(nv);
        }
        public bool Sua_NV(NhanVienDTO nv)
        {
            return nvDAL.Sua_NV(nv);
        }
    }
}