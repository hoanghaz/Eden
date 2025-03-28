using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Guna.UI2.WinForms;

namespace Eden
{
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