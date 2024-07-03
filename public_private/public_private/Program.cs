using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace public_private
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Müşteri müşteri1 = new Müşteri();

            müşteri1.isim = "Mehmet";
            müşteri1.soyisim = "Bulut";
            müşteri1.maasDegeri = 2500;
            müşteri1.cinsiyet = "Erkek";

            müşteri1.musteriBilgileriGoster();

        }
    }
}
