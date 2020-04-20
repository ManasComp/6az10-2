using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6az10_2
{
    class Ukony
    {
        //pokud přidáme funkcionalitu, musíme uporavit separátory
        public double Rozhodovani(double a, double b, string separator)
        {
            double meziVysledek =0;

            if (separator == "+")
            {
                meziVysledek = Scitani(a, b);
            }
            else if (separator == "-")
            {
                meziVysledek = Odcitani(a, b);
            }
            else if (separator == "*")
            {
                meziVysledek = Nasobeni(a, b);
            }
            else if (separator == "/")
            {
                meziVysledek = Deleni(a, b);
            }
            else
            {
                throw new ArgumentException("Neočekávaná chyba");
            }
            return meziVysledek;
        }

        private double Scitani(double a, double b)
        {
            double meziVysledek = a + b;
            return meziVysledek;
        }

        private double Odcitani(double a, double b)
        {
            double meziVysledek = a - b;
            return meziVysledek;
        }

        private double Nasobeni(double a, double b)
        {
            double meziVysledek = a * b;
            return meziVysledek;
        }

        private double Deleni(double a, double b)
        {
            double meziVysledek = 0;
            if (b == 0)
            {
                throw new ArgumentException("Nelze dělit nulou");
            }
            else
            {
                meziVysledek = a / b;
            }
            return meziVysledek;
        }
    }
}
