using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace EntityFrameworkCodeFirst
{
    public class QLSVContext : DbContext
    {
        public QLSVContext() : base("QLSVContext")
        {

        }
        public virtual DbSet<Lop> lops { get; set; }
        public virtual DbSet<SinhVien> sinhviens { get; set; }
    }
}
