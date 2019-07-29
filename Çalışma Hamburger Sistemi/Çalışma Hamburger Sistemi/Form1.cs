using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Çalışma_Hamburger_Sistemi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        List<MenulerSinifi> Menuler = new List<MenulerSinifi>()
        {
            new MenulerSinifi {MenuAdi="Big Mac",            MenuFiyati=18.25m,      MenuResmi=Properties.Resources.Bigmac},
            new MenulerSinifi {MenuAdi="Cheeseburger",       MenuFiyati=8,           MenuResmi=Properties.Resources.Cheeseburger},
            new MenulerSinifi {MenuAdi="Mangal Burger",      MenuFiyati=17,          MenuResmi=Properties.Resources.Mangalburger},
            new MenulerSinifi {MenuAdi="McRoyal",            MenuFiyati=12,          MenuResmi=Properties.Resources.Mcroyal},
            new MenulerSinifi {MenuAdi="McChicken",          MenuFiyati=18.5m,       MenuResmi=Properties.Resources.Mcchicken},
            new MenulerSinifi {MenuAdi="Double Cheeseburger",MenuFiyati=21.5m,       MenuResmi=Properties.Resources.Doublecheeseburger},
            new MenulerSinifi {MenuAdi="Max Burger",         MenuFiyati=17.5m,       MenuResmi=Properties.Resources.Maxburger},
            new MenulerSinifi {MenuAdi="Hamburger",          MenuFiyati=15.5m,       MenuResmi=Properties.Resources.Hamburger}
        };
        List<EkstraMazlemelerSinifi> EkstraMalzemeler = new List<EkstraMazlemelerSinifi>()
        {
            new EkstraMazlemelerSinifi{EkstraMalzemeIsmi="Sarımsak",   EkstraMalzemeFiyati=0.75m},
            new EkstraMazlemelerSinifi{EkstraMalzemeIsmi="Ranch",      EkstraMalzemeFiyati=0.50m},
            new EkstraMazlemelerSinifi{EkstraMalzemeIsmi="Barbekü",    EkstraMalzemeFiyati=0.50m},
            new EkstraMazlemelerSinifi{EkstraMalzemeIsmi="Domates",    EkstraMalzemeFiyati=0.75m},
            new EkstraMazlemelerSinifi{EkstraMalzemeIsmi="Soğan",      EkstraMalzemeFiyati=0.75m},
            new EkstraMazlemelerSinifi{EkstraMalzemeIsmi="Buffalo",    EkstraMalzemeFiyati=0.50m},
        };
        List<MenuBoyutu> MenuBoyu = new List<MenuBoyutu>()
        {
            new MenuBoyutu {MenuBoyu="Büyük",  MenuBoyuFiyati=0.2m},
            new MenuBoyutu {MenuBoyu="Orta",   MenuBoyuFiyati=0.1m},
            new MenuBoyutu {MenuBoyu="Küçük",  MenuBoyuFiyati=1}
        };

      //  List<SiparisSinifi> Siparisler = new List<SiparisSinifi>();

        bool cmbGirilmismi = false;
        private void cmbMenuListesi_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbGirilmismi = true;
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            pcbMenuResmi.Image = Properties.Resources.Mc_Amlemi_svg;


            foreach (MenulerSinifi menu in Menuler)
                cmbMenuListesi.Items.Add(menu);


            foreach (EkstraMazlemelerSinifi EkstraMalzeme in EkstraMalzemeler)                     // Tag Bir obje tutar "EkstraMalzeme" nin hem ismini hem fiyatı tutar
                flpExtraMazemeSecimi.Controls.Add(new CheckBox () {Text=EkstraMalzeme.EkstraMalzemeIsmi,ForeColor=Color.White,Tag=EkstraMalzeme });
            /* new CheckBox  bir sınıf olduğundan süslü parantezle propertieslerine eişe biliriz yukarıda GericListin içinde 
             * "new MenulerSinifi {MenuAdi="Hamburger",MenuFiyati=15.5m,MenuResmi=Properties.Resources.Hamburger}" içindeki 
             * propertieslerine erişebildiğimiz gibi
             */ 
        }


        private void btnSepeteEkle_Click(object sender, EventArgs e)
        {
            if (cmbGirilmismi == true)
            {

                SiparisSinifi Siparis = new SiparisSinifi() ;

                Siparis.SecilenMenu = (MenulerSinifi)cmbMenuListesi.SelectedItem;


                if (rdbBuyukBoyut.Checked)
                    Siparis.SecilenBoyut =MenuBoyu[0];
                else if (rdbOrtaBoyut.Checked)
                    Siparis.SecilenBoyut =MenuBoyu[1];
                else if (rdbKucukBoyut.Checked)
                    Siparis.SecilenBoyut =MenuBoyu[2];


                Siparis.SecilenMenuEkstraMalzemeleri = new List<EkstraMazlemelerSinifi>();

                foreach (CheckBox EkstraMalzeme in flpExtraMazemeSecimi.Controls)
                     if (EkstraMalzeme.Checked)
                        Siparis.SecilenMenuEkstraMalzemeleri.Add((EkstraMazlemelerSinifi)(EkstraMalzeme.Tag));
                // Tag Bir obje tutar "EkstraMalzeme" nin hem ismini hem fiyatı tutar
                //MessageBox.Show(EkstraMalzeme.Tag.ToString());


                Siparis.SecilenMenuAdedi = Convert.ToInt32(nupMenuAdedi.Value);

                Siparis.SiparisHesaplama();

               // Siparisler.Add(Siparis);

                lstSiparisSepeti.Items.Add(Siparis);

                ToplamTutar();

                KontrolTemizlemeSinifi.KontrolTemileme(this.Controls);
            }
            else
                MessageBox.Show("Menu Secimi Yapmadınız");
        }

        private decimal ToplamTutar()
        {
            decimal ToplamTutar = 0;

            //foreach (SiparisSinifi siparis in Siparisler)
            //    ToplamTutar += siparis.SiparisTutuari;
            foreach (SiparisSinifi siparis in lstSiparisSepeti.Items)
                ToplamTutar += siparis.SiparisTutuari;

            lblToplamTutar.Text = ToplamTutar.ToString("C2");
            return ToplamTutar;
        }

        private void btnSiparisiTamamla_Click(object sender, EventArgs e)
        {
            DialogResult MesajBoxtanDonen = MessageBox.Show("Toplam Sipariş Ücreti:" + ToplamTutar().ToString("C2") + "\nSiparişi tamamlamak istermisiniz", "SiparişBilgileri", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (MesajBoxtanDonen==DialogResult.Yes)
            {
                lstSiparisSepeti.Items.Clear();
               // Siparisler.Clear();
                pcbMenuResmi.Image = Properties.Resources.Mc_Amlemi_svg;
                ToplamTutar();
                MessageBox.Show("Sipariş Tamamlandı");
            }
            else if(MesajBoxtanDonen==DialogResult.No)
            {
                MessageBox.Show("Siparişler İptal Edilmiştir.");
            }
        }
    }
}
