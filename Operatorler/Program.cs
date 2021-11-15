using System;

namespace Operatorler
{
    class Program
    {
        static void Main(string[] args)
        {
            string ad = "ahmet";
            double sayi = 100;

            //Atama ve İşlemli Atama Operatörleri(=, +=, -=, *=, /=)
            ad += "mehmet";
            //ahmet -= "mehmet";
            sayi *= 2;
            sayi /= 29;
            Console.WriteLine(ad);
            Console.WriteLine(sayi);
            //Mantıksal Operatörler(||, &&, !)
            if(ad=="ahmetmehmet")
                Console.WriteLine("sonuc basarili");
            else if (ad=="ahmetmehmet" ||ad=="ahmet")
            Console.WriteLine("sonuc basarili");
            //İlişkisel Operatörler(==,!=, <, >, >=,<=)

            //Aritmetik(+, -, *, /, %, ++, --)
            sayi++;
            Console.WriteLine(ad);
            Console.WriteLine(sayi);
            Console.ReadLine();

        }
    }
}
