using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai1Tuan5
{
    internal class CBoQuanLy:NhanVien
    {
        private string chucVu;
        private double heSoChucVu;

        public string ChucVu { get => chucVu; set => chucVu = value; }
        public double HeSoChucVu { get => heSoChucVu; set => heSoChucVu = value; }

        public CBoQuanLy():base()
        {
            
        }

        public CBoQuanLy(string ma, string ten, int ns, string gt, double hs, int nvl, string cv, double hscv):base(ma, ten, ns, gt, hs, nvl)
        {
            ChucVu = cv;
            HeSoChucVu = hscv;
        }

        public override double tinhLuong()
        {
            return HeSoLuong * luongCoBan + tinhPhuCapChucVu();
        }

        public double tinhPhuCapChucVu()
        {
            return HeSoChucVu * 1350;
        }

        public override string xepLoaiThiDua()
        {
            return "A";
        }

        public override void xuat()
        {
            base.xuat();
            Console.WriteLine($"Chức vụ: {ChucVu}\nHệ số chức vụ: {HeSoChucVu}\nPhụ cấp chức vụ: {tinhPhuCapChucVu()}");
        }


    }
}
