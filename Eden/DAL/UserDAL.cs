using System;
using System.Data;
using System.Data.SqlClient;

namespace Eden
{
    public class UserDAL
    {
        private readonly DatabaseHelper dbHelper = new DatabaseHelper();

        // Lấy tất cả người dùng kèm tên nhóm người dùng
        public DataTable GetAllUsers()
        {
            string query = @"
                SELECT
                    ND.id,
                    ND.MaNguoiDung AS [Mã Người Dùng],
                    ND.TenNguoiDung AS [Tên Người Dùng],
                    ND.TenDangNhap AS [Tên Đăng Nhập],
                    ND.MatKhau AS [Mật Khẩu],
                    NND.TenNhomNguoiDung AS [Nhóm Người Dùng]
                FROM NGUOIDUNG ND
                INNER JOIN NHOMNGUOIDUNG NND ON ND.idNhomNguoiDung = NND.id";

            return dbHelper.ExecuteQuery(query);
        }

        // Thêm người dùng mới
        public int AddUser(string userCode, string userName, string username, string password, int groupId)
        {
            string query = @"
                INSERT INTO NGUOIDUNG
                    (MaNguoiDung, TenNguoiDung, TenDangNhap, MatKhau, idNhomNguoiDung)
                VALUES
                    (@userCode, @userName, @username, @password, @groupId)";

            SqlParameter[] parameters =
            {
                new SqlParameter("@userCode", userCode),
                new SqlParameter("@userName", userName),
                new SqlParameter("@username", username),
                new SqlParameter("@password", password),
                new SqlParameter("@groupId", groupId)
            };

            return dbHelper.ExecuteNonQuery(query, parameters);
        }

        // Cập nhật người dùng
        public int UpdateUser(int id, string userCode, string userName, string username, string password, int groupId)
        {
            string query = @"
                UPDATE NGUOIDUNG
                SET
                    MaNguoiDung = @userCode,
                    TenNguoiDung = @userName,
                    TenDangNhap = @username,
                    MatKhau = @password,
                    idNhomNguoiDung = @groupId
                WHERE id = @id";

            SqlParameter[] parameters =
            {
                new SqlParameter("@id", id),
                new SqlParameter("@userCode", userCode),
                new SqlParameter("@userName", userName),
                new SqlParameter("@username", username),
                new SqlParameter("@password", password),
                new SqlParameter("@groupId", groupId)
            };

            return dbHelper.ExecuteNonQuery(query, parameters);
        }

        // Xóa người dùng
        public int DeleteUser(int id)
        {
            string query = "DELETE FROM NGUOIDUNG WHERE id = @id";
            SqlParameter[] parameters = { new SqlParameter("@id", id) };
            return dbHelper.ExecuteNonQuery(query, parameters);
        }
    }
}