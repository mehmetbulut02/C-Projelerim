using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cift_tek_metot
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Kullanıcıdan alınan sayı tek mi çift mi oldugunu bulan metot
            Console.Write("Bir sayı giriniz: ");
            int girilenSayi = int.Parse(Console.ReadLine());
            tekmiCiftmi(girilenSayi);
        }

        static void tekmiCiftmi(int sayi)
        {
            if (sayi % 2 == 0)
            {
                Console.WriteLine("Sayı Çifttir");
            }
            else
            {
                Console.WriteLine("Sayı Tektir");
            }
            Console.ReadLine();
        }
    }
}
