using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Rennen
{
    public class Auto
    {
        public string Farbe { get; set; }


        public double Gewicht { get; set; }


        public double Leistung { get; set; }


        public double Geschwindigkeit { get; set; }


        public double MaxGeschwindigkeit { get; set; }


        public string Marke { get; set; }

        public Auto(string farbe, string marke, double gewicht, double leistung, 
            double geschwindigkeit, double maxGeschwindigkeit)
        {
            this.Farbe = farbe;
            this.Gewicht = gewicht;
            this.Leistung = leistung;
            this.Geschwindigkeit = geschwindigkeit;
            this.MaxGeschwindigkeit = maxGeschwindigkeit;
            this.Marke = marke;
        }

        public void Bremsen()
        {
            if (this.Geschwindigkeit > 0)
            {
                Geschwindigkeit -= 1;
            }                     
            
        }

        public void Beschleunigen()
        {
            if (this.Geschwindigkeit < this.MaxGeschwindigkeit)
            {
                Geschwindigkeit += 1;
            }
        }

        public void Start()
        {
            throw new System.NotImplementedException();
        }

        public void Stop()
        {
            throw new System.NotImplementedException();
        }

        public void UpdateDebug()
        {
            throw new System.NotImplementedException();
        }
    }
}