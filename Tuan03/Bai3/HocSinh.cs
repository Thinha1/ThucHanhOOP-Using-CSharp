using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai3
{
    class HocSinh
    {
        private string maHS;
        private string tenHS;
        private List<MonHoc> dsMonHoc;

        public string MaHS { get => maHS; set => maHS = value; }
        public string TenHS { get => tenHS; set => tenHS = value; }
        public List<MonHoc> DsMonHoc { get => dsMonHoc; set => dsMonHoc = value; }

        public HocSinh()
        {
            MaHS = "";
            TenHS = "";
            DsMonHoc = new List<MonHoc>();
        }

        public HocSinh(string mahs, string tenhs, List<MonHoc> listmh)
        {
            MaHS = mahs;
            TenHS = tenhs;
            DsMonHoc = listmh;
        }

        public void nhapTTHS()
        {
            Console.Write("Nhập mã học sinh: ");
            MaHS = Console.ReadLine();
            Console.Write("Nhập tên học sinh: ");
            TenHS = Console.ReadLine();
            Console.Write("Nhập số lượng môn học: ");
            int sl = int.Parse(Console.ReadLine());
            for(int i = 0; i < sl; i++)
            {
                Console.WriteLine("Nhập thông tin môn học thứ " + (i + 1));
                MonHoc mh = new MonHoc();
                mh.nhapTTMonHoc();
                DsMonHoc.Add(mh);
            }
        }

        public double tinhDiemTrungBinh()
        {
            return DsMonHoc.Average(t => t.tinhDiemTongKet());
        }

        public string xepLoaiHocSinh()
        {
            if (tinhDiemTrungBinh() >= 8 && !(DsMonHoc.Any(t => t.tinhDiemTongKet() < 6.5)))
                return "Giỏi";
            else if (tinhDiemTrungBinh() >= 6.5 && !(DsMonHoc.Any(t => t.tinhDiemTongKet() < 5.0)))
                return "Khá";
            else if (tinhDiemTrungBinh() >= 5.0 && !(DsMonHoc.Any(t => t.tinhDiemTongKet() < 2.0)))
                return "Trung bình";
            else return "Kém";
        }
        public string xetKetQuaHocTap()
        {
            if (xepLoaiHocSinh() != "Yếu" && xepLoaiHocSinh() != "Kém")
                return "Được lên lớp";
            else if (xepLoaiHocSinh() == "Yếu")
                return "Thi lại";
            return "Ở lại lớp";
        }
        public void inDSMonDat(HocSinh x)
        {
            Console.WriteLine("Thông tin môn học kết quả \"ĐẠT\"");
            foreach(MonHoc mh in x.DsMonHoc)
            {
                if (mh.tinhKetQua() == "Đạt")
                    mh.xuatTTMonHoc();
            }
        }
        public void xuatTTHS()
        {
            Console.WriteLine($"Mã học sinh: {MaHS}\nTên học sinh: {TenHS}");
            Console.WriteLine("Danh sách môn học: ");
            foreach(MonHoc mh in DsMonHoc)
            {
                mh.xuatTTMonHoc();
            }
            Console.WriteLine($"Điểm trung bình: {tinhDiemTrungBinh()}\nXếp loại: {xepLoaiHocSinh()}\nKết quả học tập: {xetKetQuaHocTap()}");
        }

        


    }
}
