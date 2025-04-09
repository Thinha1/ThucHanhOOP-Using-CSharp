using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai3
{
    internal class Nguoi
    {
        string hoten;
        DateTime ngaySinh;
        string gioiTinh;
        
        public string Hoten { get => hoten; set => hoten = value; }
        public DateTime NgaySinh { get => ngaySinh; set => ngaySinh = value; }
        public string GioiTinh { get => gioiTinh; set 
            {
                if(value == "Nam" || value == "Nữ")
                    gioiTinh = value;
                gioiTinh = "Nam";
            } 
        }
        public Nguoi()
        {
            GioiTinh = "Nam";
        }
        public Nguoi(string ten, DateTime ns, string gt)
        {
            Hoten = ten;
            NgaySinh = ns;
            GioiTinh = gt;
        }
        public virtual void nhap()
        {
            Console.Write("Nhập họ tên: ");
            Hoten = Console.ReadLine();
            Console.Write("Nhập ngày sinh: ");
            NgaySinh = DateTime.Parse(Console.ReadLine());
            Console.Write("Nhập giới tính: ");
            GioiTinh = Console.ReadLine();
        }
        public virtual void xuat()
        {
            Console.WriteLine($"Họ tên: {Hoten}\nNgày sinh: {NgaySinh}\nGiới tính: {GioiTinh}");
        }
    }
}
