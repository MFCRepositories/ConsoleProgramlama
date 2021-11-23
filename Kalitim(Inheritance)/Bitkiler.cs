using System;
using System.Collections.Generic;
using System.Text;

namespace Kalitim_Inheritance_
{
    public class Bitkiler:Canlilar
    {
        public void Fotosentez()
        {
            Console.WriteLine("Bitkiler fotosentez yapar");
        }
    }

    public class TohumluBitkiler: Bitkiler
    {
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
