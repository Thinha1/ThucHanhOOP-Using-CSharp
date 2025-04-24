using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai4
{
    internal class HoaDonKhachThanThiet : HoaDon
    {
        public HoaDonKhachThanThiet():base()
        {
            
        }
        public HoaDonKhachThanThiet(string ma, string ten, DateTime ngaylap, XangDau mh, int soluong) : base(ma, ten, ngaylap, mh, soluong)
        {

        }
        public override double tinhKhuyenMai()
        {
            if (SoLuong > 60)
                return 0.04 * MatHang.DonGia * SoLuong;
            else if(SoLuong <= 60 && tinhThanhTien() >= 800000)
                return 0.03 * tinhThanhTien();
            return 0;
        }
    }
}
