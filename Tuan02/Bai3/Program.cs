using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai3
{
    class Program
    { 
        static void Main(String[] args) {
            //MonHoc mh1 = new MonHoc("MH001", "Lập trình .Net", 8.5f, 9.4f, 10f);
            //mh1.xuatTTMonHoc();
            HocSinh hs1 = new HocSinh();
            hs1.nhapTTHS();
            hs1.xuatTTHS();
            hs1.inDSMonDat(hs1);
        }
    }
}
