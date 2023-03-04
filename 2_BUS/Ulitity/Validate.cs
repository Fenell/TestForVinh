using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _2_BUS.Ulitity
{
    public class Validate
    {
        public bool CheckSdt(string value)
        {
            if (Regex.IsMatch(value, @"(0)+[0-9]{9}"))
            {
                return true;
            }
            return false;
        }

        public bool CheckTen(string value)
        {
            if (Regex.IsMatch(value, @"[a-zA-Z]"))
            {
                return true;
            }
            return false;
        }

        public bool CheckSoNguyen(string value)
        {
            if (Regex.IsMatch(value, @"[0-9]+"))
            {
                if (decimal.Parse(value) > 0)
                {
                    return true;
                }
            }
            return false;
        }

        public bool Checkgia(decimal giaNhap, decimal giaBan)
        {
            if (giaNhap < 0)
            {
                return false;
            }

            if (giaBan < giaNhap)
            {
                return false;
            }
            return true;
        }

    }
}
