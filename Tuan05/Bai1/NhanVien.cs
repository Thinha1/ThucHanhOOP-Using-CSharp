using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai1Tuan5
{
    public abstract class NhanVien
    {
        protected string maNV;
        protected string hoTen;
        protected int namSinh;
        protected string gioiTinh;
        protected double heSoLuong;
        protected int namVaoLam;
        public static double luongCoBan = 2340000;

        public string MaNV { get => maNV; set => maNV = value; }
        public string HoTen { get => hoTen; set => hoTen = value; }
        public int NamSinh { get => namSinh; set => namSinh = value; }
        public string GioiTinh { get => gioiTinh; set => gioiTinh = value; }
        public double HeSoLuong { get => heSoLuong; set => heSoLuong = value; }
        public int NamVaoLam { get => namVaoLam; set => namVaoLam = value; }

        public abstract string xepLoaiThiDua();
        public abstract double tinhLuong();
        public double tinhThuNhap()
        {
            if (xepLoaiThiDua() == "A")
                return tinhLuong() + tinhPhuCapThamNien();
            else if(xepLoaiThiDua() == "B")
                return tinhLuong() * 0.75 + tinhPhuCapThamNien();
            else if(xepLoaiThiDua() == "C")
                return tinhLuong() * 0.5 + tinhPhuCapThamNien();
            else return tinhLuong() * 0 + tinhPhuCapThamNien();
        }

        public double tinhPhuCapThamNien()
        {
            if ((int)(DateTime.Now.Year - NamVaoLam) >= 5)
                return ((double)(DateTime.Now.Year - NamVaoLam) / 100) * luongCoBan;
            else return 0;
        }
        protected NhanVien()
        {
            
        }

        protected NhanVien(string ma, string ten, int ns, string gt, double hs, int nvl)
        {
            MaNV = ma;
            HoTen = ten;
            NamSinh = ns;
            GioiTinh = gt;
            HeSoLuong = hs;
            NamVaoLam = nvl;

        }
        public virtual void xuat()
        {
            Console.WriteLine($"Mã nhân viên: {MaNV}\nHọ tên: {HoTen}\nNăm sinh: {NamSinh}\ngiới tính: {GioiTinh}\n" +
                $"Hệ số lương: {HeSoLuong}\nNăm vào làm: {NamVaoLam}\nPhụ cấp thâm niên: {tinhPhuCapThamNien()}\n" +
                $"Xếp loại thi đua: {xepLoaiThiDua()}\nLương: {tinhLuong()}\nThu nhập: {tinhThuNhap()}");
        }
    }
}
