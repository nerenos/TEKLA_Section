using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tekla_Section
{
    partial class NumberBox : TextBox
    {
        private decimal ValeurPrecedente;

        public NumberBox()
        {
            this.ValeurPrecedente = 0;
        }

        public void Verif_Saisie(object sender, EventArgs e)
        {
            double Decimal_Saisie;
            
            if (!Double.TryParse(this.Text.Replace(".", ","), out Decimal_Saisie))
            {
                this.Text = Convert.ToString(this.ValeurPrecedente).Replace(",", ".");
            }
            else
            {
                this.ValeurPrecedente = Convert.ToDecimal(this.Text.Replace(".", ","));
            }
        }
     }
    
    partial class SC_Longueur : FlowLayoutPanel
    {

    }
}
