using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methodlar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Parametresiz - Geriye Değer Döndürmeyen Metot Tanımlama...
            SelamVer();
            AdiniYazdir();
        }
        static void SelamVer() 
        {
            Console.WriteLine("Selamlar :");
        
        }
        static void AdiniYazdir()
        {
            Console.WriteLine("Mehmet");
            Console.ReadLine();
        }
    }
}
