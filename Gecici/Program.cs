using System;
using System.Collections.Generic;

namespace Gecici
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> arr = new List<int> { 2, 3, 4, 1 };
            static void migratoryBirds(List<int> arr)
            {
                Console.WriteLine("Secimlerinizi gerçekleştiriniz...");
                for (int i = 0; i < arr.Count; i++)
                {
                    switch (arr[i])
                    {
                        case 1:
                            Console.WriteLine("A ile başlayan kız isimleri");
                            break;
                        case 2:
                            Console.WriteLine("B ile başlayan kız isimleri");
                            break;
                        case 3:
                            Console.WriteLine("C ile başlayan kız isimleri");
                            break;
                        case 4:
                            Console.WriteLine("C ile başlayan kız isimleri");
                            break;
                        case 5:
                            Console.WriteLine("C ile başlayan kız isimleri");
                            break;
                        default:
                            Console.WriteLine("Seçim yapmadınız");
                            break;
                    }
                }
                




                Console.ReadLine();
            }

        }

    }
}