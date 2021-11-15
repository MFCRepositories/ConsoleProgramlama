using System;

namespace Switch_Case
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Secimlerinizi gerçekleştiriniz...");
            string degisken = Console.ReadLine();

            switch (degisken)
            {
                case "A":
                    Console.WriteLine("A ile başlayan kız isimleri");
                    break;
                case "B":
                    Console.WriteLine("B ile başlayan kız isimleri");
                    break;
                case "C":
                    Console.WriteLine("C ile başlayan kız isimleri");
                    break;
                default:
                    Console.WriteLine("Seçim yapmadınız");
                    break;
            }
        }
    }
}
