using System;

namespace If_Else_Ternary
{
    class Program
    {
        static void Main(string[] args)
        {
            bool condition = true;
            int gel = 5;

            if (condition)
            {
                Console.WriteLine("Değişken: true");
            }
            else
            {
                Console.WriteLine("Değişken: false");
            }

            string sonuc= gel==5 ?  "true" : "false";
        }
    }
}
