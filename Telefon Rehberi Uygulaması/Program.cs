using System;
using System.Threading;

namespace Telefon_Rehberi_Uygulaması
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu menu = new Menu();
            menu.Menus();
            Secim();


            Console.ReadKey();

        }
       
         static void Secim()
         {
            bool durum = true;
            Islem islem = new Islem();
            while (durum)
             {
                 Console.WriteLine("Seciminizi giriniz:");
                 Console.WriteLine("-----------------");
                 Thread.Sleep(500);
                 char secim = Console.ReadKey(true).KeyChar;
               
                 switch (secim)
                 {
                     case '1':
                         islem.Kaydetme();
                         break;
                     case '2':
                         islem.Silme();
                         break;
                     case '3':
                         islem.Guncelleme();
                         break;
                     case '4':
                         islem.Listeleme();
                         break; 
                     case '5':
                         islem.Arama();
                         break;
                     case '6':
                         Console.WriteLine("Cikis icin emin misiniz? Evet->E /Hayır->H");
                         char cikis = Console.ReadKey().KeyChar;
                         if (cikis == 'e' || cikis == 'E') durum = false;
                         else if (cikis == 'h' || cikis == 'H') durum = true;
                         break;
                 }
            }
            
        }
    }
}
