using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buoi01
{
    class KhoaHoc
    {
        private string maKH;
        private string tenKH;
        private int soBuoi;
        private string gioHoc;
        private int soLuongHocVien;
        private string giaoVienGiangDay;
        private static double hocPhiBuoi = 1000000;
        private static double thuLaoGiangDay = 500000;

        public string MaKH
        {
            get
            {
                return maKH;
            }
            set 
            {
                if (value.Length == 5 && (value.Substring(0, 1) == "KH")
                    && ((value[2] == '1') || (value[2] == '2')
                    || (value[2] == '3')) && value.Substring(3, 4).All(char.IsDigit))
                    maKH = value;
                else maKH = "KH1001";
            }
        }
        public string TenKH
        {
            get
            {
                return tenKH;
            }
            set 
            {
                if(!string.IsNullOrWhiteSpace(value) && !string.IsNullOrEmpty(value))
                    tenKH = value;
            }
        }

        public int SoBuoi
        {
            get
            {
                return soBuoi;
            }
            set
            {
                if (value > 0)
                    soBuoi = value;
                else soBuoi = 1;
            }
        }

        public string GioHoc
        {
            get
            {
                return gioHoc;
            }
            set
            {
                if (value == "2, 4, 6" || value == "3, 5, 7" || value == "7, CN")
                    gioHoc = value;
                else gioHoc = "2, 4, 6";
            }
        }
        public int SoLuongHocVien
        {
            get
            {
                return soLuongHocVien;
            }
            set
            {
                if (value > 10 && value <= 20)
                    soLuongHocVien = value;
                else soLuongHocVien = 10;
            }
        }
        public string GiaoVienGiangDay
        {
            get
            {
                return giaoVienGiangDay;
            }
            set
            {
                if(!string.IsNullOrEmpty(value) && !string.IsNullOrWhiteSpace(value))
                    giaoVienGiangDay = value;
            }
        }

        public KhoaHoc()
        {
            
        }

        public KhoaHoc(string makh, string tenkh, int sobuoi, string giohoc, int soluonghocvien, string giaoviengiangday)
        {
            MaKH = makh;
            TenKH = tenkh;
            SoBuoi = sobuoi;
            GioHoc = giohoc;
            SoLuongHocVien = soluonghocvien;
            GiaoVienGiangDay = giaoviengiangday;
        }

        public KhoaHoc(KhoaHoc kh1)
        {
            MaKH = kh1.MaKH;
            TenKH = kh1.TenKH;
            SoBuoi = kh1.SoBuoi;
            GioHoc = kh1.GioHoc;
            SoLuongHocVien = kh1.SoLuongHocVien;
            GiaoVienGiangDay = kh1.GiaoVienGiangDay;
        }

        public double tinnhHocPhi()
        {
            if (GioHoc == "2, 4, 6" || GioHoc == "3, 4, 7")
                return SoBuoi * hocPhiBuoi;
            return SoBuoi * hocPhiBuoi * 1.2;
        }

        public double tinhThuLao()
        {
            if (SoLuongHocVien > 15)
                return (100000 * SoBuoi) * thuLaoGiangDay;
            return SoBuoi * thuLaoGiangDay;
        }
        public void nhapTT()
        {
            Console.Write("Nhập mã khóa học: ");
            MaKH = Console.ReadLine();
            Console.Write("Nhập tên khóa học: ");
            TenKH = Console.ReadLine();
            Console.Write("Nhập số buổi: ");
            SoBuoi = int.Parse(Console.ReadLine());
            Console.Write("Nhập giờ học: ");
            GioHoc = Console.ReadLine();
            Console.Write("Nhập số lượng học viên: ");
            SoLuongHocVien = int.Parse(Console.ReadLine());
            Console.Write("Nhập giáo viên giảng dạy: ");
            GiaoVienGiangDay = Console.ReadLine();
        }
        public void xuatTT()
        {
            Console.WriteLine($"Mã khóa học: {MaKH}\nTên khóa học: {TenKH}\nSố buổi: {SoBuoi}\nGiờ học: {GioHoc}\n" +
                $"Số lượng học viên: {SoLuongHocVien}\ngiáo viên giảng dạy: {GiaoVienGiangDay}" +
                $"\nHọc phí 1 buổi: {hocPhiBuoi}\nHọc phí khóa hoc: {tinnhHocPhi()}\nThù lao 1 buổi: {thuLaoGiangDay}\nThù lao cả khóa học: {tinhThuLao()}");
        }
    }
}
