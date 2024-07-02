using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace girilen_sayi_dizide_var_mi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Kullanıcının girdiği sayı dizinin içinde var mı? kontrol eden varsa kac
            // tane olduğunu söyleyen yoksa da yoktur diye uyaran program
            int[] sayilar = { 10, 10, 20, 30, 20, 30, 40, 50, 40, 50, 70, 55, 65, 70, 55, 65, 5, 20, 35, 65, 5, 20, 35, 65, 80 }; 
            int adet = 0;
            int sayi;
            Console.Write("Lütfen bir sayı giriniz: ");
            sayi = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < sayilar.Length; i++)
            {
                if (sayi == sayilar[i])
                {
                    adet++;
                }
            }
            if (adet == 0)
            {
                Console.WriteLine("Girdiğiniz Değer Dizide Bulunamadı..");
            }
            else
            {
                Console.WriteLine("Girdiğiniz Sayi Dizide Bulundu...");
                Console.WriteLine("Adet: " + adet);
            }
            Console.ReadLine();
        }
    }
}
