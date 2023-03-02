using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _1_DAL.Models;
using _2_BUS.ViewModel;

namespace _2_BUS.IServices
{
    public interface INhanVienViewService
    {
        string AddNhanVien(NhanVien nhanVien);
        string UpdateNhanVien(NhanVien nhanVien);
        string DeleteNhanVien(Guid id);
        List<NhanVienView> FindNhanVien(string str);
        List<NhanVienView> GetAllNhanVienViews();
    }
}
