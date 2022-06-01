using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;
using System.Globalization;

namespace UsingADO.NET
{
    public partial class frmADO : Form
    {
        public frmADO()
        {
            InitializeComponent();
        }
        private string ChuoiKetNoi;
        private const string textSearch = "Nhập tên sinh viên";
        private List<Lop> DanhSachLop;
        private List<SinhVien> DanhSachSV;

        private void frmADO_Load(object sender, EventArgs e)
        {
            ChuoiKetNoi = ConfigurationManager.ConnectionStrings["QLSinhVien"].ConnectionString;
            DanhSachLop = new List<Lop>();
            DanhSachSV = new List<SinhVien>();
            SetSearchText();
            GetAllLop();
            GetAllSinhVien();
            LoadListView(DanhSachSV);
        }

        private void SetSearchText()
        {
            txtTimKiem.Text = textSearch;
            //txtTimKiem.GotFocus += XoaText;
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
            string[] row = { sv.IDSinhVien.ToString(), sv.Hoten, sv.IDlop.ToString() };
            var item = new ListViewItem(row);
            lvDanhSachSV.Items.Add(item);
        }
        private void btnReset_Click(object sender, EventArgs e)
        {
            txtHoTenSV.Text = "";
            txtId.Text = "";
        }
        private SinhVien GetSinhVien()
        {
            var sv = new SinhVien();
            if (!string.IsNullOrWhiteSpace(txtHoTenSV.Text))
            {
                sv.Hoten = txtHoTenSV.Text;
                sv.IDSinhVien = string.IsNullOrWhiteSpace(txtId.Text) ? -1 : int.Parse(txtId.Text);
                sv.IDlop = Convert.ToInt32(cbbLop.SelectedValue);
            }
            return sv;
        }
        private void GetAllLop()
        {
            var sqlConnection = new SqlConnection(ChuoiKetNoi);
            var command = sqlConnection.CreateCommand();
            command.CommandText = "select * from Lop";

            var adapter = new SqlDataAdapter(command);
            var tb = new DataTable("Lop");
            sqlConnection.Open();
            adapter.Fill(tb);
            sqlConnection.Close();
            foreach (DataRow row in tb.Rows)
            {
                DanhSachLop.Add(new Lop(row));
            }
            cbbLop.DisplayMember = "TenLop";
            cbbLop.ValueMember = "Id";
            cbbLop.DataSource = DanhSachLop;
        }
        private void GetAllSinhVien()
        {
            var sqlConnection = new SqlConnection(ChuoiKetNoi);
            var command = sqlConnection.CreateCommand();
            command.CommandText = "select * from SinhVien";
            var adapter = new SqlDataAdapter(command);
            var tb = new DataTable("SinhVien");
            sqlConnection.Open();
            adapter.Fill(tb);
            sqlConnection.Close();
            foreach (DataRow row in tb.Rows)
            {
                DanhSachSV.Add(new SinhVien(row));
            }
        }
        private void ThietLapThongTin(SinhVien sv)
        {
            txtHoTenSV.Text = sv.Hoten;
            txtId.Text = sv.IDSinhVien.ToString();
            cbbLop.SelectedValue = sv.IDlop;
        }
        private void btnReload_Click(object sender, EventArgs e)
        {
            GetAllSinhVien();
            LoadListView(DanhSachSV);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            var sv = GetSinhVien();
            if (sv == null)
            {
                MessageBox.Show("Lỗi, chưa nhập thông tin!", "Thông báo");
                return;
            }
            var sqlConnection = new SqlConnection(ChuoiKetNoi);
            var command = sqlConnection.CreateCommand();
            if (sv.IDSinhVien < 0)
                command.CommandText = "exec InsertStudent @Hoten, @Malop";
            else
            {
                command.CommandText = "update SinhVien set Hoten =@Hoten, Malop=@Malop where id = @Id";
            }
            command.Parameters.AddWithValue("@Hoten", sv.Hoten);
            command.Parameters.AddWithValue("@Malop", sv.IDlop);
            command.Parameters.AddWithValue("@Id", sv.IDSinhVien);

            sqlConnection.Open();
            var numofvalue = command.ExecuteNonQuery();
            if (numofvalue > 0)
            {
                btnReload.PerformClick();
            }
            sqlConnection.Close();
        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            var list = DanhSachSV.Where(sv => sv.Hoten.IndexOf(txtTimKiem.Text, StringComparison.InvariantCultureIgnoreCase) == 0).ToList();
            LoadListView(list);
        }
    }
}
