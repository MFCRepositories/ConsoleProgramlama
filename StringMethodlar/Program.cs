using System;
using System.Linq;

namespace StringMethodlar
{
    class Program
    {
        static void Main(string[] args)
        {
            //Concat Birleştirme işlemi yapar
            //----------------------------------------------//
            string isim = "Derya";
            Console.WriteLine(String.Concat(isim, " Ünver"));
            Console.WriteLine(isim);

            ///Compare, CompareTo(Karşılaştır)

            string a = "a";
            string b = "b";
            //Console.WriteLine(a.CompareTo(b));
            //Console.WriteLine(String.Compare(a,b,true)); //a nın degeri mi büyük b nin mi a=97 ascii b=98 o zaman false(-1)
            Console.WriteLine(a.CompareTo(b));
            //şifre:123456
            //şifreyi tekrarla:12345

            //Contains bir string ifade içerisinde diğer girilen string ifadeyi aratır.Search işlemleri
            //string containsIslemleri = "Hacı Murat ";
            //string search = "Murat";
            //Console.WriteLine(containsIslemleri.Contains("Mu"));
            //Console.WriteLine(containsIslemleri.Contains(search));

            string isim2 = "Fatih Ceylan";
            Console.WriteLine("EndsWith:"+isim2.EndsWith('a'));//false
            Console.WriteLine("StartWith:"+ isim2.StartsWith("lan"));//true
            Console.WriteLine("IndexOf:"+ isim2.IndexOf("C"));//kaçıncı indexte başlıyor
            Console.WriteLine("Insert:"+isim2.Insert(0,"M."));//istediğin indexe eleman ekleme
            Console.WriteLine("LastIndexOf:"+isim2.LastIndexOf("a"));//Sonuncu a nerede
            Console.WriteLine("PadLeft:"+isim+isim2.PadLeft(20));//isim değişkeninin sağına 20 karakter alan bırakıp ,
                                                                 //isim2 değişkenin boyutunu sağa yanaşık biçimde yazar
            Console.WriteLine("PadLeft:"+isim2+isim.PadRight(20));//Sonuncu a nerede
            Console.WriteLine("Remove:"+isim.Remove(3));//belirtilen index i çıkar
            //Console.WriteLine("Remove:"+isim.Remove(3,5));//belirtilen indexleri çıkar
            Console.WriteLine("Replace:"+isim.Replace(" ","-"));//boşlukların yerine - koy


            string cumle = "Naber canım benim terliklerini severim";
            Console.WriteLine("Split:"+cumle.Split(' '));//her boşlukta bir diziye boşluk
                                                             // öncesindekini al ve 1. indisi getir

            string[] dizi = cumle.Split(' ');
            string[] dizi2 = cumle.Split('-');
            //Split string bir dizi oluşturur bu dizi elemanları foreach ile kullanılabilir
            Console.WriteLine("SubString:"+cumle.Substring(3,20));
            //bir cümlede 3 den basla 20 karakter uzunlukta yaz
            string cumle2 = "temiz twitch toplulugu lutfen duyarsız kalmayın serefsizler turemesint";
            Console.WriteLine("Trim:"+cumle2.Trim('t'));
            //Bastaki ve sonraki noktaları kırpar
            var charDizisi=cumle.ToCharArray();
            foreach (var i in charDizisi)
            {
                
                Console.WriteLine(i);
            }
            string cemal = " ";
            Console.WriteLine(string.IsNullOrEmpty(cemal)); //null ya da deger yoksa
            Console.WriteLine(string.IsNullOrWhiteSpace(cemal));//null yada boşluk karakteri varsa True
            string[] values = { "1", "2", "3", "4", "5" };
            string result = string.Join("-", values);
            Console.WriteLine(result);

        }

    }
}
