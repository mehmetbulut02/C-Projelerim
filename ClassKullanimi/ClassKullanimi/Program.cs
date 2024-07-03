using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassKullanimi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Araba araba1 = new Araba(4,"Renault","Kırmızı");

            Console.WriteLine("Arabanın Rengi : " + araba1.arabaRengi);
            Console.WriteLine("Araba Modeli : "+ araba1.arabaModel);
            Console.WriteLine("Kapı Sayısı : "+ araba1.kapiSayisi);

            araba1.kapilariKilitle();
            araba1.motorCalistir();

            Console.WriteLine("Arabanın kapı sayısı :"+ araba1.kapiSayisi);
            Console.WriteLine("Araba Rengi: "+araba1.arabaRengi);
            Console.WriteLine("Arabanın Modeli: "+araba1.arabaModel);
        
            Console.ReadLine();
        }

    }
}
