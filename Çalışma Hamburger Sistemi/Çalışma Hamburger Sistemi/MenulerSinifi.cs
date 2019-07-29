using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Çalışma_Hamburger_Sistemi
{
    public class MenulerSinifi
    {
        public string MenuAdi { get; set; }

        public decimal MenuFiyati { get; set; }

        public Image MenuResmi { get; set; }

        public override string ToString()
        {
            return MenuAdi + " " + "Menu" + " " + MenuFiyati.ToString("C2");
        }

    }
}
