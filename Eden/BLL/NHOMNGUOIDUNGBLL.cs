using System;
using System.Collections.Generic;
using System.Linq;

namespace Eden
{
    public class NHOMNGUOIDUNGBLL : IDisposable
    {
        private NHOMNGUOIDUNGDAL dal = new NHOMNGUOIDUNGDAL();

        public NHOMNGUOIDUNGBLL()
        {
            dal = new NHOMNGUOIDUNGDAL();
        }

        public List<NHOMNGUOIDUNG> GetAll()
        {
            return dal.GetAll();
        }

        public void Add(NHOMNGUOIDUNG nnd)
        {
            dal.Add(nnd);
        }

        public void Update(NHOMNGUOIDUNG nnd)
        {
            dal.Update(nnd);
        }

        public void Delete(NHOMNGUOIDUNG nnd)
        {
            dal.Delete(nnd);
        }

        public void Dispose()
        {
            dal.Dispose();
        }
    }
}
