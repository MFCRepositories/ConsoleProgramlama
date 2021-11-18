using System;
using System.Collections;

namespace UcSoruBirOdev_Odev2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Soru1();
            //Soru2();
            Soru3();
        }

     

        //Soru - 1: Klavyeden girilen 20 adet pozitif sayının asal ve asal olmayan olarak 2 ayrı listeye atın. (ArrayList sınıfını kullanara yazınız.)
        // Negatif ve numeric olmayan girişleri engelleyin.
        // Her bir dizinin elemanlarını büyükten küçüğe olacak şekilde ekrana yazdırın.
        // Her iki dizinin eleman sayısını ve ortalamasını ekrana yazdırın.
        static void Soru1()
        {
            ArrayList asal = new ArrayList();
            ArrayList asalOlmayan = new ArrayList();
            int sayi;
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine($"{i + 1}.Sayi giriniz");

                sayi = Convert.ToInt32(Console.ReadLine());
                if (sayi < 0 || sayi == 0)
                {
                    Console.WriteLine("Lütfen Pozitif sayı giriniz");
                    break;
                }

                int count = 0;
                for (int j = 1; j <= sayi; j++)
                {

                    if (sayi % j == 0)
                    {
                        count++;
                    }

                }

                if (count >= 3)
                {
                    asalOlmayan.Add(sayi);
                }
                else
                {
                    if (sayi == 1)
                        continue;
                    asal.Add(sayi);

                }


            }
            Console.WriteLine("Asal Olmayanlar:");
            Console.WriteLine("-----------------------------------");
            asalOlmayan.Sort();
            asalOlmayan.Reverse();
            double sonuc1 = 0;
           
            foreach (var ao in asalOlmayan)
            {
                Console.Write($" {ao} ");
                sonuc1 += (int)ao;
            }

            Console.WriteLine($"Asal Olmayanların sayisi:{asalOlmayan.Count}");
            Console.WriteLine("Ortalama:{0}", sonuc1 / asalOlmayan.Count);

            Console.WriteLine("-----------------------------------");
            double sonuc2 = 0;
            Console.WriteLine("Asallar:");
            Console.WriteLine("-----------------------------------");
            asalOlmayan.Sort();
            asalOlmayan.Reverse();
            Console.WriteLine();
            foreach (var a in asal)
            {
                Console.Write($" {a} ");
                sonuc2 += (int)a;
            }
            Console.WriteLine($"Asalların sayisi:{asal.Count}");
            Console.WriteLine("Ortalama:{0}", sonuc2 / asal.Count);

            Console.ReadLine();
        }

        //Soru - 2: Klavyeden girilen 20 adet sayının en büyük 3 tanesi ve en küçük 3 tanesi bulan,
        //her iki grubun kendi içerisinde ortalamalarını alan ve
        //bu ortalamaları ve ortalama toplamlarını console'a yazdıran programı yazınız. (Array sınıfını kullanarak yazınız.)
        static void Soru2()
        {
            ArrayList sayiListesi = new ArrayList();
            Console.WriteLine("Sayıları giriniz");
            int ekle;
            for (int i = 0; i < 5; i++)
            {
                Console.Write($"{i+1}:");
                ekle = Convert.ToInt32(Console.ReadLine());
                sayiListesi.Add(ekle);
            }

            double toplamB = 0;
            double toplamK = 0;
            sayiListesi.Sort();
            Console.Write("En küçük elemanlar:");
            for (int i = 0; i < 3; i++)
            {
                Console.Write("{0} ", sayiListesi[i]);
                toplamB += (int)sayiListesi[i];
            }

            Console.WriteLine(" En küçüklerin ortalaması:{0}",toplamB/3);
            sayiListesi.Reverse();
            Console.WriteLine();
            Console.Write("En büyük elemanlar:");
            for (int i = 0; i < 3; i++)
            {
                Console.Write(" {0}", sayiListesi[i]);
                toplamK += (int)sayiListesi[i];

            }
            Console.WriteLine(" En büyüklerin ortalaması:{0}", toplamK/3);
            Console.WriteLine("Ortalama toplamları:{0}",(toplamB/3+toplamK/3));
        }
        //Soru - 3: Klavyeden girilen cümle içerisindeki sesli harfleri bir dizi içerisinde saklayan
        //ve dizinin elemanlarını sıralayan programı yazınız.
        static void Soru3()
        {
            ArrayList sesli = new ArrayList();
            string cumle = Console.ReadLine();
            char[] dizi = cumle.ToCharArray();

            for (int i = 0; i < dizi.Length; i++)
            {
                if (dizi[i] == 'a' || dizi[i] == 'e' || dizi[i] == 'ı' || dizi[i] == 'i' || dizi[i] == 'o' || dizi[i] == 'ö' || dizi[i] == 'u' || dizi[i] == 'ü')
                {
                    sesli.Add(dizi[i]);
                }
            }
            sesli.Sort();
            Console.WriteLine("\nMetindeki Sesli Harfler sırası ile :");
            foreach (var item in sesli)
            {
                Console.Write("   " + item);
            }

        }
    }
}


