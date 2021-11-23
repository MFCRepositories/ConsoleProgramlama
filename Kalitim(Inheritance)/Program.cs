using System;

namespace Kalitim_Inheritance_
{
    class Program
    {
        static void Main(string[] args)
        {

            //Inheritance (Kalıtım)
            // Bir sınıfın başka bir üst sınıftan miras almasına kalıtım denir.
            // Miras veren sınıf tüm özelliklerini alt sınıfa aktarmış olur.

                        TohumluBitkiler tohumluBitkiler = new TohumluBitkiler();
            //tohumluBitkiler.Beslenme();//Protected oldugundan erişim saglayamaz.Base sınıfından alabiliriz
            tohumluBitkiler.Solunum();
            tohumluBitkiler.Bosaltim();
            tohumluBitkiler.Fotosentez();
            tohumluBitkiler.TohumlaCogalma();

            Console.WriteLine("------------------------------------");
            Kuslar serce = new Kuslar();
            serce.Solunum();
            serce.Bosaltim();
            serce.Adaptasyon();
            serce.KuslarUcar();
            TohumsuzBitkiler tohumsuz = new TohumsuzBitkiler();
            Hayvanlar hayvanlar = new Hayvanlar();
            
        }
    }
}
