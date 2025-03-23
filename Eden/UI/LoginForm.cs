using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Guna.UI2.WinForms;

namespace Eden
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void forgot_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Vui lòng liên hệ quản trị viên để lấy lại mật khẩu.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnLog_Click(object sender, EventArgs e)
        {
            string username = txtUn.Text;
            string password = txtPw.Text;
            LoginBLL loginBLL = new LoginBLL(); // Khởi tạo đối tượng BLL
            // Gọi phương thức kiểm tra đăng nhập từ DAL
            if (loginBLL.ValidateUser(username, password))
            {
                this.DialogResult = DialogResult.OK; // Đăng nhập thành công
                this.Close();
            }
            else
            {
                MessageBox.Show("Tên đăng nhập hoặc mật khẩu không đúng!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}