using System;

namespace CoderByte_SimpleEvens
{
    class Program
    {
        static void Main(string[] args)
        {
            int getir = 22220;
            Console.WriteLine(CiftTek(getir));
           
            Console.ReadLine();
        }

        static string CiftTek(int getir)
        {
            string result = " ";
            string kontrol = getir.ToString();

            foreach (var i in kontrol)
            {
                if (i%2==0)
                {
                    result="true";
                    continue;
                }
                else
                {
                    result="false";
                    break;
                }
               
            }

            return result;
        }
    }
}
