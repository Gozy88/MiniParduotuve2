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
    public partial class SukurtiPrekeForm : Form
    {
        private readonly List<Preke> AddList;
        private Action<List<Preke>> Refresh;
        public SukurtiPrekeForm(List<Preke> sandelys, Action<List<Preke>> refresh)
        {
            InitializeComponent();
            AddList = sandelys;
            Refresh = refresh;
            
        }

        private void NaujaAtgalB_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
        }

        private void NaujaSukurtiB_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(NaujaPavadinimasTB.Text) || string.IsNullOrEmpty(NaujaKainaTB.Text))
            {

                MessageBox.Show("Neįvesti duomenys!");
            }
            else
            {
                try
                {
                    char dydis = ' ';
                    if (SCB.Checked)
                    {
                        dydis = 'S';
                    }
                    else if (MCB.Checked)
                    {
                        dydis = 'M';

                    }
                    else if (LCB.Checked)
                    {
                        dydis = 'L';
                    }

                    if (dydis == 'S' | dydis == 'M' | dydis == 'L')
                    {


                        string pavadinimas = NaujaPavadinimasTB.Text;
                        double kaina = Convert.ToDouble(NaujaKainaTB.Text);
                        Preke preke = new Preke(AddList.Count + 1, pavadinimas, kaina, true, dydis);
                        AddList.Add(preke);
                        Refresh(AddList);
                        Close();
                    }
                    else
                    {
                        MessageBox.Show("Nepažymėtas prekės dydis");
                    }

                }
                catch (Exception)
                {
                    MessageBox.Show("Blogas kainos formatas");

                }
            }
            
        }

        private void SCB_CheckedChanged(object sender, EventArgs e)
        {
            
            MCB.Checked = false;
            LCB.Checked = false;
        }

        private void MCB_CheckedChanged(object sender, EventArgs e)
        {
            SCB.Checked = false;
            LCB.Checked = false;
        }

        private void LCB_CheckedChanged(object sender, EventArgs e)
        {
            SCB.Checked = false;
            MCB.Checked = false;
            
        }
    }
    
}
