using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyBanHang_2020.QuanLyNhapHang
{
    public partial class Frm_ChiTietNhapHang_Modifies : Form
    {
        public Frm_ChiTietNhapHang_Modifies()
        {
            InitializeComponent();
        }
        BLL_NhapHang bd;
        string err = string.Empty;
        private void Frm_ChiTietNhapHang_Modifies_Load(object sender, EventArgs e)
        {
            bd = new BLL_NhapHang();
            KhoiTaoPhieuNhap();
            HienThiDuLieuVaoLoaiSanPham();
            HienThiDuLieuVaoNhaCC();
            HienThiDuLieuVaoDVT();
        }

        private void HienThiDuLieuVaoDVT()
        {
            DataTable dt = new DataTable();
            dt = bd.LayDuLieuCboDonViTinh(ref err);
            cboDonViTinh.DataSource = dt;
            cboDonViTinh.DisplayMember = "TenDVT";
            cboDonViTinh.ValueMember = "MaDVT";
            cboDonViTinh.SelectedIndex = -1;
            cboDonViTinh.Text = "Chọn Đơn vị tính";
        }

        private void HienThiDuLieuVaoNhaCC()
        {
            DataTable dt = new DataTable();
            dt = bd.LayDuLieuCboNhaCungCap(ref err);
            cboNhaCungCap.DataSource = dt;
            cboNhaCungCap.DisplayMember = "TenNCC";
            cboNhaCungCap.ValueMember = "MaNCC";
            cboNhaCungCap.SelectedIndex = -1;
            cboNhaCungCap.Text = "Chọn Nhà cung cấp";
        }
        bool StatusLoaiSanPham = false;
        private void HienThiDuLieuVaoLoaiSanPham()
        {
            StatusLoaiSanPham = false;
            DataTable dt = new DataTable();
            dt = bd.LayDuLieuCboLoaiSanPham(ref err);
            cboLoaiSanPham.DataSource = dt;
            cboLoaiSanPham.DisplayMember = "TenLoaiSP";
            cboLoaiSanPham.ValueMember = "MaLoaiSP";
            cboLoaiSanPham.SelectedIndex = -1;
            cboLoaiSanPham.Text = "Chọn Loại sản phẩm";
            StatusLoaiSanPham = true;
        }

        private void KhoiTaoPhieuNhap()
        {
            object obj = null;
            string maPhieuNhap = string.Empty;
            obj = bd.LayMaPhieuLonNhat(ref err, ClsMain.MaNhanVien);
            if(obj!=null)
            {
                maPhieuNhap = string.Format("PN{0:00}{1:00}{2:00}{3:0000}",Convert.ToInt32( DateTime.Now.Year.ToString().Substring(2,2)), DateTime.Now.Month, Convert.ToInt32(ClsMain.MaNhanVien), Convert.ToInt32(obj)+1);
            }
            txtMaPhieuNhap.Text = maPhieuNhap;
        }
        private void KhoiTaoPhieuNhap(DateTime date)
        {
            object obj = null;
            string maPhieuNhap = string.Empty;
            obj = bd.LayMaPhieuLonNhat(ref err, ClsMain.MaNhanVien,date);
            if (obj != null)
            {
                maPhieuNhap = string.Format("PN{0:00}{1:00}{2:00}{3:0000}", Convert.ToInt32(date.Year.ToString().Substring(2, 2)), date.Month, Convert.ToInt32(ClsMain.MaNhanVien), Convert.ToInt32(obj) + 1);
            }
            txtMaPhieuNhap.Text = maPhieuNhap;
        }

        private void dtpNgayNhap_ValueChanged(object sender, EventArgs e)
        {
            KhoiTaoPhieuNhap(dtpNgayNhap.Value);
        }

        private void cboLoaiSanPham_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboLoaiSanPham.SelectedIndex >= 0 && StatusLoaiSanPham == true)
            {
                DataTable dtSanPham = new DataTable();
                dtSanPham = bd.LayDanhSachSanPhamTheoLoai(ref err, cboLoaiSanPham.SelectedValue.ToString());

                AutoCompleteStringCollection list = new AutoCompleteStringCollection();
                for (int i = 0; i < dtSanPham.Rows.Count; i++)
                {
                    list.Add(dtSanPham.Rows[i]["TenSanPham"].ToString());
                }
                txtTenSanPham.AutoCompleteCustomSource = list;
                txtTenSanPham.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            }
        }
    }
}
