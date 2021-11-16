using System;
using System.Linq;

namespace StringMethodlar
{
    class Program
    {
        static void Main(string[] args)
        {
            string sentence = "Bu bir deneme cümlesidir.";

            var adet = sentence.Count();

            bool result = sentence.StartsWith("Bu");
            bool result2 = sentence.StartsWith("Bu b");
            bool result3 = sentence.StartsWith("Bubir");
            bool result4 = sentence.StartsWith("deneme cümlesidir.");

            bool result5 = sentence.EndsWith(".");
            bool resul65 = sentence.EndsWith("r.");
            bool result7 = sentence.EndsWith("Bu");
            bool result8 = sentence.EndsWith("bir deneme cümlesidir.");

            var result9 = sentence.IndexOf("bir");
            var result10 = sentence.IndexOf("blog");

            var newSentence = sentence.Insert(0, "Selam! ");

            Console.WriteLine(newSentence);

            var result13 = sentence.Replace(" ", "-");
            Console.WriteLine(result);

            var result14 = sentence.Remove(2);
            Console.WriteLine(result);


            var copySentence = sentence.Clone();
            Console.WriteLine(copySentence);


            var result15 = sentence.Substring(3);
            Console.WriteLine(result);
        }

    }
}
