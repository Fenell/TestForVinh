using _1_DAL.Models;
using _2_BUS.IServices;
using _2_BUS.Services;
using _2_BUS.Ulitity;

namespace _3_GUI
{
    public partial class Form1 : Form
    {
        INhanVienViewService _nhanvienViewService;
        private Validate _validate;
        private Guid _id;

        public Form1()
        {
            InitializeComponent();
            _nhanvienViewService = new NhanVienviewServices();
            _validate = new Validate();
        }

        void LoadData()
        {
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
                dgvNhanvien.Rows.Add(x.idNV, $"{x.Ho} {x.TenDem} {x.Ten}",
                    x.Sdt, x.GioiTinh, x.DiaChi, x.ChucVu);
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
            };
            if (!_validate.CheckTen(txtTen.Text) || !_validate.CheckTen(txtHo.Text) || !_validate.CheckTen(txTenDem.Text))
            {
                MessageBox.Show("Sai ten");
                return;
            }
            if (!_validate.CheckSdt(txtSdt.Text))
            {
                MessageBox.Show("sai sdt");
                return;
            }

            if (DateTime.Now.Year - dateTimePicker1.Value.Year < 18)
            {
                
            }
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
            var nhanvien = _nhanvienViewService.GetAllNhanVienViews().FirstOrDefault(c => c.idNV == _id);

            txTenDem.Text = nhanvien.TenDem;
            txtSdt.Text = nhanvien.Sdt;
            txtHo.Text = nhanvien.Ho;
            txtTen.Text = nhanvien.Ten;
            txtDiaChi.Text = nhanvien.DiaChi;
            
            if (nhanvien.GioiTinh == "Nam")
            {
                rBtnNam.Checked = true;
                return;
            }

            rBtnNu.Checked = true;
        }

        private void txtTim_TextChanged(object sender, EventArgs e)
        {
            //cbbChucVu.DisplayMember = "Ten";
            ////lấy value là Id
            //cbbChucVu.ValueMember = "Id";
            //cbbChucVu.DataSource = _nhanvienViewService.GetAllNhanVienViews().Select(x => x.ChucVu).ToList();

            //dgvNhanvien.ColumnCount = 6;
            //dgvNhanvien.Columns[0].Visible = false;
            //dgvNhanvien.Columns[1].Name = "Ho va ten";
            //dgvNhanvien.Columns[2].Name = "Sdt";
            //dgvNhanvien.Columns[3].Name = "Gioi tinh";
            //dgvNhanvien.Columns[4].Name = "Dia chi";
            //dgvNhanvien.Columns[5].Name = "Chuc vu";

            //dgvNhanvien.Rows.Clear();
            //foreach (var x in _nhanvienViewService.GetAllNhanVienViews().Where(c=>c.NhanVien.DiaChi.ToLower().Contains(txtTim.Text.ToLower())))
            //{
            //    dgvNhanvien.Rows.Add(x.NhanVien.Id, $"{x.NhanVien.Ho} {x.NhanVien.TenDem} {x.NhanVien.Ten}",
            //        x.NhanVien.Sdt, x.NhanVien.GioiTinh, x.NhanVien.DiaChi, x.ChucVu.Ten);
            //}

            //Cach 2:

            //foreach (var x in _nhanvienViewService.FindNhanVien(txtTim.Text))
            //{
            //    dgvNhanvien.Rows.Add(x.NhanVien.Id, $"{x.NhanVien.Ho} {x.NhanVien.TenDem} {x.NhanVien.Ten}",
            //        x.NhanVien.Sdt, x.NhanVien.GioiTinh, x.NhanVien.DiaChi, x.ChucVu.Ten);
            //}





        }
    }
}