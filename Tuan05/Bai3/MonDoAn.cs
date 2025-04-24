using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai3
{
    internal class MonDoAn : MonHoc
    {
        double diemGVHD;
        double diemGVPB;

        public double DiemGVHD { get => diemGVHD; set => diemGVHD = value; }
        public double DiemGVPB { get => diemGVPB; set => diemGVPB = value; }


        public MonDoAn():base()
        {
            
        }

        public MonDoAn(string ma, string ten, int sotc, string khoa, double diemgvhd, double diemgvpb):base(ma, ten, sotc, khoa)
        {
            DiemGVHD = diemgvhd;
            DiemGVPB = diemgvpb;
        }
        public override double tinhHocPhi()
        {
            return 2000000;
        }

        public override double tinhTrungBinh()
        {
            return (DiemGVHD * 2 + DiemGVPB) / 3;
        }

        public override void xuat()
        {
            base.xuat();
            Console.WriteLine($"Điềm giáo viên hướng dẫn: {DiemGVHD}\nĐiểm giáo viên phản biện: {DiemGVPB}");
        }
    }
}
