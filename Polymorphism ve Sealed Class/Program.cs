using System;

namespace Polymorphism_ve_Sealed_Class
{
    class Program
    {
        static void Main(string[] args)
        {

            //Polymorphism (Çok Biçimcilik)
            // Çok biçimcilik ile birlikte hayatımıza sanal yani virtual metotlar giriyor.
            // Virtual metotlar ile nesne yönelimli programlama ilkesi olan polymorphism'i uygularız.
            // Sanal metotlar kalıtım alınan yani miras veren sınıf içerisinde yazılan ve daha sonra alt sınıflarda yeniden yazılabilen metotlardır.
            // Bunu da virtual ve override anahtar kelimeleri sağlar.
            TohumluBitkiler tohumluBitkiler = new TohumluBitkiler();

            
            //tohumluBitkiler.Solunum();
            //tohumluBitkiler.Bosaltim();
            //tohumluBitkiler.Fotosentez();
            //tohumluBitkiler.TohumlaCogalma();
            //tohumluBitkiler.UyaranlaraTepki();
            Console.WriteLine(nameof(Kuslar));
            Kuslar kuslar = new Kuslar();
            
            kuslar.GenelOzellik();
            kuslar.UyaranlaraTepki();

        }
    }
}
