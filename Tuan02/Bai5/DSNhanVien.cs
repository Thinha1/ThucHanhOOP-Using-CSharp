using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai5
{
    class DSNhanVien
    {
        List<NhanVien> listNhanVien;

        public List<NhanVien> ListNhanVien { get => listNhanVien; set => listNhanVien = value; }
        public DSNhanVien()
        {
            ListNhanVien = new List<NhanVien>();
        }
        public DSNhanVien(List<NhanVien> list)
        {
            ListNhanVien = list;
        }
        public void nhapDSNV()
        {
            Console.Write("Nhập số lượng nhân viên: ");
            int sl = int.Parse(Console.ReadLine());
            for (int i = 0; i < sl; i++)
            {
                Console.WriteLine("Nhập thông tin nhân viên thứ " + (i + 1));
                NhanVien nv = new NhanVien();
                nv.nhapTT();
                ListNhanVien.Add(nv);
            }
        }
        public void inDSNV()
        {
            Console.WriteLine("\t\t\t\tDANH SÁCH NHÂN VIÊN\t\t\t\t");
            foreach (NhanVien nv in ListNhanVien)
            {
                Console.WriteLine("Thông tin nhân viên thứ " + (ListNhanVien.IndexOf(nv) + 1));
                nv.xuatTT();
            }
        }
        public void inTheoHeSoThiDua()
        {
            Console.WriteLine("\t\t\t\tDANH SÁCH NHÂN VIÊN THEO HỆ SỐ THI ĐUA\t\t\t\t");
            DSNhanVien ds = new DSNhanVien();
            Console.WriteLine("Hệ số thi đua: 1.0");
            ds.ListNhanVien = ListNhanVien.Where(t => t.tinhHeSoThiDua() == 1.0).ToList();
            ds.inDSNV();

            Console.WriteLine("Hệ số thi đua: 0.8");
            ds.ListNhanVien = ListNhanVien.Where(t => t.tinhHeSoThiDua() == 0.8).ToList();
            ds.inDSNV();

            Console.WriteLine("Hệ số thi đua: 0.6");
            ds.ListNhanVien = ListNhanVien.Where(t => t.tinhHeSoThiDua() == 0.6).ToList();
            ds.inDSNV();
        }

        public void inTheoPhongBan()
        {
            List<string> dsPhongBan = (ListNhanVien.Select(t => t.PhongBan).Distinct()).ToList();
            foreach(string pb in dsPhongBan) {
                Console.WriteLine("\t\t\tPHÒNG BAN "+ pb + "\t\t\t");
                foreach (NhanVien nv in ListNhanVien.Where(t => t.PhongBan == pb))
                {
                    nv.xuatTT();
                }
            }
        }

        public void inTheoChucVu()
        {
            DSNhanVien ds = new DSNhanVien();
            foreach(NhanVien nv in ListNhanVien)
            {
                ds.ListNhanVien = ListNhanVien.Where(t => t.ChucVu == "Lãnh đạo").ToList();
            }
            ds.inDSNV();
        }
        public double tinhTongLuong()
        {
            return ListNhanVien.Sum(t => t.tinhLuong());
        }
        public void xoaNV()
        {
            foreach(NhanVien nv in ListNhanVien.Where(t => t.SoNgayLamViec < 10))
            {

                ListNhanVien.Remove(nv);
            }
        }
        public void inNhanVienKhongPhaiLanhDao()
        {
            DSNhanVien ds = new DSNhanVien();
            ds.ListNhanVien = ListNhanVien.Where(t => t.ChucVu != "Lãnh đạo" && t.SoNgayLamViec > 22).ToList();
            ds.inDSNV();
        }
        public void inNhanVienTheoHeSoVaPhongBan()
        {
            DSNhanVien ds = new DSNhanVien();
            ds.ListNhanVien = ListNhanVien.Where(t => t.HeSoLuong >= 4.34 && t.PhongBan == "Tài vụ").ToList();
            ds.inDSNV();
        }
    }
}
