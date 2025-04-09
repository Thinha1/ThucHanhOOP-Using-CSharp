namespace Bai4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            NhanVien nv = new CBoLanhDao();
            nv.nhap();
            nv.xuat();
        }
    }
}
