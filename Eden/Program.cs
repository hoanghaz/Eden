using System;
using System.Windows.Forms;

namespace Eden
{
    internal static class Program
    {
        [STAThread]
        private static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Hiển thị form đăng nhập
            LoginForm loginForm = new LoginForm();
            if (loginForm.ShowDialog() == DialogResult.OK)
            {
                // Nếu đăng nhập thành công, hiển thị MainForm
                Application.Run(new MainForm());
            }
            else
            {
                // Nếu đăng nhập thất bại hoặc hủy, thoát ứng dụng
                //MessageBox.Show("Đăng nhập thất bại hoặc đã hủy.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Application.Exit();
            }
        }
    }
}