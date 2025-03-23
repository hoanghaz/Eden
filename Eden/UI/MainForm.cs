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
            init();
        }

        private void init()
        {
            LoadDataProduct();
            LoadDataCategory();
            LoadDataUser();
            LoadDataCustomer();
            LoadDataBill();
        }

        private void LoadDataProduct() => dgPro.DataSource = productBLL.GetAllProducts();

        private void LoadDataCategory() => dgCate.DataSource = categoryBLL.GetAllCategories();

        private void LoadDataUser() => dgUser.DataSource = userBLL.GetAllUsers();

        private void LoadDataCustomer() => dgCus.DataSource = customerBLL.GetAllCustomers();

        private void LoadDataBill() => dgBill.DataSource = billBLL.GetAllBills();

        //private void btnAdd_Click(object sender, EventArgs e)
        //{
        //    try
        //    {
        //        if (productBLL.AddProduct(txtName.Text, decimal.Parse(txtPrice.Text), int.Parse(txtStock.Text), txtCategoryId.Text))
        //        {
        //            MessageBox.Show("Thêm sản phẩm thành công!");
        //            LoadData();
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show("Lỗi: " + ex.Message);
        //    }
        //}

        //private void btnUpdate_Click(object sender, EventArgs e)
        //{
        //    try
        //    {
        //        if (productBLL.UpdateProduct(int.Parse(txtId.Text), txtName.Text, decimal.Parse(txtPrice.Text), int.Parse(txtStock.Text), txtCategoryId.Text))
        //        {
        //            MessageBox.Show("Cập nhật thành công!");
        //            LoadData();
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show("Lỗi: " + ex.Message);
        //    }
        //}

        //private void btnDelete_Click(object sender, EventArgs e)
        //{
        //    try
        //    {
        //        if (productBLL.DeleteProduct(int.Parse(txtId.Text)))
        //        {
        //            MessageBox.Show("Xóa thành công!");
        //            LoadData();
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show("Lỗi: " + ex.Message);
        //    }
        //}
    }
}