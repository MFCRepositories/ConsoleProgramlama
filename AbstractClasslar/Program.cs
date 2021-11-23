using System;

namespace AbstractClasslar
{
    class Program
    {
        static void Main(string[] args)
        {
            //Abstract Class


        //    Abstract class ları sadece kalıtım için kullanılan sınıflar gibi düşünebilirsiniz.
        // Bazı özellikleri ile sınıflara benzerlerken bazı özellikleriyle arayüzlere benzerler.
        // Abstract sınıfları arayüz ve virtual metotların birleşimi gibi davranış gösterirler.

        //    Kısaca abstract sınıfların özelliklerine bakacak olursak:
        // 1-)Normal sınıflar gibi new() anahtar kelimesi ile türetilemezler.
        // 2-)Interface ler gibi metot bildirimi yapabilirsiniz.
        // 3-)Sanal metotları override eder gibi abstract metotlar override edilebilir.
        // 4-)Abstract metotların gövdesi yazılamaz.
        // 5-)Bir abstract class bir abstract metot içeriyorsa, abstract sınıftan türeyen tüm sınıflar bu metodu override etmek zorundadır.
        // 6-)Bir sınıf sadece tek abstract sınıftan kalıtım alabilir.
        // 7-)Abstract sınıf başka bir abstract sınıftan kalıtım alabilir.
        // Dolaylı olacak türeyen sınıfta birden fazla abstract dan kalıtım almış olur.
        // Ve bağlantılı olduğu tüm abstract sınıfların bildirimi yapılmış olan abstract metotlarını override etmek zorundadır.


        //    ÖNEMLI: Abstract sınıf içerisinde metot bildirimi yapabilmek için metodun erişim belirtecinden sonra "abstract"
        // anahtar kelimesi mutlaka yazılmalıdır.
        //    ÖNEMLI: Abstract metotdan türetilmiş sınıf içerisinde abstract metodun kullanılabilmesi için de override anahtar
        // kelimesinin kullanılması gerekir.

        NewFocus focus1 = new NewFocus();
        Console.WriteLine(focus1.HangiMarkaninAraci().ToString());
        Console.WriteLine(focus1.KacTekerlektenOlusur());
        Console.WriteLine(focus1.StandartRengiNe().ToString());
        }
}
}
