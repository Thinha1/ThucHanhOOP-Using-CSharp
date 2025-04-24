using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai2
{
    internal class KhachHangCaNhan : HoaDon
    {
        double khoangCachGH;

        public double KhoangCachGH { get => khoangCachGH; set => khoangCachGH = value; }

        public KhachHangCaNhan():base(){}

        public KhachHangCaNhan(string ma, string ten, int sl, double gia, double kcgh):base(ma, ten, sl, gia)
        {
            KhoangCachGH = kcgh;
        }

        public override double tinhChietKhau()
        {
            if (SoLuong < 5)
                return 0;
            else
            {
                if (KhoangCachGH < 10)
                    return (0.03 * GiaBan) - 20000;
                else return 0.03 * GiaBan;
            }
        }
        public override void xuat()
        {
            base.xuat();
            Console.WriteLine($"Khoảng cách giao hàng (km): {KhoangCachGH}");
        }
    }
}
