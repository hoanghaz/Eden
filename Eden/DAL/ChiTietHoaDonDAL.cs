using System.Data;
using System.Data.SqlClient;

namespace Eden
{
    public class ChiTietHoaDonDAL
    {
        private readonly DatabaseHelper dbHelper = new DatabaseHelper();

        public DataTable GetAllChiTietHoaDon()
        {
            string query = "SELECT idHoaDon, idSanPham, SoLuong as [Số lượng], DonGia as [Đơn giá], ThanhTien as [Thành tiền] FROM CHITIETHOADON";
            return dbHelper.ExecuteQuery(query);
        }

        public bool InsertChiTietHoaDon(int idHoaDon, int idSanPham, int soLuong, decimal donGia, decimal thanhTien)
        {
            string query = "INSERT INTO CHITIETHOADON (idHoaDon, idSanPham, SoLuong, DonGia, ThanhTien) VALUES (@idHD, @idSP, @SoLuong, @DonGia, @ThanhTien)";
            SqlParameter[] parameters =
            {
            new SqlParameter("@idHD", idHoaDon),
            new SqlParameter("@idSP", idSanPham),
            new SqlParameter("@SoLuong", soLuong),
            new SqlParameter("@DonGia", donGia),
            new SqlParameter("@ThanhTien", thanhTien)
        };
            return dbHelper.ExecuteNonQuery(query, parameters) > 0;
        }

        public bool UpdateChiTietHoaDon(int idHoaDon, int idSanPham, int soLuong, decimal donGia, decimal thanhTien)
        {
            string query = "UPDATE CHITIETHOADON SET SoLuong = @SoLuong, DonGia = @DonGia, ThanhTien = @ThanhTien WHERE idHoaDon = @idHD AND idSanPham = @idSP";
            SqlParameter[] parameters =
            {
            new SqlParameter("@idHD", idHoaDon),
            new SqlParameter("@idSP", idSanPham),
            new SqlParameter("@SoLuong", soLuong),
            new SqlParameter("@DonGia", donGia),
            new SqlParameter("@ThanhTien", thanhTien)
        };
            return dbHelper.ExecuteNonQuery(query, parameters) > 0;
        }

        public bool DeleteChiTietHoaDon(int idHoaDon, int idSanPham)
        {
            string query = "DELETE FROM CHITIETHOADON WHERE idHoaDon = @idHD AND idSanPham = @idSP";
            SqlParameter[] parameters =
            {
            new SqlParameter("@idHD", idHoaDon),
            new SqlParameter("@idSP", idSanPham)
        };
            return dbHelper.ExecuteNonQuery(query, parameters) > 0;
        }
    }
}