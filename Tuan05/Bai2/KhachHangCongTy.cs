using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai2
{
    internal class KhachHangCongTy : HoaDon
    {
        int soLuongNV;

        public int SoLuongNV { get => soLuongNV; set => soLuongNV = value; }

        public KhachHangCongTy():base()
        {
            
        }

        public KhachHangCongTy(string ma, string ten, int sl, double gia, int slnv):base(ma, ten, sl, gia)
        {
            SoLuongNV = slnv;
        }
        public override double tinhChietKhau()
        {
            if (SoLuongNV > 1000)
                return 0.03 * GiaBan;
            else if (SoLuongNV > 5000)
                return 0.05 * GiaBan;
            else return 0;
        }
        public override void xuat()
        {
            base.xuat();
            Console.WriteLine($"Số lượng nhân viên: {SoLuongNV}");
        }
    }
}
