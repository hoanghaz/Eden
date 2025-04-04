using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Eden
{
    public partial class NhapKhoForm : Form
    {
        private PHIEUNHAPBLL phieuNhapBLL;

        public NhapKhoForm()
        {
            InitializeComponent();
            phieuNhapBLL = new PHIEUNHAPBLL();
            LoadData();
        }

        // Hàm Load dữ liệu phiếu nhập vào DataGridView
        private void LoadData()
        {
            try
            {
                var phieuNhaps = phieuNhapBLL.GetAll();
                dgvPhieuNhap.DataSource = phieuNhaps.Select(p => new
                {
                    p.MaPhieuNhap,
                    p.NgayNhap,
                    NhaCungCap = p.NHACUNGCAP.TenNhaCungCap,
                    NguoiDung = p.NGUOIDUNG.TenNguoiDung
                }).ToList();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải dữ liệu phiếu nhập: " + ex.Message);
            }
        }

        // Sự kiện Thêm phiếu nhập
        private void btnAdd_Click(object sender, EventArgs e)
        {
            NhapKhoFormAdd formAdd = new NhapKhoFormAdd();
            if (formAdd.ShowDialog() == DialogResult.OK)
            {
                LoadData();
            }
        }

        // Sự kiện Sửa phiếu nhập
        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dgvPhieuNhap.SelectedRows.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn một phiếu nhập để sửa.");
                return;
            }

            string maPhieuNhap = dgvPhieuNhap.SelectedRows[0].Cells["MaPhieuNhap"].Value.ToString();
            NhapKhoFormAdd formAdd = new NhapKhoFormAdd(maPhieuNhap);
            if (formAdd.ShowDialog() == DialogResult.OK)
            {
                LoadData();
            }
        }

        // Sự kiện Xóa phiếu nhập
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvPhieuNhap.SelectedRows.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn một phiếu nhập để xóa.");
                return;
            }

            string maPhieuNhap = dgvPhieuNhap.SelectedRows[0].Cells["MaPhieuNhap"].Value.ToString();
            PHIEUNHAP phieuNhap = phieuNhapBLL.GetByMaPhieuNhap(maPhieuNhap);

            if (phieuNhap != null)
            {
                var confirmResult = MessageBox.Show("Bạn chắc chắn muốn xóa phiếu nhập này?", "Xác nhận xóa", MessageBoxButtons.YesNo);
                if (confirmResult == DialogResult.Yes)
                {
                    phieuNhapBLL.Delete(phieuNhap);
                    LoadData();
                }
            }
        }

        // Sự kiện Tìm kiếm phiếu nhập
        private void btnSearch_Click(object sender, EventArgs e)
        {
            string searchTerm = txtSearch.Text.Trim().ToLower();
            var phieuNhaps = phieuNhapBLL.GetAll()
                                           .Where(p => p.MaPhieuNhap.ToLower().Contains(searchTerm) ||
                                                       p.NHACUNGCAP.TenNhaCungCap.ToLower().Contains(searchTerm) ||
                                                       p.NGUOIDUNG.TenNguoiDung.ToLower().Contains(searchTerm))
                                           .ToList();
            dgvPhieuNhap.DataSource = phieuNhaps.Select(p => new
            {
                p.MaPhieuNhap,
                p.NgayNhap,
                NhaCungCap = p.NHACUNGCAP.TenNhaCungCap,
                NguoiDung = p.NGUOIDUNG.TenNguoiDung
            }).ToList();
        }

        // Sự kiện Refresh lại danh sách phiếu nhập
        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        // Hàm khởi tạo giao diện cho form chính này
        private void InitializeComponent()
        {
            this.dgvPhieuNhap = new System.Windows.Forms.DataGridView();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhieuNhap)).BeginInit();
            this.SuspendLayout();

            // 
            // dgvPhieuNhap
            // 
            this.dgvPhieuNhap.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPhieuNhap.Location = new System.Drawing.Point(20, 60);
            this.dgvPhieuNhap.Name = "dgvPhieuNhap";
            this.dgvPhieuNhap.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPhieuNhap.Size = new System.Drawing.Size(760, 300);
            this.dgvPhieuNhap.TabIndex = 0;

            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(20, 380);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "Thêm";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);

            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(120, 380);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(75, 23);
            this.btnEdit.TabIndex = 2;
            this.btnEdit.Text = "Sửa";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);

            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(220, 380);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 3;
            this.btnDelete.Text = "Xóa";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);

            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(320, 20);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(200, 20);
            this.txtSearch.TabIndex = 4;

            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(540, 18);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 5;
            this.btnSearch.Text = "Tìm kiếm";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);

            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(640, 18);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(75, 23);
            this.btnRefresh.TabIndex = 6;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);

            // 
            // NhapKhoForm
            // 
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.dgvPhieuNhap);
            this.Name = "NhapKhoForm";
            this.Text = "Quản Lý Phiếu Nhập";
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhieuNhap)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private DataGridView dgvPhieuNhap;
        private Button btnAdd;
        private Button btnEdit;
        private Button btnDelete;
        private TextBox txtSearch;
        private Button btnSearch;
        private Button btnRefresh;
    }
}
