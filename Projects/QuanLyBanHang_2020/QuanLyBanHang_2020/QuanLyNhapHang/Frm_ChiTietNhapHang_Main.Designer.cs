namespace QuanLyBanHang_2020.QuanLyNhapHang
{
    partial class Frm_ChiTietNhapHang_Main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_ChiTietNhapHang_Main));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnNapLay = new System.Windows.Forms.ToolStripButton();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.btnNhapHang = new System.Windows.Forms.ToolStripButton();
            this.btn = new System.Windows.Forms.ToolStripButton();
            this.btnXuatExcel = new System.Windows.Forms.ToolStripButton();
            this.btnThoat = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.dgvChiTietNhapHang = new System.Windows.Forms.DataGridView();
            this.colSTT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMaLoaiSP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMaDonViTinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMaPhieuNhap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNgayNhap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMaSanPham = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTenLoaiSP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTenSanPham = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSoLuongNhap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSoLuongNhapTon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTenDonViTinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDonGiaNhap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colThanhTienNhap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMaNhanVien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTenNhanVien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMaNCC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTenNCC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChiTietNhapHang)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnNapLay,
            this.btnNhapHang,
            this.btn,
            this.toolStripButton1,
            this.btnXuatExcel,
            this.btnThoat});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1262, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnNapLay
            // 
            this.btnNapLay.Image = ((System.Drawing.Image)(resources.GetObject("btnNapLay.Image")));
            this.btnNapLay.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnNapLay.Name = "btnNapLay";
            this.btnNapLay.Size = new System.Drawing.Size(64, 22);
            this.btnNapLay.Text = "Nạp lại";
            this.btnNapLay.Click += new System.EventHandler(this.btnNapLay_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 351);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1262, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // btnNhapHang
            // 
            this.btnNhapHang.Image = ((System.Drawing.Image)(resources.GetObject("btnNhapHang.Image")));
            this.btnNhapHang.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnNhapHang.Name = "btnNhapHang";
            this.btnNhapHang.Size = new System.Drawing.Size(86, 22);
            this.btnNhapHang.Text = "Nhập hàng";
            this.btnNhapHang.Click += new System.EventHandler(this.btnNhapHang_Click);
            // 
            // btn
            // 
            this.btn.Image = ((System.Drawing.Image)(resources.GetObject("btn.Image")));
            this.btn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn.Name = "btn";
            this.btn.Size = new System.Drawing.Size(126, 22);
            this.btn.Text = "Sửa CT Phiếu nhập";
            // 
            // btnXuatExcel
            // 
            this.btnXuatExcel.Image = ((System.Drawing.Image)(resources.GetObject("btnXuatExcel.Image")));
            this.btnXuatExcel.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnXuatExcel.Name = "btnXuatExcel";
            this.btnXuatExcel.Size = new System.Drawing.Size(81, 22);
            this.btnXuatExcel.Text = "Xuất Excel";
            // 
            // btnThoat
            // 
            this.btnThoat.Image = ((System.Drawing.Image)(resources.GetObject("btnThoat.Image")));
            this.btnThoat.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(57, 22);
            this.btnThoat.Text = "Thoát";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(47, 22);
            this.toolStripButton1.Text = "Xóa";
            // 
            // dgvChiTietNhapHang
            // 
            this.dgvChiTietNhapHang.AllowUserToAddRows = false;
            this.dgvChiTietNhapHang.AllowUserToDeleteRows = false;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvChiTietNhapHang.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle9;
            this.dgvChiTietNhapHang.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvChiTietNhapHang.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.dgvChiTietNhapHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvChiTietNhapHang.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colSTT,
            this.colMaLoaiSP,
            this.colMaDonViTinh,
            this.colMaPhieuNhap,
            this.colNgayNhap,
            this.colMaSanPham,
            this.colTenLoaiSP,
            this.colTenSanPham,
            this.colSoLuongNhap,
            this.colSoLuongNhapTon,
            this.colTenDonViTinh,
            this.colDonGiaNhap,
            this.colThanhTienNhap,
            this.colMaNhanVien,
            this.colTenNhanVien,
            this.colMaNCC,
            this.colTenNCC});
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle15.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle15.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle15.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvChiTietNhapHang.DefaultCellStyle = dataGridViewCellStyle15;
            this.dgvChiTietNhapHang.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvChiTietNhapHang.Location = new System.Drawing.Point(0, 25);
            this.dgvChiTietNhapHang.Name = "dgvChiTietNhapHang";
            this.dgvChiTietNhapHang.ReadOnly = true;
            dataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle16.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle16.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle16.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle16.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle16.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle16.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvChiTietNhapHang.RowHeadersDefaultCellStyle = dataGridViewCellStyle16;
            this.dgvChiTietNhapHang.RowHeadersVisible = false;
            this.dgvChiTietNhapHang.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvChiTietNhapHang.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvChiTietNhapHang.Size = new System.Drawing.Size(1262, 326);
            this.dgvChiTietNhapHang.TabIndex = 2;
            // 
            // colSTT
            // 
            this.colSTT.DataPropertyName = "STT";
            this.colSTT.HeaderText = "STT";
            this.colSTT.Name = "colSTT";
            this.colSTT.ReadOnly = true;
            this.colSTT.Width = 60;
            // 
            // colMaLoaiSP
            // 
            this.colMaLoaiSP.DataPropertyName = "MaLoaiSP";
            this.colMaLoaiSP.HeaderText = "Mã Loại SP";
            this.colMaLoaiSP.Name = "colMaLoaiSP";
            this.colMaLoaiSP.ReadOnly = true;
            this.colMaLoaiSP.Visible = false;
            // 
            // colMaDonViTinh
            // 
            this.colMaDonViTinh.DataPropertyName = "MaDVT";
            this.colMaDonViTinh.HeaderText = "ĐVT";
            this.colMaDonViTinh.Name = "colMaDonViTinh";
            this.colMaDonViTinh.ReadOnly = true;
            this.colMaDonViTinh.Visible = false;
            // 
            // colMaPhieuNhap
            // 
            this.colMaPhieuNhap.DataPropertyName = "MaPhieuNhap";
            this.colMaPhieuNhap.HeaderText = "Mã phiếu";
            this.colMaPhieuNhap.Name = "colMaPhieuNhap";
            this.colMaPhieuNhap.ReadOnly = true;
            // 
            // colNgayNhap
            // 
            this.colNgayNhap.DataPropertyName = "NgayNhap";
            this.colNgayNhap.HeaderText = "Ngày nhập";
            this.colNgayNhap.Name = "colNgayNhap";
            this.colNgayNhap.ReadOnly = true;
            // 
            // colMaSanPham
            // 
            this.colMaSanPham.DataPropertyName = "MaSanPham";
            this.colMaSanPham.HeaderText = "Mã SP";
            this.colMaSanPham.Name = "colMaSanPham";
            this.colMaSanPham.ReadOnly = true;
            this.colMaSanPham.Visible = false;
            // 
            // colTenLoaiSP
            // 
            this.colTenLoaiSP.DataPropertyName = "TenLoaiSP";
            this.colTenLoaiSP.HeaderText = "Loại sản phẩm";
            this.colTenLoaiSP.Name = "colTenLoaiSP";
            this.colTenLoaiSP.ReadOnly = true;
            this.colTenLoaiSP.Width = 150;
            // 
            // colTenSanPham
            // 
            this.colTenSanPham.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colTenSanPham.DataPropertyName = "TenSanPham";
            this.colTenSanPham.HeaderText = "Tên sản phẩm";
            this.colTenSanPham.Name = "colTenSanPham";
            this.colTenSanPham.ReadOnly = true;
            // 
            // colSoLuongNhap
            // 
            this.colSoLuongNhap.DataPropertyName = "SoLuongNhap";
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle11.Format = "#,###0";
            dataGridViewCellStyle11.NullValue = "0";
            this.colSoLuongNhap.DefaultCellStyle = dataGridViewCellStyle11;
            this.colSoLuongNhap.HeaderText = "SL";
            this.colSoLuongNhap.Name = "colSoLuongNhap";
            this.colSoLuongNhap.ReadOnly = true;
            this.colSoLuongNhap.Width = 50;
            // 
            // colSoLuongNhapTon
            // 
            this.colSoLuongNhapTon.DataPropertyName = "SoLuongNhapTon";
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle12.Format = "#,###0";
            dataGridViewCellStyle12.NullValue = "0";
            this.colSoLuongNhapTon.DefaultCellStyle = dataGridViewCellStyle12;
            this.colSoLuongNhapTon.HeaderText = "SLT";
            this.colSoLuongNhapTon.Name = "colSoLuongNhapTon";
            this.colSoLuongNhapTon.ReadOnly = true;
            this.colSoLuongNhapTon.Width = 50;
            // 
            // colTenDonViTinh
            // 
            this.colTenDonViTinh.DataPropertyName = "TenDVT";
            this.colTenDonViTinh.HeaderText = "ĐVT";
            this.colTenDonViTinh.Name = "colTenDonViTinh";
            this.colTenDonViTinh.ReadOnly = true;
            // 
            // colDonGiaNhap
            // 
            this.colDonGiaNhap.DataPropertyName = "DonGiaNhap";
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle13.Format = "#,###0";
            dataGridViewCellStyle13.NullValue = "0";
            this.colDonGiaNhap.DefaultCellStyle = dataGridViewCellStyle13;
            this.colDonGiaNhap.HeaderText = "Đơn giá";
            this.colDonGiaNhap.Name = "colDonGiaNhap";
            this.colDonGiaNhap.ReadOnly = true;
            // 
            // colThanhTienNhap
            // 
            this.colThanhTienNhap.DataPropertyName = "ThanhTienNhap";
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle14.Format = "#,###0";
            dataGridViewCellStyle14.NullValue = "0";
            this.colThanhTienNhap.DefaultCellStyle = dataGridViewCellStyle14;
            this.colThanhTienNhap.HeaderText = "Thành tiền";
            this.colThanhTienNhap.Name = "colThanhTienNhap";
            this.colThanhTienNhap.ReadOnly = true;
            // 
            // colMaNhanVien
            // 
            this.colMaNhanVien.DataPropertyName = "MaNV";
            this.colMaNhanVien.HeaderText = "Mã NV";
            this.colMaNhanVien.Name = "colMaNhanVien";
            this.colMaNhanVien.ReadOnly = true;
            this.colMaNhanVien.Visible = false;
            // 
            // colTenNhanVien
            // 
            this.colTenNhanVien.DataPropertyName = "TenNhanVien";
            this.colTenNhanVien.HeaderText = "Tên nhân viên";
            this.colTenNhanVien.Name = "colTenNhanVien";
            this.colTenNhanVien.ReadOnly = true;
            // 
            // colMaNCC
            // 
            this.colMaNCC.DataPropertyName = "MaNCC";
            this.colMaNCC.HeaderText = "MaNCC";
            this.colMaNCC.Name = "colMaNCC";
            this.colMaNCC.ReadOnly = true;
            this.colMaNCC.Visible = false;
            // 
            // colTenNCC
            // 
            this.colTenNCC.DataPropertyName = "TenNCC";
            this.colTenNCC.HeaderText = "Tên NCC";
            this.colTenNCC.Name = "colTenNCC";
            this.colTenNCC.ReadOnly = true;
            // 
            // Frm_ChiTietNhapHang_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1262, 373);
            this.Controls.Add(this.dgvChiTietNhapHang);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.toolStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "Frm_ChiTietNhapHang_Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Frm_ChiTietNhapHang_Main";
            this.Load += new System.EventHandler(this.Frm_ChiTietNhapHang_Main_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChiTietNhapHang)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnNapLay;
        private System.Windows.Forms.ToolStripButton btnNhapHang;
        private System.Windows.Forms.ToolStripButton btn;
        private System.Windows.Forms.ToolStripButton btnXuatExcel;
        private System.Windows.Forms.ToolStripButton btnThoat;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.DataGridView dgvChiTietNhapHang;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSTT;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaLoaiSP;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaDonViTinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaPhieuNhap;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNgayNhap;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaSanPham;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTenLoaiSP;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTenSanPham;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSoLuongNhap;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSoLuongNhapTon;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTenDonViTinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDonGiaNhap;
        private System.Windows.Forms.DataGridViewTextBoxColumn colThanhTienNhap;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaNhanVien;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTenNhanVien;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaNCC;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTenNCC;
    }
}