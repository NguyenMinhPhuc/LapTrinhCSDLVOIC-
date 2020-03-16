using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyBanHang_2020
{
    public partial class BLL_HeThong
    {
        Database data;
        public BLL_HeThong()
        {
            data = new Database();
        }
        public DataTable KiemTraDangNhap(ref string err,string tenDangNhap,string matKhau)
        {
            return data.GetDataTable(ref err, "PSP_NhanVien_KiemTraDangNhap", CommandType.StoredProcedure,
                new SqlParameter("@TenDangNhap", tenDangNhap),
                new SqlParameter("@MatKhau", matKhau));
        }
    }
}
