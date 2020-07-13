using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiniParduotuve2
{
    public partial class KrepselisForm : Form
    {
        private readonly List<Preke> KrepselisList;
        char siuntosDydis = ' ';
        double siuntosKaina = 0;
        double suma = 0;
        private Action Parduota;
        public KrepselisForm(List<Preke> krepselis, Action parduota)
        {
            InitializeComponent();
            KrepselisList = krepselis;

            KrepselisDGV.DataSource = krepselis;
            this.KrepselisDGV.Columns["Id"].Visible = false;
            this.KrepselisDGV.Columns["Prieinama"].Visible = false;
            double prekiuKaina = 0;
            foreach (var item in krepselis)
            {
               prekiuKaina += item.Kaina;
            }
            PrekiuKainaLB.Text = "Prekių kaina: " + prekiuKaina;
            Parduota = parduota;


            
            

        }

        private void PristatymasPastuRB_CheckedChanged(object sender, EventArgs e)
        {
            SiuntosPaštas pastu = new SiuntosPaštas(KrepselisList, out siuntosDydis, out siuntosKaina, out suma);
            SiuntosDydisLB.Text = "Siuntos dydis: " + siuntosDydis.ToString();
            SumaLB.Text = "Suma: " + suma.ToString();
            SiuntimoKainaLB.Text = "Siuntimo kaina: " + siuntosKaina.ToString();
        }

        private void KurjerisRB_CheckedChanged(object sender, EventArgs e)
        {
            Kurjeriu kurjeriu = new Kurjeriu(KrepselisList, out siuntosDydis, out siuntosKaina, out suma);
            SiuntosDydisLB.Text = "Siuntos dydis: " + siuntosDydis.ToString();
            SumaLB.Text = "Suma: " + suma.ToString();
            SiuntimoKainaLB.Text = "Siuntimo kaina: " + siuntosKaina.ToString();
        }

        private void PastomatasRB_CheckedChanged(object sender, EventArgs e)
        {
            Pastomatu pastomatu = new Pastomatu(KrepselisList, out siuntosDydis, out siuntosKaina, out suma);
            SiuntosDydisLB.Text = "Siuntos dydis: " + siuntosDydis.ToString();
            SumaLB.Text = "Suma: " + suma.ToString();
            SiuntimoKainaLB.Text = "Siuntimo kaina: " + siuntosKaina.ToString();
        }

        private void TarptautinisRB_CheckedChanged(object sender, EventArgs e)
        {
            Tarptautines tarptautiniu = new Tarptautines(KrepselisList, out siuntosDydis, out siuntosKaina, out suma);
            SiuntosDydisLB.Text = "Siuntos dydis: " + siuntosDydis.ToString();
            SumaLB.Text = "Suma: " + suma.ToString();
            SiuntimoKainaLB.Text = "Siuntimo kaina: " + siuntosKaina.ToString();
        }

        private void PirktiB_Click(object sender, EventArgs e)
        {
            if (suma != 0)
            {
                Parduota();
                this.Close();
            }
            else
            {
                MessageBox.Show("Nepasirinktas pristatymo tipas");

            }
        }
        
    }
}
