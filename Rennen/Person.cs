using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Rennen
{
    public class Person
    {
        public Person(double gewicht)
        {

            this.Gewicht = gewicht;
        }

        public double Gewicht { get; set; }

        public string Name { get; set; }

    }
}