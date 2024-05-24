using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Xml.Linq;

namespace Rennen
{
    public class Auto
    {
        private string Marke;
        private double Gewicht;
        private int MinAnzahlPersonen;
        private int MaxAnzahlPersonen;
        private List<Person> personenImAuto;

        private double GesamtGewicht
        {
            get
            {
                GesamtGewicht = Gewicht;
                foreach (var person in personenImAuto)
                {
                    GesamtGewicht += person.Gewicht;
                }
                return GesamtGewicht;
            }
            set { }
        }

        public void Einsteigen(Person person)
        {
            if (personenImAuto.Count < MaxAnzahlPersonen)
            {
                personenImAuto.Add(person);
            }
        }

        public void Aussteigen(Person person)
        {
            if (personenImAuto.Count >= MinAnzahlPersonen)
            {
                personenImAuto.Remove(person);
            }
        }
        public double GesamtGewichtBerechnen()
        {
            double gesamtgewicht = Gewicht;
            foreach (var person in personenImAuto)
            {
                gesamtgewicht += person.Gewicht;
            }
            return gesamtgewicht;
        }

        public string GetPassagiereString()
        {
            string passagiere = "";

            foreach (Person person in personenImAuto)
            {
                passagiere += person.ToString() + System.Environment.NewLine;
            }

            return passagiere;
        }
        public List<Person> GetPassagiere()
        {
            return new List<Person>(personenImAuto);
        }
        public override string ToString()
        {
            return $"{Marke} ({Gewicht} kg) " + System.Environment.NewLine +
                $"Maximale Personen: {MaxAnzahlPersonen}" + System.Environment.NewLine +
                $"Im Auto befindet sich: {personenImAuto.Count} Personen" + System.Environment.NewLine +
                $"{GetPassagiereString()}" + System.Environment.NewLine +
                $"Gesamtgewicht: {GesamtGewichtBerechnen()}";
        }



        public Auto(string marke, double gewicht, int minPerson, int maxPerson)
        {
            this.Marke = marke;
            this.Gewicht = gewicht;
            this.MaxAnzahlPersonen = maxPerson;
            this.MinAnzahlPersonen = minPerson;
            personenImAuto = new List<Person>();
        }


    }
}