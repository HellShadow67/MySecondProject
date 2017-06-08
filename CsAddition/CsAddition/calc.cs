using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CsAddition
{
    //abstract //si en abstract, à la compilation cela va planter car aucun(e) objet/instance ne pourra être créé

    class calc : operation //heritage
    {
        //atributs privés

        static public string monProgramme = "lol";
        
        private double valA;
        private double valB;
        private double valc;
        private double vald;


        public calc()//constructeur
                {
                    valA = 99;
                    valB = 99;
                    valc = 99;
                    vald = 99;
        }
        public calc(double a, double b, double c)
        {
            valA = a;
            valB = b;
            valc = c;
        }

        public calc(double a, double b)
        {
            valA = a;
            valB = b;
        }

      
        public override string addition(string a, string b)
        {
            valA = Convert.ToDouble(a);
            valB = Convert.ToDouble(b);
            return Convert.ToString(valA +valB);
        }

        public override double addition(double a, double b)
        {
            valA = a;
            valB = b;
            return (valA + valB);
        }

        public override double addition(double a, double b, double c)
        {
            valA = a;
            valB = b;
            valc = c;
            return (valA + valB + valc);
        }

        public override double addition(double a, double b, double c,double d)
        {
            valA = a;
            valB = b;
            valc = c;
            vald = d;
            return (valA + valB + valc + vald);
        }

        public override double addition()
        {
            return (valA + valB);
        }

       

    }
}
