using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace while_dongusu
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 1'den 10'a kadar sayılar ekrana yazdırın
            // 100'den 0'a kadar olan sayıların çift olanlarını büyükten küçüğe yazdırın
            /*
            int a = 1;

            while (a <= 10)
            {
                Console.WriteLine(a);
                a++;
            }
            Console.ReadLine();
            */
            /*
            int a = 100;
            while (a >= 0)
            {
                Console.WriteLine(a);
                a = a - 2;
            }
            Console.ReadLine();
            */

            int a = 1;
            int toplam = 0;

            do
            {
                toplam += a;
                a++;
            } while (a<=100);
            Console.WriteLine("1'den 100'e kadar olan sayıların toplamı:"+toplam);
            Console.ReadLine();
            }


    }
}
