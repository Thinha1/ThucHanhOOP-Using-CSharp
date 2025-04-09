using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai4
{
    internal class CBoLanhDao:NhanVien
    {
        string chucVu;
        int thamNien;

        public string ChucVu { get => chucVu; set => chucVu = value; }
        public int ThamNien { get => thamNien; set => thamNien = value; }

        public CBoLanhDao()
        {
            MaNV = "NV009";
            TenNV = "Dieu Hien";
            HeSoLuong = 4.67;
            ChucVu = "Gíám đốc";
            ThamNien = 10;
        }

        public override void nhap()
        {
            base.nhap();
            Console.Write("Nhập chức vụ: ");
            ChucVu = Console.ReadLine();
            Console.Write("Nhập thâm niên quản lí: ");
            ThamNien = int.Parse(Console.ReadLine());
        }

        public double tinhHeSoLanhDao()
        {
            if (ChucVu == "Giám đốc")
                return 7.0;
            else if (ChucVu == "Trưởng phòng")
                return 6.0;
            else if (ChucVu == "Phó phòng")
                return 4.5;
            else return 1.0;
        }

        public double tinhPhuCapLanhDao()
        {
            return 1500000 * tinhHeSoLanhDao();
        }
        public override double tinhThuNhap()
        {
            return base.tinhThuNhap() + tinhPhuCapLanhDao();
        }
        public override void xuat()
        {
            base.xuat();
            Console.WriteLine($"Chức vụ: {ChucVu}\nThâm niên quản lý: {ThamNien}\nHệ số lãnh đạo: {tinhHeSoLanhDao()}\nPhụ cấp lãnh đạo: {tinhPhuCapLanhDao()}\nLương: {tinhThuNhap()}");
        }
    }
}
