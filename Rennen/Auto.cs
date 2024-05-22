using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;

namespace Rennen
{
    public class Auto
    {
        private double Gewicht;
        private int MinAnzahlPersonen;
        private int MaxAnzahlPersonen;
        private double GesamtGewicht;
        private int AnzahlPersonen;
        

        

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
        public double GesamtGewichtBerechnen(Person person)
        {
            return GesamtGewicht = Gewicht + (AnzahlPersonen*person.GetGewicht());
        }
        public int GetAnzahl()
        {
            return AnzahlPersonen;
        }

        public Auto(double gewicht, int minPerson, int maxPerson)
        {            
            this.Gewicht = gewicht;
            this.MaxAnzahlPersonen = maxPerson;
            this.MinAnzahlPersonen = minPerson;
        }

        
    }
}