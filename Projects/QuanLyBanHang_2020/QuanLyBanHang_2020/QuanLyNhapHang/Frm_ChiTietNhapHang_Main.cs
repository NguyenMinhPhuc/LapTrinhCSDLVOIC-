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
    public partial class Frm_ChiTietNhapHang_Main : Form
    {
        public Frm_ChiTietNhapHang_Main()
        {
            InitializeComponent();

        }
        BLL_NhapHang bd;
        DataTable dtChiTietNhapSanPham;
        string err = string.Empty;
        private void Frm_ChiTietNhapHang_Main_Load(object sender, EventArgs e)
        {
            bd = new BLL_NhapHang();
            HienThiChiTietNhapSanPham();
        }

        private void HienThiChiTietNhapSanPham()
        {
            dtChiTietNhapSanPham = new DataTable();
            dtChiTietNhapSanPham = bd.LayChiTietNhapSanPham(ref err);
            dgvChiTietNhapHang.DataSource = dtChiTietNhapSanPham.DefaultView;
        }

        private void btnNapLay_Click(object sender, EventArgs e)
        {
            HienThiChiTietNhapSanPham();
        }

        private void btnNhapHang_Click(object sender, EventArgs e)
        {
            Frm_ChiTietNhapHang_Modifies frmNhapHang = new Frm_ChiTietNhapHang_Modifies();
            frmNhapHang.ShowDialog();
        }
    }
}
