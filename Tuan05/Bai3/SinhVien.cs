using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Bai3
{
    internal class SinhVien
    {
        string maSV;
        string hoTen;
        List<MonHoc> dsMonHoc;

        public string MaSV { get => maSV; set => maSV = value; }
        public string HoTen { get => hoTen; set => hoTen = value; }
        internal List<MonHoc> DsMonHoc { get => dsMonHoc; set => dsMonHoc = value; }

        public SinhVien()
        {
            DsMonHoc = new List<MonHoc>();
        }

        public void docFile(string filename)
        {
            XmlDocument doc = new XmlDocument();
            doc.Load(filename);
            MaSV = doc.SelectSingleNode("SinhVien/MaSV").InnerText;
            HoTen = doc.SelectSingleNode("SinhVien/TenSV").InnerText;
            XmlNodeList list = doc.SelectNodes("SinhVien/DSMH/MH");
            foreach (XmlNode node in list)
            {
                MonHoc mh;
                int loai = int.Parse(node["Loai"].InnerText);
                string mamon = node["Ma"].InnerText;
                string tenmon = node["Ten"].InnerText;
                int sotc = int.Parse(node["SoTC"].InnerText);
                string khoa = node["KhoaQL"].InnerText;
                if (loai == 1)
                {
                    double diemtl = double.Parse(node["DiemTL"].InnerText);
                    double diemgk = double.Parse(node["DiemGK"].InnerText);
                    double diemck = double.Parse(node["DiemCK"].InnerText);
                    mh = new MonLyThuyet(mamon, tenmon, sotc, khoa, diemtl, diemgk, diemck);
                }
                else if (loai == 2)
                {
                    double diemkt1 = double.Parse(node["DiemKT1"].InnerText);
                    double diemkt2 = double.Parse(node["DiemKT2"].InnerText);
                    double diemkt3 = double.Parse(node["DiemKT3"].InnerText);
                    double diemkt4 = double.Parse(node["DiemKT4"].InnerText);
                    mh = new MonThucHanh(mamon, tenmon, sotc, khoa, diemkt1, diemkt2, diemkt3, diemkt4);
                }
                else
                {
                    double diemgvhd = double.Parse(node["DiemGVHD"].InnerText);
                    double diemgvpb = double.Parse(node["DiemGVPB"].InnerText);
                    mh = new MonDoAn(mamon, tenmon, sotc, khoa, diemgvhd, diemgvpb);
                }
                DsMonHoc.Add(mh);
            }
        }
        public void xuat()
        {
            Console.WriteLine($"Mã sinh viên: {MaSV}\nHọ tên: {HoTen}");
            Console.WriteLine("DANH SÁCH MÔN HỌC");
            Console.WriteLine();
            foreach (MonHoc mh in DsMonHoc)
            {
                Console.WriteLine($"Môn học thứ {(DsMonHoc.IndexOf(mh) + 1)}");
                mh.xuat();
                Console.WriteLine();
            }
        }
        
    }
}
