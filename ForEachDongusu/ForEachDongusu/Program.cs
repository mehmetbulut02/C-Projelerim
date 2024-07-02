using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForEachDongusu
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Foreach Döngüsü...

            string[] isimler = { "Enes", "Aysun", "Sevcan", "Elif", "Eren" };
            /*for(int i = 0; i < isimler.Length; i++)
            {
                Console.WriteLine(isimler[i]);
            }*/
            foreach (string a in isimler)

            {
                Console.WriteLine(a);
            }
            Console.ReadLine();
        }
    }
}
