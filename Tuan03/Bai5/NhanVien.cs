using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai5
{
    class NhanVien
    {
        private string maNV;
        private string tenNV;
        private string phongBan;
        private string chucVu;
        private double heSoLuong;
        private int thamNienCongTac;
        private int soNgayLamViec;
        private static double luongCoBan = 2340000;

        public string MaNV { get => maNV; set => maNV = value; }
        public string TenNV { get => tenNV; set => tenNV = value; }
        public string PhongBan { get => phongBan; set => phongBan = value; }
        public string ChucVu
        {
            get => chucVu; set
            {
                if (value == "Lãnh đạo" || value == "Nhân viên")
                    chucVu = value;
                else chucVu = "Nhân viên";
            }
        }
        public double HeSoLuong { get => heSoLuong; set => heSoLuong = value; }
        public int ThamNienCongTac { get => thamNienCongTac; set => thamNienCongTac = value; }
        public int SoNgayLamViec { get => soNgayLamViec; set => soNgayLamViec = value; }

        public double tinhHeSoThiDua()
        {
            if(ChucVu == "Lãnh đạo")
            {
                return 1.0;
            }
            else
            {
                if (SoNgayLamViec > 22)
                    return 1.0;
                else if (SoNgayLamViec > 20)
                    return 0.8;
                return 0.6;
            }
        }
        public double tinhPhuCap()
        {
            if (ChucVu == "Lãnh đạo")
                return 1350000;
            return 0;
        }
        public double tinhLuong()
        {
            return HeSoLuong * luongCoBan * tinhHeSoThiDua() + 1100000 + tinhPhuCap();
        }

        public void nhapTT()
        {
            Console.Write("Nhập mã nhân viên: ");
            MaNV = Console.ReadLine();
            Console.Write("Nhập tên nhân viên: ");
            TenNV = Console.ReadLine();
            Console.Write("Nhập phòng ban: ");
            PhongBan = Console.ReadLine();
            Console.Write("Nhập chức vụ: ");
            ChucVu = Console.ReadLine();
            Console.Write("Nhập hệ số lương: ");
            HeSoLuong = double.Parse(Console.ReadLine());
            Console.Write("Nhập thâm niên công tác: ");
            ThamNienCongTac = int.Parse(Console.ReadLine());
            Console.Write("Nhập số ngày làm việc trong tháng: ");
            SoNgayLamViec = int.Parse(Console.ReadLine());
        }
        public void xuatTT()
        {
            Console.WriteLine($"Mã nhân viên: {MaNV}\nTên nhân viên: {TenNV}\nPhòng ban: {PhongBan}\n" +
                $"Chức vụ: {ChucVu}\nHệ số lương: {HeSoLuong}\nThâm niên công tác: {ThamNienCongTac}\n" +
                $"Số ngày làm việc trong tháng: {SoNgayLamViec}\nHệ số thi đua: {tinhHeSoThiDua()}\n" +
                $"Phụ cấp: {tinhPhuCap()}\nLương: {tinhLuong()}");
        }
    }
}
