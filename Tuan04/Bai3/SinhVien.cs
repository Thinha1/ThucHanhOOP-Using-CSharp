using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai3
{
    internal class SinhVien:Nguoi
    {
        string heDaoTao;
        int tongSoTC;

        public string HeDaoTao { get => heDaoTao; 
            set 
            {
                if (value == "Đại học" || value == "Cao đẳng" || value == "Cao đẳng nghề")
                    heDaoTao = value;
                else heDaoTao = "Đại học";
            } 
        }

        public int TongSoTC { get
            { 
                if(HeDaoTao == "Đại học")
                    return 150;
                else if(HeDaoTao == "Cao đẳng")
                    return 100;
                else return 130;
            } 
        }

        public override void nhap()
        {
            base.nhap();
            Console.Write("Nhập hệ đào tạo: ");
            HeDaoTao = Console.ReadLine();
        }

        public double tinhHocPhiTinChi()
        {
            if (HeDaoTao == "Đại học")
                return 200000;
            else if (HeDaoTao == "Cao đẳng")
                return 150000;
            else return 120000;
        }

        public double tinhTongHocPhi()
        {
            return TongSoTC * tinhHocPhiTinChi();
        }

        public override void xuat()
        {
            base.xuat();
            Console.WriteLine($"Hệ đào tạo: {HeDaoTao}\nTổng số tín chỉ: {TongSoTC}");
        }
    }
}
