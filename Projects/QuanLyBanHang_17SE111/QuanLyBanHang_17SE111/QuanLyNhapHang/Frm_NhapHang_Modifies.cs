using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyBanHang_17SE111.QuanLyNhapHang
{
    public partial class Frm_NhapHang_Modifies : Form
    {
        public Frm_NhapHang_Modifies()
        {
            InitializeComponent();
        }
        BLL_NhapHang bd;
        string err = string.Empty;

        private void Frm_NhapHang_Modifies_Load(object sender, EventArgs e)
        {
            bd = new BLL_NhapHang();
            TaoMaPhieuNhap();
            HienThicboLoaiSanPham();
            HienThicboNhaCungCap();
            HienThicboDonViTinh();
        }

        private void HienThicboDonViTinh()
        {
            DataTable dt = new DataTable();
            dt = bd.LayDuLieuComboDonViTinh(ref err);
            cboDonViTinh.DataSource = dt;
            cboDonViTinh.DisplayMember = "TenDonViTinh";
            cboDonViTinh.ValueMember = "MaDonViTinh";
            cboDonViTinh.SelectedIndex = -1;
            cboDonViTinh.Text = "Chọn Đơn vị tính";
        }

        private void HienThicboNhaCungCap()
        {
            DataTable dt = new DataTable();
            dt = bd.LayDuLieuComboNhaCungCap(ref err);
            cboNhaCungCap.DataSource = dt;
            cboNhaCungCap.DisplayMember = "TenNhaCungCap";
            cboNhaCungCap.ValueMember = "MaNhaCungCap";
            cboNhaCungCap.SelectedIndex = -1;
            cboNhaCungCap.Text = "Chọn Nhà cung cấp";
        }
        bool statusLoadboLoaiSanPham = false;
        private void HienThicboLoaiSanPham()
        {
            statusLoadboLoaiSanPham = false;
            DataTable dt = new DataTable();
            dt = bd.LayDuLieuComboLoaiSanPham(ref err);
            cboLoaiSanPham.DataSource = dt;
            cboLoaiSanPham.DisplayMember = "TenLoaiSanPham";
            cboLoaiSanPham.ValueMember = "MaLoaiSanPham";
            cboLoaiSanPham.SelectedIndex = -1;
            cboLoaiSanPham.Text = "Chọn loại sản phẩm";
            statusLoadboLoaiSanPham = true;
        }

        private void TaoMaPhieuNhap()
        {
            object obj = null;
            string maPhieuNhap = string.Empty;
            obj = bd.LayMaPhieuNhapLonNhat(ref err, Cls_Main.maNhanVien);
            if(obj!=null)
            {
                maPhieuNhap = string.Format("PN{0}{1:00}{2:00}{3:0000}", DateTime.Now.Year.ToString().Substring(2,2), DateTime.Now.Month, Convert.ToInt32(Cls_Main.maNhanVien), Convert.ToInt32(obj) + 1);
            }
            else
            {
                MessageBox.Show("Không lấy được mã phiếu trong database");
                this.Close();
            }
            txtMaPhieuNhap.Text = maPhieuNhap;
        }
        private void TaoMaPhieuNhap(DateTime ngayNhap)
        {
            object obj = null;
            string maPhieuNhap = string.Empty;
            obj = bd.LayMaPhieuNhapLonNhat(ref err, Cls_Main.maNhanVien, ngayNhap);
            if (obj != null)
            {
                maPhieuNhap = string.Format("PN{0}{1:00}{2:00}{3:0000}", ngayNhap.Year.ToString().Substring(2, 2), ngayNhap.Month, Convert.ToInt32(Cls_Main.maNhanVien), Convert.ToInt32(obj) + 1);
            }
            else
            {
                MessageBox.Show("Không lấy được mã phiếu trong database");
                this.Close();
            }
            txtMaPhieuNhap.Text = maPhieuNhap;
        }

        private void dtpNgayNhap_ValueChanged(object sender, EventArgs e)
        {
            TaoMaPhieuNhap(dtpNgayNhap.Value);
        }
        DataTable dtSanPham;
        private void cboLoaiSanPham_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboLoaiSanPham.SelectedIndex >= 0 && statusLoadboLoaiSanPham == true)
            {
                dtSanPham = new DataTable();
                dtSanPham = bd.LayDanhSachSanPhamTheoLoai(ref err, cboLoaiSanPham.SelectedValue.ToString());
                AutoCompleteStringCollection list = new AutoCompleteStringCollection();
                for (int i = 0; i < dtSanPham.Rows.Count; i++)
                {
                    list.Add(dtSanPham.Rows[i]["TenSanPham"].ToString());
                }
                txtTenSanPham.AutoCompleteCustomSource = list;
                txtTenSanPham.AutoCompleteMode = AutoCompleteMode.Suggest;
            }
        }

        private void txtTenSanPham_Leave(object sender, EventArgs e)
        {
            if(!string.IsNullOrEmpty(txtTenSanPham.Text.Trim()))
            {
                foreach (DataRow item in dtSanPham.Rows)
                {
                    if (item["TenSanPham"].ToString().Equals(txtTenSanPham.Text.Trim()))
                    {
                        txtMaSanPham.Text = item["MaSanPham"].ToString();
                        cboDonViTinh.SelectedValue = item["MaDonViTinh"].ToString();
                        return;
                    }
                }
            }
            txtMaSanPham.Text = "0";
        }
    }
}
