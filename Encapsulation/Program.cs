using System;

namespace Encapsulation
{
    class Program
    {
        //
        // Örneğin siz bir propery yani özellik tanımı yaptınız ve diğer sınıflar içerisinden erişilsin
        // ama sadece okumak için erişilsin değeri dışarıdan değiştirilemesin istiyorsunuz bunu kapsülleme yaparak sağlayabilirsiniz.
        // Kapsülleme işlemini ise property leri kullanarak yapabilirsiniz.
        // Kapsülleme sayesinden nesneler bilinçsiz olarak kullanımdan korunmuş olur.
        // Fakat bazı durumlarda private field'lara erişmemiz ve özelliklerini değiştirmemiz gerekebilir.
        // Bu durumda Property Kavramı devreye girer. Property bir field'ın değerini geri döndürmeye(Get)
        // ve yeni bir değer(Set) atamaya olanak sağlar.
        static void Main(string[] args)
        {
            Ogrenci ogrenci = new Ogrenci("Ceylan", 13, 4, "Fatih");
            ogrenci.OgrenciBilgileriniGetir();
            ogrenci.SinifDusur();
            Console.WriteLine("------------------");
            ogrenci.OgrenciBilgileriniGetir();
            Console.WriteLine("------------------");

            Ogrenci ogrenci2 = new Ogrenci("Ahmet", 3, 1, "Köse");

            ogrenci2.OgrenciBilgileriniGetir();
            Console.WriteLine("------------------");
            ogrenci2.SinifDusur();
            ogrenci2.OgrenciBilgileriniGetir();
        }
    }

    class Ogrenci
    {
        private string _isim;
        private string _soyad;
        private int _ogrenciNo;
        private int _sinif;



        public Ogrenci(string soyad, int ogrenciNo, int sinif, string isim)
        {
            _soyad = soyad;
            _ogrenciNo = ogrenciNo;
            _sinif = sinif;
            _isim = isim;
        }

        public string Isim
        {
            get { return _isim; }

            set { _isim = value; }
        }

        public string Soyad { get => _soyad; set => _soyad = value; }
        public int OgrenciNo { get => _ogrenciNo; set => _ogrenciNo = value; }
        public int Sinif
        {
            get => _sinif;

            set
            {
                if (value < 1)
                {
                    Console.WriteLine("Sınıf 1 den kücük olamaz!");
                    _sinif = 1;
                }
                else
                {
                    _sinif = value;
                }

            }

        }

        public void OgrenciBilgileriniGetir()
        {
            Console.WriteLine("Ogrenci Bilgileri");
            Console.WriteLine("Ogrenci Adı:{0}", _isim);
            Console.WriteLine("Ogrenci Soyadı:{0}", _soyad);
            Console.WriteLine("Ogrenci No:{0}", _ogrenciNo);
            Console.WriteLine("Ogrenci Sınıfı:{0}", _sinif);
        }

        public void SinifAtlat()
        {
            _sinif = _sinif + 1;
        }

        public void SinifDusur()
        {


            _sinif = _sinif - 1;
        }
    }
}
