using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Bai2
{
    internal class CongTy
    {
        string tenCTY;
        string soDienThoai;
        string diaChi;
        List<HoaDon> listHD;

        public string TenCTY { get => tenCTY; set => tenCTY = value; }
        public string SoDienThoai { get => soDienThoai; set => soDienThoai = value; }
        public string DiaChi { get => diaChi; set => diaChi = value; }
        internal List<HoaDon> ListHD { get => listHD; set => listHD = value; }

        public CongTy()
        {
            ListHD = new List<HoaDon>();
        }

        public CongTy(string ten, string sdt, string dchi, List<HoaDon> list)
        {
            TenCTY = ten;
            SoDienThoai = sdt;
            DiaChi = dchi;
            ListHD = list;
        }

        public void docFile(string filename)
        {
            XmlDocument doc = new XmlDocument();
            doc.Load(filename);
            TenCTY = doc.SelectSingleNode("CongTy/TenCty").InnerText;
            SoDienThoai = doc.SelectSingleNode("CongTy/SoDienThoai").InnerText;
            DiaChi = doc.SelectSingleNode("CongTy/DiaChi").InnerText;
            XmlNodeList nodeList = doc.SelectNodes("CongTy/DSHD/HD");
            foreach(XmlNode node in nodeList)
            {
                HoaDon hd;
                int loai = int.Parse(node["Loai"].InnerText);
                string makh = node["MaKH"].InnerText;
                string tenkh = node["TenKH"].InnerText;
                int sl = int.Parse(node["SoLuong"].InnerText);
                double giaban = double.Parse(node["GiaBan"].InnerText);
                if (loai == 1)
                {
                    int kcgh = int.Parse(node["KhoangCach"].InnerText);
                    hd = new KhachHangCaNhan(makh, tenkh, sl, giaban, kcgh);
                }
                else if (loai == 2)
                {
                    int thoigianht = int.Parse(node["ThoiGianHopTac"].InnerText);
                    hd = new DaiLyCapMot(makh, tenkh, sl, giaban, thoigianht);
                }
                else
                {
                    int slnv = int.Parse(node["SoLuongNV"].InnerText);
                    hd = new KhachHangCongTy(makh, tenkh, sl, giaban, slnv);
                }
                ListHD.Add(hd);
            }
        }

        public double tinhTongThanhTien()
        {
            return ListHD.Sum(t => t.tinhThanhTien());
        }

        public HoaDon muaNhieuNhat()
        {
            return ListHD.OrderByDescending(t => t.SoLuong).FirstOrDefault();
        }

        public void xuatDaiLy()
        {
            int count = 0;
            foreach (HoaDon hoaDon in ListHD)
            {
                if (hoaDon is DaiLyCapMot)
                {
                    count++;
                    hoaDon.xuat();
                }
            }
            Console.WriteLine("Số lượng: " + count);
        }
        public List<HoaDon> sapXep()
        {
            return ListHD.OrderBy(t => t.SoLuong).ThenByDescending(t=> t.tinhThanhTien()).ToList();
        }
        public double tinhTongChietKhauCongTy()
        {
            foreach (var hd in ListHD)
            {
                if (hd is KhachHangCongTy)
                    return ListHD.Sum(t => t.tinhChietKhau());
            }
            return 0;
        }
        public List<HoaDon> xuatHoaDonMaX(string x)
        {
            List<HoaDon> dshd =ListHD.Where(t => t.MaKH == x).ToList();
            if(dshd.Count == 0)
            {
                Console.WriteLine("Khách hàng lạ");

            }
            return dshd;
        }
        public void xuat()
        {
            Console.WriteLine($"Tên công ty: {TenCTY}\nSố điện thoại: {SoDienThoai}\nĐịa chỉ: {DiaChi}");
            Console.WriteLine("DANH SÁCH HÓA ĐƠN");
            Console.WriteLine();
            foreach (HoaDon hd in ListHD)
            {
                Console.WriteLine($"Hóa đơn thứ {(ListHD.IndexOf(hd) + 1)}");
                hd.xuat();
                Console.WriteLine();
            }
            Console.WriteLine($"Tổng thành tiền: {tinhTongThanhTien()}");
            Console.WriteLine($"Tổng chiết khấu của công ty: {tinhTongChietKhauCongTy()}");
        }
    }
}
