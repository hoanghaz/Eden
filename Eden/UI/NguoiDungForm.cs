using System;
using System.Linq;
using System.Windows.Forms;

namespace Eden
{
    public partial class NguoiDungForm : Form
    {
        private NGUOIDUNGBLL nguoiDungBLL = new NGUOIDUNGBLL();
        private int pageSize = 5;
        private int currentPage = 1;

        public NguoiDungForm()
        {
            InitializeComponent();
            LoadUsers();
        }

        private void LoadUsers()
        {
            var users = nguoiDungBLL.GetAll()
                .Skip((currentPage - 1) * pageSize)
                .Take(pageSize)
                .ToList();

            dgvUsers.DataSource = users;
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            string keyword = txtSearch.Text.ToLower();
            var users = nguoiDungBLL.GetAll()
                .Where(u => u.TenNguoiDung.ToLower().Contains(keyword))
                .ToList();

            dgvUsers.DataSource = users;
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            NGUOIDUNG newUser = new NGUOIDUNG
            {
                TenNguoiDung = txtUserName.Text,
                TenDangNhap = txtLogin.Text,
                MatKhau = txtPassword.Text,
                idNhomNguoiDung = Convert.ToInt32(cbUserGroup.SelectedValue)
            };

            nguoiDungBLL.Add(newUser);
            LoadUsers();
        }

        private void BtnEdit_Click(object sender, EventArgs e)
        {
            // Sửa thông tin người dùng
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            // Xóa người dùng
        }

        private void BtnPrev_Click(object sender, EventArgs e)
        {
            if (currentPage > 1)
            {
                currentPage--;
                LoadUsers();
            }
        }

        private void BtnNext_Click(object sender, EventArgs e)
        {
            if ((currentPage * pageSize) < nguoiDungBLL.GetAll().Count)
            {
                currentPage++;
                LoadUsers();
            }
        }

        private void lblSearch_Click(object sender, EventArgs e)
        {

        }
    }
}