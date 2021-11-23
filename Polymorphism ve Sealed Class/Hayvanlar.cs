using System;
using System.Collections.Generic;
using System.Text;

namespace Polymorphism_ve_Sealed_Class
{
    public class Hayvanlar:Canlilar
    {
        public override void UyaranlaraTepki()
        {
            //base.UyaranlaraTepki();
            Console.WriteLine("Hayvanlar temasa tepki verir.");
        }
        public void Adaptasyon()
        {
            Console.WriteLine("Hayvanlar adaptasyon kurabilir");
        }

        
         
    }

    public class Surungenler:Hayvanlar
    {
         
        public Surungenler()
        {
            base.Adaptasyon();
        }
        public void SurunerekHareket (){
            Console.WriteLine("Sürüngeler sürünerek hareket ederler");
        }
    }
    public class Kuslar : Hayvanlar
    {
        public Kuslar()
        {
            //base.UyaranlaraTepki();
            
        }
        public override void UyaranlaraTepki()
        {
            Console.Write("Base:" );
            base.UyaranlaraTepki();
            
            Console.WriteLine("Kus sınıfına özel override method:Kuşlar uyaranlara güzel tepki verirler");
        }
        public void KuslarUcar()
        {
            Console.WriteLine("Kuslar ucarak hareket ederler");
        }
    }
}
