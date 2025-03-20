using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buoi01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.UTF8;
            Console.OutputEncoding = Encoding.UTF8;

            //Nhân viên
            //NhanVien nv1 = new NhanVien();
            //nv1.xuatTT();
            //NhanVien nv2 = new NhanVien();
            //Console.WriteLine("Nhập thông tin nhân viên 2");
            //nv2.nhapTT();
            //nv2.xuatTT();
            //Console.WriteLine("Thông tin nhân viên 3");
            //NhanVien nv3 = new NhanVien("NV002", "Tran Hoang Anh", 25);
            //nv3.xuatTT();
            //Console.WriteLine("Thông tin nhân viên 4");
            //NhanVien nv4 = new NhanVien("NV004", "Tran Hoa", 1);
            //nv4.xuatTT();

            //Hóa đơn
            //HoaDon hd1 = new HoaDon();
            //Console.WriteLine("Thông tin hóa đơn 1");
            //hd1.xuatTT();
            //Console.WriteLine("Thông tin hóa đơn 2");
            //HoaDon hd2 = new HoaDon("Samsung", "S0001", "Samsung galaxy J7", 14000000, "");
            //hd2.xuatTT();
            //Console.WriteLine("Thông tin hóa đơn 3");
            //HoaDon hd3 = new HoaDon(hd2);
            //hd3.xuatTT();
            //Console.WriteLine("Thông tin hóa đơn 4");
            //HoaDon hd4 = new HoaDon();
            //hd4.nhapTT();
            //hd4.xuatTT();

            //Khóa học
            //KhoaHoc kh1 = new KhoaHoc();
            //Console.WriteLine("Nhập thông tin khóa học 1");
            //kh1.nhapTT();
            //Console.WriteLine("Thông tin khóa học 1");
            //kh1.xuatTT();
            //Console.WriteLine("Thông tin khóa học 2");
            //KhoaHoc kh2 = new KhoaHoc("KH2001", "Lập trình C#", 10, "3, 4, 7", 15, "Thịnh");
            //kh2.xuatTT();
            //Console.WriteLine("Thông tin khóa học 3");
            //KhoaHoc kh3 = new KhoaHoc(kh2);
            //kh3.xuatTT();

            //Nước giải khát
            //NuocGiaiKhat ngk1 = new NuocGiaiKhat();
            //Console.WriteLine("Nhập thông tin nước giải khát 1");
            //ngk1.nhapTT();
            //Console.WriteLine("Thông tin nước giải khát 1");
            //ngk1.xuatTT();
            //Console.WriteLine("Thông tin nước giải khát 2");
            //NuocGiaiKhat ngk2 = new NuocGiaiKhat("Pepsi", "Lon", 10, 250000);
            //ngk2.xuatTT();
            
            //Hình chữ nhật
            HinhChuNhat hcn1 = new HinhChuNhat();
            Console.WriteLine("Nhập thông tin hình chữ nhật 1");
            hcn1.nhapTT();
            Console.WriteLine("Thông tin hình chữ nhật 1");
            hcn1.xuatTT();
            Console.WriteLine("Thông tin hình chữ nhật 2");
            HinhChuNhat hcn2 = new HinhChuNhat(2, 5);
            hcn2.xuatTT();
            Console.WriteLine("Thông tin hình chữ nhật 3");
            HinhChuNhat hcn3 = new HinhChuNhat(hcn2);
            hcn3.xuatTT();
            Console.ReadLine();
        }
    }
}
