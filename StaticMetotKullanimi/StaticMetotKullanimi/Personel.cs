using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticMetotKullanimi
{
    public class Personel
    {
        public static void isimSoyisimyazdır()
        {
            System.Console.WriteLine("Mehmet Bulut");
        }

        public static void sayilariTopla(int sayi1, int sayi2)
        {
            Console.WriteLine("İki sayinin toplami : " + (sayi1 + sayi2));
        }
    }
}
