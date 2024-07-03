using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ogrenci_Uygulaması
{
    class Program
    {
        static void Main(string[] args)
        {
            bool kontrol = true;
            Öğrenci öğrenci1 = new Öğrenci(1, "Mehmet", "Bulut", 50, 40, 73, "İBU");

            Console.WriteLine("Uygulamamıza hoşgeldiniz... Yapmak istediğiniz işlemi seçiniz");
            

            while (kontrol)
            {
                islemleriGoster();
                string secim = Console.ReadLine();

                switch (secim)
                {
                    case "1":
                        öğrenci1.ogrenciBilgileriGoster();
                        break;
                    case "2":
                        double ogrenciOrtalama = öğrenci1.ogrenciNotuBul();
                        break;
                    case "3":
                        öğrenci1.okulGetir();
                        break;
                    case "4":
                        kontrol = false;
                        break;

                }
            }
        }
        static void islemleriGoster()
        {
            Console.WriteLine("1- Öğrenci Bilgileri Göster");
            Console.WriteLine("2- Öğrenci Ortalamasını Göster");
            Console.WriteLine("3- Öğrenci Okulunu Göster");
            Console.WriteLine("4- Çıkış Yap");
        }
    }
}
