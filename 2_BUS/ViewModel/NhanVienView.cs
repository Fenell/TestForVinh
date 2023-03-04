using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _1_DAL.Models;

namespace _2_BUS.ViewModel
{
    public class NhanVienView
    {
        public Guid idNV { get; set; }
        public string Ho { get; set; }
        public string TenDem { get; set; }
        public string Ten { get; set; }
        public string Sdt { get; set; }
        public string DiaChi { get; set; }
        public string GioiTinh { get; set; }
        public string ChucVu { get; set; }
    }
}
