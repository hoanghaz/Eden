using System;
using System.Data;

namespace Eden
{
    public class LoginBLL
    {
        private readonly UserDAL userDAL = new UserDAL();

        public Boolean ValidateUser(string username, string password)
        {
            DataTable users = userDAL.GetAllUsers(); // Lấy tất cả người dùng

            foreach (DataRow row in users.Rows)
            {
                if (row["Tên đăng nhập"].ToString() == username &&
                    row["Mật Khẩu"].ToString() == password)
                {
                    return true; // Trả về ID người dùng nếu hợp lệ
                }
            }
            return false; // Đăng nhập thất bại
        }
    }
}