using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;

namespace Eden
{
    public class LOAISANPHAMDAL : IDisposable
    {
        private QLBanHoaEntities db = new QLBanHoaEntities();

        public List<LOAISANPHAM> GetAll() => db.LOAISANPHAMs.ToList();
        public void Add(LOAISANPHAM entity) { db.LOAISANPHAMs.Add(entity); db.SaveChanges(); }
        public void Update(LOAISANPHAM entity) { db.Entry(entity).State = System.Data.Entity.EntityState.Modified; db.SaveChanges(); }
        public void Delete(LOAISANPHAM entity) { db.LOAISANPHAMs.Remove(entity); db.SaveChanges(); }
        public void Dispose() { db.Dispose(); }
    }
}