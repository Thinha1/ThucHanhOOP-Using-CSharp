using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace _2001230930_DangAnhThinh_Buoi02_Bai2
{
    internal class DSNhanVien
    {
        List<NhanVien> listNhanVien;
        public List<NhanVien> DanhSachNhanVien
        {
            get
            {
                return listNhanVien;
            }
            set
            {
                listNhanVien = value;
            }
        }

        public DSNhanVien()
        {
            DanhSachNhanVien = new List<NhanVien>();
        }

        public DSNhanVien(List<NhanVien> list)
        {
            listNhanVien = list;
        }


        public void nhapDSNV()
        {
            Console.WriteLine("---Nhap danh sach nhan vien---");
            Console.Write("Nhap so luong nhan vien: ");
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"Nhap nhan vien thu {i + 1}");
                NhanVien nv = new NhanVien();
                nv.nhapTT();
                DanhSachNhanVien.Add(nv);
            }
        }

        public void docFile(string file)
        {
            XmlDocument doc = new XmlDocument();
            doc.Load(file);
            XmlNodeList nodeList = doc.SelectNodes("/DSNhanVien/NhanVien");
            foreach (XmlNode node in nodeList)
            {
                NhanVien nv = new NhanVien();
                nv.MaNV = node["MaNV"].InnerText;
                nv.HoTen = node["HoTen"].InnerText;
                nv.HeSoLuong = double.Parse(node["HeSoLuong"].InnerText);
                nv.NamVaoLam = int.Parse(node["NamVaoLam"].InnerText);
                DanhSachNhanVien.Add((nv));
            }
        }
        public void xuatDSNV()
        {
            Console.WriteLine("---Danh sach nhan vien---");
            for (int i = 0; i < listNhanVien.Count; i++)
            {
                Console.WriteLine($"Nhan vien thu {i + 1}");
                NhanVien nv = listNhanVien[i];
                nv.xuatTT();
            }
        }

        public double tinhTongLuong()
        {
            return DanhSachNhanVien.Sum(t => t.tinhLuong());
        }
        public double timLuongCaoNhat()
        {
            return listNhanVien.Max(t => t.tinhLuong());
        }

        public DSNhanVien timDSNhanVienLuongCaoNhat()
        {
            double luongMax = timLuongCaoNhat();
            DSNhanVien ds1 = new DSNhanVien();
            ds1.DanhSachNhanVien.Where(t => t.tinhLuong() == luongMax).ToList();
            return ds1;
        }

        public NhanVien timNVMaxLuong()
        {
            double maxLuong = timLuongCaoNhat();
            NhanVien nv1 = DanhSachNhanVien.FirstOrDefault(t=> t.tinhLuong() == maxLuong);
            return nv1;
        }
        public DSNhanVien sapXep()
        {
            DSNhanVien ds1 = new DSNhanVien();
            ds1.DanhSachNhanVien = DanhSachNhanVien.OrderBy(t => t.NamVaoLam).ToList();
            return ds1;
        }
        
        public int demSoNhanVienHeSoLuong()
        {
            int count = 0;
            count += DanhSachNhanVien.Count(t => t.HeSoLuong > 3);
            return count;
        }
        public DSNhanVien sapXepGiamDan()
        {
            DSNhanVien ds1 = new DSNhanVien();
            ds1.DanhSachNhanVien = DanhSachNhanVien.OrderByDescending(t => t.HeSoLuong).ToList();
            return ds1;
        }
    }
}
