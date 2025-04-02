using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using Eden.UI;

namespace Eden
{
    public partial class SanPhamForm : Form
    {
        private SANPHAMBLL sanphamBLL; // Đổi tên theo chuẩn CamelCase
        
        public SanPhamForm()
        {
            InitializeComponent();
            sanphamBLL = new SANPHAMBLL(); // Khởi tạo BLL
            LoadSanPham(); // Gọi hàm tải dữ liệu
        }

        private void guna2DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Xử lý sự kiện nếu cần
        }

        private void LoadSanPham()
        {
            dgSanPham.DataSource = sanphamBLL.GetAll();
        }
        

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            using (SanPhamFormAdd formAdd = new SanPhamFormAdd())
            {
                formAdd.ShowDialog();
                LoadSanPham(); // Cập nhật danh sách sau khi thêm
            }
        }
    }
}
