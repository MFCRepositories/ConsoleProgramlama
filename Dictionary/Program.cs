using System;
using System.Collections.Generic;

namespace Dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> kullanicilar = new Dictionary<int, string>();
            bool durum = true;
           
                Console.WriteLine("Kullanici adi ve soyadi giriniz:");
                string kullaniciAdveSoyad = Console.ReadLine();
                Console.WriteLine("Telefon Numarasi giriniz");
                int telefonNumarasi = Convert.ToInt32(Console.ReadLine());
                kullanicilar.Add(telefonNumarasi, kullaniciAdveSoyad);
                Console.WriteLine("Kullanici adi ve soyadi giriniz:");
                string kullaniciAdveSoyad1 = Console.ReadLine();
                Console.WriteLine("Telefon Numarasi giriniz");
                int telefonNumarasi1 = Convert.ToInt32(Console.ReadLine());
                kullanicilar.Add(telefonNumarasi1, kullaniciAdveSoyad1);
           


            Console.WriteLine("Arama Yap");
            var arama = Console.ReadLine();
            
            foreach (var i in kullanicilar)
            {
                if (i.Value.Contains(arama))
                {
                    Console.WriteLine(i);
                }
            }

            Console.ReadLine();
            //kullanicilar.Add(1, "Hayri Boz");
            //kullanicilar.Add(2, "Cuma Terzi");
            //kullanicilar.Add(5, "Osman Hurma");
            ////kullanicilar.Add(5, "Yumru Hurma");//Keyler unique olmalı
            ////System.ArgumentException: An item with the same key has already been added.
            //kullanicilar.Remove(2);
            //Console.WriteLine("***********---Erişim---************");
            //foreach (var i in kullanicilar)
            //{
            //    Console.WriteLine(i);
            //    Console.WriteLine(i.Key);
            //    Console.WriteLine(i.Value);
            //}

            //Console.WriteLine("Kullanıcı Sayısı:" + kullanicilar.Count);
            //Console.WriteLine("Kullanıcı İndex:" + kullanicilar.ContainsKey(2));
            //Console.WriteLine("Kullanıcı Value:" + kullanicilar.ContainsValue("Hayri Boz"));

            //foreach (var i in kullanicilar.Keys)
            //{
            //    Console.WriteLine(i);
            //}
            //foreach (var i in kullanicilar.Values)
            //{
            //    Console.WriteLine(i);
            //}
        }
    }
}
