using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buoi01
{
    class NhanVien
    {
        private string maSo;
        private string hoTen;
        private int soNgayCong;
        private static double luongNgay = 200000;
        public string MaSo
        {
            get
            {
                return maSo;
            }
            set
            {
                if(!string.IsNullOrEmpty(value) && !string.IsNullOrWhiteSpace(value))
                    maSo = value;
                else maSo = "NVMoi";
            }
        }
        public string HoTen
        {
            get
            {
                return hoTen;
            }
            set
            {
                hoTen = value;
            }
        }
        public int SoNgayCong
        {
            get
            {
                return soNgayCong;
            }
            set
            {
                if(value >= 10)
                    soNgayCong = value;
                else 
                {
                    Console.WriteLine("Dữ liệu không hợp lệ!");
                    soNgayCong = 10;
                }
            }
        }
        public char XepLoai
        {
            get
            {
                if (SoNgayCong >= 26)
                {
                    return 'A';
                }
                else if (SoNgayCong >= 22)
                    return 'B';
                return 'C';
            }
        }
        public NhanVien()
        {
            MaSo = "3002";
            HoTen = "Van Hoa";
            SoNgayCong = 25;
        }
        public NhanVien(string maso, string hoten, int songaycong)
        {
            MaSo = maso;
            HoTen = hoten;
            SoNgayCong = songaycong;
        }

        public NhanVien(NhanVien nv1)
        {
            MaSo = nv1.MaSo;
            HoTen = nv1.HoTen;
            SoNgayCong = nv1.SoNgayCong;
        }
        public void nhapTT()
        {
            Console.Write("Nhập mã số: ");
            MaSo = Console.ReadLine();
            Console.Write("Nhập họ tên: ");
            HoTen = Console.ReadLine();
            Console.Write("Nhập số ngày công: ");
            SoNgayCong = int.Parse(Console.ReadLine());
        }
        public double tinhLuong()
        {
            return SoNgayCong * luongNgay;
        }

        public double tinhThuong()
        {
            if (XepLoai == 'A')
                return tinhLuong() * 0.05;
            else if (XepLoai == 'B')
                return tinhLuong() * 0.02;
            return 0;
        }
        public void xuatTT()
        {
            Console.WriteLine($"Mã số: {MaSo}\nHọ tên: {HoTen}\nSố ngày công: {SoNgayCong}\nLương ngày: {luongNgay}\nLương: {tinhLuong()}\nThưởng: {tinhThuong()}");
        }

    }
}
