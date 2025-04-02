using System;
using System.Linq;
using System.Windows.Forms;
using Guna.UI2.WinForms;

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
                // Lấy thông tin loại sản phẩm từ cơ sở dữ liệu
                LOAISANPHAM lsp = loaiSanPhamBLL.GetAll().FirstOrDefault(l => l.MaLoaiSanPham == maLSP);

                if (lsp != null) // Nếu sản phẩm tồn tại
                {
                    // Đổ thông tin sản phẩm vào các ô nhập liệu
                    guna2TextBox1.Text = lsp.MaLoaiSanPham;
                    guna2TextBox1.ReadOnly = true; // Không cho phép sửa mã loại sản phẩm
                    guna2TextBox2.Text = lsp.TenLoaiSanPham;
                }
                else // Nếu không tìm thấy sản phẩm
                {
                    MessageBox.Show("Không tìm thấy loại sản phẩm với mã: " + maLSP, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.Close(); // Đóng form nếu không tìm thấy sản phẩm
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải dữ liệu: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close(); // Đóng form nếu có lỗi
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

                loaiSanPhamBLL.Update(lsp);
                MessageBox.Show("Cập nhật khách hàng thành công!");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi cập nhật: " + ex.Message);
            }
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
