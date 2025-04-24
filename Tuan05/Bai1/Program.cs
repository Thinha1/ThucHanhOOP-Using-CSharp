using System.Text;

namespace Bai1Tuan5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.Unicode;
            Console.OutputEncoding = Encoding.Unicode;
            DSNV dSNV = new DSNV();
            dSNV.docFile("");
            dSNV.xuatDS();
        }
    }
}
