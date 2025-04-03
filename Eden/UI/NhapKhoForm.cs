using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Eden
{
    partial class NhapKhoForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.DataGridView dgvPhieuNhap;
        private System.Windows.Forms.DataGridView dgvChiTietPhieuNhap;
        private System.Windows.Forms.Button btnAddPhieuNhap;
        private System.Windows.Forms.Button btnUpdatePhieuNhap;
        private System.Windows.Forms.Button btnDeletePhieuNhap;
        private System.Windows.Forms.Button btnAddChiTiet;
        private System.Windows.Forms.Button btnUpdateChiTiet;
        private System.Windows.Forms.Button btnDeleteChiTiet;
        private System.Windows.Forms.ComboBox comboBoxNhaCungCap;
        private System.Windows.Forms.ComboBox comboBoxNguoiDung;
        private System.Windows.Forms.ComboBox comboBoxSanPham;
        private System.Windows.Forms.DateTimePicker dateTimePickerNgayNhap;
        private System.Windows.Forms.TextBox txtSoLuong;
        private System.Windows.Forms.TextBox txtDonGia;
        private System.Windows.Forms.DateTimePicker dateTimePickerStartDate;
        private System.Windows.Forms.DateTimePicker dateTimePickerEndDate;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label lblNgayNhap;
        private System.Windows.Forms.Label lblNhaCungCap;
        private System.Windows.Forms.Label lblNguoiDung;
        private System.Windows.Forms.Label lblSanPham;
        private System.Windows.Forms.Label lblSoLuong;
        private System.Windows.Forms.Label lblDonGia;
        private System.Windows.Forms.Label lblStartDate;
        private System.Windows.Forms.Label lblEndDate;

        private void InitializeComponent()
        {
            this.dgvPhieuNhap = new System.Windows.Forms.DataGridView();
            this.dgvChiTietPhieuNhap = new System.Windows.Forms.DataGridView();
            this.btnAddPhieuNhap = new System.Windows.Forms.Button();
            this.btnUpdatePhieuNhap = new System.Windows.Forms.Button();
            this.btnDeletePhieuNhap = new System.Windows.Forms.Button();
            this.btnAddChiTiet = new System.Windows.Forms.Button();
            this.btnUpdateChiTiet = new System.Windows.Forms.Button();
            this.btnDeleteChiTiet = new System.Windows.Forms.Button();
            this.comboBoxNhaCungCap = new System.Windows.Forms.ComboBox();
            this.comboBoxNguoiDung = new System.Windows.Forms.ComboBox();
            this.comboBoxSanPham = new System.Windows.Forms.ComboBox();
            this.dateTimePickerNgayNhap = new System.Windows.Forms.DateTimePicker();
            this.txtSoLuong = new System.Windows.Forms.TextBox();
            this.txtDonGia = new System.Windows.Forms.TextBox();
            this.dateTimePickerStartDate = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerEndDate = new System.Windows.Forms.DateTimePicker();
            this.btnSearch = new System.Windows.Forms.Button();
            this.lblNgayNhap = new System.Windows.Forms.Label();
            this.lblNhaCungCap = new System.Windows.Forms.Label();
            this.lblNguoiDung = new System.Windows.Forms.Label();
            this.lblSanPham = new System.Windows.Forms.Label();
            this.lblSoLuong = new System.Windows.Forms.Label();
            this.lblDonGia = new System.Windows.Forms.Label();
            this.lblStartDate = new System.Windows.Forms.Label();
            this.lblEndDate = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhieuNhap)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChiTietPhieuNhap)).BeginInit();
            this.SuspendLayout();

            // dgvPhieuNhap
            this.dgvPhieuNhap.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPhieuNhap.Location = new System.Drawing.Point(12, 12);
            this.dgvPhieuNhap.Name = "dgvPhieuNhap";
            this.dgvPhieuNhap.Size = new System.Drawing.Size(600, 200);
            this.dgvPhieuNhap.TabIndex = 0;
            this.dgvPhieuNhap.SelectionChanged += new System.EventHandler(this.dgvPhieuNhap_SelectionChanged);

            // dgvChiTietPhieuNhap
            this.dgvChiTietPhieuNhap.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvChiTietPhieuNhap.Location = new System.Drawing.Point(12, 230);
            this.dgvChiTietPhieuNhap.Name = "dgvChiTietPhieuNhap";
            this.dgvChiTietPhieuNhap.Size = new System.Drawing.Size(600, 200);
            this.dgvChiTietPhieuNhap.TabIndex = 1;

            // btnAddPhieuNhap
            this.btnAddPhieuNhap.Location = new System.Drawing.Point(630, 12);
            this.btnAddPhieuNhap.Name = "btnAddPhieuNhap";
            this.btnAddPhieuNhap.Size = new System.Drawing.Size(75, 23);
            this.btnAddPhieuNhap.TabIndex = 2;
            this.btnAddPhieuNhap.Text = "Thêm Phiếu Nhập";
            this.btnAddPhieuNhap.UseVisualStyleBackColor = true;
            this.btnAddPhieuNhap.Click += new System.EventHandler(this.btnAddPhieuNhap_Click);

            // btnUpdatePhieuNhap
            this.btnUpdatePhieuNhap.Location = new System.Drawing.Point(630, 41);
            this.btnUpdatePhieuNhap.Name = "btnUpdatePhieuNhap";
            this.btnUpdatePhieuNhap.Size = new System.Drawing.Size(75, 23);
            this.btnUpdatePhieuNhap.TabIndex = 3;
            this.btnUpdatePhieuNhap.Text = "Cập Nhật Phiếu Nhập";
            this.btnUpdatePhieuNhap.UseVisualStyleBackColor = true;
            this.btnUpdatePhieuNhap.Click += new System.EventHandler(this.btnUpdatePhieuNhap_Click);

            // btnDeletePhieuNhap
            this.btnDeletePhieuNhap.Location = new System.Drawing.Point(630, 70);
            this.btnDeletePhieuNhap.Name = "btnDeletePhieuNhap";
            this.btnDeletePhieuNhap.Size = new System.Drawing.Size(75, 23);
            this.btnDeletePhieuNhap.TabIndex = 4;
            this.btnDeletePhieuNhap.Text = "Xóa Phiếu Nhập";
            this.btnDeletePhieuNhap.UseVisualStyleBackColor = true;
            this.btnDeletePhieuNhap.Click += new System.EventHandler(this.btnDeletePhieuNhap_Click);

            // btnAddChiTiet
            this.btnAddChiTiet.Location = new System.Drawing.Point(630, 230);
            this.btnAddChiTiet.Name = "btnAddChiTiet";
            this.btnAddChiTiet.Size = new System.Drawing.Size(75, 23);
            this.btnAddChiTiet.TabIndex = 5;
            this.btnAddChiTiet.Text = "Thêm Chi Tiết";
            this.btnAddChiTiet.UseVisualStyleBackColor = true;
            this.btnAddChiTiet.Click += new System.EventHandler(this.btnAddChiTiet_Click);

            // btnUpdateChiTiet
            this.btnUpdateChiTiet.Location = new System.Drawing.Point(630, 259);
            this.btnUpdateChiTiet.Name = "btnUpdateChiTiet";
            this.btnUpdateChiTiet.Size = new System.Drawing.Size(75, 23);
            this.btnUpdateChiTiet.TabIndex = 6;
            this.btnUpdateChiTiet.Text = "Cập Nhật Chi Tiết";
            this.btnUpdateChiTiet.UseVisualStyleBackColor = true;
            this.btnUpdateChiTiet.Click += new System.EventHandler(this.btnUpdateChiTiet_Click);

            // btnDeleteChiTiet
            this.btnDeleteChiTiet.Location = new System.Drawing.Point(630, 288);
            this.btnDeleteChiTiet.Name = "btnDeleteChiTiet";
            this.btnDeleteChiTiet.Size = new System.Drawing.Size(75, 23);
            this.btnDeleteChiTiet.TabIndex = 7;
            this.btnDeleteChiTiet.Text = "Xóa Chi Tiết";
            this.btnDeleteChiTiet.UseVisualStyleBackColor = true;
            this.btnDeleteChiTiet.Click += new System.EventHandler(this.btnDeleteChiTiet_Click);

            // comboBoxNhaCungCap
            this.comboBoxNhaCungCap.FormattingEnabled = true;
            this.comboBoxNhaCungCap.Location = new System.Drawing.Point(755, 12);
            this.comboBoxNhaCungCap.Name = "comboBoxNhaCungCap";
            this.comboBoxNhaCungCap.Size = new System.Drawing.Size(121, 21);
            this.comboBoxNhaCungCap.TabIndex = 8;

            // comboBoxNguoiDung
            this.comboBoxNguoiDung.FormattingEnabled = true;
            this.comboBoxNguoiDung.Location = new System.Drawing.Point(755, 41);
            this.comboBoxNguoiDung.Name = "comboBoxNguoiDung";
            this.comboBoxNguoiDung.Size = new System.Drawing.Size(121, 21);
            this.comboBoxNguoiDung.TabIndex = 9;

            // comboBoxSanPham
            this.comboBoxSanPham.FormattingEnabled = true;
            this.comboBoxSanPham.Location = new System.Drawing.Point(755, 70);
            this.comboBoxSanPham.Name = "comboBoxSanPham";
            this.comboBoxSanPham.Size = new System.Drawing.Size(121, 21);
            this.comboBoxSanPham.TabIndex = 10;

            // dateTimePickerNgayNhap
            this.dateTimePickerNgayNhap.Location = new System.Drawing.Point(755, 97);
            this.dateTimePickerNgayNhap.Name = "dateTimePickerNgayNhap";
            this.dateTimePickerNgayNhap.Size = new System.Drawing.Size(200, 20);
            this.dateTimePickerNgayNhap.TabIndex = 11;

            // txtSoLuong
            this.txtSoLuong.Location = new System.Drawing.Point(755, 123);
            this.txtSoLuong.Name = "txtSoLuong";
            this.txtSoLuong.Size = new System.Drawing.Size(100, 20);
            this.txtSoLuong.TabIndex = 12;

            // txtDonGia
            this.txtDonGia.Location = new System.Drawing.Point(755, 149);
            this.txtDonGia.Name = "txtDonGia";
            this.txtDonGia.Size = new System.Drawing.Size(100, 20);
            this.txtDonGia.TabIndex = 13;

            // dateTimePickerStartDate
            this.dateTimePickerStartDate.Location = new System.Drawing.Point(755, 175);
            this.dateTimePickerStartDate.Name = "dateTimePickerStartDate";
            this.dateTimePickerStartDate.Size = new System.Drawing.Size(200, 20);
            this.dateTimePickerStartDate.TabIndex = 14;

            // dateTimePickerEndDate
            this.dateTimePickerEndDate.Location = new System.Drawing.Point(755, 201);
            this.dateTimePickerEndDate.Name = "dateTimePickerEndDate";
            this.dateTimePickerEndDate.Size = new System.Drawing.Size(200, 20);
            this.dateTimePickerEndDate.TabIndex = 15;

            // btnSearch
            this.btnSearch.Location = new System.Drawing.Point(755, 227);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 16;
            this.btnSearch.Text = "Tìm Kiếm";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);

            // NhapKhoForm
            this.ClientSize = new System.Drawing.Size(984, 461);
            this.Controls.Add(this.dgvPhieuNhap);
            this.Controls.Add(this.dgvChiTietPhieuNhap);
            this.Controls.Add(this.btnAddPhieuNhap);
            this.Controls.Add(this.btnUpdatePhieuNhap);
            this.Controls.Add(this.btnDeletePhieuNhap);
            this.Controls.Add(this.btnAddChiTiet);
            this.Controls.Add(this.btnUpdateChiTiet);
            this.Controls.Add(this.btnDeleteChiTiet);
            this.Controls.Add(this.comboBoxNhaCungCap);
            this.Controls.Add(this.comboBoxNguoiDung);
            this.Controls.Add(this.comboBoxSanPham);
            this.Controls.Add(this.dateTimePickerNgayNhap);
            this.Controls.Add(this.txtSoLuong);
            this.Controls.Add(this.txtDonGia);
            this.Controls.Add(this.dateTimePickerStartDate);
            this.Controls.Add(this.dateTimePickerEndDate);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.lblNgayNhap);
            this.Controls.Add(this.lblNhaCungCap);
            this.Controls.Add(this.lblNguoiDung);
            this.Controls.Add(this.lblSanPham);
            this.Controls.Add(this.lblSoLuong);
            this.Controls.Add(this.lblDonGia);
            this.Controls.Add(this.lblStartDate);
            this.Controls.Add(this.lblEndDate);
            this.Name = "NhapKhoForm";
            this.Text = "Quản lý Nhập Kho";
            this.Load += new System.EventHandler(this.NhapKhoForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhieuNhap)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChiTietPhieuNhap)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
    public partial class NhapKhoForm : Form
    {
        private PHIEUNHAPBLL phieuNhapBLL = new PHIEUNHAPBLL();
        private CHITIETPHIEUNHAPBLL chiTietBLL = new CHITIETPHIEUNHAPBLL();

        public NhapKhoForm()
        {
            InitializeComponent();
        }

        // Khi form được load, sẽ hiển thị danh sách phiếu nhập và chi tiết
        private void NhapKhoForm_Load(object sender, EventArgs e)
        {
            LoadPhieuNhapData();
            LoadChiTietPhieuNhapData();
        }

        // Tải dữ liệu phiếu nhập
        private void LoadPhieuNhapData()
        {
            var phieuNhapList = phieuNhapBLL.GetAll();
            dgvPhieuNhap.DataSource = phieuNhapList;
        }

        // Tải dữ liệu chi tiết phiếu nhập theo mã phiếu
        private void LoadChiTietPhieuNhapData()
        {
            if (dgvPhieuNhap.SelectedRows.Count > 0)
            {
                var selectedPhieuNhap = dgvPhieuNhap.SelectedRows[0].Cells["MaPhieuNhap"].Value.ToString();
                var chiTietList = chiTietBLL.GetByMaPhieuNhap(selectedPhieuNhap);
                dgvChiTietPhieuNhap.DataSource = chiTietList;
            }
        }

        // Thêm phiếu nhập mới
        private void btnAddPhieuNhap_Click(object sender, EventArgs e)
        {
            var phieuNhap = new PHIEUNHAP
            {
                NgayNhap = dateTimePickerNgayNhap.Value,
                idNhaCungCap = Convert.ToInt32(comboBoxNhaCungCap.SelectedValue),  // giả sử có combo box để chọn nhà cung cấp
                idNguoiDung = Convert.ToInt32(comboBoxNguoiDung.SelectedValue),  // giả sử có combo box để chọn người dùng
                TongTien = 0  // Giá trị này có thể được tính sau khi thêm chi tiết phiếu nhập
            };

            phieuNhapBLL.Add(phieuNhap);
            LoadPhieuNhapData();
        }

        // Thêm chi tiết phiếu nhập
        private void btnAddChiTiet_Click(object sender, EventArgs e)
        {
            var chiTiet = new CHITIETPHIEUNHAP
            {
                idPhieuNhap = Convert.ToInt32(dgvPhieuNhap.SelectedRows[0].Cells["id"].Value),
                idSanPham = Convert.ToInt32(comboBoxSanPham.SelectedValue), // Giả sử có combo box để chọn sản phẩm
                SoLuong = Convert.ToInt32(txtSoLuong.Text),
                DonGia = Convert.ToDecimal(txtDonGia.Text),
                ThanhTien = Convert.ToInt32(txtSoLuong.Text) * Convert.ToDecimal(txtDonGia.Text)
            };

            chiTietBLL.Add(chiTiet);
            LoadChiTietPhieuNhapData();
        }

        // Cập nhật phiếu nhập
        private void btnUpdatePhieuNhap_Click(object sender, EventArgs e)
        {
            if (dgvPhieuNhap.SelectedRows.Count > 0)
            {
                var selectedPhieuNhap = dgvPhieuNhap.SelectedRows[0].Cells["id"].Value.ToString();
                var phieuNhap = phieuNhapBLL.GetByMaPhieuNhap(selectedPhieuNhap).FirstOrDefault();

                if (phieuNhap != null)
                {
                    phieuNhap.NgayNhap = dateTimePickerNgayNhap.Value;
                    phieuNhap.idNhaCungCap = Convert.ToInt32(comboBoxNhaCungCap.SelectedValue);
                    phieuNhap.idNguoiDung = Convert.ToInt32(comboBoxNguoiDung.SelectedValue);
                    phieuNhap.TongTien = 0;  // Tính toán lại tổng tiền sau khi cập nhật chi tiết phiếu nhập

                    phieuNhapBLL.Update(phieuNhap);
                    LoadPhieuNhapData();
                }
            }
        }

        // Cập nhật chi tiết phiếu nhập
        private void btnUpdateChiTiet_Click(object sender, EventArgs e)
        {
            if (dgvChiTietPhieuNhap.SelectedRows.Count > 0)
            {
                var selectedChiTiet = dgvChiTietPhieuNhap.SelectedRows[0].Cells["id"].Value.ToString();
                var chiTiet = chiTietBLL.GetById(Convert.ToInt32(selectedChiTiet));

                if (chiTiet != null)
                {
                    chiTiet.SoLuong = Convert.ToInt32(txtSoLuong.Text);
                    chiTiet.DonGia = Convert.ToDecimal(txtDonGia.Text);
                    chiTiet.ThanhTien = chiTiet.SoLuong * chiTiet.DonGia;

                    chiTietBLL.Update(chiTiet);
                    LoadChiTietPhieuNhapData();
                }
            }
        }

        // Xóa phiếu nhập
        private void btnDeletePhieuNhap_Click(object sender, EventArgs e)
        {
            if (dgvPhieuNhap.SelectedRows.Count > 0)
            {
                var selectedPhieuNhap = dgvPhieuNhap.SelectedRows[0].Cells["id"].Value.ToString();
                var phieuNhap = phieuNhapBLL.GetByMaPhieuNhap(selectedPhieuNhap).FirstOrDefault();

                if (phieuNhap != null)
                {
                    phieuNhapBLL.Delete(phieuNhap);
                    LoadPhieuNhapData();
                }
            }
        }

        // Xóa chi tiết phiếu nhập
        private void btnDeleteChiTiet_Click(object sender, EventArgs e)
        {
            if (dgvChiTietPhieuNhap.SelectedRows.Count > 0)
            {
                var selectedChiTiet = dgvChiTietPhieuNhap.SelectedRows[0].Cells["id"].Value.ToString();
                var chiTiet = chiTietBLL.GetById(Convert.ToInt32(selectedChiTiet));

                if (chiTiet != null)
                {
                    chiTietBLL.Delete(chiTiet);
                    LoadChiTietPhieuNhapData();
                }
            }
        }

        // Tìm kiếm phiếu nhập theo thời gian
        private void btnSearch_Click(object sender, EventArgs e)
        {
            var startDate = dateTimePickerStartDate.Value;
            var endDate = dateTimePickerEndDate.Value;

            var filteredPhieuNhapList = phieuNhapBLL.SearchPhieuNhap(startDate, endDate);
            dgvPhieuNhap.DataSource = filteredPhieuNhapList;
        }
    }
}
