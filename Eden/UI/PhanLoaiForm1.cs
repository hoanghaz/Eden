using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Guna.UI2.WinForms;

namespace Eden
{
    public partial class PhanLoaiForm1 : Form
    {
       
        public PhanLoaiForm1()
        {
            InitializeComponent();
        }

        private void PhanLoaiForm1_Load(object sender, EventArgs e)
        {
            LoadLoaiSanPham();
        }

        private void guna2ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (guna2ComboBox1.SelectedItem == null || guna2ComboBox1.SelectedValue == null)
                return;

            
        }

        private void LoadLoaiSanPham()
        {
            LOAISANPHAMBLL loaiSanPhamBLL = new LOAISANPHAMBLL();
            List<LOAISANPHAM> dsLoaiSanPham = loaiSanPhamBLL.GetAll();

            guna2ComboBox1.DataSource = dsLoaiSanPham;
            guna2ComboBox1.DisplayMember = "MaLoaiSanPham";
        }

        private bool isEditing = false; // Mặc định là thêm mới
        private int maLoaiSanPham = 0; // Lưu lại ID của loại sản phẩm khi sửa
        private void guna2Button1_Click(object sender, EventArgs e)
        {

            string tenLoai = guna2TextBox1.Text.Trim();

            if (string.IsNullOrEmpty(tenLoai))
            {
                MessageBox.Show("Vui lòng nhập tên loại sản phẩm!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            LOAISANPHAMBLL loaiSanPhamBLL = new LOAISANPHAMBLL();

            if (!isEditing) // Thêm mới
            {
                LOAISANPHAM loaiMoi = new LOAISANPHAM
                {
                    TenLoaiSanPham = tenLoai
                };

                loaiSanPhamBLL.Add(loaiMoi);
                MessageBox.Show("Thêm loại sản phẩm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else // Chỉnh sửa
            {
                LOAISANPHAM loaiSua = new LOAISANPHAM
                {
                    MaLoaiSanPham = maLoaiSanPham.ToString(), // Lấy từ biến đã lưu
                    TenLoaiSanPham = tenLoai
                };

                loaiSanPhamBLL.Update(loaiSua);
                MessageBox.Show("Cập nhật loại sản phẩm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            this.DialogResult = DialogResult.OK; // Đóng form và trả về kết quả OK
            this.Close();
        }
}
}
