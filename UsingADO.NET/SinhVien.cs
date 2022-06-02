using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsingADO.NET
{
    public class SinhVien
    {
        public int IDSinhVien { get; set; }
        public string Hoten { get; set; }
        public int IDlop { get; set; }
        public SinhVien(int iDSinhVien, string hoten, int iDlop)
        {
            IDSinhVien = iDSinhVien;
            Hoten = hoten;
            IDlop = iDlop;
        }
        public SinhVien(DataRow row)
        {
            IDSinhVien = Convert.ToInt32(row["ID"]);
            Hoten = row["HoTen"].ToString();
            IDlop = Convert.ToInt32(row["MaLop"]);
        }

        public SinhVien()
        {
        }
    }
}
