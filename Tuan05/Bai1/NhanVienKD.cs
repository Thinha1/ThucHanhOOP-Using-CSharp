using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai1Tuan5
{
    internal class NhanVienKD : NhanVien
    {
        private double doanhSoToiThieu;
        private double doanhSoThucTe;

        public double DoanhSoToiThieu { get => doanhSoToiThieu; set => doanhSoToiThieu = value; }
        public double DoanhSoThucTe { get => doanhSoThucTe; set => doanhSoThucTe = value; }

        public NhanVienKD():base()
        {
            
        }

        public NhanVienKD(string ma, string ten, int ns, string gt, double hs, int nvl, double dstoithieu, double dsthucte) :base(ma, ten, ns, gt, hs, nvl)
        {
            DoanhSoToiThieu = dstoithieu;
            DoanhSoThucTe = dsthucte;
        }

        public override double tinhLuong()
        {
            return HeSoLuong * luongCoBan + tinhHoaHong();
        }

        public override string xepLoaiThiDua()
        {
            if (DoanhSoThucTe >= DoanhSoToiThieu * 2)
                return "A";
            else if (DoanhSoThucTe >= DoanhSoToiThieu && DoanhSoThucTe < (DoanhSoToiThieu * 2))
                return "B";
            else if(DoanhSoThucTe < DoanhSoToiThieu && DoanhSoThucTe > (0.5 * DoanhSoToiThieu))
                return "C";
            else
                return "D";
        }

        public double tinhHoaHong()
        {
            if(DoanhSoThucTe > DoanhSoToiThieu)
                return 0.15 * (DoanhSoThucTe - DoanhSoToiThieu);
            return 0;
        }

        public override void xuat()
        {
            base.xuat();
            Console.WriteLine($"Doanh thu tối thiểu: {DoanhSoToiThieu}\nDoanh số thực tế: {DoanhSoThucTe}\nHoa hồng: {tinhHoaHong()}");
        }
    }
}
