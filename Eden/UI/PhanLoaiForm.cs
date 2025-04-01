using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Eden.UI;

namespace Eden
{
    public partial class PhanLoaiForm : Form
    {
        private LOAISANPHAMBLL loaiSanPhamBLL;
        public PhanLoaiForm()
        {
            InitializeComponent();
            loaiSanPhamBLL = new LOAISANPHAMBLL();
            LoadLoaiSanPham();
        }

        private void PhanLoaiForm_Load(object sender, EventArgs e)
        {

        }
        private void LoadLoaiSanPham()
        {
            try
            {
                guna2DataGridView1.DataSource = null; // Xóa dữ liệu cũ trước khi load lại
                guna2DataGridView1.DataSource = loaiSanPhamBLL.GetAll();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải dữ liệu: " + ex.Message);
            }
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            using (PhanLoaiFormAdd formAdd = new PhanLoaiFormAdd())
            {
                formAdd.ShowDialog();
                LoadLoaiSanPham(); // Cập nhật danh sách sau khi thêm
            }
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            if (guna2DataGridView1.CurrentRow != null)
            {
                // Lấy giá trị "MaLoaiSanPham" từ cột trong DataGridView
                string maLSP = guna2DataGridView1.CurrentRow.Cells["MaLoaiSanPham"].Value.ToString();

                // Tạo đối tượng PhanLoaiFormSua và truyền maLSP vào constructor
                using (PhanLoaiFormSua phanLoaiFormSua = new PhanLoaiFormSua(maLSP))
                {
                    // Đăng ký sự kiện khi form PhanLoaiFormSua đóng để cập nhật lại dữ liệu
                    phanLoaiFormSua.FormClosed += (s, args) => LoadLoaiSanPham(); // Cập nhật dữ liệu sau khi sửa
                    phanLoaiFormSua.ShowDialog();
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn loại sản phẩm cần sửa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            if (guna2DataGridView1.CurrentRow != null)
            {
                // Lấy giá trị "MaLoaiSanPham" từ cột trong DataGridView
                string maLSP = guna2DataGridView1.CurrentRow.Cells["MaLoaiSanPham"].Value.ToString(); // Đảm bảo đúng tên cột
                LOAISANPHAM lsp = new LOAISANPHAM { MaLoaiSanPham = maLSP };

                // Hỏi người dùng có chắc chắn muốn xóa loại sản phẩm này không
                DialogResult result = MessageBox.Show("Bạn có chắc muốn xóa loại sản phẩm này?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    try
                    {
                        // Tìm loại sản phẩm trong cơ sở dữ liệu trước khi xóa
                        var existingLSP = loaiSanPhamBLL.GetAll().FirstOrDefault(l => l.MaLoaiSanPham == maLSP);

                        if (existingLSP != null) // Nếu loại sản phẩm tồn tại
                        {
                            // Gọi phương thức Delete để xóa loại sản phẩm
                            loaiSanPhamBLL.Delete(existingLSP);
                            LoadLoaiSanPham(); // Load lại danh sách sau khi xóa
                            MessageBox.Show("Xóa loại sản phẩm thành công!");
                        }
                        else
                        {
                            MessageBox.Show("Không tìm thấy loại sản phẩm cần xóa.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lỗi khi xóa loại sản phẩm: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn loại sản phẩm cần xóa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}