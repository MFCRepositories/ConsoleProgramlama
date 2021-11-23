using System;

namespace Sinif_Instance_Field_Property
{
    class Program
    {
        static void Main(string[] args)
        {
            //Sınıflar Nesne Yönelimli Programlamanın en öneeli öğesidir.
            //C# %100 nesne yönelimli bir dil olduğu için tüm metot ve özellikler sınıflar içerisinde yer alır.
            /*Metotlardan bahsederken bütün işlemleri tek bir metot içerisinde yazmak yerine,
            parçalarına yani alt metotlara ayırmak kod tekrarını azaltırken okunabilirliği arttırır.*/
            //Üstelik bu şekilde yazdığınız programların daha kolay genişleyebildiğini görürsünüz.
            /*Aynı şekilde program geliştirirken bütün metotları tek bir sınıf içerisinde yazmak yerine
            benzer görevleri olan metotları tek bir sınıf içerisinde toplamak en doğru yaklaşımdır.*/
            //Bir sınıfın temelde 2 tipte öğesi vardır; field / özellik ve metotlar.



            //Erişim Belirleyiciler
            //Erişim belirleyiciler önüne geldiği öğenin projenin nerelerinden erişilebileceğini belirler.Öğeleri korur gibi düşünebilirsiniz.
            //1.Public : Her yerden erişilebilir.
            //2.Private : Sadece tanımlandığı sınıf içerisinden erişilebilir.Blok içerisinde
            //3.Internal : Sadece bulunduğu proje içerisinden erişilebilir.
            //4.Protected : Sadece tanımlandığı sınıfta ya da o sınıfı miras alan sınıflardan erişilebilir.
            Calisan calisan = new Calisan();
            calisan.Ad = "Fatih";
            calisan.Soyad = "Ceylan";
            calisan.No = 12345671011;
            calisan.Departman = "Yazılım Departmanı";
            Calisan calisan1 = new Calisan();
            calisan1.Ad = "Tansu";
            calisan1.Soyad = "Kemal";
            calisan1.No = 3212312312;
            calisan1.Departman = "Satın Alma Departmanı";
         
            calisan.CalisanlarinBilgileri();
            Console.WriteLine("-----------------------");
            calisan1.CalisanlarinBilgileri();



        }

        class Calisan
        {
            //property tanımlama Calisanı nasıl tanımlarız
            public string Ad;
            public string Soyad;
            public string Departman;
            public long No;

            //Calisan sınıfının bilgilerini yazdıracağımız Method yazımı
            public void CalisanlarinBilgileri()
            {
                Console.WriteLine("Çalışan Adi:{0}",Ad);
                Console.WriteLine("Çalışan Soyadi:{0}",Soyad);
                Console.WriteLine("Çalışan Numarası:{0}",No);
                Console.WriteLine("Çalışan Departman:{0}",Departman);

            }
        }
    }
}


