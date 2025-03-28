using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eden
{
    public class NHOMNGUOIDUNGDAL : IDisposable
    {
        private QLBanHoaEntities db = new QLBanHoaEntities();

        public List<NHOMNGUOIDUNG> GetAll() => db.NHOMNGUOIDUNGs.ToList();
        public void Add(NHOMNGUOIDUNG entity) { db.NHOMNGUOIDUNGs.Add(entity); db.SaveChanges(); }
        public void Update(NHOMNGUOIDUNG entity) { db.Entry(entity).State = System.Data.Entity.EntityState.Modified; db.SaveChanges(); }
        public void Delete(NHOMNGUOIDUNG entity) { db.NHOMNGUOIDUNGs.Remove(entity); db.SaveChanges(); }
        public void Dispose() { db.Dispose(); }
    }
}
