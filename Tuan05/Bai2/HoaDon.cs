using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai2
{
    internal abstract class HoaDon
    {
        string maKH;
        string tenKH;
        int soLuong;
        double giaBan;
        public static double thueVAT = 0.1;

        public string MaKH { get => maKH; set => maKH = value; }
        public string TenKH { get => tenKH; set => tenKH = value; }
        public int SoLuong { get => soLuong; set => soLuong = value; }
        public double GiaBan { get => giaBan; set => giaBan = value; }

        protected HoaDon()
        {
            
        }

        protected HoaDon(string ma, string ten, int sl, double gia)
        {
            MaKH = ma;
            TenKH = ten;
            SoLuong = sl;
            GiaBan = gia;
        }
        public abstract double tinhChietKhau();
        public double tinhThanhTien()
        {
            return SoLuong * GiaBan - (tinhChietKhau()*SoLuong) + thueVAT * (SoLuong * GiaBan);
        }
        public virtual void xuat()
        {
            Console.WriteLine($"Mã khách hàng: {MaKH}\nHọ tên khách hàng: {TenKH}\nSố lượng: {SoLuong}\nGiá bán: {GiaBan}\nChiết khấu: {tinhChietKhau()}\nThành tiền: {tinhThanhTien()}");
        }
    }
}
