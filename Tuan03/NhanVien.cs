using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2001230930_DangAnhThinh_Buoi02_Bai2
{
    internal class NhanVien:IComparable<NhanVien>
    {
        private string maNV;
        private string hoTen;
        private double heSoLuong;
        private int namVaoLam;
        public static double mucLuongToiThieu = 2340000;

        public string MaNV 
        {
            get 
            {
                return maNV; 
            }
            set 
            {
                maNV = value; 
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

        public double HeSoLuong
        {
            get
            {
                return heSoLuong;
            }
            set
            {
                if (value > 0)
                    heSoLuong = value;
            }
        }

        public int NamVaoLam
        {
            get
            {
                return namVaoLam;
            }
            set
            {
                if (value < DateTime.Now.Year)
                    namVaoLam = value;
                else namVaoLam = DateTime.Now.Year;

            }
        }

        public NhanVien()
        {
            
        }
        public NhanVien(string manv, string hoten, double hesoluong, int namvaolam)
        {
            MaNV = manv;
            HoTen = hoten;
            HeSoLuong = hesoluong;
            NamVaoLam = namVaoLam;
        }

        public NhanVien(NhanVien nv1)
        {
            MaNV = nv1.MaNV;
            HoTen = nv1.HoTen;
            HeSoLuong = nv1.HeSoLuong;
            NamVaoLam= nv1.NamVaoLam;
        }

        public double tinhLuongCoBan()
        {
            return HeSoLuong * mucLuongToiThieu;
        }

        public double tinhHeSoPCTN()
        {
            int year = DateTime.Now.Year;
            return (double)(year - NamVaoLam) / 100;
        }

        public double tinhLuong()
        {
            return tinhLuongCoBan() * (1 + tinhHeSoPCTN());
        }

        public void nhapTT()
        {
            Console.Write("Nhap ma nhan vien: ");
            MaNV = Console.ReadLine();
            Console.Write("Nhap ho ten: ");
            HoTen = Console.ReadLine();
            Console.Write("Nhap he so luong: ");
            HeSoLuong = double.Parse(Console.ReadLine());
            Console.Write("Nhap nam vao lam: ");
            NamVaoLam = int.Parse(Console.ReadLine());
        }

        public void xuatTT()
        {
            Console.WriteLine("---Thong tin nhan vien---");
            Console.WriteLine($"Ma nhan vien: {MaNV}\nHo ten: {HoTen}\nHe so luong: {HeSoLuong}" +
                $"\nNam vao lam: {NamVaoLam}\nMuc luong toi thieu: {mucLuongToiThieu}\nLuong co ban: {tinhLuongCoBan()}\nHe so phu cap tham nien: {tinhHeSoPCTN()}\nLuong: {tinhLuong()}");
        }

        public int CompareTo(NhanVien? other)
        {
            return this.NamVaoLam.CompareTo(other.NamVaoLam);
        }
    }
}
