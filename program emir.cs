using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, toplam;
            Console.Write("ilk değeri giriniz:");
            a=Convert.ToInt16(Console.ReadLine());
            Console.Write("ikinci değeri gir");
            b = Convert.ToInt16(Console.ReadLine());
            toplam = a + b;
            Console.WriteLine();
            Console.WriteLine("{0} ve {1}sayılarının toplamı: {2}",a,b,(a+b));
            Console.ReadKey();


        }
    }
}
