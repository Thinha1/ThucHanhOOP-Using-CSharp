using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai2
{
    internal class DaiLyCapMot : HoaDon
    {
        int thoiGianHopTac;

        public int ThoiGianHopTac { get => thoiGianHopTac; set => thoiGianHopTac = value; }


        public DaiLyCapMot():base()
        {
            ThoiGianHopTac = 1;
        }

        public DaiLyCapMot(string ma, string ten, int sl, double gia, int tg) : base(ma, ten, sl, gia)
        {
            ThoiGianHopTac = tg;
        }

        public override double tinhChietKhau()
        {
            double chietKhauThem = 0;
            if (ThoiGianHopTac > 3)
            {
                chietKhauThem = 0.01 * ThoiGianHopTac;
                if (chietKhauThem > 0.35)
                    chietKhauThem = 0.35;
                return (0.3 + chietKhauThem) * GiaBan;
            }
            else return 0.3 * GiaBan;
        }
        public override void xuat()
        {
            base.xuat();
            Console.WriteLine($"Thời gian hợp tác: {ThoiGianHopTac}");
        }
    }
}
