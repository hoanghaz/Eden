using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            guna2DataGridView1.DataSource = loaiSanPhamBLL.GetAll();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            PhanLoaiForm1 phanLoaiForm1 = new PhanLoaiForm1();
            if (phanLoaiForm1.ShowDialog() == DialogResult.OK)
            {
                LoadLoaiSanPham(); // Cập nhật danh sách sau khi thêm
            }
        }
    }
}