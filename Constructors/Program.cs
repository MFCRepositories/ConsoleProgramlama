using System;

namespace Constructors
{
    class Program
    {
        static void Main(string[] args)
        {
            //Constructor OverLoad
            Calisan calisan2 = new Calisan();//Gizli Constructor
            Calisan calisan = new Calisan("Mehmet Saim","Şadoğlu",1,"Bakanlık");
            Calisan calisan1 = new Calisan("Turgut","Akın",2,"Savcı");
            calisan.Bilgiler();
            Console.WriteLine("----------");
            calisan1.Bilgiler();
            Console.WriteLine("----------");
            calisan2.Bilgiler();
            Console.WriteLine("----------");
        }

        //Constructor Kavramı

        //Bir sınıftan bir nesne oluşturulduğunda biz tanımlamasak bile arka planda çalışan
        //varsayılan yapıcı metotlara kurucu yada constructor denir.Sınıf nesnesi ilk oluşturulduğunda yapılmasını istediğimiz işleri
        //kurucu metotlar içerisinde yaparız.

        //    Kurucu metot tanımlarken dikkat edilmesi gereken noktalar ise şu şekildedir:
        //1-)Yapıcı metotların isimleri sınıf isimleri ile aynı olmak zorundadır.
        //2-)Public olarak bildirilmeleri gerekir.
        //3-)Geri dönüş değerleri yoktur.
        class Calisan
        {
            public string Ad;
            public string Soyad;
            public string Departman;
            
            public long No;

            //Initial degerlerini buraya otomatik olarak veriyoruz
            public Calisan()
            {

            }
            public Calisan(string ad, string soyad, long no, string departman)
            {
                Ad = ad;
                Soyad = soyad;
                No = no;
                Departman = departman;
            }


            public void Bilgiler()
            {
                Console.WriteLine("Adınız: {0}",Ad);
                Console.WriteLine("Soyad: {0}",Soyad);
                Console.WriteLine("Numaranız: {0}",No);
                Console.WriteLine("Departman: {0}",Departman);
            }
        }
    }
}
