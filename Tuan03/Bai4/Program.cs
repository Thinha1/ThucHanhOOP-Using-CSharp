using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai4
{
    class Program
    {
        static void Main(string[] args) {
            //ThiSinh ts1 = new ThiSinh();
            //ts1.nhapTTThiSinh();
            //ts1.xuatTTThiSinh();
            DSThiSinh ds = new DSThiSinh();
            ds.nhapDSTS();
            ds.inDSTS();
            ds.inDSTSDau();
            ds.inTTDuaTrenMa("0");
            Console.WriteLine($"Tổng thí sinh đậu: {ds.tongTSDau()}\nTổng thí sinh rớt: {ds.tongTSRot()}");
            DSThiSinh lstSort = ds.sapXepGiamDanTheoDiem();
            lstSort.inDSTS();
        }
    }
}
