﻿using System;

namespace Donguler
{
    class Program
    {
        static void Main(string[] args)
        {
            string kurs1 = "Yazılım Geliştirici Yetiştime Kampı";
            string kurs2 = "Proglamaya Başlangıç için temel kurs";
            string kurs3 = "java";

            //array

            string[] kurslar = new string[] { "Yazılım Geliştirici Yetiştime Kampı", "Proglamaya Başlangıç için temel kurs", "java" };


            for (int i = 0; i < kurslar.Length; i++)
            {
                Console.WriteLine(kurslar[i]);
            }
            Console.WriteLine("for bitti"); 


            foreach (string kurs in kurslar)
            {
                Console.WriteLine(kurs);
            }
        }
    }
}
