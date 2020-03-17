﻿using QuanLyBanHang_17SE111.HeThong;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyBanHang_17SE111
{
    public partial class Frm_Main: Form
    {
        public Frm_Main()
        {
            InitializeComponent();
        }

        private void Frm_Main_Load(object sender, EventArgs e)
        {
            Frm_DangNhap frm_DangNhap = new Frm_DangNhap();
            frm_DangNhap.ShowDialog();
            lblTenNhanVien.Text = Cls_Main.tenNhanVien;
        }

        private void mnuDangXuat_Click(object sender, EventArgs e)
        {
            Frm_DangNhap frm_DangNhap = new Frm_DangNhap();
            frm_DangNhap.ShowDialog();
            lblTenNhanVien.Text = Cls_Main.tenNhanVien;
        }

        private void mnuQuanLyTaiKhoan_Click(object sender, EventArgs e)
        {
            Frm_NhanVien_Main frm_NhanVien_Main = new Frm_NhanVien_Main();
            frm_NhanVien_Main.MdiParent = this;
            frm_NhanVien_Main.Show();
        }
    }
}
