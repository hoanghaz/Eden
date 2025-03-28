using System;
using System.Collections.Generic;
using System.Data;
using Guna.UI2.WinForms;

namespace Eden
{
    using System.Linq;

    namespace Eden
    {
        public class LoginBLL
        {
            private readonly LoginDAL loginDAL = new LoginDAL();

            public bool ValidateUser(string username, string password)
            {
                var user = loginDAL.ValidateUser(username, password);
                if (user != null)
                {
                    CurrentUser.Id = user.id;
                    CurrentUser.Username = user.TenNguoiDung;
                    CurrentUser.Role = user.NHOMNGUOIDUNG?.TenNhomNguoiDung;
                    CurrentUser.UserGroupId = user.idNhomNguoiDung;

                    // Lấy quyền từ navigation properties
                    CurrentUser.Permissions = loginDAL.GetUserPermissions(user.idNhomNguoiDung).ToList();

                    return true;
                }
                return false;
            }
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

        public static void Logout(List<Guna2GradientButton> sidebarButtons, Guna2Panel guna2Panel2)
        {
            Id = 0;
            Username = null;
            Role = null;
            UserGroupId = 0;
            Permissions.Clear();
            // Xóa tất cả các nút sidebar
            foreach (var btn in sidebarButtons)
            {
                guna2Panel2.Controls.Remove(btn); // Hoặc yourPanel.Controls.Remove(btn)
                btn.Dispose(); // Giải phóng tài nguyên
            }
            sidebarButtons.Clear(); // Xóa danh sách
        }
    }
}