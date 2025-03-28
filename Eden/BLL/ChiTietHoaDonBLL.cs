using System;
using System.Collections.Generic;
using System.Linq;

namespace Eden
{
    public class CHITIETHOADONBLL : IDisposable
    {
        private CHITIETHOADONDAL dal = new CHITIETHOADONDAL();

        public CHITIETHOADONBLL()
        {
            dal = new CHITIETHOADONDAL();
        }

        public List<CHITIETHOADON> GetAll()
        {
            return dal.GetAll();
        }

        public void Add(CHITIETHOADON cthd)
        {
            dal.Add(cthd);
        }

        public void Update(CHITIETHOADON cthd)
        {
            dal.Update(cthd);
        }

        public void Delete(CHITIETHOADON cthd)
        {
            dal.Delete(cthd);
        }

        public void Dispose()
        {
            dal.Dispose();
        }
    }
}
