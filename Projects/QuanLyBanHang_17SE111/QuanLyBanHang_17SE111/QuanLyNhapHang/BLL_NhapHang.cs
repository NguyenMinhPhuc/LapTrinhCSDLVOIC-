using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyBanHang_17SE111.QuanLyNhapHang
{
    public class BLL_NhapHang
    {
        Database data;
        public BLL_NhapHang()
        {
            data = new Database();
        }
        public DataTable LayChiTietNhapHang(ref string err)
        {
            return data.GetDataTable(ref err, "PSP_NhapHang_LayChiTietNhapHang", CommandType.StoredProcedure, null);
        }
        public object LayMaPhieuNhapLonNhat(ref string err, string maNhanVien)
        {
            return data.MyExecuteScalar(ref err, "PSP_NhapHang_LayMaPhieuNhapLonNhat", CommandType.StoredProcedure,
                new SqlParameter("@MaNhanVien", maNhanVien));
        }
            public object LayMaPhieuNhapLonNhat(ref string err, string maNhanVien,DateTime ngayNhap)
        {
            return data.MyExecuteScalar(ref err, "PSP_NhapHang_LayMaPhieuNhapLonNhatTheoNgay", CommandType.StoredProcedure,
                new SqlParameter("@MaNhanVien", maNhanVien),
                new SqlParameter("@NgayNhap", ngayNhap));
        }
        public DataTable LayDuLieuComboLoaiSanPham(ref string err)
            {
                return data.GetDataTable(ref err, "PSP_NhapHang_LayLoaiSanPhamCbo", CommandType.StoredProcedure, null);
            }
        public DataTable LayDuLieuComboDonViTinh(ref string err)
        {
            return data.GetDataTable(ref err, "PSP_NhapHang_LayDonViTinhCbo", CommandType.StoredProcedure, null);
        }
        public DataTable LayDuLieuComboNhaCungCap(ref string err)
        {
            return data.GetDataTable(ref err, "PSP_NhapHang_LayNhaCungCapCbo", CommandType.StoredProcedure, null);
        }

        public DataTable LayDanhSachSanPhamTheoLoai(ref string err, string maLoaiSanPham)
        {
            return data.GetDataTable(ref err, "PSP_NhapHang_LayThongTinSanPhamTheoLoai", CommandType.StoredProcedure,
                new SqlParameter("@MaLoaiSanPham", maLoaiSanPham));
        }
    }
}
