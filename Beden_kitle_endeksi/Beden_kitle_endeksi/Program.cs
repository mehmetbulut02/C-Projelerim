using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Beden_kitle_endeksi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Kilonuzu giriniz");
            int kilo = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Boyunuzu giriniz");
            double boy = Convert.ToDouble(Console.ReadLine());

            double bke = kilo / (boy *  boy);

            if (bke < 18)
            {
                Console.WriteLine("Zayıfsınız");
            }
            else if (bke > 18 && bke < 25)
            {
                Console.WriteLine("Normalsiniz");
            }
            else if(bke > 25)
            {
                Console.WriteLine("Obessiniz");
            }
            Console.ReadLine();
        }
    }
}
