using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Bai4
{
    internal class DSHoaDon
    {
        List<HoaDon> hoaDonList;
        internal List<HoaDon> HoaDonList { get => hoaDonList; set => hoaDonList = value; }

        public DSHoaDon()
        {
            HoaDonList = new List<HoaDon>();
        }
        public void docFile(string filename)
        {
            XmlDocument doc = new XmlDocument();
            doc.Load(filename);
            XmlNodeList nodeList = doc.SelectNodes("DSHoaDon/HoaDon");
            foreach(XmlNode node in nodeList)
            {
                HoaDon hd;
                int loai = int.Parse(node["Loai"].InnerText);
                string mahd = node["MaHD"].InnerText;
                string tenkh = node["TenKH"].InnerText;
                DateTime ngaylap = DateTime.Parse(node["NgayLap"].InnerText);
                XmlNodeList mhList = node.SelectNodes("MatHang");
                XangDau mh = new XangDau();
                foreach (XmlNode nodeMH in mhList)
                {
                    mh.MaHang = nodeMH["MaMH"].InnerText;
                    mh.TenHang = nodeMH["TenMH"].InnerText;
                    mh.DonGia = double.Parse(nodeMH["DonGia"].InnerText);
                }
                int sl = int.Parse(node["SoLuong"].InnerText);
                if (loai == 1)
                {
                    hd = new HoaDonKhachVIP(mahd, tenkh, ngaylap, mh, sl);
                }
                else if (loai == 2)
                {
                    hd = new HoaDonKhachThanThiet(mahd, tenkh, ngaylap, mh, sl);
                }
                else
                {
                    hd = new HoaDonKhachVangLai(mahd, "", ngaylap, mh, sl);
                }
                HoaDonList.Add(hd);
            }
        }
        public void xuat()
        {
            foreach(HoaDon hd in HoaDonList)
            {
                Console.WriteLine($"Hóa đơn thứ {(HoaDonList.IndexOf(hd) + 1)}");
                hd.xuat();
                Console.WriteLine();
            }
            Console.WriteLine($"Tổng trị giá hóa đơn: {tinhTongTriGia()}");
        }
        public void xuatVangLai()
        {
            foreach( HoaDon hd in HoaDonList)
            {
                if (hd is HoaDonKhachVangLai)
                    hd.xuat();
            }
        }
        public double tinhTongTriGia()
        {
            return HoaDonList.Sum(t => t.tinhTriGia());
        }
        public HoaDon inGiaCaoNhat()
        {
            return HoaDonList.OrderByDescending(t => t.tinhTriGia()).FirstOrDefault();
        }
        public int demVIPVaThanThiet()
        {
            int count = 0;
            foreach (HoaDon hd in HoaDonList)
            {
                if(hd is HoaDonKhachThanThiet || hd is HoaDonKhachVIP)
                    count++;
            }
            return count;
        }
        public void sapXepTangDan()
        {
            DSHoaDon ds = new DSHoaDon();
            ds.HoaDonList = HoaDonList.OrderBy(t => t.tinhTriGia()).ThenByDescending(t => t.MaHD).ToList();
            ds.xuat();
        }
    }
}
