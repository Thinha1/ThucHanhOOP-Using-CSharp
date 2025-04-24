using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai3
{
    internal class MonLyThuyet : MonHoc
    {
        double diemTL;
        double diemGK;
        double diemCKi;
        public static double tienTinChi = 250000;

        public double DiemTL { get => diemTL; set => diemTL = value; }
        public double DiemGK { get => diemGK; set => diemGK = value; }
        public double DiemCKi { get => diemCKi; set => diemCKi = value; }
        public MonLyThuyet():base()
        {
            
        }

        public MonLyThuyet(string ma, string ten, int sotc, string khoa, double diemtl, double diemgky, double diemcuoiky):base(ma, ten, sotc, khoa)
        {
            DiemTL = diemtl;
            DiemGK = diemgky;
            DiemCKi = diemcuoiky;
        }

        public override double tinhHocPhi()
        {
            return tienTinChi * SoTC;
        }

        public override double tinhTrungBinh()
        {
            return 0.2 * DiemTL + DiemGK * 0.3 + DiemCKi * 0.5;
        }
        public override void xuat()
        {
            base.xuat();
            Console.WriteLine($"Điểm tiểu luận: {DiemTL}\nĐiểm giữa kỳ: {DiemGK}\nĐiểm cuối kỳ: {DiemCKi}");
        }
    }
}
