using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClasslar
{
    public class Focus:IOtomobil
    {
        public Marka HangiMarkaninAraci()
        {
            return HangiMarkaninAraci.Ford;
        }

        public int KacTekerlektenOlusur()
        {
            return 4;
        }

        public Renk StandartRengiNe()
        {
            return Renk.Beyaz;
        }
        
    }
}
