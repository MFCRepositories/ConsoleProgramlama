using System;

namespace ConsoleProgramlama
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Console.WriteLine("İsminizi Giriniz");
            string isim = Console.ReadLine();
            Console.WriteLine("Soyadınızı Giriniz");
            string soyad = Console.ReadLine();
            Console.WriteLine("{0} {1}", isim, soyad);
            Console.ReadLine();
        }
    }
}
