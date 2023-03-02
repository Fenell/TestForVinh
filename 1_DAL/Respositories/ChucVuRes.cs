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
    public class ChucVuRes: IChucVuRes
    {
        VinhContext _context;

        public ChucVuRes()
        {
            _context = new VinhContext();
        }
        public List<ChucVu> GetChucVuFromDb()
        {
            return _context.ChucVus.ToList();
        }
    }
}
