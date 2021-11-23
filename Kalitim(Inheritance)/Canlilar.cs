using System;
using System.Collections.Generic;
using System.Text;

namespace Kalitim_Inheritance_
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
    }
}
