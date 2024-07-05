using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayListKullanimi
{    
        internal class Program
        {
            static void Main(string[] args)
            {
                ArrayList koleksiyon = new ArrayList();

            koleksiyon.Add("Mehmet");
            koleksiyon.Add("Emre");
            koleksiyon.Add("Tolga");
            // koleksiyon.Remove("Emre"); Kaldırmak icin kullanilir

            // int count = koleksiyon.Count; Dizinin eleman sayisi icin kullanilir

            // bool kontrol = koleksiyon.Contains("Mehmet"); Koleksiyonda var mı yok mu onu kontrol ederiz

            // int index = koleksiyon.IndexOf("Emre"); Sectiğimiz elemanin index numarasini gösteriyor

            // koleksiyon.Insert(2, "Ahmet"); İstediğimiz indexe eleman ekliyor
           
            // koleksiyon.Reverse(); Listeyi tersine cevirir


            foreach (var a in koleksiyon)
            {
                Console.WriteLine(a);
            }
           // Console.WriteLine("Dizinin eleman sayısı: "+ count);
           // Console.WriteLine("Var mı ? : " + kontrol);
           // Console.WriteLine("İndex Numarası :"+index);
            Console.ReadLine();
            }
        }
    }


