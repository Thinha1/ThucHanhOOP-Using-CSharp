using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2001230930_DangAnhThinh_THLTHDTBuoi04
{
    internal class NhanVien
    {
        protected string maNV;
        protected string tenNV;
        protected int namVaoLam;
        protected double heSoLuong;
        protected int soNgayNghi;
        public static double luongCB = 2340000;
        public string MaNV { get => maNV; set => maNV = value; }
        public string TenNV { get => tenNV; set => tenNV = value; }
        public int NamVaoLam
        {
            get => namVaoLam; 
            set
            {
                if (value < DateTime.Now.Year)
                    namVaoLam = value;
                else namVaoLam = DateTime.Now.Year;
            }
        }

        public double HeSoLuong { get => heSoLuong; set => heSoLuong = value; }
        public int SoNgayNghi { get => soNgayNghi;
            set 
            {
                if(value >= 0)
                soNgayNghi = value;
                else soNgayNghi = 0;
            } 
        }
        public NhanVien()
        {
            
        }

        public NhanVien(string ma, string ten, double hsl)
        {
            MaNV = ma;
            TenNV = ten;
            NamVaoLam = DateTime.Now.Year;
            HeSoLuong = hsl;
            SoNgayNghi = 0;
        }

        public NhanVien(string ma, string ten, int nvl, double hsl, int songaynghi)
        {
            MaNV = ma;
            TenNV = ten;
            NamVaoLam = nvl;
            HeSoLuong = hsl;
            SoNgayNghi = songaynghi;
        }
        public double tinhPhuCapThamNien()
        {
            int sonam = DateTime.Now.Year - NamVaoLam;
            if (sonam > 5)
                return sonam * luongCB / 100;
            return 0;
        }
        public virtual string xepLoaiThiDua()
        {
            if (SoNgayNghi <= 1) return "A";
            else if (SoNgayNghi <= 3) return "B";
            return "C";
        }
        public double tinhHeSoThiDua()
        {
            if (xepLoaiThiDua() == "A")
                return 1.0;
            else if(xepLoaiThiDua()== "B")
                return 0.8;
            return 0.5;
        }
        public virtual double tinhLuong()
        {
            return luongCB * HeSoLuong * tinhHeSoThiDua() + tinhPhuCapThamNien();
        }
        public void nhapTT()
        {
            Console.Write("Nhập mã nhân viên: ");
            MaNV = Console.ReadLine();
            Console.Write("Nhập tên nhân viên: ");
            TenNV = Console.ReadLine();
            Console.Write("Nhập năm vào làm: ");
            NamVaoLam = int.Parse(Console.ReadLine());
            Console.Write("Nhập hệ số lương: ");
            HeSoLuong = double.Parse(Console.ReadLine());
            Console.Write("Nhập số ngày nghỉ: ");
            SoNgayNghi = int.Parse(Console.ReadLine());
        }
        public virtual void xuatTT()
        {
            Console.WriteLine($"Mã nhân viên: {MaNV}\nTên nhân viên: {TenNV}\nNăm vào làm: {NamVaoLam}\nHệ số lương: {HeSoLuong}\nSố ngày nghỉ: {SoNgayNghi}\nXếp loại thi đua: {xepLoaiThiDua()}\nHệ số thi đua: {tinhHeSoThiDua()}\nHệ số phụ cấp thâm niên: {tinhPhuCapThamNien()}\nLương: {tinhLuong()}");
        }
    }
}
