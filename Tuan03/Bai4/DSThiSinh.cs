using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai4
{
    class DSThiSinh
    {
        List<ThiSinh> danhSachThiSinh;
        public List<ThiSinh> DanhSachThiSinh { get => danhSachThiSinh; set => danhSachThiSinh = value; }
        public DSThiSinh()
        {
            DanhSachThiSinh = new List<ThiSinh>();
        }

        public DSThiSinh(List<ThiSinh> list)
        {
            DanhSachThiSinh = list;
        }

        public void nhapDSTS()
        {
            Console.Write("Nhập số lượng thí sinh: ");
            int sl = int.Parse(Console.ReadLine());
            for(int i = 0; i < sl; i++)
            {
                Console.WriteLine("Nhập thông tin thí sinh thứ " + (i + 1));
                ThiSinh ts = new ThiSinh();
                ts.nhapTTThiSinh();
                DanhSachThiSinh.Add(ts);
            }
        }
        public void inDSTS()
        {
            Console.WriteLine("\t\t\t\tDANH SÁCH THÍ SINH\t\t\t\t");
            foreach(ThiSinh ts in DanhSachThiSinh)
            {
                Console.WriteLine("Thông tin thí sinh thứ " + (DanhSachThiSinh.IndexOf(ts) + 1));
                ts.xuatTTThiSinh();
            }
        }
        
        public void inDSTSDau()
        {
            Console.WriteLine("\t\t\t\tDANH SÁCH THÍ SINH ĐẬU\t\t\t\t");
            foreach(ThiSinh ts in DanhSachThiSinh)
            {
                if (ts.tinhKetQuaXetTuyen() == "Đậu")
                    ts.xuatTTThiSinh();
            }
        }
        public void inTTDuaTrenMa(string mats)
        {
            foreach(ThiSinh ts in DanhSachThiSinh)
            {
                if (ts.MaTS == mats)
                    ts.xuatTTThiSinh();
            }
            if (!(DanhSachThiSinh.Any(t => t.MaTS == mats)))
                Console.WriteLine("Không tìm thấy thông tin");
        }
        
        public int tongTSDau()
        {
            return DanhSachThiSinh.Count(t => t.tinhKetQuaXetTuyen() == "Đậu");
           
        }
        public int tongTSRot()
        {
            return DanhSachThiSinh.Count(t => t.tinhKetQuaXetTuyen() == "Rớt");
        }
        public DSThiSinh sapXepGiamDanTheoDiem()
        {
            DSThiSinh ds = new DSThiSinh();
            ds.DanhSachThiSinh = DanhSachThiSinh.OrderByDescending(t => t.tinhDiemTongKet()).ToList();
            return ds;
        }
    }
}
