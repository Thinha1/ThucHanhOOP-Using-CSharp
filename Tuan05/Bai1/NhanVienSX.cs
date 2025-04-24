using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai1Tuan5
{
    internal class NhanVienSX:NhanVien, IHoTro
    {
        public static double heSoPhuCapNN = 0.1;
        private int soNgayNghi;

        public int SoNgayNghi { get => soNgayNghi; set => soNgayNghi = value; }

        public NhanVienSX():base()
        {
            
        }

        public NhanVienSX(string ma, string ten, int ns, string gt, double hs, int nvl, int songaynghi):base(ma, ten, ns, gt, hs, nvl)
        {
            SoNgayNghi = songaynghi;
        }

        public override double tinhLuong()
        {
            return HeSoLuong * luongCoBan * (1 + heSoPhuCapNN);
        }

        public override string xepLoaiThiDua()
        {
            if(SoNgayNghi <= 1)
                return "A";
            else if(SoNgayNghi <= 3)
                return "B";
            else if(SoNgayNghi <= 5)
                return "C";
            else return "D";
        }
        public override void xuat()
        {
            base.xuat();
            Console.WriteLine($"Số ngày nghỉ: {SoNgayNghi}");
        }

        public double tinhTienAn()
        {
            return 500000 - (20000 * SoNgayNghi);
        }
    }
}
