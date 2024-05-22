using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;

namespace Rennen
{
    public class Auto
    {
        public double Gewicht = 2000;
        public int MinAnzahlPersonen = 1;
        public int MaxAnzahlPersonen = 6;
        public double GesamtGewicht;
        public int AnzahlPersonen;
        

        public void Einsteigen()
        {
           if (AnzahlPersonen < MaxAnzahlPersonen)
            {
                AnzahlPersonen++;
            }
        }

        public void Aussteigen()
        {
            if (AnzahlPersonen > MinAnzahlPersonen)
            {
                AnzahlPersonen--;
            }

        }
        public double GesamtGewichtBerechnen()
        {
            return GesamtGewicht = Gewicht + (AnzahlPersonen*Person.Gewicht);
        }

        public Auto(double gewicht, int maxPerson)
        {            
            this.Gewicht = gewicht;
            this.MaxAnzahlPersonen = maxPerson;
        }

        
    }
}