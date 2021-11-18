using System;
using System.Collections.Generic;
using System.Text;

namespace Telefon_Rehberi_Uygulaması
{
    public class Menu
    {
        public void Menus()
        {
            string[] Menuler =
            {
                "(1) Yeni Numara Kaydetmek",
                "(2) Varolan Numarayı Silmek",
                "(3) Varolan Numarayı Güncelleme",
                "(4) Rehberi Listelemek",
                "(5) Rehberde Arama Yapmak﻿"
            };
            foreach (var m in Menuler)
            {
                Console.WriteLine(m+"/n");
            }
    }
      
    }
}
