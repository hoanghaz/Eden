using System.Data;
using System.Data.SqlClient;

namespace Eden
{
    public class LoginDAL
    {
        private readonly DatabaseHelper dbHelper = new DatabaseHelper();

        // Kiểm tra đăng nhập và lấy thông tin người dùng
        public DataTable ValidateUser(string username, string password)
        {
            string query = @"
                SELECT ND.id, ND.TenNguoiDung, ND.TenDangNhap, ND.idNhomNguoiDung, NND.TenNhomNguoiDung
                FROM NGUOIDUNG ND
                INNER JOIN NHOMNGUOIDUNG NND ON ND.idNhomNguoiDung = NND.id
                WHERE ND.TenDangNhap = @username AND ND.MatKhau = @password";

            SqlParameter[] parameters =
            {
                new SqlParameter("@username", username),
                new SqlParameter("@password", password) // Cần mã hóa mật khẩu nếu cần
            };

            return dbHelper.ExecuteQuery(query, parameters);
        }

        // Lấy danh sách chức năng (quyền) của nhóm người dùng
        public DataTable GetUserPermissions(int userGroupId)
        {
            string query = @"
                SELECT CN.TenChucNang, CN.TenManHinh
                FROM CHUCNANG CN
                INNER JOIN PHANQUYEN PQ ON CN.id = PQ.idChucNang
                WHERE PQ.idNhomNguoiDung = @userGroupId";

            SqlParameter[] parameters =
            {
                new SqlParameter("@userGroupId", userGroupId)
            };

            return dbHelper.ExecuteQuery(query, parameters);
        }
    }
}