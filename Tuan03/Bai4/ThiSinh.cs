using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;

namespace Bai4
{
    class ThiSinh
    {
        private string maTS;
        private string hoTen;
        private string gioiTinh;
        private double diemLyThuyet;
        private double diemThucHanh;
        public string MaTS { get => maTS; set => maTS = value; }
        public string HoTen { get => hoTen; set => hoTen = value; }
        public string GioiTinh { get => gioiTinh; set => gioiTinh = value; }
        public double DiemLyThuyet { get => diemLyThuyet; set => diemLyThuyet = value; }
        public double DiemThucHanh { get => diemThucHanh; set => diemThucHanh = value; }

        public ThiSinh()
        {
            
        }
        public ThiSinh(ThiSinh ts)
        {
            MaTS = ts.MaTS;
            HoTen = ts.HoTen;
            GioiTinh = ts.GioiTinh;
            DiemLyThuyet = ts.DiemLyThuyet;
            DiemThucHanh = ts.DiemThucHanh;
        }

        public ThiSinh(string mats, string hoten, string gioitinh, double diemlythuyet, double diemthuchanh)
        {
            MaTS = mats;
            HoTen = hoten;
            GioiTinh = gioitinh;
            DiemLyThuyet = diemlythuyet;
            DiemThucHanh = diemthuchanh;
        }
        public double tinhDiemTongKet()
        {
            return (DiemLyThuyet + DiemThucHanh) / 2;
        }

        public string tinhKetQuaXetTuyen()
        {
            if (tinhDiemTongKet() > 5.0 && DiemLyThuyet >= 5.0 && DiemThucHanh >= 5.0)
                return "Đậu";
            return "Rớt";
        }

        public void nhapTTThiSinh()
        {
            Console.Write("Nhập mã thí sinh: ");
            MaTS = Console.ReadLine();
            Console.Write("Nhập họ tên thí sinh: ");
            HoTen = Console.ReadLine();
            Console.Write("Nhập điểm lý thuyết: ");
            DiemLyThuyet = double.Parse(Console.ReadLine());
            Console.Write("Nhập điểm thực hành: ");
            DiemThucHanh = double.Parse(Console.ReadLine());
        }

        public void xuatTTThiSinh()
        {
            Console.WriteLine($"Mã thí sinh: {MaTS}\nHọ tên thí sinh: {HoTen}\n" +
                $"Điểm lý thuyết: {DiemLyThuyet}\nĐiểm thực hành: {DiemThucHanh}\n" +
                $"Điểm tổng kết: {tinhDiemTongKet()}\nKết quả xét tuyển: {tinhKetQuaXetTuyen()}");
        }
    }
}
