using System;
using System.Data;

namespace Eden
{
    public class UserBLL
    {
        private UserDAL userDAL = new UserDAL();

        // Lấy tất cả người dùng
        public DataTable GetAllUsers()
        {
            return userDAL.GetAllUsers();
        }

        // Thêm người dùng mới
        public bool AddUser(string userCode, string fullName, string username, string password, int userGroupId)
        {
            // Kiểm tra dữ liệu đầu vào
            if (string.IsNullOrWhiteSpace(userCode) || string.IsNullOrWhiteSpace(fullName) ||
                string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password) || userGroupId <= 0)
            {
                throw new Exception("Dữ liệu không hợp lệ!");
            }

            return userDAL.AddUser(userCode, fullName, username, password, userGroupId) > 0;
        }

        // Cập nhật người dùng
        public bool UpdateUser(int id, string userCode, string fullName, string username, string password, int userGroupId)
        {
            // Kiểm tra dữ liệu đầu vào
            if (id <= 0 || string.IsNullOrWhiteSpace(userCode) || string.IsNullOrWhiteSpace(fullName) ||
                string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password) || userGroupId <= 0)
            {
                throw new Exception("Dữ liệu không hợp lệ!");
            }

            return userDAL.UpdateUser(id, userCode, fullName, username, password, userGroupId) > 0;
        }

        // Xóa người dùng
        public bool DeleteUser(int id)
        {
            if (id <= 0)
            {
                throw new Exception("ID không hợp lệ!");
            }

            return userDAL.DeleteUser(id) > 0;
        }
    }
}