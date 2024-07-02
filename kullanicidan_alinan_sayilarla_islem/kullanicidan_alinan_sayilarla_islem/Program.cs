using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kullanicidan_alinan_sayilarla_islem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Kullanicidan 10 tane int değer alan ve şunları yapan programı kodlayınız...
            // 1- Kaç adet tek,çift eleman olduğunu
            // 2- Çift değerlerin toplamını , tek değerlerin toplamını
            // 3- Son olarak kontrol yapsın çift değ top büyükse çift yazsın tek değ top büyükse tek

            int[] sayilar = new int[10];

            int tekAdetToplam = 0;
            int ciftAdetToplam = 0;

            int tekSayilarinToplami = 0;
            int ciftSayilarinToplami = 0;

            int kullaniciDeger;

            for(int i = 0; i < sayilar.Length; i++)
            {
                Console.Write((i + 0) + ". İndex değerini giriniz :");
                kullaniciDeger = int.Parse(Console.ReadLine());

                sayilar[i] = kullaniciDeger; // Dizimin içini kullanicidan aldiğim değerlerle doldurdum
            }
            for (int j = 0; j < sayilar.Length; j++)
            {
                if (sayilar[j] % 2 == 0)
                {
                    ciftAdetToplam++;
                    ciftSayilarinToplami += sayilar[j];
                }
                else 
                {
                    tekAdetToplam++;
                    tekSayilarinToplami += sayilar[j];
                }
            }
            if (ciftSayilarinToplami > tekSayilarinToplami)
            {
                Console.WriteLine("Çift sayıların toplamı tek sayıların toplamından büyüktür");
            }
            Console.WriteLine("**********************************");
            Console.WriteLine("Çift sayilarin Toplamı: " + ciftSayilarinToplami);
            Console.WriteLine("Çift sayilarin adedi: " + ciftAdetToplam);
            Console.WriteLine("**********************************");
            Console.WriteLine("Tek sayilarin toplamı: " + tekSayilarinToplami);
            Console.WriteLine("Tek sayıların adedi: " + tekAdetToplam);
            Console.ReadLine();
        }
        
    }
}
