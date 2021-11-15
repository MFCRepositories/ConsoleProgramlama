using System;

namespace DortSoruBirOdev
{
    class Program
    {
        static void Main(string[] args)
        {
            //Soru1();
            //Soru2();
            //Soru3();
           // Soru4();

            Console.ReadLine();

        }
        //1-Bir konsol uygulamasında kullanıcıdan pozitif bir sayı girmesini isteyin(n).Sonrasında kullanıcıdan n adet 
        //    pozitif sayı girmesini isteyin.Kullanıcının girmiş olduğu sayılardan çift olanlar console'a yazdırın.
        static void Soru1()
        {
            Console.WriteLine("Kaç tane Pozitif bir sayı girmek istiyorsunuz");
            int sayi = Convert.ToInt32(Console.ReadLine());
            int[] dizi = new int[sayi];
            Console.WriteLine("Pozitif bir sayı giriniz:");
            for (int i = 0; i < sayi; i++)
            {
                dizi[i] = Convert.ToInt32(Console.ReadLine());

            }
            Console.WriteLine("Çift Sayılari Görüyorsunuz");
            for (int i = 0; i < sayi; i++)
            {
                if (dizi[i] % 2 == 0)
                {
                    Console.Write(dizi[i] + " ");
                }

            }

        }
        //2-Bir konsol uygulamasında kullanıcıdan pozitif iki sayı girmesini isteyin(n, m). Sonrasında kullanıcıdan n adet pozitif sayı girmesini isteyin.
        //Kullanıcının girmiş olduğu sayılardan m'e eşit yada tam bölünenleri console'a yazdırın.

        static void Soru2()
        {

            Console.WriteLine("N pozitif sayısını giriniz");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] dizi = new int[n];
            Console.WriteLine("M pozitif sayısını giriniz");
            int m = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"{i + 1}.sayiyi giriniz");
                dizi[i] = Convert.ToInt32(Console.ReadLine());

            }

            for (int i = 0; i < n; i++)
            {
                if (m == dizi[i] || dizi[i] % m == 0)
                {
                    Console.WriteLine($"{dizi[i]}");
                }
            }

        }

        //3-)Bir konsol uygulamasında kullanıcıdan pozitif bir sayı girmesini isteyin(n).
        //Sonrasında kullanıcıdan n adet kelime girmesi isteyin.
        //Kullanıcının girişini yaptığı kelimeleri sondan başa doğru console'a yazdırın.
        static void Soru3()
        {
            Console.WriteLine("N pozitif sayısını giriniz");
            int n = Convert.ToInt32(Console.ReadLine());
            string[] dizi = new string[n];
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"{i + 1}.kelimeyi giriniz");
                dizi[i] = Console.ReadLine();

            }

            for (int i = dizi.Length-1; i >= 0; i--)
            {
                Console.Write(dizi[i] + " ");
            }
        }
        //Bir konsol uygulamasında kullanıcıdan bir cümle yazması isteyin.
        //    Cümledeki toplam kelime ve harf sayısını console'a yazdırın.
        static void Soru4()
        {
            Console.WriteLine("Cümle giriniz:");
            string cumle = Console.ReadLine();
            int toplamKelime = 1;
            int toplamHarf = 0;
            foreach (var i in cumle)
            {
                if (i==' ')
                {
                    toplamKelime++;
                    continue;
                }
                toplamHarf++;
            }
            Console.WriteLine($"Toplam kelime sayisi : {toplamKelime}");

            Console.WriteLine($"Toplam harf sayisi :  {toplamHarf}");
        }
    }
}
