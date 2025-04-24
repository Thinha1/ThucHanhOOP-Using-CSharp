using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Bai1Tuan5
{
    internal class DSNV
    {
        string tenCT;
        List<NhanVien> listNV;

        public List<NhanVien> ListNV { get => listNV; set => listNV = value; }
        public string TenCT { get => tenCT; set => tenCT = value; }

        public DSNV()
        {
            ListNV = new List<NhanVien>();
        }
        public void docFile(string filename)
        {
            XmlDocument document = new XmlDocument();
            document.Load(filename);
            XmlNodeList nodeList = document.SelectNodes("CongTy/DSNhanVien/NhanVien");
            TenCT = document.SelectSingleNode("CongTy/TenCT").InnerText;
            foreach(XmlNode node in nodeList)
            {
                NhanVien nv;
                int loai = int.Parse(node.Attributes["Loai"].Value);
                string maNV = node["MaNhanVien"].InnerText;
                string hoTen = node["HoTen"].InnerText;
                int namSinh = int.Parse(node["NamSinh"].InnerText);
                string gioiTinh = node["GioiTinh"].InnerText;
                double hsLuong = double.Parse(node["HeSoLuong"].InnerText);
                int namVaoLam = int.Parse(node["NamVaoLam"].InnerText);
                if (loai == 1)
                {
                    int soNN = int.Parse(node["SoNgayNghi"].InnerText);
                    nv = new NhanVienSX(maNV, hoTen, namSinh, gioiTinh, hsLuong, namVaoLam, soNN);
                }
                else if (loai == 2)
                {
                    double dsToiThieu = double.Parse(node["DSToiThieu"].InnerText);
                    double dsThucTe = double.Parse(node["DSThucTe"].InnerText);
                    nv = new NhanVienKD(maNV, hoTen, namSinh, gioiTinh, hsLuong, namVaoLam, dsToiThieu, dsThucTe);
                }
                else
                {
                    string chucVu = node["ChucVu"].InnerText;
                    double hsChucVu = double.Parse(node["HeSoChucVu"].InnerText);
                    nv = new CBoQuanLy(maNV, hoTen, namSinh, gioiTinh, hsLuong, namVaoLam, chucVu, hsChucVu);
                }
                ListNV.Add(nv);
            }
        }

        public void xuatDS()
        {
            Console.WriteLine("Tên công ty: " + TenCT);
            foreach (NhanVien nv in ListNV)
            {
                nv.xuat();
                Console.WriteLine();
            }
            Console.WriteLine($"Tổng thu nhập: {tinhTongThuNhap()}");
        }

        public double tinhTongThuNhap()
        {
            return ListNV.Sum(t => t.tinhThuNhap());
        }
        public int demSLNV()
        {
            return ListNV.Count;
        }
    }
}
