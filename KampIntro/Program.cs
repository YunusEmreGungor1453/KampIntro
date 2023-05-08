using System;

namespace KampIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            //type safety - tip güvenliği
            // do not repeat yourself 

             string kategoriEtiketi = "Kategoriler";

            

            bool sistemeGirişYapmişmi = false;

            double dolarDun = 7.35;
            double dolarBugun = 7.45;

            if (dolarDun > dolarBugun)
            {
                Console.WriteLine("azalış butonu");

            }
            else if (dolarDun < dolarBugun)
            {
                Console.WriteLine("azalış butonu");
            }
            else {
                Console.Write("değimedi butonu");
            }

          
            if (sistemeGirişYapmişmi== true)
            {
                Console.WriteLine("ayarlar butonu");

            }
            else
            {
                Console.WriteLine("giriş yap butonu");
            }

            Console.WriteLine(kategoriEtiketi);

            
        }
    }
}
