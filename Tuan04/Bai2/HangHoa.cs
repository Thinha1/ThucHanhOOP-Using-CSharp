using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai2
{
    internal class HangHoa
    {
        string maHang;
        string tenHang;

        public string MaHang { get => maHang; 
            set 
            {
                if(value.Length == 5 && value.StartsWith("HH") && value.Substring(2).All(char.IsDigit))
                    maHang = value;
                maHang = "HH001";
            } 
        }

        public string TenHang { get => tenHang; set => tenHang = value; }

        public HangHoa()
        {
            
        }

        public HangHoa(string ma, string ten)
        {
            MaHang = ma;
            TenHang = ten;
        }
        public virtual void nhap()
        {
            Console.Write("Nhập mã hàng: ");
            MaHang = Console.ReadLine();
            Console.Write("Nhập tên hàng: ");
            TenHang = Console.ReadLine();
        }
        public virtual void xuat()
        {
            Console.WriteLine($"Mã hàng: {MaHang}\nTên hàng: {TenHang}");
        }
    }
}
