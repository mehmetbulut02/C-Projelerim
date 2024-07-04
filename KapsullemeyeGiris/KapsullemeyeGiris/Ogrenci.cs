using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KapsullemeyeGiris
{
    public class Ogrenci
    {
        private string isim ;

        public void setIsım(string _isim)
        {
            isim = _isim;
        }
        public string getIsim() 
        { 
        return isim;
        }
    }
}
