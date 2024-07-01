using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace for_dongusu
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 1 den 10'a kadar olan sayıları alt alta ekrana yazdıran program
            /*
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine(i);
            }
            Console.ReadLine();
            */
            // 10a kadar olan çift sayılar 

            for (int i = 0; i<= 10; i += 2)
            {
                Console.WriteLine(i);
            }
            Console.ReadLine();
        }
    }
}
