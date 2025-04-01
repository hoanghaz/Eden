using System;
using System.Linq;
using System.Windows.Forms;

namespace Eden.UI
{
    public partial class PhanLoaiFormSua : Form
    {
        private LOAISANPHAMBLL loaiSanPhamBLL;
        private string maLSP;
        public PhanLoaiFormSua(string maLSP)
        {
            InitializeComponent();
            this.loaiSanPhamBLL = new LOAISANPHAMBLL();
            this.maLSP = maLSP;
            PhanLoaiFormSua_Load();
        }

        private void PhanLoaiFormSua_Load()
        {
            try
            {
                // Lấy thông tin loại sản phẩm theo mã
                LOAISANPHAM lsp = loaiSanPhamBLL.GetAll().FirstOrDefault(l => l.MaLoaiSanPham == maLSP);

                if (lsp != null) // Nếu tìm thấy loại sản phẩm
                {
                    guna2TextBox1.Text = lsp.MaLoaiSanPham;
                    guna2TextBox1.ReadOnly = true; // Ngăn sửa mã loại sản phẩm
                    guna2TextBox2.Text = lsp.TenLoaiSanPham;
                }
                else // Nếu không tìm thấy loại sản phẩm
                {
                    MessageBox.Show("Không tìm thấy loại sản phẩm với mã: " + maLSP, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.Close(); // Đóng form sửa để tránh hiển thị form trống
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải dữ liệu: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close(); // Đóng form nếu xảy ra lỗi
            }

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            try
            {
                LOAISANPHAM lsp = new LOAISANPHAM
                {
                    MaLoaiSanPham = maLSP,
                    TenLoaiSanPham = guna2TextBox2.Text.Trim(),
                };

                loaiSanPhamBLL.Update(lsp); // Cập nhật thông tin loại sản phẩm
                MessageBox.Show("Cập nhật loại sản phẩm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            catch (System.Data.Entity.Validation.DbEntityValidationException ex)
            {
                foreach (var entityValidationErrors in ex.EntityValidationErrors)
                {
                    foreach (var validationError in entityValidationErrors.ValidationErrors)
                    {
                        MessageBox.Show($"Lỗi: {validationError.PropertyName} - {validationError.ErrorMessage}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi cập nhật loại sản phẩm: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
