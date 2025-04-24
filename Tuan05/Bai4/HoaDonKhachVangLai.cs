using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai4
{
    internal class HoaDonKhachVangLai:HoaDon
    {
        public HoaDonKhachVangLai()
        {
            
        }

        public HoaDonKhachVangLai(string ma, string ten, DateTime ngaylap, XangDau mh, int soluong) :base(ma, ten, ngaylap, mh, soluong)
        {
            
        }
        public override double tinhKhuyenMai()
        {
            if(tinhThanhTien() > 1000000)
                return 0.03 * tinhThanhTien();
            return 0;
        }

    }
}
