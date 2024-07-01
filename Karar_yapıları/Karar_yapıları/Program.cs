using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Karar_yapıları
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            int not = 75;
            if (not >= 50) {
                Console.WriteLine("Başarılı");
                    }
            else {
                Console.WriteLine("Başarısız");
                    }
            Console.ReadLine();
            */
            Console.WriteLine("Notunuzu giriniz");
            int not = Convert.ToInt32(Console.ReadLine());
            if (not >= 50)
            {
                Console.WriteLine("Başarılı");
            }
            else
            {
                Console.WriteLine("Başarısız");
            }
            Console.ReadLine();
        }
    }
}
