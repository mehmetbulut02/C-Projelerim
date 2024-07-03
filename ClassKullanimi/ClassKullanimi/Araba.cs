using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassKullanimi
{
    internal class Araba
    {
        
            public int kapiSayisi;
            public string arabaModel;

            public string arabaRengi;

        public Araba(int _kapiSayisi , string _arabaModel , string _arabaRengi)
        {
            kapiSayisi = _kapiSayisi ;
            arabaModel = _arabaModel ;
            arabaRengi = _arabaRengi ;
        }

        public void motorCalistir()
            {
                Console.WriteLine("Motor Çalışıyor...");
            }
            public void kapilariKilitle()
            {
                Console.WriteLine("Kapılar Kilitleniyor...");
            }
        
    }


}
