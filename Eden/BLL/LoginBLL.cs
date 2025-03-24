using System;
using System.Collections.Generic;
using System.Data;

namespace Eden
{
    public class LoginBLL
    {
        private readonly LoginDAL loginDAL = new LoginDAL();

        // Kiểm tra đăng nhập và lấy thông tin người dùng
        public bool ValidateUser(string username, string password)
        {
            DataTable dt = loginDAL.ValidateUser(username, password);

            if (dt.Rows.Count > 0)
            {
                int userId = Convert.ToInt32(dt.Rows[0]["id"]);
                string userRole = dt.Rows[0]["TenNhomNguoiDung"].ToString();
                int userGroupId = Convert.ToInt32(dt.Rows[0]["idNhomNguoiDung"]);

                // Lưu thông tin người dùng hiện tại
                CurrentUser.Id = userId;
                CurrentUser.Username = dt.Rows[0]["TenNguoiDung"].ToString();
                CurrentUser.Role = userRole;
                CurrentUser.UserGroupId = userGroupId;

                // Lấy quyền của nhóm người dùng
                DataTable permissions = loginDAL.GetUserPermissions(userGroupId);
                foreach (DataRow row in permissions.Rows)
                {
                    CurrentUser.Permissions.Add(row["TenChucNang"].ToString());
                }

                return true;
            }
            return false;
        }
    }

    // Lớp lưu thông tin người dùng sau khi đăng nhập
    public static class CurrentUser
    {
        public static int Id { get; set; }
        public static string Username { get; set; }
        public static string Role { get; set; }
        public static int UserGroupId { get; set; }
        public static List<string> Permissions { get; set; } = new List<string>();
    }
}