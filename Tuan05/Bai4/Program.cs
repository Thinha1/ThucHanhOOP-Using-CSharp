namespace Bai4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DSHoaDon ds = new DSHoaDon();
            ds.docFile("D:\\Documents\\BaiTapOOP\\BTapThucHanh\\ThucHanhOOP-Using-CSharp\\Bai4\\DSHoaDon.xml");
            ds.xuat();
            Console.WriteLine();
            Console.WriteLine("HÓA ĐƠN GIÁ CAO NHẤT");
            HoaDon max = ds.inGiaCaoNhat();
            max.xuat();
            Console.WriteLine();
            Console.WriteLine("DANH SÁCH VÃNG LAI");
            ds.xuatVangLai();
            Console.WriteLine($"Số lượng VIP và thân thiết: {ds.demVIPVaThanThiet()}");
            Console.WriteLine();
            Console.WriteLine("DANH SÁCH TĂNG DẦN");
            ds.sapXepTangDan();
        }
    }
}
