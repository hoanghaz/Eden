using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;

namespace Eden
{
    public class NHACUNGCAPDAL : IDisposable
    {
        private QLBanHoaEntities db = new QLBanHoaEntities();

        public List<NHACUNGCAP> GetAll() => db.NHACUNGCAPs.ToList();
        public void Add(NHACUNGCAP entity) { db.NHACUNGCAPs.Add(entity); db.SaveChanges(); }
        public void Update(NHACUNGCAP entity) { db.Entry(entity).State = System.Data.Entity.EntityState.Modified; db.SaveChanges(); }
        public void Delete(NHACUNGCAP entity) { db.NHACUNGCAPs.Remove(entity); db.SaveChanges(); }
        public void Dispose() { db.Dispose(); }
    }
}