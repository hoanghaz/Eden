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
        public void Update(KHACHHANG entity) { db.Entry(entity).State = System.Data.Entity.EntityState.Modified; db.SaveChanges(); }
        public void Delete(KHACHHANG entity) { db.KHACHHANGs.Remove(entity); db.SaveChanges(); }
        public void Dispose() { db.Dispose(); }
    }
}