using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metot_ornek
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Kullanıcıdan aldığımız sayinin karesini alalım eğer karesi 25'ten büyükse;
            // Karesi 25'ten büyüktür
            // Değilse 25'ten küçüktür

            Console.WriteLine("Bir sayi giriniz : ");
            int sayi = int.Parse(Console.ReadLine());
            int KareDeger = kareAl(sayi);
            if (KareDeger > 25)
            {
                Console.WriteLine("Karesi 25'ten büyüktür");
            }
            else
            { 
                Console.WriteLine("Karesi 25'ten küçüktür");
            }
            Console.ReadLine();
        }
        static int kareAl(int a)
        {
            return a * a;
        }
    }
}
