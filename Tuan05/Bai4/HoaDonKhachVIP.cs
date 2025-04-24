using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai4
{
    internal class HoaDonKhachVIP : HoaDon
    {
        public HoaDonKhachVIP():base()
        {
            
        }

        public HoaDonKhachVIP(string ma, string ten, DateTime ngaylap, XangDau mh, int soluong) : base(ma, ten, ngaylap, mh, soluong)
        {

        }
        public override double tinhKhuyenMai()
        {
            if (SoLuong > 50)
                return 0.05 * MatHang.DonGia * SoLuong;
            else if (SoLuong <= 50 && tinhThanhTien() > 600000)
                return 0.04 * tinhThanhTien();
            else if (SoLuong > 10)
                return 0.01 * tinhThanhTien();
            else return 0;
        }
    }
}
