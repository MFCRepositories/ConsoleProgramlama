using System;

namespace Static_Sınıf_ve_Uyeler
{
    class Program
    {
        //Bir sınıfın static olamayan üyelerine nesneler aracılığıyla erişirken static
        //olan metotlara ve özelliklere ise nesne oluşturmadan o sınıfın ismi aracılığıyla erişiriz.
        static void Main(string[] args)
        {
           
            Calisan calisan = new Calisan( "ahmey","human");
            Console.WriteLine("Çalisan Sayisi:{0}", Calisan.CalisanSayisi);
            Console.WriteLine(Islemler.Topla(50, 25));//static methoda erişim 
        


        }

        class Calisan
        {
            private static int _calisanSayisi; //static field 
            private string _isim;
            private string _soyisim; 

            public static int CalisanSayisi { get => _calisanSayisi;}/* set => _calisanSayisi = value; */
            //static field encapssulation ile static public bir property dönüştürdük.
            public Calisan(string isim, string soyisim)
            {
                _isim = isim;
                _soyisim = soyisim;
                _calisanSayisi++;

            }

            public Calisan()
            {

            }

            static Calisan() //Static Constructların erişim blirteci olmaz
            {
                _calisanSayisi = 0;
            }

            

        }

        static class Islemler
        {
          public static int Topla(int a ,int b)
            {
                return a + b;
            }
        }
    }
}
