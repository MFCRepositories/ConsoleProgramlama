using System;

namespace Struct
{
    //Yapıların özellikleri:
    //Class lar referans tipli özellikler gösterir, Yapılar ise değer tipli özellikler gösterirler.En temel fark budur.
    //Diğer struct yada sınıflardan kalıtım almazlar.
    //Interface'lerden kalıtım alabilirler.
    //new anahtar sözcüğü ile nesneleri yaratılabilir.
    //Sınıflar gibi metot, property ve field'lardan oluşurlar.
    //Sınıf içerisinde struct, struct içerisinde de sınıf oluşturulabilir.
    //Static üye barındırabilirler.
    //16 byte a kadar olan veriler için struct uygun oluyor Performans konusu

    class Program
    {
        static void Main(string[] args)
        {
            #region Class
            Dikdortgen dikdortgen = new Dikdortgen();
            dikdortgen.kisaKenar = 4;
            dikdortgen.uzunKenar = 12;
            Console.WriteLine("Class Alan Hesabı:{0}", dikdortgen.AlanHesapla());
            #endregion

            #region Struct
            DikdortgenStruct dikdortgenStruct = new DikdortgenStruct();
            dikdortgenStruct._kisaKenar = 12;
            dikdortgenStruct._uzunKenar = 15;
            Console.WriteLine("Struct Alan Hesabı:{0}", dikdortgenStruct.AlanHesapla());
            //new ile yaratmadan direk cagrılabiliyorlar
            DikdortgenStruct dikdortgenStruct1;
            dikdortgenStruct1._kisaKenar = 23;
            dikdortgenStruct1._uzunKenar = 5;
            Console.WriteLine("Newleden struct yapımı{0}",dikdortgenStruct1.AlanHesapla());

            #endregion
        }

    }

    class Dikdortgen
    {

        //Default Constructor olusturuluyor
        //Dikdortgen()
        //{

        //}
        public int kisaKenar;
        public int uzunKenar;

        public long AlanHesapla()
        {
            return kisaKenar * uzunKenar;

        }
    }

    struct DikdortgenStruct
    {
        //Parametresiz default constructor tanımalamaz
        //DikdortgenStruct()
        //{

        //}
        public int _kisaKenar;
        public int _uzunKenar;

        //Parametreli constructor olusturulabiliyor.
        public DikdortgenStruct(int kisaKenar,int uzunkenar) 
        {
           _kisaKenar = kisaKenar;
           _uzunKenar = uzunkenar;
        }

      
        public long AlanHesapla()
        {
            return _kisaKenar * _uzunKenar;

        }
    }
}
