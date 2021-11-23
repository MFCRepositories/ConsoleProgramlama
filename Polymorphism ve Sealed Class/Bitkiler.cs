using System;
using System.Collections.Generic;
using System.Text;

namespace Polymorphism_ve_Sealed_Class
{
    public class Bitkiler:Canlilar
    {
        public void Fotosentez()
        {
            Console.WriteLine("Bitkiler fotosentez yapar");
        }
        public override void UyaranlaraTepki()
        {
            base.UyaranlaraTepki();
            Console.WriteLine("Bitkiler güneşe tepki verir");
        }
        
    }

    public class TohumluBitkiler: Bitkiler
    {
        public override void GenelOzellik()
        {
            base.GenelOzellik();
        }
        public TohumluBitkiler()
        {
            base.Beslenme();
            base.Fotosentez();
        }
        public void TohumlaCogalma()
        {
            Console.WriteLine("Tohumlu bitkiler tohumla cogalır");
        }
    }
    public class TohumsuzBitkiler: Bitkiler
    {
        public void SporlaCogalma()
        {
            Console.WriteLine("Tohumsuz bitkiler sporla cogalır.");
        }
    }
}
