using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CsAddition
    {
    // à quoi sert la classe abstraite?
    // le chef de projet donne la classe abstraite et tout le monde doit suivre les méthodes de la classe


    abstract class operation
    {
        //atributs privés   
        
        abstract public  string addition(string a, string b);
 
        abstract public  double addition(double a, double b);
 
        abstract public  double addition();

        abstract public double addition(double a, double b, double c);

        abstract public double addition(double a, double b, double c,double d);

        public string disBonjour()
        {
            return "Salut";
        }

    }
}
