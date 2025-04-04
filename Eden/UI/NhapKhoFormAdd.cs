using System;
using System.Windows.Forms;

namespace Eden
{
    public partial class NhapKhoFormAdd : Form
    {
        private PHIEUNHAPBLL phieuNhapBLL;
        private string maPhieuNhap; // Mã phiếu nhập khi sửa
        private PHIEUNHAP currentPhieuNhap; // Phiếu nhập hiện tại khi sửa

        public NhapKhoFormAdd()
        {
            InitializeComponent();
            phieuNhapBLL = new PHIEUNHAPBLL();
            this.Text = "Thêm Phiếu Nhập";
        }

        // Constructor cho Sửa phiếu nhập
        public NhapKhoFormAdd(string maPhieuNhap) : this()
        {
            this.maPhieuNhap = maPhieuNhap;
            this.Text = "Sửa Phiếu Nhập";
            LoadDataForEdit();
        }

        // Hàm Load dữ liệu cho việc Sửa phiếu nhập
        private void LoadDataForEdit()
        {
            try
            {
                currentPhieuNhap = phieuNhapBLL.GetByMaPhieuNhap(maPhieuNhap);
                if (currentPhieuNhap != null)
                {
                    txtMaPhieuNhap.Text = currentPhieuNhap.MaPhieuNhap;
                    dtpNgayNhap.Value = currentPhieuNhap.NgayNhap;
                    cmbNhaCungCap.SelectedItem = currentPhieuNhap.NHACUNGCAP;
                    cmbNguoiDung.SelectedItem = currentPhieuNhap.NGUOIDUNG;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải dữ liệu: " + ex.Message);
            }
        }

        // Sự kiện Lưu (Thêm hoặc Sửa)
        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                PHIEUNHAP phieuNhap = new PHIEUNHAP
                {
                    MaPhieuNhap = txtMaPhieuNhap.Text,
                    NgayNhap = dtpNgayNhap.Value,
                    MaNhaCungCap = ((NHACUNGCAP)cmbNhaCungCap.SelectedItem).MaNhaCungCap,
                    MaNguoiDung = ((NGUOIDUNG)cmbNguoiDung.SelectedItem).MaNguoiDung
                };

                if (string.IsNullOrEmpty(maPhieuNhap))
                {
                    // Thêm mới
                    phieuNhapBLL.Add(phieuNhap);
                    MessageBox.Show("Thêm phiếu nhập thành công.");
                }
                else
                {
                    // Sửa
                    phieuNhapBLL.Update(phieuNhap);
                    MessageBox.Show("Cập nhật phiếu nhập thành công.");
                }

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi lưu dữ liệu: " + ex.Message);
            }
        }

        // Sự kiện Hủy
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // Hàm khởi tạo giao diện cho form này
        private void InitializeComponent()
        {
            this.txtMaPhieuNhap = new System.Windows.Forms.TextBox();
            this.dtpNgayNhap = new System.Windows.Forms.DateTimePicker();
            this.cmbNhaCungCap = new System.Windows.Forms.ComboBox();
            this.cmbNguoiDung = new System.Windows.Forms.ComboBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.lblMaPhieuNhap = new System.Windows.Forms.Label();
            this.lblNgayNhap = new System.Windows.Forms.Label();
            this.lblNhaCungCap = new System.Windows.Forms.Label();
            this.lblNguoiDung = new System.Windows.Forms.Label();

            // 
            // txtMaPhieuNhap
            // 
            this.txtMaPhieuNhap.Location = new System.Drawing.Point(120, 20);
            this.txtMaPhieuNhap.Name = "txtMaPhieuNhap";
            this.txtMaPhieuNhap.Size = new System.Drawing.Size(200, 20);
            this.txtMaPhieuNhap.TabIndex = 0;

            // 
            // dtpNgayNhap
            // 
            this.dtpNgayNhap.Location = new System.Drawing.Point(120, 60);
            this.dtpNgayNhap.Name = "dtpNgayNhap";
            this.dtpNgayNhap.Size = new System.Drawing.Size(200, 20);
            this.dtpNgayNhap.TabIndex = 1;

            // 
            // cmbNhaCungCap
            // 
            this.cmbNhaCungCap.FormattingEnabled = true;
            this.cmbNhaCungCap.Location = new System.Drawing.Point(120, 100);
            this.cmbNhaCungCap.Name = "cmbNhaCungCap";
            this.cmbNhaCungCap.Size = new System.Drawing.Size(200, 21);
            this.cmbNhaCungCap.TabIndex = 2;

            // 
            // cmbNguoiDung
            // 
            this.cmbNguoiDung.FormattingEnabled = true;
            this.cmbNguoiDung.Location = new System.Drawing.Point(120, 140);
            this.cmbNguoiDung.Name = "cmbNguoiDung";
            this.cmbNguoiDung.Size = new System.Drawing.Size(200, 21);
            this.cmbNguoiDung.TabIndex = 3;

            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(120, 180);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 4;
            this.btnSave.Text = "Lưu";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);

            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(200, 180);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "Hủy";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);

            // 
            // lblMaPhieuNhap
            // 
            this.lblMaPhieuNhap.AutoSize = true;
            this.lblMaPhieuNhap.Location = new System.Drawing.Point(20, 23);
            this.lblMaPhieuNhap.Name = "lblMaPhieuNhap";
            this.lblMaPhieuNhap.Size = new System.Drawing.Size(88, 13);
            this.lblMaPhieuNhap.TabIndex = 6;
            this.lblMaPhieuNhap.Text = "Mã Phiếu Nhập";

            // 
            // lblNgayNhap
            // 
            this.lblNgayNhap.AutoSize = true;
            this.lblNgayNhap.Location = new System.Drawing.Point(20, 63);
            this.lblNgayNhap.Name = "lblNgayNhap";
            this.lblNgayNhap.Size = new System.Drawing.Size(62, 13);
            this.lblNgayNhap.TabIndex = 7;
            this.lblNgayNhap.Text = "Ngày Nhập";

            // 
            // lblNhaCungCap
            // 
            this.lblNhaCungCap.AutoSize = true;
            this.lblNhaCungCap.Location = new System.Drawing.Point(20, 103);
            this.lblNhaCungCap.Name = "lblNhaCungCap";
            this.lblNhaCungCap.Size = new System.Drawing.Size(74, 13);
            this.lblNhaCungCap.TabIndex = 8;
            this.lblNhaCungCap.Text = "Nhà Cung Cấp";

            // 
            // lblNguoiDung
            // 
            this.lblNguoiDung.AutoSize = true;
            this.lblNguoiDung.Location = new System.Drawing.Point(20, 143);
            this.lblNguoiDung.Name = "lblNguoiDung";
            this.lblNguoiDung.Size = new System.Drawing.Size(60, 13);
            this.lblNguoiDung.TabIndex = 9;
            this.lblNguoiDung.Text = "Người Dùng";

            // 
            // NhapKhoFormAdd
            // 
            this.ClientSize = new System.Drawing.Size(340, 220);
            this.Controls.Add(this.lblNguoiDung);
            this.Controls.Add(this.lblNhaCungCap);
            this.Controls.Add(this.lblNgayNhap);
            this.Controls.Add(this.lblMaPhieuNhap);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.cmbNguoiDung);
            this.Controls.Add(this.cmbNhaCungCap);
            this.Controls.Add(this.dtpNgayNhap);
            this.Controls.Add(this.txtMaPhieuNhap);
            this.Name = "NhapKhoFormAdd";
            this.Text = "Thêm Phiếu Nhập";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private TextBox txtMaPhieuNhap;
        private DateTimePicker dtpNgayNhap;
        private ComboBox cmbNhaCungCap;
        private ComboBox cmbNguoiDung;
        private Button btnSave;
        private Button btnCancel;
        private Label lblMaPhieuNhap;
        private Label lblNgayNhap;
        private Label lblNhaCungCap;
        private Label lblNguoiDung;
    }
}
