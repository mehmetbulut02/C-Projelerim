using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticYapiciMetotKullanimi
{
    public class Kullanici
    {
        private int kullaniciID { get; set; }
        private int isim { get; set; }
        private int soyisim { get; set; }
        private static int maas { get; set; }

        static Kullanici()
        {
            maas = 2500;
        }
        public Kullanici(int kullaniciid , string isim , string soyisim)
        {
            kullaniciID = kullaniciid;
            isim = isim;
            soyisim = soyisim;
        }
        public void bilgileriGoster()
        {
            Console.WriteLine("Kullanici Bilgileri");
            Console.WriteLine("Id : " + kullaniciID);
            Console.WriteLine("İsim : " + isim);
            Console.WriteLine("Soyisim : " + soyisim);
            Console.WriteLine("Maaş : " + maas);
        }

        public void zamYap(int zamMiktari)
        { 
            Console.WriteLine("Kullanıcıya Zam Yapılıyor...");
            Console.WriteLine("Şuanki Maaşı : " + (maas+zamMiktari));
        }
    }
}
