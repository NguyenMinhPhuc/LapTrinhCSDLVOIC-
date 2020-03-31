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
    public partial class Frm_NhapHang_Main : Form
    {
        public Frm_NhapHang_Main()
        {
            InitializeComponent();

        }
        BLL_NhapHang bd;
        string err = string.Empty;
        DataTable dtChiTietNhap;
        private void btnThoat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Frm_NhapHang_Main_Load(object sender, EventArgs e)
        {
            bd = new BLL_NhapHang();
            HienThiDuLieu();
        }

        private void HienThiDuLieu()
        {
            try
            {
                dtChiTietNhap = new DataTable();
                dtChiTietNhap = bd.LayChiTietNhapHang(ref err);
                dgvChiTietNhapHang.DataSource = dtChiTietNhap.DefaultView;
            }
            catch (Exception ex)
            {
                lblerr.Text =string.Format("{0} - {1}", err , ex.Message);
            }
           
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            HienThiDuLieu();
        }

        private void btnNhapHang_Click(object sender, EventArgs e)
        {
            Frm_NhapHang_Modifies frmNhapHang = new Frm_NhapHang_Modifies();
            frmNhapHang.ShowDialog();
            HienThiDuLieu();
        }
    }
}
