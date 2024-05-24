using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Rennen
{
    public class Person
    {
        public double Gewicht { get; set; }
        private string Name {  get; set; }
        private int ID {  get; set; }


        public Person(string name,double gewicht,int id)
        {
            this.Name = name;
            this.Gewicht = gewicht;
            this.ID = id;
        }

        public Person(string name, double gewicht):this(name,gewicht,123)
        {        }

        public string GetName()
        {
            return Name;
        }
        public override string ToString()
        {
            return $"{Name} ({Gewicht} kg) ID:{ID}";
        }


    }
}