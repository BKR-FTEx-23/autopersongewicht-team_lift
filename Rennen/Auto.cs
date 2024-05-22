using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;

namespace Rennen
{
    public class Auto
    {
        public double Gewicht;
        public int MinAnzahlPersonen;
        public int MaxAnzahlPersonen;
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

        public Auto(double gewicht, int minPerson, int maxPerson)
        {            
            this.Gewicht = gewicht;
            this.MaxAnzahlPersonen = maxPerson;
            this.MinAnzahlPersonen = minPerson;
        }

        
    }
}