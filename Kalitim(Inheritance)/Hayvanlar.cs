using System;
using System.Collections.Generic;
using System.Text;

namespace Kalitim_Inheritance_
{
    public class Hayvanlar:Canlilar
    {
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
        public void KuslarUcar()
        {
            Console.WriteLine("Kuslar ucarak hareket ederler");
        }
    }
}
