using System.Text;

namespace Bai2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.Unicode;
            Console.OutputEncoding = Encoding.Unicode;
            HangHoa hh = new NuocGiaiKhat();
            hh.nhap();
            hh.xuat();
        }
    }
}
