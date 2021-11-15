using System;

namespace Metotlar___Recursive_Extension_Metotlar
{
    class Program
    {
        static void Main(string[] args)
        {
            Kaydet();

            ToplamiYaz(25, 55);

            //int toplam = ToplamiGetir(15, 23);
            //Console.WriteLine(toplam);

            Console.WriteLine(ToplamiGetir(3, 5));

            Console.WriteLine(MerhabaMesajiGetir());

            Console.ReadKey();
        }

        static void Kaydet()
        {
            Console.WriteLine("Kaydedildi");
        }

        static void ToplamiYaz(int sayi1, int sayi2)
        {
            Console.WriteLine(sayi1 + sayi2);
        }

        static int ToplamiGetir(int sayi1, int sayi2)
        {
            int toplam = sayi1 + sayi2;
            return toplam;
        }

        static string MerhabaMesajiGetir()
        {
            string mesaj = "Merhaba Yazılım 131";
            return mesaj;
        }

        //static string[] OgrencileriGetir()
        //{
        //    string[] ogrenciler = { "Rümeysa", "Gürkan", "İdil" };
        //    return ogrenciler;
        //}

        //static void ProjeksiyonuKapat(string kumanda)
        //{
        //    Console.WriteLine("X Kumanda kullanıldı ve kapatıldı");
        //}
    }
}
