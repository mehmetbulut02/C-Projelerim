using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mini_atm_switch_case
{
    internal class Program
    {
        static void Main(string[] args)
        {
        int bakiye = 700;
            Console.WriteLine("Atm ye hoşgeldiniz");
            Console.WriteLine("Lütfen bir işlem seçiniz");
            Console.WriteLine("1- Bakiye görünyüle");
            Console.WriteLine("2- Para çek");
            Console.WriteLine("3- Para yatır");
            Console.WriteLine("4- Çıkış yap");

            string secim = Console.ReadLine();

            switch (secim)
            {
                case "1":
                    Console.WriteLine("Bakiyeniz: " + bakiye);
                    break;
                case "2":
                    Console.WriteLine("Çekmek istediğniz tutarı giriniz");
                    int cekilecek_tutar = Convert.ToInt32(Console.ReadLine());
                    if (cekilecek_tutar > bakiye)
                    {
                        Console.WriteLine("Bakiyenizden fazla para çekemezsiniz");
                        Console.ReadLine();
                    }
                    else
                    {
                        Console.WriteLine("Kalan Bakiyeniz: " + (bakiye - cekilecek_tutar));
                    }
                    break;
                case "3":
                    Console.WriteLine("Yatırmak istediğiniz tutarı giriniz");
                    int yatirilacak_tutar = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Yeni Bakiyeniz: " + (yatirilacak_tutar + bakiye));
                    break;
                case "4":
                    Console.WriteLine("Çıkış Yapılıyor..");
                    Console.WriteLine("İyi Günler");
                    break;
                default:
                    Console.WriteLine("Lütfen geçerli bir değer giriniz");
                    break;
            }
            Console.ReadLine ();
        }
    }
}
