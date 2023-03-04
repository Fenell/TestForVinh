using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _1_DAL.IRespositoes;
using _1_DAL.Models;
using _1_DAL.Respositories;
using _2_BUS.IServices;
using _2_BUS.ViewModel;

namespace _2_BUS.Services
{
    public class NhanVienviewServices : INhanVienViewService
    {
        private INhanVienRepositories _iNhanVienRepositories;
        private IChucVuRes _iChucVuRes;

        public NhanVienviewServices()
        {
            _iNhanVienRepositories = new NhanVienRepositories();
            _iChucVuRes = new ChucVuRes();
        }
        public string AddNhanVien(NhanVien nhanVien)
        {
            if (_iNhanVienRepositories.AddNhanVien(nhanVien))
            {
                return "Them thanh cong";
            }

            return "k Thanh cong";
        }

        public string UpdateNhanVien(NhanVien nhanVien)
        {
            if (_iNhanVienRepositories.UpdateNhanVien(nhanVien))
            {
                return "Sua thanh cong";
            }

            return "k thanh cong";
        }

        public string DeleteNhanVien(Guid id)
        {
            if (_iNhanVienRepositories.RemoveNhanVien(id))
            {
                return "xoa thanh cong";
            }

            return "k thanh cong";
        }

        public List<NhanVienView> FindNhanVien(string str)
        {
            throw new NotImplementedException();
        }


        public List<NhanVienView> GetAllNhanVienViews()
        {
            //var lst = (from nv in _iNhanVienRepositories.GetAllNhanVienFromDb()
            //    join chucVu in _iChucVuRes.GetChucVuFromDb() on nv.IdCv equals chucVu.Id 
            //    select new NhanVienView()
            //    {
            //        NhanVien = nv,
            //        ChucVu = chucVu
            //    }).ToList();
            //return lst;

            //left join

            var lst = (from nv in _iNhanVienRepositories.GetAllNhanVienFromDb()
                join cv in _iChucVuRes.GetChucVuFromDb() on nv.IdCv equals cv.Id into a
                from chucVu in a.DefaultIfEmpty()
                select new NhanVienView()
                {
                    Ho = nv.Ho,
                    TenDem = nv.TenDem,
                    Ten = nv.Ten,
                    DiaChi = nv.DiaChi,
                    GioiTinh = nv.GioiTinh,
                    Sdt = nv.Sdt,
                    ChucVu = nv.IdCv != null? chucVu.Ten: ""
                }).ToList();
            return lst;
        }
        
    }
}
