using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EntityFrameworkCodeFirst
{
    public partial class frmCodeFirst : Form
    {
        private QLSVContext context;
        public frmCodeFirst()
        {
            InitializeComponent();
        }

        private void frmCodeFirst_Load(object sender, EventArgs e)
        {
            context = new QLSVContext();
            var list = context.sinhviens.ToList();
            LoadListView(list);
        }
        private void LoadListView(List<SinhVien> list)
        {
            lvDanhSachSV.Items.Clear();
            foreach (var sv in list)
            {
                ThemSV(sv);
            }
        }
        private void ThemSV(SinhVien sv)
        {
            string[] row = { sv.Id.ToString(), sv.HoTen, sv.lop.Name };
            var item = new ListViewItem(row);
            lvDanhSachSV.Items.Add(item);
        }
    }
}
