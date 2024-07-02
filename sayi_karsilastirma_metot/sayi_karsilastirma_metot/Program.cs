using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sayi_karsilastirma_metot
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Kullanıcıdan 2 tane sayi alalim hangisi büyükse ; büyük olan sayıyı ekrana yazdıralım
            Console.Write("Birinci Sayiyi Giriniz : ");
            int sayi1 = int.Parse(Console.ReadLine());

            Console.Write("İkinci sayiyi giriniz : ");
            int sayi2 = int.Parse(Console.ReadLine());

            kontrolEt(sayi1, sayi2 );
            Console.ReadLine();
        }
        static void kontrolEt(int a, int b)
        {
            if (a > b)
            {
                Console.WriteLine("1. sayi 2.sayidan büyüktür");
            }
            else if (a == b)
            {
                Console.WriteLine("İki sayının değeri eşittir");
            }
            else
            {
                Console.WriteLine("2. sayi 1.sayidan büyüktür");
            }
        }
        
    }
}
