﻿using System;
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
    public partial class NhaCungCapFormAdd : Form
    {
        private NHACUNGCAPBLL nhaCungCapBLL;
        public NhaCungCapFormAdd()
        {
            InitializeComponent();
            nhaCungCapBLL = new NHACUNGCAPBLL();
            GenerateSupplierID();
        }

        private void GenerateSupplierID()
        {
            var nhaCungCapList = nhaCungCapBLL.GetAll();
            if (nhaCungCapList.Count > 0)
            {
                var lastNhaCungCap = nhaCungCapList
                    .Where(n => n.MaNhaCungCap.StartsWith("NCC")) // Chỉ lấy mã hợp lệ
                    .OrderByDescending(n => n.MaNhaCungCap)
                    .FirstOrDefault();

                if (lastNhaCungCap != null)
                {
                    int lastNumber = int.Parse(lastNhaCungCap.MaNhaCungCap.Substring(3)); // Lấy số từ NCCxxx
                    guna2TextBox1.Text = $"NCC{(lastNumber + 1):D3}"; // NCC001, NCC002...
                }
                else
                {
                    guna2TextBox1.Text = "NCC001"; // Nếu không có mã hợp lệ
                }
            }
            else
            {
                guna2TextBox1.Text = "NCC001"; // Nếu chưa có nhà cung cấp nào
            }
            guna2TextBox1.ReadOnly = true; // Không cho phép chỉnh sửa mã
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            try
            {
                NHACUNGCAP ncc = new NHACUNGCAP
                {
                    MaNhaCungCap = guna2TextBox1.Text.Trim(),
                    TenNhaCungCap = guna2TextBox2.Text.Trim(),
                    DiaChi = guna2TextBox3.Text.Trim(),
                    SoDienThoai = guna2TextBox4.Text.Trim(),
                    Email = guna2TextBox5.Text.Trim()
                };

                nhaCungCapBLL.Add(ncc);
                MessageBox.Show("Thêm nhà cung cấp thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi thêm nhà cung cấp: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
