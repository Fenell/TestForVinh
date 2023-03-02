using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _1_DAL.Models;

namespace _1_DAL.IRespositoes
{
    public interface IChucVuRes
    {
        List<ChucVu> GetChucVuFromDb();
    }
}
