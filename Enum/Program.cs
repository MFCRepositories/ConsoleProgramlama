using System;

namespace Enum
{
    class Program
    {
        public static void Main(string[] args)
        {
           
            //Enum (Sıralama)
            //Uygulama geliştirirken sabit değerlerle çalışmak durumunda kalırız.
            //Bu noktalarda okunabilirliği yüksek bir program yazmak istiyorsak enum lardan faydalanırız.
            //"enum" anahtar kelimesi enumeration yani numaralandırma kelimesinden gelir.Sayısal verileri
            //string ifadelerle saklamanızı sağlar.Okunabilirliğe katkısı da tam olarak burdan gelir diyebiliriz.
            // Enum lar default olarak 1'den başlar.
            //Gunler.Pazartesi ifadesi ile Pazartesi'nin string ifadesine erişebiliriz. 
            //Eğer Pazartesinin 1. gün olduğu bilgisine ihtiyacımız varsa o da şu şekildedir: (int)Gunler.Pazartesi**

            Console.WriteLine(Gunler.Pazar);

            //Numerik değerine ulaşımı 
            Console.WriteLine("Cumartesi haftanın {0}. günüdür.",(int)Gunler.Cumartesi);
            Console.WriteLine("");
            int sicaklik=12;
            if (sicaklik<(int)HavaDurumu.Normal)
            {
                Console.WriteLine("Hava bugun güzel değil");
            }
            else if (sicaklik >= (int) HavaDurumu.Sicak)
            {
                Console.WriteLine("GEzelim bugun hava güzel");
            }
            else if (sicaklik >= (int) HavaDurumu.ÇokSicak)
            {
                Console.WriteLine("Bugun hava bunaltıcı");
            }
        }
    }
    //Numerik veriyi anlamdırma işlemi yapıyoruz.
    enum Gunler
    {
        Pazartesi=1,Salı,Çarşamba,Perşembe,Cuma,Cumartesi,Pazar
    }

    enum HavaDurumu
    {
        Soguk=5,
        Normal=20,
        Sicak=25,
        ÇokSicak=30
    }
}
