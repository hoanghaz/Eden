using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;

namespace Eden
{
    public class NGUOIDUNGDAL : IDisposable
    {
        private QLBanHoaEntities db = new QLBanHoaEntities();

        public List<NGUOIDUNG> GetAll() => db.NGUOIDUNGs.ToList();
        public void Add(NGUOIDUNG entity) { db.NGUOIDUNGs.Add(entity); db.SaveChanges(); }
        public void Update(NGUOIDUNG entity) { db.Entry(entity).State = System.Data.Entity.EntityState.Modified; db.SaveChanges(); }
        public void Delete(NGUOIDUNG entity) { db.NGUOIDUNGs.Remove(entity); db.SaveChanges(); }
        public void Dispose() { db.Dispose(); }
    }
}