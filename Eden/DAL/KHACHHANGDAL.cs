using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;

namespace Eden
{
    public class KHACHHANGDAL : IDisposable
    {
        private QLBanHoaEntities db = new QLBanHoaEntities();
        public List<KHACHHANG> GetAll() => db.KHACHHANGs.ToList();
        public void Add(KHACHHANG entity) { db.KHACHHANGs.Add(entity); db.SaveChanges(); }
        public void Update(KHACHHANG entity)
        {
            Console.WriteLine("Cập nhật khách hàng: " + entity.MaKhachHang);

            var existingKH = db.KHACHHANGs.FirstOrDefault(k => k.MaKhachHang == entity.MaKhachHang);
            if (existingKH != null)
            {
                existingKH.TenKhachHang = entity.TenKhachHang;
                existingKH.SoDienThoai = entity.SoDienThoai;
                existingKH.DiaChi = entity.DiaChi;
                existingKH.Email = entity.Email;

                Console.WriteLine("Dữ liệu cập nhật: " + existingKH.TenKhachHang);
                db.SaveChanges();
            }
            else
            {
                Console.WriteLine("Không tìm thấy khách hàng!");
                throw new Exception("Khách hàng không tồn tại.");
            }
        }
        public void Delete(KHACHHANG entity) {
            db.KHACHHANGs.Remove(entity);
            db.SaveChanges();
        }
        public void Dispose() { db.Dispose(); }
    }
}