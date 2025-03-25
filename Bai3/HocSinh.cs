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

        public void xuatTTHS()
        {
            Console.WriteLine($"Mã học sinh: {MaHS}\nTên học sinh: {TenHS}");
            Console.WriteLine("Danh sách môn học: ");
            foreach(MonHoc mh in DsMonHoc)
            {
                mh.xuatTTMonHoc();
            }
        }
    }
}
