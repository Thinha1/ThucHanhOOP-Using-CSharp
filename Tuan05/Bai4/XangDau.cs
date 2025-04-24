using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai4
{
    internal class XangDau
    {
        string maHang;
        string tenHang;
        double donGia;

        public string MaHang { get => maHang; set => maHang = value; }
        public string TenHang { get => tenHang; set => tenHang = value; }
        public double DonGia { get => donGia; set => donGia = value; }

        public XangDau() { }
        public XangDau(string ma, string ten, double dgia)
        {
            MaHang = ma;
            TenHang = ten;
            DonGia = dgia;
        }

        public void xuat()
        {
            Console.WriteLine($"Mã hàng: {MaHang}\nTên hàng: {TenHang}\nĐơn giá: {DonGia}");
        }
    }
}
