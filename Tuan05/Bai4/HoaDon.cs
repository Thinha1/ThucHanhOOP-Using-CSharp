using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai4
{
    internal abstract class HoaDon
    {
        string maHD;
        string tenKH;
        DateTime ngayLap;
        XangDau matHang;
        int soLuong;

        public string MaHD { get => maHD; set => maHD = value; }
        public DateTime NgayLap { get => ngayLap; set => ngayLap = value; }
        public int SoLuong { get => soLuong; set => soLuong = value; }
        internal XangDau MatHang { get => matHang; set => matHang = value; }
        public string TenKH { get => tenKH; set => tenKH = value; }

        protected HoaDon()
        {
            
        }

        protected HoaDon(string ma, string ten, DateTime ngaylap, XangDau mh, int soluong)
        {
            MaHD = ma;
            TenKH = ten;
            ngayLap = ngaylap;
            MatHang = mh;
            SoLuong = soluong;
        }
        public abstract double tinhKhuyenMai();
        public double tinhThanhTien()
        {
            return SoLuong * MatHang.DonGia;
        }
        public double tinhTriGia()
        {
            return tinhThanhTien() - tinhKhuyenMai();
        }
        public void xuat()
        {
            Console.WriteLine($"Mã khách hàng: {MaHD}\nTên khách hàng: {TenKH}\nNgày lập: {NgayLap}\nSố lượng: {SoLuong}\n");
            Console.WriteLine("MẶT HÀNG KHÁCH MUA: ");
            MatHang.xuat();
            Console.WriteLine($"Khuyến mãi: {tinhKhuyenMai()}\nThành tiền: {tinhThanhTien()}\nTrị giá: {tinhTriGia()}");
        }
    }
}
