using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_Kalitim_
{
    public class Hayvan
    {
        public string hayvan_isim;
        public string hayvan_cinsiyet;
        public string hayvan_rengi;
        public int hayvan_yasi;

        public void hayvanBilgisiGoster()
        {
            Console.WriteLine("Hayvanın İsmi : " + hayvan_isim);
            Console.WriteLine("Hayvanın Cinsiyeti : " + hayvan_cinsiyet);
            Console.WriteLine("Hayvanın Rengi : " + hayvan_rengi);
            Console.WriteLine("Hayvanın Yaşı : " + hayvan_yasi);
        }
    }
}
