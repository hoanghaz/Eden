using System;
using System.Windows.Forms;
using Eden;
using Eden.UI;

namespace Eden
{
    public partial class KhachHangForm : Form
    {
        private KHACHHANGBLL khachHangBLL;

        public KhachHangForm()
        {
            InitializeComponent();
            khachHangBLL = new KHACHHANGBLL();
            LoadData();
        }

        // Hàm tải dữ liệu lên DataGridView
        private void LoadData()
        {
            try
            {
                dgkhachhang.DataSource = null; // Xóa dữ liệu cũ trước khi load lại
                dgkhachhang.DataSource = khachHangBLL.GetAll();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải dữ liệu: " + ex.Message);
            }
        }

        // Mở form thêm khách hàng
        private void addkhachhang_Click(object sender, EventArgs e)
        {
            using (KhachHangadd formAdd = new KhachHangadd())
            {
                formAdd.ShowDialog();
                LoadData(); // Cập nhật danh sách sau khi thêm
            }
        }

        // Mở form sửa khách hàng
        private void suakhachhang_Click(object sender, EventArgs e)
        {
            if (dgkhachhang.CurrentRow != null)
            {
                string maKH = dgkhachhang.CurrentRow.Cells["MaKhachHang"].Value.ToString();

                using (KhachHangsua formSua = new KhachHangsua(maKH))
                {
                    formSua.FormClosed += (s, args) => LoadData(); // Cập nhật dữ liệu khi đóng form
                    formSua.ShowDialog();
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn khách hàng cần sửa.");
            }
        }

        // Xóa khách hàng
        private void xoakhachhang_Click(object sender, EventArgs e)
        {
            if (dgkhachhang.CurrentRow != null)
            {
                string maKH = dgkhachhang.CurrentRow.Cells["MaKhachHang"].Value.ToString(); // Đảm bảo đúng tên cột
                KHACHHANG kh = new KHACHHANG { MaKhachHang = maKH };

                DialogResult result = MessageBox.Show("Bạn có chắc muốn xóa khách hàng này?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    try
                    {
                        khachHangBLL.Delete(kh);
                        LoadData(); // Load lại danh sách sau khi xóa
                        MessageBox.Show("Xóa khách hàng thành công!");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lỗi khi xóa khách hàng: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn khách hàng cần xóa.");
            }
        }

        // Xử lý sự kiện click trong DataGridView (Nếu cần)
        private void dgkhachhang_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Có thể thêm xử lý nếu cần, ví dụ hiển thị thông tin khách hàng
        }
    }
}