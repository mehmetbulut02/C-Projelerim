using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tur_donusumleri
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            int a = 100;

            byte b = (byte)a;    // bu sekilde tur donusumu yapılıyor fakat byte veri tipi 250 ye kadar oldugu icin bu değer sonrası veri kaybı oluyor
            Console.WriteLine(b.GetType());   // veri tipini yazdırıyoruz
            Console.WriteLine(b);

            string sayi1 = "1";
            string sayi2 = "2";
            // int sayi1_1 = int.Parse(sayi1); // stringten integera cevirmede parse komutunu kullanıyoruz
            // int sayi2_1 = int.Parse(sayi2);
            // Console.WriteLine(sayi2_1 + sayi1_1);

            int sayi1_10 = Convert.ToInt32(sayi1); // diger yontem ise bu metodtur
            int sayi2_10 = Convert.ToInt32(sayi2);
            Console.WriteLine(sayi1_10 + sayi2_10);
            Console.ReadLine();
            */
            /*
            int sayi1 = 5;
            int sayi2 = 10;

            string a = sayi1.ToString(); // integer dan stringe cevirmek icin bu ifadeyi kullanıyoruz
            string b = sayi2.ToString();
            Console.WriteLine(b+a);
            Console.ReadLine();
            */
            /* Doubledan integera çevirme
            double sayi = 5.22;
            int a = Convert.ToInt32(sayi);
            Console.WriteLine(a);
            Console.WriteLine(sayi.GetType());
            Console.ReadLine();

            */
            // kullanıcıdan alınan degerler string veri tipindedir yani iki kullanıcının yasini toplamak istersek 18 ve 22 olsun. ceviri
            // yapmazsak 1822 cıkar bu yuzden integera cevirmemiz lazım
            Console.WriteLine("Lütfen yaşınızı giriniz");

            string kullanıcı_yas = Console.ReadLine();

            int kullanıcı_yasInt = int.Parse(kullanıcı_yas);
            int kullanıcı_yasInt2 = Convert.ToInt32(kullanıcı_yas);

            Console.WriteLine(kullanıcı_yasInt);
            Console.WriteLine(kullanıcı_yasInt2);
            Console.ReadLine();
        }
    }
}
