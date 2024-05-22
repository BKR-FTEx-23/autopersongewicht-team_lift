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

        private void btnEinsteigen_Click(object sender, EventArgs e)
        {
            auto1.Einsteigen();
        }

        private void btnAussteigen_Click(object sender, EventArgs e)
        {
            auto1.Aussteigen();
        }
        public void Ausgabe()
        {
            double gewicht = auto1.GesamtGewichtBerechnen();
            txtAusgabe.Text = "Anzahl Personen: " + auto1.AnzahlPersonen +
                                "Gewicht: " + gewicht;
        }

    }
}
