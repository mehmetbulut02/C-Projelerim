using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parametreli_metotlar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Parametre Alan - Geriye Değer Döndürmeyen metot yazma
            //  toplamaYap(8, 9);
            //carpmaYap(7, 8, 2);
            IsimSoyIsimYazdir("Mehmet", "Bulut");
            Console.ReadLine();
        }
        static void toplamaYap(int sayi1 , int sayi2)
        {
            Console.WriteLine("Gönderilen Sayilarin Toplamı :" + (sayi1 + sayi2));
        }
        static void carpmaYap(int sayi1, int sayi2, int sayi3)
        {
            Console.WriteLine("3 sayinin çarpimi :"+ (sayi1*sayi2*sayi3));
        }
        static void IsimSoyIsimYazdir(string isim, string soyisim)
        {
            Console.WriteLine("İsim ve Soyisim: "+ isim+" "+soyisim);
        }
        

    }
}
