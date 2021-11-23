using System;
using System.Collections.Generic;
using System.Text;

namespace Polymorphism_ve_Sealed_Class
{
    public class Canlilar
    {
        protected void Beslenme()
        {
            Console.WriteLine("Canlılar beslenir");
        } 
        public void Solunum()
        {
            Console.WriteLine("Canlılar solunum yapar");
        }
        public void Bosaltim()
        {
            Console.WriteLine("Canlılar bosaltım yapar");
        }

        public virtual void UyaranlaraTepki()
        {
            Console.WriteLine("Canlilar uyaranlara tepki verir.");
        }

        public virtual void GenelOzellik()
        {
            Console.WriteLine("Canlılar canlıdır");
        }
    }
}
