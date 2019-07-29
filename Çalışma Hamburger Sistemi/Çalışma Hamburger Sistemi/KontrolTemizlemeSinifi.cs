using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Çalışma_Hamburger_Sistemi
{
    public static class KontrolTemizlemeSinifi
    {
        public static  void KontrolTemileme (Control.ControlCollection GelenKontroler)
        {
            foreach (Control kontrol in GelenKontroler)
            {
                if (kontrol is ComboBox) ((ComboBox)kontrol).SelectedIndex = -1;
                else if (kontrol is RadioButton)
                {
                    if (((RadioButton)kontrol).Name == "rdbKucukBoyut") ((RadioButton)kontrol).Checked = true;
                    else ((RadioButton)kontrol).Checked = false;
                }
                else if (kontrol is NumericUpDown) ((NumericUpDown)kontrol).Value = 1;
                else if (kontrol is CheckBox) ((CheckBox)kontrol).Checked = false;
                else if (kontrol is GroupBox) KontrolTemileme(((GroupBox)kontrol).Controls);
                else if (kontrol is FlowLayoutPanel) KontrolTemileme(((FlowLayoutPanel)kontrol).Controls);
            }
        }
    }
}
