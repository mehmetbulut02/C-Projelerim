using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_Kalitim_
{
    public class Kedi : Hayvan
    {

        public string kedinin_goz_rengi;
        public void kediMetot()
        {
            Console.WriteLine("Kedi miyavlıyor...");
        }
    }
}
