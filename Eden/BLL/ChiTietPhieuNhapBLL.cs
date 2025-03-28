using System;
using System.Collections.Generic;
using System.Linq;
using Eden.Eden;

namespace Eden
{
    public class CHITIETPHIEUNHAPBLL : IDisposable
    {
        private CHITIETPHIEUNHAPDAL dal = new CHITIETPHIEUNHAPDAL();

        public CHITIETPHIEUNHAPBLL()
        {
            dal = new CHITIETPHIEUNHAPDAL();
        }

        public List<CHITIETPHIEUNHAP> GetAll()
        {
            return dal.GetAll();
        }

        public void Add(CHITIETPHIEUNHAP ctpn)
        {
            dal.Add(ctpn);
        }

        public void Update(CHITIETPHIEUNHAP ctpn)
        {
            dal.Update(ctpn);
        }

        public void Delete(CHITIETPHIEUNHAP ctpn)
        {
            dal.Delete(ctpn);
        }

        public void Dispose()
        {
            dal.Dispose();
        }
    }
}
