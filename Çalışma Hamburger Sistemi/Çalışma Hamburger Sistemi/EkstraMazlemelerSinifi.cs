using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Çalışma_Hamburger_Sistemi
{
    public class EkstraMazlemelerSinifi
    {
        public decimal EkstraMalzemeFiyati { get; set; }

        public string EkstraMalzemeIsmi { get; set; }


        public override string ToString()
        {
            return EkstraMalzemeIsmi+EkstraMalzemeFiyati;
        }

    }
}
