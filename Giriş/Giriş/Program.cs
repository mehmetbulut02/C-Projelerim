using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Giriş
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World");
            Console.WriteLine("Yazdırma");
            Console.Write("Deneme");
            Console.WriteLine(1); //Line kullanmadığımız zaman değerler yan yana yazılır
            //byte b = 5; //byte 0-255
            float f = 34.56f; //float veri tipinde f değişkeni kullanmamız gerekir
            //char c = 'a'; // char veri tipinde tek tırnak kullanılır 
            String s = "Merhaba";
            Console.WriteLine(f);
            bool kontrol = true;
            bool kontrol2 = false;
            bool sonuc = 10 > 5;
            object a = true;
            object b = 2;
            object c = "Merhaba";
            object d = 3.12;
            object e = false;
            // Object tüm veri tipleri için kullanılabilir
            /*
            //Console.WriteLine(sonuc);
            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(c);
            Console.WriteLine(d);
            Console.ReadLine(); */

            Console.WriteLine("Lütfen adınızı giriniz:");
            string isim = Console.ReadLine();

            Console.WriteLine("Soyisminizi giriniz:");
            string soyisim = Console.ReadLine();

            Console.WriteLine("Kullanıcı ismi:" + isim);
            Console.WriteLine("Kullanıcının soyismi:" +soyisim);
            Console.ReadLine();

        }
    }
}
