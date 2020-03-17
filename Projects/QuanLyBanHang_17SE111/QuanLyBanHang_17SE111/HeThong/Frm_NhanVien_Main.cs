using QuanLyBanHang_17SE111.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyBanHang_17SE111.HeThong
{
    public partial class Frm_NhanVien_Main : Form
    {
        public Frm_NhanVien_Main()
        {
            InitializeComponent();
        }
        BLL_HeThong bd;
        string err = string.Empty;
        DataTable dataTable;
        NhanVien nhanVien;
        private void Frm_NhanVien_Main_Load(object sender, EventArgs e)
        {
            bd = new BLL_HeThong();
            HienThiDanhSachNhanVien();
        }

        private void HienThiDanhSachNhanVien()
        {
            dataTable = new DataTable();
            dataTable = bd.LayDanhSachNhanVien(ref err);
            dgvDanhSachNhanVien.DataSource = dataTable;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            Frm_NhanVien_Modifies frm_NhanVien_Modifies = new Frm_NhanVien_Modifies();
            frm_NhanVien_Modifies.Them = true;
            frm_NhanVien_Modifies.ShowDialog();
            HienThiDanhSachNhanVien();
        }

        private void dgvDanhSachNhanVien_Click(object sender, EventArgs e)
        {
            if(dgvDanhSachNhanVien.Rows.Count>0)
            {
                nhanVien = new NhanVien();
                nhanVien.MaNhanVien = dgvDanhSachNhanVien.CurrentRow.Cells["colMaNhanVien"].Value.ToString();
                nhanVien.TenNhanVien = dgvDanhSachNhanVien.CurrentRow.Cells["colTenNhanVien"].Value.ToString();
                nhanVien.NgaySinh =Convert.ToDateTime( dgvDanhSachNhanVien.CurrentRow.Cells["colNgaySinh"].Value.ToString());
                nhanVien.DienThoai = dgvDanhSachNhanVien.CurrentRow.Cells["colDienThoai"].Value.ToString();
                nhanVien.MaTaiKhoan = dgvDanhSachNhanVien.CurrentRow.Cells["colMaTaiKhoan"].Value.ToString();
                nhanVien.TenDangNhap = dgvDanhSachNhanVien.CurrentRow.Cells["colTenDangNhap"].Value.ToString();
                nhanVien.MatKhau = dgvDanhSachNhanVien.CurrentRow.Cells["colMatKhau"].Value.ToString();
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            Frm_NhanVien_Modifies frm_NhanVien_Modifies = new Frm_NhanVien_Modifies();
            frm_NhanVien_Modifies.Them = false;
            frm_NhanVien_Modifies.nhanVien = nhanVien;
            frm_NhanVien_Modifies.ShowDialog();
            HienThiDanhSachNhanVien();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {

        }
    }
}
