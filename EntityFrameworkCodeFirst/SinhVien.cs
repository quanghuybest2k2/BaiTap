using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameworkCodeFirst
{
    public class SinhVien
    {
        public int Id { get; set; }
        public string HoTen { get; set; }
        public int LopId { get; set; }
        public virtual Lop lop { get; set; }
        public SinhVien()
        {

        }
    }
}
