using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Rennen
{
    public class Auto
    {
        public string farbe { get; set; }


        public double gewicht { get; set; }


        public double leistung { get; set; }


        public double geschwindigkeit { get; set; }


        public double maxGeschwindigkeit { get; set; }


        public string marke { get; set; }

        public Auto(string farbe, string marke, double gewicht, double leistung, 
            double geschwindigkeit, double maxGeschwindigkeit)
        {
            this.farbe = farbe;
            this.gewicht = gewicht;
            this.leistung = leistung;
            this.geschwindigkeit = geschwindigkeit;
            this.maxGeschwindigkeit = maxGeschwindigkeit;
            this.marke = marke;
        }

        public void Bremsen()
        {
                       
            throw new System.NotImplementedException();
        }

        public void Beschleunigen()
        {
            throw new System.NotImplementedException();
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