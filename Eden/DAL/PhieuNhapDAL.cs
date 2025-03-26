using System;
using System.Data;
using System.Data.SqlClient;

namespace Eden
{
    public class PhieuNhapDAL
    {
        private readonly DatabaseHelper dbHelper = new DatabaseHelper();

        public DataTable GetAllPhieuNhap()
        {
            string query = "SELECT id, MaPhieuNhap as [Mã phiếu nhập], NgayNhap as [Ngày nhập], idNhaCungCap as [Nhà cung cấp], idNguoiDung as [Người lập], TongTien as [Tổng tiền] FROM PHIEUNHAP";
            return dbHelper.ExecuteQuery(query);
        }

        public bool InsertPhieuNhap(DateTime ngayNhap, int idNhaCungCap, int idNguoiDung, decimal tongTien)
        {
            string query = "INSERT INTO PHIEUNHAP (NgayNhap, idNhaCungCap, idNguoiDung, TongTien) VALUES (@NgayNhap, @idNCC, @idND, @TongTien)";
            SqlParameter[] parameters =
            {
            new SqlParameter("@NgayNhap", ngayNhap),
            new SqlParameter("@idNCC", idNhaCungCap),
            new SqlParameter("@idND", idNguoiDung),
            new SqlParameter("@TongTien", tongTien)
        };
            return dbHelper.ExecuteNonQuery(query, parameters) > 0;
        }

        public bool UpdatePhieuNhap(int id, DateTime ngayNhap, int idNhaCungCap, int idNguoiDung, decimal tongTien)
        {
            string query = "UPDATE PHIEUNHAP SET NgayNhap = @NgayNhap, idNhaCungCap = @idNCC, idNguoiDung = @idND, TongTien = @TongTien WHERE id = @id";
            SqlParameter[] parameters =
            {
            new SqlParameter("@id", id),
            new SqlParameter("@NgayNhap", ngayNhap),
            new SqlParameter("@idNCC", idNhaCungCap),
            new SqlParameter("@idND", idNguoiDung),
            new SqlParameter("@TongTien", tongTien)
        };
            return dbHelper.ExecuteNonQuery(query, parameters) > 0;
        }

        public bool DeletePhieuNhap(int id)
        {
            string query = "DELETE FROM PHIEUNHAP WHERE id = @id";
            SqlParameter[] parameters = { new SqlParameter("@id", id) };
            return dbHelper.ExecuteNonQuery(query, parameters) > 0;
        }
    }
}