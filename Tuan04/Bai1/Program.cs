using System.Text;

namespace _2001230930_DangAnhThinh_THLTHDTBuoi04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.Unicode;
            Console.OutputEncoding = Encoding.Unicode;
            CongTyABC cty = new CongTyABC();
            cty.docFile("E:\\LuuDuLieuSinhVien\\DangAnhThinh_2001230930\\2001230930_DangAnhThinh_THLTHDTBuoi04\\2001230930_DangAnhThinh_THLTHDTBuoi04\\DSCTY.xml");
            cty.xuatCty();
            Console.WriteLine(cty.maxLuong());
            Console.WriteLine();
            NhanVien max = cty.nhanVienMaxLuong();
            max.xuatTT();
            Console.WriteLine();
            cty.inDSCbo();
        }
    }
}
