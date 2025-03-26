using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai6
{
    class Program
    {
        static void Main(string[] args)
        {
            //ChiTietDonHang ctdh1 = new ChiTietDonHang();
            //ctdh1.nhapCTDH();
            //ctdh1.xuatCTDH();
            HoaDon hd1 = new HoaDon();
            hd1.nhapTTHoaDon();
            hd1.xuatTTHoaDon();
            HoaDon sort = hd1.sapXep();
            sort.xuatTTHoaDon();
            HoaDon max = hd1.xuatMax();
            max.xuatTTHoaDon();
        }
        
        
    }
}
