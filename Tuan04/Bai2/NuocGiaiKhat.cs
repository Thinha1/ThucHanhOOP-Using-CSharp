using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai2
{
    internal class NuocGiaiKhat:HangHoa
    {
        string donViTinh;
        int sl;
        double donGia;
        public static double chietKhau = 0.05;

        public string DonViTinh { get => donViTinh; set 
            {
                if(value == "Két" || value == "Thùng" || value == "Chai" || value == "Lon")
                    donViTinh = value;
                else donViTinh = "Két";
            } 
        }

        public int Sl { get => sl; set => sl = value; }
        public double DonGia { get => donGia; set => donGia = value; }
        
        public double tinhThanhTien()
        {
            if (DonViTinh == "Két" || DonViTinh == "Thùng")
                return Sl * DonGia;
            else if (DonViTinh == "Chai")
                return sl * DonGia / 20;
            else return sl * DonGia / 24;
        }
        public double tinhTongTien()
        {
            return tinhThanhTien() * (1 + chietKhau);
        }
        public override void nhap()
        {
            base.nhap();
            Console.Write("Nhập đơn vị tính: ");
            DonViTinh = Console.ReadLine();
            Console.Write("Nhập số lượng: ");
            Sl = int.Parse(Console.ReadLine());
            Console.Write("Nhập đơn giá: ");
            DonGia = int.Parse(Console.ReadLine());
        }
        public override void xuat()
        {
            base.xuat();
            Console.WriteLine($"Đơn vị tính: {DonViTinh}\nSố lượng: {Sl}\nĐơn giá: {DonGia}\nThành tiền: {tinhThanhTien()}\nTổng tiền: {tinhTongTien()}");
        }
    }
}
