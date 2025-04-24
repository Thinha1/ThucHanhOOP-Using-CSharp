namespace Bai2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CongTy cty1 = new CongTy();
            cty1.docFile("D:\\Documents\\BaiTapOOP\\BTapThucHanh\\ThucHanhOOP-Using-CSharp\\Bai2\\DSCty.xml");
            cty1.xuat();
            Console.WriteLine();
            HoaDon hdMax = cty1.muaNhieuNhat();
            hdMax.xuat();
            CongTy khCTy = new CongTy();
            Console.WriteLine();
            cty1.xuatDaiLy();
            Console.WriteLine();
            khCTy.ListHD = cty1.xuatHoaDonMaX("KH006");
            khCTy.xuat();
            cty1.ListHD = cty1.sapXep();
            cty1.xuat();
        }
    }
}
