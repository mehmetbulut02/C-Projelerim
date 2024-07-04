using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticDegiskenKullanimi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Calısan c1 = new Calısan();

            c1.calisanID= 1;
            c1.isim = "Mehmet";
            c1.soyisim = "Bulut";
            Calısan.maas = 2500;
            Console.WriteLine("Çalışan id : " + c1.calisanID);
            Console.WriteLine("Çalışan isim : " + c1.isim);
            Console.WriteLine("Çalışan soyisim : "+ c1.soyisim);
            Console.WriteLine("Çalışan Maaşı : " + Calısan.maas);
            Console.ReadLine();
               
        }
    }
}
