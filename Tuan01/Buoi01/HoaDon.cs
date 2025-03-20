using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buoi01
{
    class HoaDon
    {
        private string hangSX;
        private string soSeries;
        private string tenSanPham;
        private double giaBan;
        private string loaiSanPham;
        private static double thueVAT = 0.1;

        public string HangSX
        {
            get
            {
                return hangSX;
            }
            set
            {
                hangSX = value;
            }
        }

        public string SoSeries
        {
            get
            {
                return soSeries;
            }
            set
            {
                if (!value.StartsWith('S') && !(value.Substring(1, value.Length - 1).All(char.IsDigit)))
                {
                    soSeries = "S000";
                }
                else soSeries = value;
            }
        }

        public string TenSanPham
        {
            get
            {
                return tenSanPham;
            }
            set
            {
                tenSanPham = value;
            }
        }
        public double GiaBan
        {
            get
            {
                return giaBan;
            }
            set
            {
                if (value > 4000000)
                    giaBan = value;
                else
                {
                    Console.WriteLine("Thông tin không hợp lệ phải lớn hơn 4 triệu!");
                    giaBan = 4000000;
                }
            }
        }

        public string LoaiSanPham
        {
            get
            {
                return loaiSanPham;
            }
            set
            {
                if (value == "May tinh de ban" || value == "May tinh xach tay" || value == "Dien thoai di dong")
                    loaiSanPham = value;
                else loaiSanPham = "Dien thoai di dong";
            }
        }

        public HoaDon()
        {
            HangSX = "Apple";
            TenSanPham = "Iphone 13";
            SoSeries = "S0001";
            GiaBan = 15000000;
            LoaiSanPham = "Dien thoai di dong";
        }

        public HoaDon(string hangsx, string tensp, string soseries, double giaban, string loaisp)
        {
            HangSX = hangsx;
            TenSanPham = tensp;
            SoSeries = soseries;
            GiaBan = giaban;
            LoaiSanPham = loaisp;
        }

        public HoaDon(HoaDon hd1)
        {
            HangSX = hd1.HangSX;
            TenSanPham = hd1.TenSanPham;
            SoSeries = hd1.SoSeries;
            GiaBan = hd1.GiaBan;
            LoaiSanPham = hd1.LoaiSanPham;
        }
        public double tinhPhiBaoHanh()
        {
            if (LoaiSanPham == "May tinh de ban")
                return 0.08 * GiaBan;
            else if (LoaiSanPham == "May tinh xach tay")
                return 0.05 * GiaBan;
            else
            {
                if (0.1 * GiaBan > 2000000)
                    return 2000000;
                else return 0.1 * GiaBan;
            }
        }
        public double tinhThue()
        {
            return GiaBan * thueVAT;
        }
        public double tinhUuDai()
        {
            if (HangSX == "Samsung" && LoaiSanPham == "Dien thoai di dong")
                return 500000;
            else return 0;
        }
        public double tinhThanhTien()
        {
            return GiaBan + tinhPhiBaoHanh() - tinhUuDai() + tinhThue();
        }

        public void nhapTT()
        {
            Console.Write("Nhập hãng sản xuất: ");
            HangSX = Console.ReadLine();
            Console.Write("Nhập số series: ");
            SoSeries = Console.ReadLine();
            Console.Write("Nhập tên sản phẩm: ");
            TenSanPham = Console.ReadLine();
            Console.Write("Nhập giá bán: ");
            GiaBan = double.Parse(Console.ReadLine());
            Console.Write("Nhập loại sản phẩm: ");
            LoaiSanPham = Console.ReadLine();
        }

        public void xuatTT()
        {
            Console.WriteLine($"Hãng sản xuất: {HangSX}\nSố series: {SoSeries}" +
                $"\nTên sản phẩm: {TenSanPham}\nGiá bán: {GiaBan}\nLoại sản phẩm: {LoaiSanPham}\nThành tiền: {tinhThanhTien()}");
        }

    }
}
