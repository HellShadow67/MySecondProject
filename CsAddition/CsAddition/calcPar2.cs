using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CsAddition
{
    class calcPar2 : calc   //héritage calc
    {

        public calcPar2() : base()
        {
        }

        public calcPar2(double a, double b) : base(a, b)
        {
           
        }

        public override string addition(string a, string b)
        {
            //calcul de l'addition, à multiplier par 2
            string res;
            res = Convert.ToString(base.addition(Convert.ToDouble(a),Convert.ToDouble(b)) * 2);
            return (res);
        }

        public override double addition(double a, double b)
        {
            double res;
            res = base.addition(a, b) * 2;
            return (res);
        }

        public override double addition()
        {
            return (base.addition() * 2);
        }

      
    }
}