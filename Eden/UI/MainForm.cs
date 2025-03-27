using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using Guna.UI2.WinForms;

namespace Eden
{
    public partial class MainForm : Form
    {
        private ProductBLL productBLL = new ProductBLL();
        private CategoryBLL categoryBLL = new CategoryBLL();
        private UserBLL userBLL = new UserBLL();
        private CustomerBLL customerBLL = new CustomerBLL();
        private BillBLL billBLL = new BillBLL();

        public MainForm()
        {
            InitializeComponent();
            InitializeSidebarButtons();
            //init();
            //MessageBox.Show("Welcome to Eden!" + string.Join(", ", CurrentUser.Permissions));
        }

        private void InitializeSidebarButtons()
        {
            int yPosition = 94;
            //btnTK = CreateSBB("Thống kê","btnTK",yPosition,"report");
        }

        //private Guna2GradientButton CreateSBB(string text, string name, int y, string img)
        //{
        //    Guna2GradientButton btn = new Guna.UI2.WinForms.Guna2GradientButton();
        //    btn.Animated = true;
        //    btn.BackColor = System.Drawing.Color.Transparent;
        //    btn.CustomImages.Image = global::Eden.Properties.Resources.img;
        //    btn.CustomImages.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
        //    btn.CustomImages.ImageOffset = new System.Drawing.Point(10, 0);
        //    btn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
        //    btn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
        //    btn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
        //    btn.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
        //    btn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
        //    btn.FillColor = System.Drawing.Color.Empty;
        //    btn.FillColor2 = System.Drawing.Color.Empty;
        //    btn.Font = new System.Drawing.Font("Segoe UI", 9F);
        //    btn.ForeColor = System.Drawing.Color.White;
        //    btn.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(125)))), ((int)(((byte)(167)))));
        //    btn.HoverState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(49)))), ((int)(((byte)(80)))));
        //    btn.HoverState.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        //    btn.Location = new System.Drawing.Point(0, y);
        //    btn.Name = name;
        //    btn.Size = new System.Drawing.Size(219, 69);
        //    btn.TabIndex = 1;
        //    btn.Text = text;
        //    btn.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
        //    btn.TextOffset = new System.Drawing.Point(50, 0);
        //}

        //private void init()
        //{
        //    LoadDataProduct();
        //    LoadDataCategory();
        //    LoadDataUser();
        //    LoadDataCustomer();
        //    LoadDataBill();
        //}

        //private void LoadDataProduct() => dgPro.DataSource = productBLL.GetAllProducts();

        //private void LoadDataCategory() => dgCate.DataSource = categoryBLL.GetAllCategories();

        //private void LoadDataUser() => dgUser.DataSource = userBLL.GetAllUsers();

        //private void LoadDataCustomer() => dgCus.DataSource = customerBLL.GetAllCustomers();

        //private void LoadDataBill() => dgBill.DataSource = billBLL.GetAllBills();

        private void gbOut_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn đăng xuất?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                // Xóa thông tin người dùng
                CurrentUser.Logout();

                // Mở lại màn hình đăng nhập
                LoginForm loginForm = new LoginForm();
                loginForm.Show();

                // Đóng form chính
                this.Close();
            }
        }

        private void btnPL_Click(object sender, EventArgs e)
        {

        }
    }
}