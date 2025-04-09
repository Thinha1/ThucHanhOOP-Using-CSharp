using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace _2001230930_DangAnhThinh_THLTHDTBuoi04
{
    internal class CanBo:NhanVien
    {
        string chucVu;
        string phongBan;
        double heSoPhuCap;
        public string ChucVu { get => chucVu; 
            set 
            {
                if(value == "Giám đốc" || value == "Phó giám đốc" || value == "Trưởng phòng" || value == "Phó trưởng phòng")
                chucVu = value; 
            } 
        }

        public string PhongBan { get => phongBan; set => phongBan = value; }
        public double HeSoPhuCap { get => heSoPhuCap; set => heSoPhuCap = value; }

        public CanBo():base()
        {
            ChucVu = "Trưởng phòng";
            PhongBan = "Hành chính";
            HeSoPhuCap = 5.0;
        }
        public CanBo(string ma, string ten, double hsl, string chucvu, double hspc):base(ma, ten, hsl)
        {
            ChucVu = chucvu;
            HeSoPhuCap= hspc;
            PhongBan = "Hành chính";
            SoNgayNghi = 1;
            NamVaoLam = DateTime.Now.Year;
        }

        public CanBo(string ma, string ten, int nvl, double hsl, int songaynghi, string chucvu, string phongban, double hspc):base(ma, ten, nvl, hsl, songaynghi)
        {
            ChucVu= chucvu;
            HeSoPhuCap= hspc;
            PhongBan = phongban;
        }
        public override string xepLoaiThiDua()
        {
            return "A";
        }
        public double tinhPhuCapLanhDao()
        {
            return HeSoPhuCap * luongCB;
        }


        public override double tinhLuong()
        {
            return base.tinhLuong() + tinhPhuCapLanhDao();
        }
        public override void xuatTT()
        {
            base.xuatTT();
            Console.WriteLine($"Chức vụ: {ChucVu}\nPhòng ban: {PhongBan}\nHệ số phụ cấp: {HeSoPhuCap}\nPhụ cấp lãnh đạo: {tinhPhuCapLanhDao()}");
        }
   
    }
}
