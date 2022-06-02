using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity;

namespace EntityFrameworkCodeFirst
{
    public partial class frmCodeFirst : Form
    {
        private QLSVContext context;
        private string textSearch = "Nhập tên sinh viên";
        public frmCodeFirst()
        {
            InitializeComponent();
        }

        private void frmCodeFirst_Load(object sender, EventArgs e)
        {
            context = new QLSVContext();
            var list = context.sinhviens.ToList();
            SetSearchText();
            GetAllLop();
            btnReload.PerformClick();
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

        private void btnReload_Click(object sender, EventArgs e)
        {
            var list = context.sinhviens.Include(sv => sv.lop).ToList();
            LoadListView(list);
        }
        private void ThietLapThongTin(SinhVien sv)
        {
            txtHoTenSV.Text = sv.HoTen;
            txtId.Text = sv.Id.ToString();
            cbbLop.SelectedValue = sv.LopId;
        }
        private void lvDanhSachSV_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvDanhSachSV.SelectedItems.Count > 0)
            {
                var id = int.Parse(lvDanhSachSV.SelectedItems[0].Text);
                var sinhvien = context.sinhviens.Find(id);
                ThietLapThongTin(sinhvien);
            }
        }
        private void GetAllLop()
        {
            var list = context.lops.ToList();
            cbbLop.DisplayMember = "TenLop";
            cbbLop.ValueMember = "Id";
            cbbLop.DataSource = list;
        }
        private SinhVien GetSinhVien()
        {
            var sv = new SinhVien();
            if (!string.IsNullOrWhiteSpace(txtHoTenSV.Text))
            {
                sv.HoTen = txtHoTenSV.Text;
                sv.Id = string.IsNullOrWhiteSpace(txtId.Text) ? -1 : int.Parse(txtId.Text);
                sv.LopId = Convert.ToInt32(cbbLop.SelectedValue);
            }
            return sv;
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            var sv = GetSinhVien();
            if (sv == null)
            {
                MessageBox.Show("Lỗi, chưa nhập thông tin!", "Thông báo");
                return;
            }
            if (sv.Id < 0)
                context.sinhviens.Add(sv);
            else
            {
                var sinhvien = context.sinhviens.Find(sv.Id);
                sinhvien.HoTen = sv.HoTen;
                sinhvien.LopId = sv.LopId;
            }
            context.SaveChanges();
            btnReload.PerformClick();
        }
        private void SetSearchText()
        {
            txtTimKiem.Text = textSearch;
            txtTimKiem.GotFocus += GotFocus;
            txtTimKiem.LostFocus += LostFocus;
        }
        private void GotFocus(object sender, EventArgs e)
        {
            txtTimKiem.Text = "";
        }
        private void LostFocus(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTimKiem.Text))
            {
                txtTimKiem.Text = textSearch;
                btnReload.PerformClick();
            }
        }
        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            var SearchTextChange = txtTimKiem.Text;
            var list = context.sinhviens.Where(sv => sv.HoTen.Contains(SearchTextChange)).ToList();
            LoadListView(list);
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtHoTenSV.Text = "";
            txtId.Text = "";
        }
    }
}
