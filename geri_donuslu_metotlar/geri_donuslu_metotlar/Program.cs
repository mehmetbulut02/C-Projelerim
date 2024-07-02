using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace geri_donuslu_metotlar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Paramatre Alan - Geriye Değer Döndüren Metot Tanımlama
            // return anahtar kelimesi
            // metot sonu

            int DonenDeger = toplamaYap(6, 7);

            if (DonenDeger > 10)
            {
                Console.WriteLine("Değer 10'dan büyüktür");
            }
            else 
            { 
                Console.WriteLine("Değer 10'dan küçüktür");
            }
            Console.ReadLine();
        }

        static int toplamaYap(int sayi1 , int sayi2)
        {
            int sonuc = sayi1 + sayi2;
            return sonuc;
        }
    }
}
