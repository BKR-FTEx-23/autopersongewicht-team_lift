using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rennen
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }
        Auto auto1 = new Auto(2000, 1, 6);
        Person p1 = new Person(100);

        private void btnEinsteigen_Click(object sender, EventArgs e)
        {
            auto1.Einsteigen();
            Ausgabe();
        }

        private void btnAussteigen_Click(object sender, EventArgs e)
        {
            auto1.Aussteigen();
            Ausgabe();
        }
        public void Ausgabe()
        {
            double gewicht = auto1.GesamtGewichtBerechnen(p1);
            txtAusgabe.Text = "Anzahl Personen: " + auto1.GetAnzahl() +
                                System.Environment.NewLine+"Gewicht: " + gewicht;
        }

    }
}
