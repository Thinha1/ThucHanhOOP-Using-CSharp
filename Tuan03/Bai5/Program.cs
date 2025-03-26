using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai5
{
    class Program
    {
        static void Main(string[] args)
        {
            //NhanVien nv1 = new NhanVien();
            //nv1.nhapTT();
            //nv1.xuatTT();
            DSNhanVien ds1 = new DSNhanVien();
            ds1.nhapDSNV();
            ds1.inTheoHeSoThiDua();
            ds1.inDSNV();
            ds1.inTheoPhongBan();
            ds1.inTheoChucVu();
            ds1.inNhanVienKhongPhaiLanhDao();
            ds1.inNhanVienTheoHeSoVaPhongBan();
        }
        
    }
}
