using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyBanHang_2020.QuanLyNhapHang
{
    public class BLL_NhapHang
    {
        Database data;
        public BLL_NhapHang()
        {
            data = new Database();
        }
        public  DataTable LayChiTietNhapSanPham(ref string err)
        {
            return data.GetDataTable(ref err, "PSP_NhapHang_HienThiDanhSachNhapHang", CommandType.StoredProcedure, null);
        }
        public object LayMaPhieuLonNhat(ref string err, string maNhanVien)
        {
            return data.MyExecuteScalar(ref err, "PSP_NhapHang_LayMaPhieuNhapMax", CommandType.StoredProcedure,
                new SqlParameter("@MaNhanVien", maNhanVien));
        }
        public object LayMaPhieuLonNhat(ref string err, string maNhanVien,DateTime ngayTao)
        {
            return data.MyExecuteScalar(ref err, "PSP_NhapHang_LayMaPhieuNhapMaxTheoDatetime", CommandType.StoredProcedure,
                new SqlParameter("@MaNhanVien", maNhanVien),
                 new SqlParameter("@NgayTao", ngayTao));
        }

        public DataTable LayDuLieuCboLoaiSanPham(ref string err)
        {
            return data.GetDataTable(ref err, "PSP_LoaiSanPham_LayDuLieuCbo", CommandType.StoredProcedure, null);
        }
        public DataTable LayDuLieuCboDonViTinh(ref string err)
        {
            return data.GetDataTable(ref err, "PSP_DonViTinh_LayDuLieuCbo", CommandType.StoredProcedure, null);
        }
        public DataTable LayDuLieuCboNhaCungCap(ref string err)
        {
            return data.GetDataTable(ref err, "PSP_NhaCungCap_LayDuLieuCbo", CommandType.StoredProcedure, null);
        }

        public DataTable LayDanhSachSanPhamTheoLoai(ref string err, string loaiSanPham)
        {
            return data.GetDataTable(ref err, "PSP_SanPham_LaySanPhamTheoLoai", CommandType.StoredProcedure, new SqlParameter("@MaLoaiSanPham",loaiSanPham));
        }
    }
}
