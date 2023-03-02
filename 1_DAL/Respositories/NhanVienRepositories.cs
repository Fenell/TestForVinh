using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _1_DAL.DbContext;
using _1_DAL.IRespositoes;
using _1_DAL.Models;

namespace _1_DAL.Respositories
{
    public class NhanVienRepositories : INhanVienRepositories
    {
        VinhContext _context;

        public NhanVienRepositories()
        {
            _context = new VinhContext();
        }
        public bool AddNhanVien(NhanVien obj)
        {
            try
            {
                if (obj != null)
                {
                    obj.Id = Guid.NewGuid();
                    _context.Add(obj);
                    _context.SaveChanges();
                    return true; 
                }
                return false;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool UpdateNhanVien(NhanVien obj)
        {
            var nhanvien = _context.NhanViens.FirstOrDefault(c => c.Id == obj.Id);
            if (nhanvien != null)
            {
                nhanvien.Ho = obj.Ho;
                nhanvien.TenDem = obj.TenDem;
                nhanvien.DiaChi = obj.DiaChi;
                nhanvien.Ten = obj.Ten;
                nhanvien.Sdt = obj.Sdt;
                nhanvien.GioiTinh = obj.GioiTinh;
                nhanvien.IdCv = obj.IdCv;
                _context.Update(nhanvien);
                _context.SaveChanges();
                return true;
            }

            return false;
        }

        public bool RemoveNhanVien(Guid id)
        {
            var nhanvien = _context.NhanViens.Find(id);
            if (nhanvien != null)
            {
                _context.NhanViens.Remove(nhanvien);
                _context.SaveChanges();
                return true;
            }

            return false;
        }

        public List<NhanVien> GetAllNhanVienFromDb()
        {
            var  lstNhanvien = _context.NhanViens.ToList();
            return lstNhanvien;
        }
    }
}
