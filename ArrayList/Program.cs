using System;
using System.Collections;
namespace ArrayList
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("----------ArrayList----------------------");
            //Kolleksiyon bir tipidir. 
            System.Collections.ArrayList arrayList = new System.Collections.ArrayList();
            //Görüldüğü gibi genişletilebilir ve farklı tipteki değişken türlerini bünyesinde barındırabilir.
            //Ancak bu Tip Güvenli olmadıgını gösterir.
            arrayList.Add("Hayri");
            arrayList.Add("Tansu");
            arrayList.Add("Bagnaz");
            arrayList.Add(42);
            arrayList.Add(true);
            arrayList.Add(77.32);
            foreach(var i in arrayList)
                Console.WriteLine(i);
            Console.WriteLine("Array List Methodları" +
                              "AddRange:Collection tipindeki herşeyi örn bir dizi ekleyebiliyoruz");
            char[] ekleChardizisi ={'A','B','D','g'} ;
            
            arrayList.AddRange(ekleChardizisi);
            foreach (var i in arrayList)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("ArrayList e sort işlemleri");
            //arrayList.Sort();
            //Hepsi aynı tipte olmalı hatası alırız
            Console.WriteLine("BinarySearch");
            int[] dizi =  {91, 2, 33, 5, 26, 17, 8};
            System.Collections.ArrayList yeniArrayList = new System.Collections.ArrayList();
            yeniArrayList.AddRange(dizi);
       
            //Console.WriteLine(yeniArrayList.BinarySearch(4));

            yeniArrayList.Sort();//Sıralama
            yeniArrayList.Reverse();//Ters Cevir
            foreach (var m in yeniArrayList)
            {
                Console.WriteLine(m);
            }
           
            


        }
    }
}
