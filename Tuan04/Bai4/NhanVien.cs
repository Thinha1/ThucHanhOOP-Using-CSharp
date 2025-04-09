using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai4
{
    internal class NhanVien
    {
        string maNV;
        string tenNV;
        double heSoLuong;
        public static double luongCoBan = 2340000;

        public string MaNV { get => maNV; set 
            {
                if (value.StartsWith("NV"))
                    maNV = value;
                else maNV = "NV001";
            } 
        }
        public string TenNV { get => tenNV; set => tenNV = value; }
        public double HeSoLuong { get => heSoLuong; set => heSoLuong = value; }

        public NhanVien()
        {
            MaNV = "NV001";
            TenNV = "Thịnh";
            HeSoLuong = 2.34;
        }

        public NhanVien(string ma, string ten, double hso)
        {
            MaNV = ma;
            TenNV = ten;
            HeSoLuong = hso;
        }

        public virtual double tinhThuNhap()
        {
            return HeSoLuong * luongCoBan;
        }

        public virtual void nhap()
        {
            Console.Write("Nhập mã: ");
            MaNV = Console.ReadLine();
            Console.Write("Nhập tên: ");
            TenNV = Console.ReadLine();
            Console.Write("Nhập hệ số lương: ");
            HeSoLuong = double.Parse(Console.ReadLine());
        }

        public virtual void xuat()
        {
            Console.WriteLine($"Mã nhân viên: {MaNV}\nTên nhân viên: {TenNV}\nHệ số lương: {HeSoLuong}");
        }
    }
}
