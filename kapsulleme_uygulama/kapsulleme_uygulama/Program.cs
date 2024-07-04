using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kapsulleme_uygulama
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Personel P1 = new Personel();
            P1.TCKİMLİKNO = "12345678956";
            Console.WriteLine("Tc kimlik numaranız : +"+P1.TCKİMLİKNO);
        }
    }
}
