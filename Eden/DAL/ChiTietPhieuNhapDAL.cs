using System.Data;
using System.Data.SqlClient;

namespace Eden
{
    public class ChiTietPhieuNhapDAL
    {
        private readonly DatabaseHelper dbHelper = new DatabaseHelper();

        public DataTable GetAllChiTietPhieuNhap()
        {
            string query = "SELECT idPhieuNhap, idSanPham, SoLuong as [Số lượng], DonGia as [Đơn giá], ThanhTien as [Thành tiền] FROM CHITIETPHIEUNHAP";
            return dbHelper.ExecuteQuery(query);
        }

        public bool InsertChiTietPhieuNhap(int idPhieuNhap, int idSanPham, int soLuong, decimal donGia, decimal thanhTien)
        {
            string query = "INSERT INTO CHITIETPHIEUNHAP (idPhieuNhap, idSanPham, SoLuong, DonGia, ThanhTien) VALUES (@idPN, @idSP, @SoLuong, @DonGia, @ThanhTien)";
            SqlParameter[] parameters =
            {
            new SqlParameter("@idPN", idPhieuNhap),
            new SqlParameter("@idSP", idSanPham),
            new SqlParameter("@SoLuong", soLuong),
            new SqlParameter("@DonGia", donGia),
            new SqlParameter("@ThanhTien", thanhTien)
        };
            return dbHelper.ExecuteNonQuery(query, parameters) > 0;
        }

        public bool UpdateChiTietPhieuNhap(int idPhieuNhap, int idSanPham, int soLuong, decimal donGia, decimal thanhTien)
        {
            string query = "UPDATE CHITIETPHIEUNHAP SET SoLuong = @SoLuong, DonGia = @DonGia, ThanhTien = @ThanhTien WHERE idPhieuNhap = @idPN AND idSanPham = @idSP";
            SqlParameter[] parameters =
            {
            new SqlParameter("@idPN", idPhieuNhap),
            new SqlParameter("@idSP", idSanPham),
            new SqlParameter("@SoLuong", soLuong),
            new SqlParameter("@DonGia", donGia),
            new SqlParameter("@ThanhTien", thanhTien)
        };
            return dbHelper.ExecuteNonQuery(query, parameters) > 0;
        }

        public bool DeleteChiTietPhieuNhap(int idPhieuNhap, int idSanPham)
        {
            string query = "DELETE FROM CHITIETPHIEUNHAP WHERE idPhieuNhap = @idPN AND idSanPham = @idSP";
            SqlParameter[] parameters =
            {
            new SqlParameter("@idPN", idPhieuNhap),
            new SqlParameter("@idSP", idSanPham)
        };
            return dbHelper.ExecuteNonQuery(query, parameters) > 0;
        }
    }
}