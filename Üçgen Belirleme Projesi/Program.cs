using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Diagnostics.Eventing.Reader;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace YazılımTasarım
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("A değerini girin");
            int a = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("B değerini girin");
            int b = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("C değerini girin");
            int c = Convert.ToInt16(Console.ReadLine());

            int toplam1 = a + b;
            int toplam2 = toplam1 + c;

            if (toplam2 == 180)
            {
                Console.WriteLine("Bu bir üçgendir.");
            }
            else if (toplam2 > 180)
            {
                Console.WriteLine("Bu bir üçgen değildir.");
            }
            else if (toplam2 < 180)
            {
                Console.WriteLine("Bu bir üçgen değildir");
            }

            Console.ReadLine();













        }
    }
}
