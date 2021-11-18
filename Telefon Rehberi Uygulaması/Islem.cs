using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Telefon_Rehberi_Uygulaması
{
    public class Islem
    {
        public Dictionary<string, string> personList = new Dictionary<string, string>();

        public void Kaydetme()
        {
            Console.WriteLine("Kullanici adi ve soyadi giriniz");
            string kAdSoyad = Console.ReadLine();
            Console.WriteLine("Telefon numaranızı giriniz");
            string kTelefon = Console.ReadLine();
            personList.Add(kAdSoyad,kTelefon);
            Console.WriteLine("Sistemimize Kaydediliyor...");
            Thread.Sleep(2000);
        }

        public void Silme()
        {
            Console.WriteLine(" Lütfen numarasını silmek istediğiniz kişinin adını ya da soyadını giriniz:");
            string sil = Console.ReadLine();
            personList.Remove(sil);
            Console.WriteLine("siliniyor");
            Thread.Sleep(500);

        }

        public void Guncelleme()
        {
            Console.WriteLine("  Lütfen numarasını güncellemek istediğiniz ad soyad giriniz");
            string sil = Console.ReadLine();
            foreach (var p in personList)
            {
                if (p.Key==sil)
                {
                    Console.WriteLine("Yeni numaranızı giriniz:");
                    string telefon = Console.ReadLine();
                }
            }

            Console.WriteLine("siliniyor");
            Thread.Sleep(500);

        }

        public void Listeleme()
        {
            foreach (var person in personList)
            {
                Console.WriteLine("Kullanici Adi ve Soyadi:"+person.Value);
                Console.WriteLine("Telefon Numarası:"+person.Key);
               
            }
            Console.WriteLine("Listeleniyor");
            Thread.Sleep(3000);
        }
        public void Arama()
        {
            Console.WriteLine("Aramaya hoşgeldiniz");
            var arama = Console.ReadLine();
            foreach (var i in personList)
            {
                if (i.Key.Contains(arama))
                {
                    Console.WriteLine(i);
                }
            }
        }

        public bool Cikis()
        {
            bool durum = true;
            Console.WriteLine("Cikis icin emin misiniz? Evet->E /Hayır->H");
            char cikis = Console.ReadKey().KeyChar;

            if (cikis == 'e' || cikis == 'E')  durum=false;
            else if (cikis == 'h' || cikis == 'H') durum=true;


            return durum;
        }
    
    }
}
