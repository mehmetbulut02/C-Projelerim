﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dizinin_elemanlarını_alma
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] sayilar = new int[4];

            for (int i = 0; i < sayilar.Length; i++)
            {
                Console.Write("Sayılar Dizisinin " + (i) + ". index değerini giriniz: ");
                sayilar[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("********************************");
            for (int i = 0;i < sayilar.Length; i++)
            {
                Console.WriteLine(sayilar[i]);
            }
            Console.ReadLine();
        }
    }
}
