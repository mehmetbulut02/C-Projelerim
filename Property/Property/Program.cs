using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Property
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            musteri1.KİLO = 85; // Değer atama yapıyorum o zaman set Blockları çalışır
            // Eğer değer ataması yapmasaydım o zamanda get blockları çalışırdı
            Console.WriteLine(musteri1.KİLO);  
        }
    }
}
