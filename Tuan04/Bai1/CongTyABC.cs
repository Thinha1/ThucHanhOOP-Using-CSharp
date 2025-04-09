using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace _2001230930_DangAnhThinh_THLTHDTBuoi04
{
    internal class CongTyABC
    {
        string tenCTY;
        string diaChi;
        string soDienThoai;
        List<NhanVien> listNhanVien;

        public string TenCTY { get => tenCTY; set => tenCTY = value; }
        public string DiaChi { get => diaChi; set => diaChi = value; }
        public string SoDienThoai { get => soDienThoai; set => soDienThoai = value; }
        internal List<NhanVien> ListNhanVien { get => listNhanVien; set => listNhanVien = value; }
        public CongTyABC()
        {
            ListNhanVien = new List<NhanVien>();
        }

        public void docFile(string filename)
        {
            XmlDocument doc = new XmlDocument();
            doc.Load(filename);
            TenCTY = doc.SelectSingleNode("CongTy/TenCty").InnerText;
            DiaChi = doc.SelectSingleNode("CongTy/DiaChi").InnerText;
            SoDienThoai = doc.SelectSingleNode("CongTy/DT").InnerText;
            XmlNodeList nodeList = doc.SelectNodes("CongTy/DSNV/NV");
            foreach(XmlNode node in nodeList)
            {
                int loai = int.Parse(node.Attributes["loai"].Value);
                if(loai == 1)
                {
                    NhanVien nv = new NhanVien();
                    nv.MaNV = node["ma"].InnerText;
                    nv.TenNV = node["ten"].InnerText;
                    nv.NamVaoLam = int.Parse(node["nvl"].InnerText);
                    nv.HeSoLuong = double.Parse(node["hsl"].InnerText);
                    nv.SoNgayNghi = int.Parse(node["snn"].InnerText);
                    ListNhanVien.Add(nv);
                }
                else
                {
                    CanBo cb = new CanBo();
                    cb.MaNV = node["ma"].InnerText;
                    cb.TenNV = node["ten"].InnerText;
                    cb.NamVaoLam = int.Parse(node["nvl"].InnerText);
                    cb.HeSoLuong = double.Parse(node["hsl"].InnerText);
                    cb.SoNgayNghi = int.Parse(node["snn"].InnerText);
                    cb.ChucVu = node["cv"].InnerText;
                    cb.HeSoPhuCap = double.Parse(node["hspccv"].InnerText);
                    cb.PhongBan = node["phongban"].InnerText;
                    ListNhanVien.Add(cb);
                }
            }
        }
        public void xuatCty()
        {
            Console.WriteLine($"Tên công ty: {TenCTY}\nĐịa chỉ: {DiaChi}\nSố điện thoại: {SoDienThoai}");
            foreach (NhanVien nv in ListNhanVien)
            {
                nv.xuatTT();
                Console.WriteLine();
            }
        }

        public double maxLuong()
        {
            return ListNhanVien.Max(t => t.tinhLuong());
        }

        public NhanVien nhanVienMaxLuong()
        {
            return ListNhanVien.FirstOrDefault(t => t.tinhLuong() == maxLuong());
        }
        public void inDSCbo()
        {
            foreach(NhanVien nv in listNhanVien)
            {
                if (nv is CanBo)
                    nv.xuatTT();
            }
        }
    }
}
