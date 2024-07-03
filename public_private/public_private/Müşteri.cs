using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace public_private
{
    public class Müşteri
    {
        public string isim;
        public string soyisim;
        public int maasDegeri;
        public string cinsiyet;
        private int yas;

        public Müşteri() 
        {
            Console.WriteLine("Müşteri sınıfının yapıcı metodu çalıştı");
        }
        public void musteriBilgileriGoster()
        {
            Console.WriteLine("İsmi : " + isim);
            Console.WriteLine("Soyisim : "+soyisim);
            Console.WriteLine("Maaş Değeri : "+maasDegeri);
            Console.WriteLine("Cinsiyet : "+cinsiyet);
            Console.WriteLine("Yaş Değeri : "+yas);
        }

        private void isimSoyisimYazdır(string musteriisim, string musteriSoyisim)
        {
            Console.WriteLine("Müşterinin isim ve soyisimi :"+musteriisim+" "+musteriSoyisim);
        }
    }
}
