using System;

namespace Diziler
{
    class Program
    {
        static void Main(string[] args)
        {
            //string[] ogrenciler = {"Rümeysa","İdil","Sezer","İlayda","Servet"};
            //string ad = "Soner";
            //int yas = 35;
            //Console.WriteLine(ogrenciler[0]);
            //Console.WriteLine(ogrenciler[1]);

            // Dizi - ARRAY
            // 1. Diziler type safe'dir.
            // 2. Dizilerin ilk elemanı 0. indextedir.
            // 3. Index elemanın dizideki sırasını belirtir.
            // 4. Index, indis diye de anılır.
            // 5. sayilar.Length, sayılar dizisinin uzunluğunu verir.
            // 6. sayilar[sayilar.Length-1] ' i dizinin son elemanını belirtir.
            //Console.WriteLine(sayilar.Length);

            //int[] sayilar = { 15, 25, 46, 67, 45, 34 };
            //sayilar[5] = 30;
            //for (int i = 0; i < sayilar.Length; i++)
            //{
            //    Console.WriteLine(sayilar[i]);
            //}

            string[] konular = new string[5];
            konular[0] = "Yazılım Nedir";
            konular[1] = "C# Temelleri";
            konular[2] = "Operatörler";
            konular[3] = "Diziler";
            konular[4] = "Döngüler";

            for (int i = 0; i < konular.Length; i++)
            {
                Console.WriteLine(konular[i]);
            }

            Console.ReadKey();
        }
    }
}
