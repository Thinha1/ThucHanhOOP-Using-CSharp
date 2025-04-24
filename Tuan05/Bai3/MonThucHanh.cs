using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai3
{
    internal class MonThucHanh : MonHoc
    {
        double diemKT1;
        double diemKT2;
        double diemKT3;
        double diemKT4;
        public static double tienTinChi = 350000;
        public static double tienCSVC = 100000;

        public double DiemKT1 { get => diemKT1; set => diemKT1 = value; }
        public double DiemKT2 { get => diemKT2; set => diemKT2 = value; }
        public double DiemKT3 { get => diemKT3; set => diemKT3 = value; }
        public double DiemKT4 { get => diemKT4; set => diemKT4 = value; }

        public MonThucHanh():base()
        {
            
        }

        public MonThucHanh(string ma, string ten, int sotc, string khoa, double diem1, double diem2, double diem3, double diem4):base(ma, ten, sotc, khoa)
        {
            DiemKT1 = diem1;
            DiemKT2 = diem2;
            DiemKT3 = diem3;
            DiemKT4 = diem4;
        }

        public override double tinhHocPhi()
        {
            return tienTinChi * SoTC + tienCSVC;
        }

        public override double tinhTrungBinh()
        {
            return (DiemKT1 + DiemKT2 + DiemKT3 + DiemKT4) / 4;
        }
        public override void xuat()
        {
            base.xuat();
            Console.WriteLine($"Điểm kiểm tra 1: {DiemKT1}\nĐiểm kiểm tra 2: {DiemKT2}\nĐiểm kiểm tra 3: {DiemKT3}\nĐiểm kiểm tra 4: {DiemKT4}");
        }
    }
}
