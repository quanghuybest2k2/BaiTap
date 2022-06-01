using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameworkCodeFirst
{
    public class Lop
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public virtual ICollection<SinhVien> sinhviens { get; set; }
        public Lop()
        {
            sinhviens = new HashSet<SinhVien>();
        }
    }
}
