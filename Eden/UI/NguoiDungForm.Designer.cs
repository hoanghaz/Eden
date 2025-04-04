using Guna.UI2.WinForms;

namespace Eden
{
    partial class NguoiDungForm
    {
        private Guna2DataGridView dgvUsers;
        private Guna2TextBox txtUserName;
        private Guna2TextBox txtLogin;
        private Guna2TextBox txtPassword;
        private Guna2ComboBox cbUserGroup;
        private Guna2TextBox txtSearch;
        private Guna2Button btnAdd;
        private Guna2Button btnEdit;
        private Guna2Button btnDelete;
        private Guna2Button btnSearch;
        private Guna2Button btnPrev;
        private Guna2Button btnNext;
        private Guna2HtmlLabel lblUserName;
        private Guna2HtmlLabel lblLogin;
        private Guna2HtmlLabel lblPassword;
        private Guna2HtmlLabel lblUserGroup;
        private Guna2HtmlLabel lblSearch;

        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvUsers = new Guna.UI2.WinForms.Guna2DataGridView();
            this.txtUserName = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtLogin = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtPassword = new Guna.UI2.WinForms.Guna2TextBox();
            this.cbUserGroup = new Guna.UI2.WinForms.Guna2ComboBox();
            this.txtSearch = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnAdd = new Guna.UI2.WinForms.Guna2Button();
            this.btnEdit = new Guna.UI2.WinForms.Guna2Button();
            this.btnDelete = new Guna.UI2.WinForms.Guna2Button();
            this.btnSearch = new Guna.UI2.WinForms.Guna2Button();
            this.btnPrev = new Guna.UI2.WinForms.Guna2Button();
            this.btnNext = new Guna.UI2.WinForms.Guna2Button();
            this.lblUserName = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblLogin = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblPassword = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblUserGroup = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblSearch = new Guna.UI2.WinForms.Guna2HtmlLabel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsers)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvUsers
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgvUsers.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvUsers.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvUsers.ColumnHeadersHeight = 29;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvUsers.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvUsers.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvUsers.Location = new System.Drawing.Point(186, 304);
            this.dgvUsers.Name = "dgvUsers";
            this.dgvUsers.RowHeadersVisible = false;
            this.dgvUsers.RowHeadersWidth = 51;
            this.dgvUsers.Size = new System.Drawing.Size(579, 211);
            this.dgvUsers.TabIndex = 0;
            this.dgvUsers.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvUsers.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvUsers.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvUsers.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvUsers.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvUsers.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvUsers.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvUsers.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgvUsers.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvUsers.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvUsers.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvUsers.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvUsers.ThemeStyle.HeaderStyle.Height = 29;
            this.dgvUsers.ThemeStyle.ReadOnly = false;
            this.dgvUsers.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvUsers.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvUsers.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvUsers.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvUsers.ThemeStyle.RowsStyle.Height = 22;
            this.dgvUsers.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvUsers.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // txtUserName
            // 
            this.txtUserName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtUserName.DefaultText = "";
            this.txtUserName.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtUserName.Location = new System.Drawing.Point(325, 100);
            this.txtUserName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.PlaceholderText = "";
            this.txtUserName.SelectedText = "";
            this.txtUserName.Size = new System.Drawing.Size(200, 22);
            this.txtUserName.TabIndex = 1;
            // 
            // txtLogin
            // 
            this.txtLogin.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtLogin.DefaultText = "";
            this.txtLogin.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtLogin.Location = new System.Drawing.Point(325, 130);
            this.txtLogin.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtLogin.Name = "txtLogin";
            this.txtLogin.PlaceholderText = "";
            this.txtLogin.SelectedText = "";
            this.txtLogin.Size = new System.Drawing.Size(200, 22);
            this.txtLogin.TabIndex = 2;
            // 
            // txtPassword
            // 
            this.txtPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPassword.DefaultText = "";
            this.txtPassword.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtPassword.Location = new System.Drawing.Point(325, 160);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PlaceholderText = "";
            this.txtPassword.SelectedText = "";
            this.txtPassword.Size = new System.Drawing.Size(200, 22);
            this.txtPassword.TabIndex = 3;
            // 
            // cbUserGroup
            // 
            this.cbUserGroup.BackColor = System.Drawing.Color.Transparent;
            this.cbUserGroup.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbUserGroup.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbUserGroup.FocusedColor = System.Drawing.Color.Empty;
            this.cbUserGroup.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbUserGroup.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbUserGroup.ItemHeight = 30;
            this.cbUserGroup.Location = new System.Drawing.Point(325, 190);
            this.cbUserGroup.Name = "cbUserGroup";
            this.cbUserGroup.Size = new System.Drawing.Size(200, 36);
            this.cbUserGroup.TabIndex = 4;
            // 
            // txtSearch
            // 
            this.txtSearch.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSearch.DefaultText = "";
            this.txtSearch.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtSearch.Location = new System.Drawing.Point(325, 272);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.PlaceholderText = "";
            this.txtSearch.SelectedText = "";
            this.txtSearch.Size = new System.Drawing.Size(218, 22);
            this.txtSearch.TabIndex = 5;
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Location = new System.Drawing.Point(633, 102);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(132, 26);
            this.btnAdd.TabIndex = 6;
            this.btnAdd.Text = "Thêm";
            this.btnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnEdit.ForeColor = System.Drawing.Color.White;
            this.btnEdit.Location = new System.Drawing.Point(633, 141);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(132, 26);
            this.btnEdit.TabIndex = 7;
            this.btnEdit.Text = "Sửa";
            this.btnEdit.Click += new System.EventHandler(this.BtnEdit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Location = new System.Drawing.Point(633, 175);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(132, 26);
            this.btnDelete.TabIndex = 8;
            this.btnDelete.Text = "Xóa";
            this.btnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.Location = new System.Drawing.Point(633, 272);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(132, 26);
            this.btnSearch.TabIndex = 9;
            this.btnSearch.Text = "Tìm";
            this.btnSearch.Click += new System.EventHandler(this.BtnSearch_Click);
            // 
            // btnPrev
            // 
            this.btnPrev.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnPrev.ForeColor = System.Drawing.Color.White;
            this.btnPrev.Location = new System.Drawing.Point(325, 549);
            this.btnPrev.Name = "btnPrev";
            this.btnPrev.Size = new System.Drawing.Size(98, 25);
            this.btnPrev.TabIndex = 10;
            this.btnPrev.Text = "◀ Trước";
            this.btnPrev.Click += new System.EventHandler(this.BtnPrev_Click);
            // 
            // btnNext
            // 
            this.btnNext.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnNext.ForeColor = System.Drawing.Color.White;
            this.btnNext.Location = new System.Drawing.Point(475, 549);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(98, 25);
            this.btnNext.TabIndex = 11;
            this.btnNext.Text = "Sau ▶";
            this.btnNext.Click += new System.EventHandler(this.BtnNext_Click);
            // 
            // lblUserName
            // 
            this.lblUserName.BackColor = System.Drawing.Color.Transparent;
            this.lblUserName.Location = new System.Drawing.Point(209, 100);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(99, 18);
            this.lblUserName.TabIndex = 12;
            this.lblUserName.Text = "Tên người dùng:";
            // 
            // lblLogin
            // 
            this.lblLogin.BackColor = System.Drawing.Color.Transparent;
            this.lblLogin.Location = new System.Drawing.Point(209, 134);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(97, 18);
            this.lblLogin.TabIndex = 13;
            this.lblLogin.Text = "Tên đăng nhập:";
            // 
            // lblPassword
            // 
            this.lblPassword.BackColor = System.Drawing.Color.Transparent;
            this.lblPassword.Location = new System.Drawing.Point(209, 164);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(60, 18);
            this.lblPassword.TabIndex = 14;
            this.lblPassword.Text = "Mật khẩu:";
            // 
            // lblUserGroup
            // 
            this.lblUserGroup.BackColor = System.Drawing.Color.Transparent;
            this.lblUserGroup.Location = new System.Drawing.Point(209, 190);
            this.lblUserGroup.Name = "lblUserGroup";
            this.lblUserGroup.Size = new System.Drawing.Size(42, 18);
            this.lblUserGroup.TabIndex = 15;
            this.lblUserGroup.Text = "Nhóm:";
            // 
            // lblSearch
            // 
            this.lblSearch.BackColor = System.Drawing.Color.Transparent;
            this.lblSearch.Location = new System.Drawing.Point(245, 272);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(61, 18);
            this.lblSearch.TabIndex = 16;
            this.lblSearch.Text = "Tìm kiếm:";
            this.lblSearch.Click += new System.EventHandler(this.lblSearch_Click);
            // 
            // NguoiDungForm
            // 
            this.ClientSize = new System.Drawing.Size(1026, 738);
            this.Controls.Add(this.dgvUsers);
            this.Controls.Add(this.txtUserName);
            this.Controls.Add(this.txtLogin);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.cbUserGroup);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnPrev);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.lblUserName);
            this.Controls.Add(this.lblLogin);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.lblUserGroup);
            this.Controls.Add(this.lblSearch);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "NguoiDungForm";
            this.Text = "Quản lý người dùng";
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
