using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticYapiciMetotKullanimi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Kullanici K1 = new Kullanici(1,"Mehmet","Bulut");
            K1.bilgileriGoster();
            K1.zamYap(700);
            Console.ReadLine();
        }
    }
}
