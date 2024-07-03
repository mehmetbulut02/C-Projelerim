using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ogrenci_Uygulaması
{
    internal class Öğrenci
    {
        private int ogrno;
        private string isim;
        private string soyisim;
        private int vize1;
        private int vize2;
        private int final;
        private string okulismi;

        public Öğrenci(int _ogrno , string _isim , string _soyisim , int _vize1, int _vize2, int _final , string _okulismi)
        {
            ogrno = _ogrno;
            isim = _isim;
            soyisim = _soyisim;
            vize1 = _vize1;
            vize2 = _vize2;
            final = _final;
            okulismi = _okulismi;
        }

        public void ogrenciBilgileriGoster()
        {
            Console.WriteLine("Öğrenci Numarası: "+ ogrno);
            Console.WriteLine("Öğrenci İsmi: "+ isim);
            Console.WriteLine("Öğrenci Vize1 : " + vize1);
            Console.WriteLine("Öğrenci Vize2 : " + vize2 );
            Console.WriteLine("Öğrenci final : " + final);
            Console.WriteLine("Öğrenci Okul İsmi : " +okulismi);
        }

        public double ogrenciNotuBul()
        {
          double ortalama =  vize1 * 0.2 + vize2 * 0.2 + final * 0.6;
            Console.WriteLine("Öğrencinin Ortalaması : " + ortalama); 
            return ortalama;
        }
        public void okulGetir()
        { 
            Console.WriteLine("Öğrencinin Okul İsmi : " + okulismi);
        }
    }
}
