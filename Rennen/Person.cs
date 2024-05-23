using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Rennen
{
    public class Person
    {

        public Person(string name,double gewicht)
        {
            this.Name = name;
            this.Gewicht = gewicht;
        }
        private double Gewicht;
        private string Name;
        public double GetGewicht()
        {
            return Gewicht;
        }
        public string GetName()
        {
            return Name;
        }
        public override string ToString()
        {
            return $"{Name} ({Gewicht} kg)";
        }


    }
}