using QuanLyBanHang_17SE111.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyBanHang_17SE111.HeThong
{
    public class BLL_HeThong
    {
        Database data;
        public BLL_HeThong()
        {
            data = new Database();
        }

        public DataTable KiemTraDangNhap(ref string err,string tenDangNhap  ,string matKhau)
        {
            return data.GetDataTable(ref err, "PSP_NhanVien_KiemTraDangNhap", CommandType.StoredProcedure, 
                new SqlParameter("@TenDangNhap", tenDangNhap),
                new SqlParameter("@MatKhau",matKhau));
        }
        public DataTable LayDanhSachNhanVien(ref string err)
        {
            return data.GetDataTable(ref err, "PSP_NhanVien_LayDanhSachNhanVien", CommandType.StoredProcedure, null);
        }
        public bool CapNhatNhanVien(ref string err,ref int count,NhanVien nhanVien)
        {
            return data.MyExcuteNonQuery(ref err, ref count, "PSP_NhanVien_InsertVaUpdate", CommandType.StoredProcedure,
                new SqlParameter("@MaNhanVien", nhanVien.MaNhanVien),
                new SqlParameter("@TenNhanVien", nhanVien.TenNhanVien),
                new SqlParameter("@TenDangNhap", nhanVien.TenDangNhap),
                new SqlParameter("@NgaySinh", nhanVien.NgaySinh),
                new SqlParameter("@DienThoai", nhanVien.DienThoai),
                new SqlParameter("@MaTaiKhoan", nhanVien.MaTaiKhoan),
                new SqlParameter("@MatKhau", nhanVien.MatKhau));
        }
        public DataTable LayDuLieuComboTaiKhoan(ref string err)
        {
            return data.GetDataTable(ref err, "PSP_TaiKhoan_LayCombo", CommandType.StoredProcedure, null);
        }
    }
}
