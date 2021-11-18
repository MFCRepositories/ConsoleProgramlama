using System;
using System.Collections.Generic;

namespace Generic_Koleksiyonlar
{
    class Program
    {
        static void Main(string[] args)
        {
            //List<T> class
            //System.Collections.Generic
            //T--> object türünde olmalı
            List<int> sayiListesi = new List<int>();
            sayiListesi.Add(2);
            sayiListesi.Add(1);
            sayiListesi.Add(4);
            sayiListesi.Add(6);
            sayiListesi.Add(21);

            List<string> renkListesi = new List<string>();
            renkListesi.Add("kırmızı");
            renkListesi.Add("mavi");
            renkListesi.Add("turuncu");
            renkListesi.Add("sarı");
            renkListesi.Add("yesil");

            //foreach ile yazı gosterme ve listeForeach ile elemanlara erisim
            foreach (var s in sayiListesi)
            {
                Console.WriteLine(s);
            }

            foreach (var r in renkListesi)
            {
                Console.WriteLine(r);
            }

            sayiListesi.ForEach(sayi => Console.WriteLine(sayi));
            renkListesi.ForEach(renk => Console.WriteLine(renk));

            //Listeden eleman cıkarma
            sayiListesi.Remove(4);//itemlere göre 
            renkListesi.Remove("Yeşil");
            //sayiListesi.RemoveAt(4); //indexlere göre
            //renkListesi.RemoveAt("Yeşil");

            Console.WriteLine("/-----------------------------------/");
            Console.WriteLine("Bir diziyi bir listeye taşıma");
            Console.WriteLine("/-----------------------------------/");

            string[] meyveler = { "Trabzon Hurması", "Üzüm", "Armut" };
            List<string> meyveListesi = new List<string>(meyveler);
            foreach (var VARIABLE in meyveListesi)
            {
                Console.WriteLine(VARIABLE);
            }

            Console.WriteLine("/-----------------------------------/");
            meyveListesi.Clear();//liste temizleme


            Console.WriteLine("---------List of Class-------------");

            Kullanicilar kullanici1 = new Kullanicilar
            {
                Ad = "Saniye",
                Soyad = "Boz",
                Yas = 22
            };
            Kullanicilar kullanici2 = new Kullanicilar
            {
                Ad = "Hayri",
                Soyad = "Boz",
                Yas = 32
            };
            List<Kullanicilar> kullaniciListesi = new List<Kullanicilar>();
            kullaniciListesi.Add(kullanici1);
            kullaniciListesi.Add(kullanici2);
            List<Kullanicilar> yeniListe = new List<Kullanicilar>();
            yeniListe.Add(new Kullanicilar
            {
                Ad = "Cumali",
                Soyad = "Bisi",
                Yas = 31

            });

            foreach (var k in yeniListe)
            {
                Console.WriteLine(k.Ad);
                Console.WriteLine(k.Soyad);
                Console.WriteLine(k.Yas);
            }

            yeniListe.Clear();
        }
    }
    //Encapsulation işlemleri
    class Kullanicilar
    {
        private string ad;
        private string soyad;
        private int yas;
        public int Yas { get => yas; set => yas = value; }
        public string Ad { get => ad; set => ad = value; }
        public string Soyad { get => soyad; set => soyad = value; }

    }
}
