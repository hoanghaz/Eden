using System;
using System.Collections.Generic;
using System.Linq;

namespace Eden
{
    public class NHACUNGCAPBLL : IDisposable
    {
        private NHACUNGCAPDAL dal = new NHACUNGCAPDAL();

        public NHACUNGCAPBLL()
        {
            dal = new NHACUNGCAPDAL();
        }

        public List<NHACUNGCAP> GetAll()
        {
            return dal.GetAll();
        }

        public void Add(NHACUNGCAP ncc)
        {
            dal.Add(ncc);
        }

        public void Update(NHACUNGCAP ncc)
        {
            dal.Update(ncc);
        }

        public void Delete(NHACUNGCAP ncc)
        {
            dal.Delete(ncc);
        }

        public void Dispose()
        {
            dal.Dispose();
        }
    }
}
