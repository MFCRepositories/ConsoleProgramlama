using System;

namespace For_Loop_ve_Break_Continue
{
    class Program
    {
        static void Main(string[] args)
        {

            //for (int i = 100; i >= 1; i--)
            //{
            //    Console.WriteLine(i);
            //}

            #region Tek sayılar
            //for (int i = 1; i <= 100; i++)
            //{
            //    if (i%2==1)
            //    {
            //        Console.WriteLine(i);
            //    }
            //} 
            #endregion

            #region 1'den 100'e toplam
            //int toplam = 0;
            //for (int i = 1; i <= 100; i++)
            //{
            //    toplam += i;
            //}
            //Console.WriteLine(toplam); 
            #endregion

            #region Faktöriyel
            //Console.Write("Faktöriyelini hesaplamak istediğiniz sayı: ");
            //int sayi = int.Parse(Console.ReadLine());
            //int sonuc = 1;
            //for (int i = 1; i <= sayi; i++)
            //{
            //    sonuc *= i;
            //}
            //Console.WriteLine($"Girmiş olduğunuz sayı ({sayi})'nin faktöriyeli: {sonuc}"); 
            #endregion

            #region Random sayı bulmaca
            //Random rnd = new Random();
            //for (; ; )
            //{
            //    int sayi = rnd.Next(200000);
            //    Console.WriteLine("Sayı : " + sayi);
            //    if (sayi == 35)
            //    {
            //        Console.WriteLine("Buldum : " + sayi);
            //        break;
            //    }
            //}
            #endregion

            Console.ReadKey();
        }
    }
}
