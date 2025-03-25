using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2001230930_DangAnhThinh_Buoi02_Bai2
{
    internal class CongTy
    {
        private string tenCT;
        private string diaChi;
        private List<NhanVien> lstNhanVien;

        public string TenCT
        {
            get { return tenCT; }
            set { tenCT = value; }
        }
        public string DiaChi
        {
            get { return diaChi; }
            set { diaChi = value; }
        }

        public List<NhanVien> LstNhanVien
        {
            get { return lstNhanVien; }
            set { lstNhanVien = value; }
        }

        public CongTy()
        {
            TenCT = string.Empty;
            DiaChi = string.Empty;
            LstNhanVien = new List<NhanVien>(); 
        }

        public CongTy(string tenct, string diachi, List<NhanVien> lstnhanvien)
        {
            TenCT = tenct;
            DiaChi = diachi;
            LstNhanVien = lstnhanvien;
        }

        
        public void nhapDSNV()
        {
            Console.Write("Nhap ten cong ty: ");
            TenCT = Console.ReadLine();
            Console.Write("Nhap dia chi: ");
            DiaChi = Console.ReadLine();
            Console.WriteLine("---Nhap danh sach nhan vien---");
            Console.Write("Nhap so luong nhan vien: ");
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"Nhap nhan vien thu {i + 1}");
                NhanVien nv = new NhanVien();
                nv.nhapTT();
                LstNhanVien.Add(nv);
            }
        }
        public void xuatDSNV()
        {
 
            Console.WriteLine($"Ten cong ty: {TenCT}\nDia chi: {DiaChi}");
            Console.WriteLine("---Danh sach nhan vien---");
            for (int i = 0; i < LstNhanVien.Count; i++)
            {
                Console.WriteLine($"Nhan vien thu {i + 1}");
                NhanVien nv = LstNhanVien[i];
                nv.xuatTT();
            }
        }
    }
}
