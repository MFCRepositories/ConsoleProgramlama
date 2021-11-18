using System;

namespace HackerRank_TimeConversion
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Saat ve saniye:" + DateTime.Now.ToLongTimeString());
            string tarih="12:22:20PM";
            Console.WriteLine(tarih.Substring(0,8));
            DateTime convertTarih = Convert.ToDateTime(tarih);
            Console.WriteLine("ConvertTarih:"+convertTarih);
           
            DateTime givenTime = new DateTime(12,02,20,12,22,20);
            Console.WriteLine(givenTime.ToLongTimeString());

            Console.WriteLine("Time:"+givenTime.AddHours(12).ToLongTimeString());
            Console.ReadLine();
        }
    }
}
