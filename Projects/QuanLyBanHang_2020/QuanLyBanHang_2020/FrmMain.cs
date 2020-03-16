using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyBanHang_2020
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }
        public string tenNhanVien = string.Empty;
        private void FrmMain_Load(object sender, EventArgs e)
        {
            LogIn frm_Login = new LogIn();
            frm_Login.ShowDialog();
            //các việc thực hiện trên form main sau khi thực hiện login thành công
            txtTenNhanVien.Text = ClsMain.TenNhanVien;
        }

        private void mnuDangXuat_Click(object sender, EventArgs e)
        {
            LogIn frm_Login = new LogIn();
            frm_Login.ShowDialog();
            //các việc thực hiện trên form main sau khi thực hiện login thành công
            txtTenNhanVien.Text = ClsMain.TenNhanVien;
        }

        private void mnuQuanLyNhanVien_Click(object sender, EventArgs e)
        {
            Frm_NhanVien_Main frmNhanVien = new Frm_NhanVien_Main();
            frmNhanVien.ShowDialog();
        }
    }
}
