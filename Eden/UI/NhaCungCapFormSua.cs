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
    public partial class NhaCungCapFormSua : Form
    {
        private NHACUNGCAPBLL nhaCungCapBLL;
        private string maNCC;
        public NhaCungCapFormSua(string maNCC)
        {
            InitializeComponent();
            this.nhaCungCapBLL = new NHACUNGCAPBLL();
            this.maNCC = maNCC;
            LoadNhaCungCap();
        }
        private void LoadNhaCungCap()
        {
            try
            {
                // Lấy thông tin nhà cung cấp từ cơ sở dữ liệu
                NHACUNGCAP ncc = nhaCungCapBLL.GetAll().FirstOrDefault(n => n.MaNhaCungCap == maNCC);

                if (ncc != null) // Nếu tìm thấy nhà cung cấp
                {
                    guna2TextBox1.Text = ncc.MaNhaCungCap;
                    guna2TextBox1.ReadOnly = true; // Không cho phép sửa mã NCC
                    guna2TextBox2.Text = ncc.TenNhaCungCap;
                    guna2TextBox3.Text = ncc.DiaChi;
                    guna2TextBox4.Text = ncc.SoDienThoai;
                    guna2TextBox5.Text = ncc.Email;
                }
                else
                {
                    MessageBox.Show("Không tìm thấy nhà cung cấp!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.Close(); // Đóng form nếu không tìm thấy
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải dữ liệu: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close(); // Đóng form nếu có lỗi
            }
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            try
            {
                NHACUNGCAP ncc = new NHACUNGCAP
                {
                    MaNhaCungCap = maNCC,
                    TenNhaCungCap = guna2TextBox2.Text.Trim(),
                    DiaChi = guna2TextBox3.Text.Trim(),
                    SoDienThoai = guna2TextBox4.Text.Trim(),
                    Email = guna2TextBox5.Text.Trim()
                };

                nhaCungCapBLL.Update(ncc);

                MessageBox.Show("Cập nhật nhà cung cấp thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Cập nhật lại DataGridView trên form cha
                if (this.Owner is NhaCungCapForm parentForm)
                {
                    parentForm.UpdateDataGridView(ncc);
                }

                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi cập nhật: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
