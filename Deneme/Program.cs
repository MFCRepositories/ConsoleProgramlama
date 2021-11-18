using System;

namespace Deneme
{
    class Program
    {
        static void Main(string[] args)
        {
            var sayi =Convert.ToInt32(Console.ReadLine());
            Type control = sayi.GetType();
            if (control != typeof(Int32))
            {
                Console.WriteLine("lütfen tamsayı giriniz");
            }
            Console.WriteLine(control);
        }
    }
}
