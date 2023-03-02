using System;
using System.Collections.Generic;

namespace _1_DAL.Models
{
    public partial class Nxb
    {
        public Nxb()
        {
            Saches = new HashSet<Sach>();
        }

        public Guid Id { get; set; }
        public string? Ma { get; set; }
        public string? Ten { get; set; }

        public virtual ICollection<Sach> Saches { get; set; }
    }
}
