using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Eden.UI
{
    public partial class SanPhamFormAdd : Form
    {
        private LOAISANPHAMBLL loaiSanPhamBLL;
        private SANPHAMBLL sanPhamBLL;
        public SanPhamFormAdd()
        {
            InitializeComponent();
            sanPhamBLL = new SANPHAMBLL();
            loaiSanPhamBLL = new LOAISANPHAMBLL();
            GenerateProductID();
            LoadLoaiSanPham();
            LoadNhaCungCap();
        }
        private void GenerateProductID()
        {
            var sanPhamList = sanPhamBLL.GetAll();
            if (sanPhamList.Count > 0)
            {
                var lastSanPham = sanPhamList
                    .Where(sp => sp.MaSanPham.StartsWith("SP")) // Chỉ lấy các mã hợp lệ
                    .OrderByDescending(sp => sp.MaSanPham)
                    .FirstOrDefault();

                if (lastSanPham != null)
                {
                    int lastNumber = int.Parse(lastSanPham.MaSanPham.Substring(2)); // Lấy số từ SPxxx
                    guna2TextBoxMaSP.Text = $"SP{(lastNumber + 1):D3}"; // Định dạng SP001 -> SP999
                }
                else
                {
                    guna2TextBoxMaSP.Text = "SP001"; // Nếu không có mã hợp lệ
                }
            }
            else
            {
                guna2TextBoxMaSP.Text = "SP001"; // Nếu chưa có sản phẩm nào
            }
            guna2TextBoxMaSP.ReadOnly = true; // Không cho phép chỉnh sửa mã
        }
        private void LoadLoaiSanPham()
        {
            try
            {
                List<LOAISANPHAM> loaiSanPhams = loaiSanPhamBLL.GetAll(); // Lấy danh sách loại sản phẩm từ DB

                if (loaiSanPhams.Count > 0)
                {
                    guna2ComboBoxLoaiSP.DataSource = loaiSanPhams; // Gán danh sách vào ComboBox
                    guna2ComboBoxLoaiSP.DisplayMember = "TenLoaiSanPham"; // Hiển thị tên loại sản phẩm
                    guna2ComboBoxLoaiSP.ValueMember = "id"; // Giá trị thực tế là ID loại sản phẩm
                }
                else
                {
                    MessageBox.Show("Không có loại sản phẩm nào trong cơ sở dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải danh sách loại sản phẩm: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void LoadNhaCungCap()
        {
            try
            {
                // Gọi BLL để lấy danh sách nhà cung cấp
                var nhaCungCapBLL = new NHACUNGCAPBLL();
                var listNCC = nhaCungCapBLL.GetAll();

                if (listNCC.Count > 0)
                {
                    // Gán dữ liệu cho ComboBox
                    guna2ComboBoxNCC.DataSource = listNCC;
                    guna2ComboBoxNCC.DisplayMember = "TenNhaCungCap"; // Hiển thị tên nhà cung cấp
                    guna2ComboBoxNCC.ValueMember = "MaNhaCungCap"; // Lưu mã nhà cung cấp
                }
                else
                {
                    MessageBox.Show("Không có nhà cung cấp nào trong hệ thống!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải danh sách nhà cung cấp: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void guna2Button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            try
            {
                SANPHAM sp = new SANPHAM
                {
                    MaSanPham = guna2TextBoxMaSP.Text.Trim(),
                    TenSanPham = guna2TextBoxTenSP.Text.Trim(),
                    MoTa = guna2TextBoxMoTa.Text.Trim(),
                    Gia = decimal.Parse(guna2TextBoxGia.Text.Trim()), // Đảm bảo nhập số hợp lệ
                    SoLuong = int.Parse(guna2TextBoxSoLuong.Text.Trim()), // Đảm bảo nhập số hợp lệ
                    MauSac = guna2TextBoxMauSac.Text.Trim(),
                    AnhChiTiet = guna2TextBoxAnh.Text.Trim(), // Tên ảnh nhập bằng text
                    idNhaCungCap = int.Parse(guna2ComboBoxNCC.SelectedValue.ToString()), // Lấy ID nhà cung cấp từ ComboBox
                    idLoaiSanPham = int.Parse(guna2ComboBoxLoaiSP.SelectedValue.ToString()) // Lấy ID loại sản phẩm từ ComboBox
                };

                sanPhamBLL.Add(sp);
                MessageBox.Show("Thêm sản phẩm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi thêm sản phẩm: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
