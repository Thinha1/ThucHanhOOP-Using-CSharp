using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2001230930_DangAnhThinh_Buoi02_Bai2
{
    internal class Program
    {
        static void Main(string[] args) 
        {
            DSNhanVien ds1 = new DSNhanVien();
            String f = "E:\\LuuDuLieuSinhVien\\DangAnhThinh2001230930\\2001230930_DangAnhThinh_Buoi02_Bai2\\2001230930_DangAnhThinh_Buoi02_Bai2\\DSNhanVien.xml";
            ds1.docFile(f);
            ds1.xuatDSNV();
        }
    }
}