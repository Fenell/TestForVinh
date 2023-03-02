using _1_DAL.Models;
using _2_BUS.IServices;
using _2_BUS.Services;

namespace _3_GUI
{
    public partial class Form1 : Form
    {
        INhanVienViewService _nhanvienViewService;
        private Guid _id;

        public Form1()
        {
            InitializeComponent();
            _nhanvienViewService = new NhanVienviewServices();
        }

        void LoadData()
        {
            //load Combobox
            cbbChucVu.DisplayMember = "Ten";
            //lấy value là Id
            cbbChucVu.ValueMember = "Id";
            cbbChucVu.DataSource = _nhanvienViewService.GetAllNhanVienViews().Select(x => x.ChucVu).ToList();

            dgvNhanvien.ColumnCount = 6;
            dgvNhanvien.Columns[0].Visible = false;
            dgvNhanvien.Columns[1].Name = "Ho va ten";
            dgvNhanvien.Columns[2].Name = "Sdt";
            dgvNhanvien.Columns[3].Name = "Gioi tinh";
            dgvNhanvien.Columns[4].Name = "Dia chi";
            dgvNhanvien.Columns[5].Name = "Chuc vu";

            dgvNhanvien.Rows.Clear();
            foreach (var x in _nhanvienViewService.GetAllNhanVienViews())
            {
                dgvNhanvien.Rows.Add(x.NhanVien.Id, $"{x.NhanVien.Ho} {x.NhanVien.TenDem} {x.NhanVien.Ten}",
                    x.NhanVien.Sdt, x.NhanVien.GioiTinh, x.NhanVien.DiaChi, x.ChucVu.Ten);
            }

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            NhanVien nhanVien = new NhanVien()
            {
                Ho = txtHo.Text,
                TenDem = txTenDem.Text,
                Ten = txtTen.Text,
                Sdt = txtSdt.Text,
                GioiTinh = rBtnNam.Checked? "Nam": "Nu",
                DiaChi = txtDiaChi.Text,
                IdCv = Guid.Parse(cbbChucVu.SelectedValue.ToString())
            };
            MessageBox.Show(_nhanvienViewService.AddNhanVien(nhanVien));
            LoadData();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            NhanVien nhanVien = new NhanVien()
            {
                Id = _id,
                Ho = txtHo.Text,
                TenDem = txTenDem.Text,
                Ten = txtTen.Text,
                Sdt = txtSdt.Text,
                GioiTinh = rBtnNam.Checked? "Nam": "Nu",
                DiaChi = txtDiaChi.Text,
                IdCv = Guid.Parse(cbbChucVu.SelectedValue.ToString())
            };
            MessageBox.Show(_nhanvienViewService.UpdateNhanVien(nhanVien));
            LoadData();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            MessageBox.Show(_nhanvienViewService.DeleteNhanVien(_id));
            LoadData();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void dgvNhanvien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = e.RowIndex;
            //bam ra ngoai chet chuong trinh
            if (rowIndex == -1|| rowIndex == _nhanvienViewService.GetAllNhanVienViews().Count)
            {
                return;
            }

            _id = Guid.Parse(dgvNhanvien.Rows[rowIndex].Cells[0].Value.ToString());
            var nhanvien = _nhanvienViewService.GetAllNhanVienViews().FirstOrDefault(c => c.NhanVien.Id == _id);

            txTenDem.Text = nhanvien.NhanVien.TenDem;
            txtSdt.Text = nhanvien.NhanVien.Sdt;
            txtHo.Text = nhanvien.NhanVien.Ho;
            txtTen.Text = nhanvien.NhanVien.Ten;
            txtDiaChi.Text = nhanvien.NhanVien.DiaChi;
            cbbChucVu.Text = nhanvien.ChucVu.Ten;
            
            if (nhanvien.NhanVien.GioiTinh == "Nam")
            {
                rBtnNam.Checked = true;
                return;
            }

            rBtnNu.Checked = true;
        }

        private void txtTim_TextChanged(object sender, EventArgs e)
        {
            cbbChucVu.DisplayMember = "Ten";
            //lấy value là Id
            cbbChucVu.ValueMember = "Id";
            cbbChucVu.DataSource = _nhanvienViewService.GetAllNhanVienViews().Select(x => x.ChucVu).ToList();

            dgvNhanvien.ColumnCount = 6;
            dgvNhanvien.Columns[0].Visible = false;
            dgvNhanvien.Columns[1].Name = "Ho va ten";
            dgvNhanvien.Columns[2].Name = "Sdt";
            dgvNhanvien.Columns[3].Name = "Gioi tinh";
            dgvNhanvien.Columns[4].Name = "Dia chi";
            dgvNhanvien.Columns[5].Name = "Chuc vu";

            dgvNhanvien.Rows.Clear();
            foreach (var x in _nhanvienViewService.GetAllNhanVienViews().Where(c=>c.NhanVien.DiaChi.ToLower().Contains(txtTim.Text.ToLower())))
            {
                dgvNhanvien.Rows.Add(x.NhanVien.Id, $"{x.NhanVien.Ho} {x.NhanVien.TenDem} {x.NhanVien.Ten}",
                    x.NhanVien.Sdt, x.NhanVien.GioiTinh, x.NhanVien.DiaChi, x.ChucVu.Ten);
            }

            //Cach 2:

            //foreach (var x in _nhanvienViewService.FindNhanVien(txtTim.Text))
            //{
            //    dgvNhanvien.Rows.Add(x.NhanVien.Id, $"{x.NhanVien.Ho} {x.NhanVien.TenDem} {x.NhanVien.Ten}",
            //        x.NhanVien.Sdt, x.NhanVien.GioiTinh, x.NhanVien.DiaChi, x.ChucVu.Ten);
            //}
        }
    }
}