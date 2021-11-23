using System;

namespace CoderByteC101
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Kelime sayisi:"+ WordCount(" ahmet mehmet cuma"));
           
        }

        private static int WordCount(string str)
        {
            int count = 0;
            string[] dizi = str.Split(' ');
            foreach (var i in dizi)
            {
                Console.WriteLine(i);
                count++;
            }
            return count;

        }
        //Word Count
        
        //class MainClass
        //{

        //    public static string WordCount(string str)
        //    {

        //        string[] dizi = str.Split(' ');
        //        str = Convert.ToString(dizi.Length);

        //        return str;

        //    }

        //    static void Main()
        //    {
        //        // keep this function call here
        //        Console.WriteLine(WordCount(Console.ReadLine()));
        //    }

        //}


    }
}




   


