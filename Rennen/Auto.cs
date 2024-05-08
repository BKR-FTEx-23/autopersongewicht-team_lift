using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Rennen
{
    public class Auto
    {


        public double Gewicht { get; set; }

        public int MaxAnzahlPersonen { get; set; }


        public Auto(double gewicht, int maxPerson)
        {            
            this.Gewicht = gewicht;
            this.MaxAnzahlPersonen = maxPerson;
        }

        
    }
}