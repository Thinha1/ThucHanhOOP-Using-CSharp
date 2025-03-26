using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Bai6
{
    class HoaDon
    {
        private string maHoaDon;
        private string tenKH;
        private List<ChiTietDonHang> dsCTDH;

        public string MaHoaDon { get => maHoaDon; set => maHoaDon = value; }
        public string TenKH { get => tenKH; set => tenKH = value; }
        internal List<ChiTietDonHang> DsCTDH { get => dsCTDH; set => dsCTDH = value; }

        public HoaDon()
        {
            DsCTDH = new List<ChiTietDonHang>();
        }

        public HoaDon(string mahd, string tenkh, List<ChiTietDonHang> ds)
        {
            MaHoaDon = mahd;
            TenKH = tenkh;
            dsCTDH = ds;
        }

        public void nhapTTHoaDon()
        {
            Console.Write("Nhập mã hóa đơn: ");
            MaHoaDon = Console.ReadLine();
            Console.Write("Nhập tên khách hàng: ");
            TenKH = Console.ReadLine();
            Console.Write("Nhập số lượng đơn hàng: ");
            int sl = int.Parse(Console.ReadLine());
            for(int i = 0; i < sl; i++)
            {
                Console.WriteLine("Nhập đơn hàng thứ: " +(i + 1));
                ChiTietDonHang ctdh = new ChiTietDonHang();
                ctdh.nhapCTDH();
                DsCTDH.Add(ctdh);
            }
        }
        public double tinhTriGiaHoaDon()
        {
            return DsCTDH.Sum(t => t.tinhThanhTien());
        }

        public void xuatTTHoaDon()
        {
            Console.WriteLine($"Mã hóa đơn: {MaHoaDon}\nTên khách hàng: {TenKH}");
            foreach(ChiTietDonHang ctdh in DsCTDH)
            {
                ctdh.xuatCTDH();
            }
            Console.WriteLine($"Tổng tiền: {tinhTriGiaHoaDon()}");
        }
        public HoaDon sapXep()
        {
            HoaDon hd = new HoaDon();
            hd.DsCTDH = DsCTDH.OrderByDescending(t => t.tinhThanhTien()).ThenBy(t => t.GiaBan).ToList();
            return hd;
        }
        public HoaDon xuatMax()
        {
            HoaDon hd = new HoaDon();
            hd.DsCTDH = DsCTDH.Where(t => t.tinhThanhTien() == DsCTDH.Max(t => t.tinhThanhTien())).ToList();
            return hd;
        }
    }
}
