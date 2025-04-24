using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai3
{
    class MonHoc
    {
        private string maMH;
        private string tenMH;
        private float diemKTThuongXuyen;
        private float diemGKi;
        private float diemCKi;

        public string MaMH { get => maMH; set => maMH = value; }
        public string TenMH { get => tenMH; set => tenMH = value; }
        public float DiemKTThuongXuyen { get => diemKTThuongXuyen; set => diemKTThuongXuyen = value; }
        public float DiemGKi { get => diemGKi; set => diemGKi = value; }
        public float DiemCKi { get => diemCKi; set => diemCKi = value; }

        public MonHoc()
        {
            MaMH = "";
            TenMH = "";
        }

        public MonHoc(string mamh, string tenmh)
        {
            MaMH = mamh;
            TenMH = tenmh;
        }
        public MonHoc(string mamh, string tenmh, float diemtx, float diemgki, float diemcki)
        {
            MaMH = mamh;
            TenMH = tenmh;
            DiemKTThuongXuyen = diemtx;
            DiemGKi = diemgki;
            DiemCKi = diemcki;
        }
        
        public double tinhDiemTongKet()
        {
            return Math.Round((DiemKTThuongXuyen + DiemGKi * 2 + DiemCKi * 3) / 6, 2);
        }

        public string tinhKetQua()
        {
            if (tinhDiemTongKet() >= 5)
                return "Đạt";
            else return "Không đạt";
        }

        public void nhapTTMonHoc()
        {
            Console.Write("Nhập mã: ");
            MaMH = Console.ReadLine();
            Console.Write("Nhập tên môn học: ");
            TenMH = Console.ReadLine();
            Console.Write("Nhập điểm thường xuyên: ");
            DiemKTThuongXuyen = float.Parse(Console.ReadLine());
            Console.Write("Nhập điểm giữa kỳ: ");
            DiemGKi = float.Parse(Console.ReadLine());
            Console.Write("Nhập điểm cuối kỳ: ");
            DiemCKi = float.Parse(Console.ReadLine());
        }

        public void xuatTTMonHoc()
        {
            Console.WriteLine($"Mã môn học: {MaMH}\nTên môn học: {TenMH}\n" +
                $"Điểm thường xuyên: {DiemKTThuongXuyen}\nĐiểm giữa kỳ: {DiemGKi}\nĐiểm cuối kỳ: {DiemCKi}\nĐiểm tổng kết: {tinhDiemTongKet()}\nKết quả: {tinhKetQua()}");
        }
        

    }
}
