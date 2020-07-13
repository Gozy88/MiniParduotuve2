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
    public partial class Form1 : Form
    {
        private List<Preke> Sandelys;
        private List<Preke> Prienamos;
        private List<Preke> Krepselis;
        public Form1()
        {
            InitializeComponent();
            Sandelys = new List<Preke>();
            Preke preke = new Preke(1, "Lempa", 19.99, true, 'M');
            Preke preke2 = new Preke(2, "Rasiklis", 1.99, true,'S');
            Preke preke3 = new Preke(3, "Saldainis", 0.99, true,'S');
            Preke preke4 = new Preke(4, "Kortos", 1.49, true,'S');
            Preke preke5 = new Preke(5, "Pieštukas", 0.39, true,'S');
       
            Sandelys.Add(preke);
            Sandelys.Add(preke2);
            Sandelys.Add(preke3);
            Sandelys.Add(preke4);
            Sandelys.Add(preke5);

            Prienamos = new List<Preke>();
            Krepselis = new List<Preke>();

            foreach (var item in Sandelys)
            {
                if (item.Prieinama)
                {
                    Prienamos.Add(item);
                }
            }
            PrekiuDGV.DataSource = Prienamos;

        }

        private void Refresh(List<Preke> sandelys)
        {
            PrekiuDGV.DataSource = null;
            Prienamos.Clear();
            foreach (var item in sandelys)
            {
                if (item.Prieinama)
                {
                    Prienamos.Add(item);
                }
            }
            PrekiuDGV.DataSource = Prienamos;

             PrekiuDGV.Refresh();
            PrekiuDGV.Update();
            Sandelys = sandelys;
        }
        private void Parduota()
        {
            
                Krepselis.Clear();
            
        }

        private void SukurtiPrekeB_Click(object sender, EventArgs e)
        {
            SukurtiPrekeForm form = new SukurtiPrekeForm(Sandelys, Refresh);
            form.Show();
        }

        private void DetiIKrepseliB_Click(object sender, EventArgs e)
        {

            


            string id = PrekiuDGV.CurrentRow.Cells[0].Value.ToString();
            foreach (var item in Sandelys)
            {
                if (item.Id == Convert.ToInt32(id))
                {
                    Krepselis.Add(item);
                    item.Prieinama = false;
                    Refresh(Sandelys);
                    
                }
            }

        }

        private void KrepselisB_Click(object sender, EventArgs e)
        {
            KrepselisForm form = new KrepselisForm(Krepselis, Parduota);
            form.Show();
        }
    }
}
