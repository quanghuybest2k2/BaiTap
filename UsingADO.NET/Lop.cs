using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsingADO.NET
{
    public class Lop
    {
        public int IDlop { get; set; }
        public string TenLop { get; set; }
        public Lop(int iDlop, string tenLop)
        {
            IDlop = iDlop;
            TenLop = tenLop;
        }
        public Lop(DataRow row)
        {
            IDlop = Convert.ToInt32(row["ID"]);
            TenLop = row["TenLop"].ToString();
        }
    }
}
