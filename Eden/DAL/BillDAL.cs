using System;
using System.Data;
using System.Data.SqlClient;

namespace Eden
{
    public class BillDAL
    {
        private readonly DatabaseHelper dbHelper = new DatabaseHelper();

        // Lấy tất cả hóa đơn
        public DataTable GetAllBills()
        {
            string query = @"
                SELECT HD.id, HD.MaHoaDon AS [Mã hóa đơn], HD.NgayLap as [Ngày lập], HD.TongTien as [Tổng tiền], KH.TenKhachHang as [Tên khách hàng], ND.TenNguoiDung as [Tên người dùng]
                FROM HOADON HD
                INNER JOIN KHACHHANG KH ON HD.idKhachHang = KH.id
                INNER JOIN NGUOIDUNG ND ON HD.idNguoiDung = ND.id";
            return dbHelper.ExecuteQuery(query);
        }

        // Thêm hóa đơn mới
        public int AddBill(string maHD, DateTime ngayLap, decimal tongTien, int idKhachHang, int idNguoiDung)
        {
            string query = @"
                INSERT INTO HOADON (MaHoaDon, NgayLap, TongTien, idKhachHang, idNguoiDung)
                VALUES (@maHD, @ngayLap, @tongTien, @idKhachHang, @idNguoiDung)";

            SqlParameter[] parameters =
            {
                new SqlParameter("@maHD", maHD),
                new SqlParameter("@ngayLap", ngayLap),
                new SqlParameter("@tongTien", tongTien),
                new SqlParameter("@idKhachHang", idKhachHang),
                new SqlParameter("@idNguoiDung", idNguoiDung)
            };
            return dbHelper.ExecuteNonQuery(query, parameters);
        }

        // Cập nhật hóa đơn
        public int UpdateBill(int id, DateTime ngayLap, decimal tongTien, int idKhachHang, int idNguoiDung)
        {
            string query = @"
                UPDATE HOADON
                SET NgayLap = @ngayLap, TongTien = @tongTien, idKhachHang = @idKhachHang, idNguoiDung = @idNguoiDung
                WHERE id = @id";

            SqlParameter[] parameters =
            {
                new SqlParameter("@id", id),
                new SqlParameter("@ngayLap", ngayLap),
                new SqlParameter("@tongTien", tongTien),
                new SqlParameter("@idKhachHang", idKhachHang),
                new SqlParameter("@idNguoiDung", idNguoiDung)
            };
            return dbHelper.ExecuteNonQuery(query, parameters);
        }

        // Xóa hóa đơn
        public int DeleteBill(int id)
        {
            string query = "DELETE FROM HOADON WHERE id = @id";
            SqlParameter[] parameters =
            {
                new SqlParameter("@id", id)
            };
            return dbHelper.ExecuteNonQuery(query, parameters);
        }
    }
}