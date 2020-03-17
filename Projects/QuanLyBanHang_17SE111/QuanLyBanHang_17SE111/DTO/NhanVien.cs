using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyBanHang_17SE111.DTO
{
    public class NhanVien
    {
        string maNhanVien, tenNhanVien, dienThoai, maTaiKhoan, tenDangNhap, matKhau;
        DateTime ngaySinh;
        bool isDelete;

        public string MaNhanVien { get => maNhanVien; set => maNhanVien = value; }
        public string TenNhanVien { get => tenNhanVien; set => tenNhanVien = value; }
        public string DienThoai { get => dienThoai; set => dienThoai = value; }
        public string MaTaiKhoan { get => maTaiKhoan; set => maTaiKhoan = value; }
        public string TenDangNhap { get => tenDangNhap; set => tenDangNhap = value; }
        public string MatKhau { get => matKhau; set => matKhau = value; }
        public DateTime NgaySinh { get => ngaySinh; set => ngaySinh = value; }
        public bool IsDelete { get => isDelete; set => isDelete = value; }
    }
}
