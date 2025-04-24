using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai3
{
    internal abstract class MonHoc
    {
        string maMon;
        string tenMon;
        int soTC;
        string khoaQL;

        public string MaMon { get => maMon; set => maMon = value; }
        public string TenMon { get => tenMon; set => tenMon = value; }
        public string KhoaQL { get => khoaQL; set => khoaQL = value; }
        public int SoTC { get => soTC; set => soTC = value; }

        public MonHoc()
        {
            
        }

        public MonHoc(string ma, string ten, int sotc, string khoa)
        {
            MaMon = ma;
            TenMon = ten;
            SoTC = sotc;
            KhoaQL = khoa;
        }
        public abstract double tinhHocPhi();
        public abstract double tinhTrungBinh();
        public virtual void xuat()
        {
            Console.WriteLine($"Mã môn: {MaMon}\nTên môn học: {TenMon}\nSố tín chỉ: {SoTC}\nKhoa: {KhoaQL}\nHọc phí: {tinhHocPhi()}\nĐiểm trung bình: {tinhTrungBinh()}");
        }
    }
}
