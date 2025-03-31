namespace Eden
{
    partial class KhachHangForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.addkhachhang = new Guna.UI2.WinForms.Guna2Button();
            this.suakhachhang = new Guna.UI2.WinForms.Guna2Button();
            this.xoakhachhang = new Guna.UI2.WinForms.Guna2Button();
            this.dgkhachhang = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgkhachhang)).BeginInit();
            this.SuspendLayout();
            // 
            // addkhachhang
            // 
            this.addkhachhang.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.addkhachhang.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.addkhachhang.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.addkhachhang.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.addkhachhang.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.addkhachhang.ForeColor = System.Drawing.Color.White;
            this.addkhachhang.Location = new System.Drawing.Point(107, 541);
            this.addkhachhang.Name = "addkhachhang";
            this.addkhachhang.Size = new System.Drawing.Size(180, 45);
            this.addkhachhang.TabIndex = 1;
            this.addkhachhang.Text = "Thêm Khách Hàng";
            this.addkhachhang.Click += new System.EventHandler(this.addkhachhang_Click);
            // 
            // suakhachhang
            // 
            this.suakhachhang.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.suakhachhang.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.suakhachhang.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.suakhachhang.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.suakhachhang.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.suakhachhang.ForeColor = System.Drawing.Color.White;
            this.suakhachhang.Location = new System.Drawing.Point(440, 541);
            this.suakhachhang.Name = "suakhachhang";
            this.suakhachhang.Size = new System.Drawing.Size(180, 45);
            this.suakhachhang.TabIndex = 2;
            this.suakhachhang.Text = "Sửa thông tin KH";
            this.suakhachhang.Click += new System.EventHandler(this.suakhachhang_Click);
            // 
            // xoakhachhang
            // 
            this.xoakhachhang.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.xoakhachhang.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.xoakhachhang.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.xoakhachhang.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.xoakhachhang.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.xoakhachhang.ForeColor = System.Drawing.Color.White;
            this.xoakhachhang.Location = new System.Drawing.Point(755, 541);
            this.xoakhachhang.Name = "xoakhachhang";
            this.xoakhachhang.Size = new System.Drawing.Size(180, 45);
            this.xoakhachhang.TabIndex = 3;
            this.xoakhachhang.Text = "Xóa Khách Hàng";
            this.xoakhachhang.Click += new System.EventHandler(this.xoakhachhang_Click);
            // 
            // dgkhachhang
            // 
            this.dgkhachhang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgkhachhang.Location = new System.Drawing.Point(0, 0);
            this.dgkhachhang.Name = "dgkhachhang";
            this.dgkhachhang.RowHeadersWidth = 51;
            this.dgkhachhang.RowTemplate.Height = 24;
            this.dgkhachhang.Size = new System.Drawing.Size(1284, 449);
            this.dgkhachhang.TabIndex = 4;
            // 
            // KhachHangForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1283, 702);
            this.Controls.Add(this.dgkhachhang);
            this.Controls.Add(this.xoakhachhang);
            this.Controls.Add(this.suakhachhang);
            this.Controls.Add(this.addkhachhang);
            this.Name = "KhachHangForm";
            this.Text = "KhachHangForm";
            ((System.ComponentModel.ISupportInitialize)(this.dgkhachhang)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2Button addkhachhang;
        private Guna.UI2.WinForms.Guna2Button suakhachhang;
        private Guna.UI2.WinForms.Guna2Button xoakhachhang;
        private System.Windows.Forms.DataGridView dgkhachhang;
    }
}