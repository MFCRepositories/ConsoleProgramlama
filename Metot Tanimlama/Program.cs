using System;

namespace Metot_Tanimlama
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.Write("Ad: ");
            //string ad = Console.ReadLine();
            //Console.Write("Soyad: ");
            //string soyad = Console.ReadLine();
            //Console.WriteLine(MesajGetir(ad,soyad));

            //Console.Write("Faktöriyeli hesaplanacak sayı: ");
            //long sayi = long.Parse(Console.ReadLine());
            //Console.WriteLine(FaktoriyelHesapla(sayi));

            //Console.Write("Küçük sayı: ");
            //int kucukSayi = int.Parse(Console.ReadLine());
            //Console.Write("Büyük sayı: ");
            //int buyukSayi = int.Parse(Console.ReadLine());
            //Console.WriteLine("Küçük sayıdan büyük sayıya kadar olan tek sayıların toplamı: "+TekSayilarinToplaminiGetir(kucukSayi,buyukSayi));

            int sonuc = TekSayilarinToplaminiGetir(5, 15);
            Console.ReadKey();
        }

        /// <summary>
        /// Bu method girilen iki sayı arasındaki tek sayıların toplamını getirir.(Girilen sayılar dahil)
        /// </summary>
        /// <param name="baslangic">Küçük sayı</param>
        /// <param name="bitis">Büyük sayı</param>
        /// <returns>Toplam</returns>
        static int TekSayilarinToplaminiGetir(int baslangic, int bitis)
        {
            int toplam = 0;
            for (int i = baslangic; i <= bitis; i++)
            {
                if (TekMi(i))
                    toplam += i;
            }
            return toplam;
        }

        /// <summary>
        /// Girilen sayı tek ise true döner.
        /// </summary>
        /// <param name="sayi"></param>
        /// <returns></returns>
        static bool TekMi(int sayi)
        {
            return sayi % 2 == 1;
        }

        static long FaktoriyelHesapla(long sayi)
        {
            long sonuc = 1;
            for (int i = 1; i <= sayi; i++)
            {
                sonuc *= i;
            }
            return sonuc;
        }

        static string MesajGetir(string isim, string soyisim)
        {
            return $"Merhaba {isim} {soyisim}, Yazılım 131 sınıfının ilk oop uygulamasına hoş geldin";
        }
    }
}
