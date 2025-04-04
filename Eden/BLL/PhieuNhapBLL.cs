using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
namespace Eden
{
    public class PHIEUNHAPBLL : IDisposable
    {
        private PHIEUNHAPDAL dal = new PHIEUNHAPDAL();
        public PHIEUNHAPBLL()
        {
            dal = new PHIEUNHAPDAL();
        }
        public List<PHIEUNHAP> GetAll()
        {
            return dal.GetAll();
        }
        public void Add(PHIEUNHAP p)
        {
            dal.Add(p);
        }
        public void Update(PHIEUNHAP p)
        {
            dal.Update(p);
        }
        public void Delete(PHIEUNHAP p)
        {
            dal.Delete(p);
        }

        public void Dispose()
        {
            dal.Dispose();
        }
    }
}