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

namespace EntityFrameworkDBFirst
{
    public partial class frmDBFirst : Form
    {
        private const string textSearch = "Nhập tên sinh viên";
        private QLSinhVienContext context;
        public frmDBFirst()
        {
            InitializeComponent();
        }

        private void frmDBFirst_Load(object sender, EventArgs e)
        {
            context = new QLSinhVienContext();
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
            string[] row = { sv.ID.ToString(), sv.HoTen, sv.Lop.TenLop };
            var item = new ListViewItem(row);
            lvDanhSachSV.Items.Add(item);
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
        private void GetAllLop()
        {
            var list = context.Lops.ToList();
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
                sv.ID = string.IsNullOrWhiteSpace(txtId.Text) ? -1 : int.Parse(txtId.Text);
                sv.MaLop = Convert.ToInt32(cbbLop.SelectedValue);
            }
            return sv;
        }
        private void ThietLapThongTin(SinhVien sv)
        {
            txtHoTenSV.Text = sv.HoTen;
            txtId.Text = sv.ID.ToString();
            cbbLop.SelectedValue = sv.MaLop;
        }
        private void btnReload_Click(object sender, EventArgs e)
        {
            var list = context.SinhViens.Include(sv => sv.Lop).ToList();
            LoadListView(list);
        }

        private void lvDanhSachSV_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvDanhSachSV.SelectedItems.Count > 0)
            {
                var id = int.Parse(lvDanhSachSV.SelectedItems[0].Text);
                var sinhvien = context.SinhViens.Find(id);
                ThietLapThongTin(sinhvien);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            var sv = GetSinhVien();
            if (sv == null)
            {
                MessageBox.Show("Lỗi, chưa nhập thông tin!", "Thông báo");
                return;
            }
            if (sv.ID < 0)
                context.SinhViens.Add(sv);
            else
            {
                var sinhvien = context.SinhViens.Find(sv.ID);
                sinhvien.HoTen = sv.HoTen;
                sinhvien.MaLop = sv.MaLop;
            }
            context.SaveChanges();
            btnReload.PerformClick();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtId.Text = "";
            txtHoTenSV.Text = "";
        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            var SearchTextChange = txtTimKiem.Text;
            var list = context.SinhViens.Where(sv => sv.HoTen.Contains(SearchTextChange)).ToList();
            LoadListView(list);
        }
    }
}
