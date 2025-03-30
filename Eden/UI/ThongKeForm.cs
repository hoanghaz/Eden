using System;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Eden
{
    public partial class ThongKeForm : Form
    {
        private QLBanHoaEntities db = new QLBanHoaEntities(); // DbContext của Entity Framework

        public ThongKeForm()
        {
            InitializeComponent();
            LoadThongKe();
        }

        private void LoadThongKe()
        {
            // Mặc định hiển thị tổng doanh thu hôm nay
            DateTime today = DateTime.Today;
            ThongKeDoanhThu(today, today);
            cmbLoaiThongKe.Items.Add("Doanh thu");
            cmbLoaiThongKe.Items.Add("Sản phẩm bán chạy");
            cmbLoaiThongKe.SelectedIndex = 0; // Mặc định là "Doanh thu"
        }

        private void btnThongKe_Click(object sender, EventArgs e)
        {
            DateTime fromDate = dtpFrom.Value;
            DateTime toDate = dtpTo.Value;

            if (cmbLoaiThongKe.SelectedIndex == 0) // Doanh thu
                ThongKeDoanhThu(fromDate, toDate);
            else if (cmbLoaiThongKe.SelectedIndex == 1) // Sản phẩm bán chạy
                ThongKeSanPhamBanChay(fromDate, toDate);
        }

        private void ThongKeDoanhThu(DateTime from, DateTime to)
        {
            var doanhThu = db.HOADONs.Where(hd => DbFunctions.TruncateTime(hd.NgayLap) >= from.Date &&
                 DbFunctions.TruncateTime(hd.NgayLap) <= to.Date).ToList();

            dgvThongKe.DataSource = doanhThu; // Hiển thị lên DataGridView

            // Hiển thị biểu đồ
            chartThongKe.Series.Clear();
            var series = new Series("Doanh Thu");
            series.ChartType = SeriesChartType.Column;
            chartThongKe.Series.Add(series);

            foreach (var item in doanhThu)
            {
                series.Points.AddXY(item.NgayLap.ToShortDateString(), item.TongTien);
            }
        }

        private void ThongKeSanPhamBanChay(DateTime from, DateTime to)
        {
            var sanPhamBanChay = db.CHITIETHOADONs
                .Where(ct => ct.HOADON.NgayLap >= from && ct.HOADON.NgayLap <= to)
                .GroupBy(ct => ct.SANPHAM.TenSanPham)
                .Select(g => new { SanPham = g.Key, SoLuong = g.Sum(ct => ct.SoLuong) })
                .OrderByDescending(sp => sp.SoLuong)
                .ToList();

            dgvThongKe.DataSource = sanPhamBanChay; // Hiển thị lên DataGridView

            // Hiển thị biểu đồ
            chartThongKe.Series.Clear();
            var series = new Series("Sản phẩm bán chạy");
            series.ChartType = SeriesChartType.Pie;
            chartThongKe.Series.Add(series);

            foreach (var item in sanPhamBanChay)
            {
                series.Points.AddXY(item.SanPham, item.SoLuong);
            }
        }
    }
}