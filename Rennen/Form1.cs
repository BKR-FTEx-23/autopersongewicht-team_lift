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
            txtAusgabe.Text = auto.ToString();
        }
        Auto auto = new Auto("VW Golf",1200, 1, 6);
        Person person1 = new Person("Anne", 65);
        Person person2 = new Person("Peter", 85);


        private void btnEinsteigen_Click(object sender, EventArgs e)
        {
            if (chBox1.Checked)
            {
                auto.Einsteigen(person1);
            }
            if (chBox2.Checked)
            {
                auto.Einsteigen(person2);
            }
            txtAusgabe.Text = auto.ToString();
        }

        private void btnAussteigen_Click(object sender, EventArgs e)
        {
            if (chBox1.Checked)
            {
                auto.Aussteigen(person1);
            }
            if (chBox2.Checked)
            {
                auto.Aussteigen(person2);
            }
            txtAusgabe.Text = auto.ToString();
            
        }

    }
}
