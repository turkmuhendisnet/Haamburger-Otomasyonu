using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Çalışma_Hamburger_Sistemi
{
    class SiparisSinifi
    {
        public MenulerSinifi SecilenMenu { get; set; }

        public MenuBoyutu SecilenBoyut { get; set; }

        public int SecilenMenuAdedi { get; set; }

        public List<EkstraMazlemelerSinifi> SecilenMenuEkstraMalzemeleri { get; set; }

        public Decimal SiparisTutuari { get; set; }

        public  void  SiparisHesaplama()
        {
            SiparisTutuari = 0;

            SiparisTutuari += SecilenMenu.MenuFiyati;

            //SiparisTutuari += SiparisTutuari * SecilenBoyut.MenuBoyuFiyati;
            switch (SecilenBoyut.MenuBoyu)
            {
                case "Büyük":SiparisTutuari += SiparisTutuari * SecilenBoyut.MenuBoyuFiyati;
                    break;
                case "Küçük":
                    SiparisTutuari += SiparisTutuari * SecilenBoyut.MenuBoyuFiyati;
                    break;
                case "Orta": SiparisTutuari += SiparisTutuari * SecilenBoyut.MenuBoyuFiyati;
                    break;
            }

            foreach (EkstraMazlemelerSinifi EkstraMalzeme in SecilenMenuEkstraMalzemeleri)
            {
                SiparisTutuari += EkstraMalzeme.EkstraMalzemeFiyati;
            }
            SiparisTutuari *= SecilenMenuAdedi;
        }
        public override string ToString()
        {
            if (SecilenMenuEkstraMalzemeleri.Count < 1) return string.Format("{0} Menu,x{1} Adet,{2} Boy,Toplam:{3}", SecilenMenu.MenuAdi, SecilenMenuAdedi, SecilenBoyut.MenuBoyu, SiparisTutuari.ToString());
            else
            {
                string EkstraMalzemeler = null;
                foreach (EkstraMazlemelerSinifi ekstramalazme in SecilenMenuEkstraMalzemeleri)
                    EkstraMalzemeler += ekstramalazme.EkstraMalzemeIsmi + "-";

                EkstraMalzemeler=EkstraMalzemeler.Trim('-');
                return string.Format("{0} Menu,x{1} Adet,{2} Boy,[{3}],Toplam:{4}", SecilenMenu.MenuAdi, SecilenMenuAdedi, SecilenBoyut.MenuBoyu, EkstraMalzemeler, SiparisTutuari.ToString("C2"));
            }
        }
    }
}
