using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai6
{
    class ChiTietDonHang
    {
        private string maSP;
        private string tenSP;
        private double giaBan;
        private int soLuongBan;
        private static double thueVAT = 0.1;
        public string MaSp
        {
            get
            {
                return maSP;
            }
            set
            {
                if (value.Length == 6 && value.StartsWith("SP"))
                    maSP = value;
            }
        }
        public string TenSP { get => tenSP; set => tenSP = value; }
        public double GiaBan { get => giaBan; set => giaBan = value; }
        public int SoLuongBan { get => soLuongBan; set => soLuongBan = value; }

        public ChiTietDonHang()
        {
            MaSp = "SP0010";
            TenSP = "May tinh Dell";
            GiaBan = 15000;
            SoLuongBan = 2;
        }
        public ChiTietDonHang(string masp, string tensp, double giaban, int soluong)
        {
            MaSp = masp;
            TenSP = tensp;
            GiaBan = giaban;
            SoLuongBan = soluong;
        }
        public ChiTietDonHang(ChiTietDonHang ctdh)
        {
            MaSp = ctdh.MaSp;
            TenSP = ctdh.TenSP;
            GiaBan = ctdh.GiaBan;
            SoLuongBan = ctdh.SoLuongBan;
        }
        
        public double tinhThanhTien()
        {
            return SoLuongBan * GiaBan * (1 + thueVAT);
        }

        public void nhapCTDH()
        {
            Console.Write("Nhập mã sản phẩm: ");
            MaSp = Console.ReadLine();
            Console.Write("Nhập tên sản phẩm: ");
            TenSP = Console.ReadLine();
            Console.Write("Nhập giá bán: ");
            GiaBan = double.Parse(Console.ReadLine());
            Console.Write("Nhập số lượng: ");
            SoLuongBan = int.Parse(Console.ReadLine());
        }

        public void xuatCTDH()
        {
            Console.WriteLine($"Mã sản phẩm: {MaSp}\nTên sản phẩm: {TenSP}\nGiá bán: {GiaBan}\nSố lượng: {SoLuongBan}\nThành tiền: {tinhThanhTien()}");
        }
    }
}
