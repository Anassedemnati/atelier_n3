using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtelierN1_G22
{
    class MAD
    {
        private double valeur; 

        public MAD(double val)
        {
            this.valeur = val;
        }
        public void afficherSolde()
        {
            Console.WriteLine("la valeur est : " + this.valeur);
        }


        public static bool operator>(MAD m1, MAD m2)
        {
            if (m1.valeur> m2.valeur)
            {
                return true;
            }
           else
                return false;

        }

        public static bool operator <(MAD m1, MAD m2)
        {
            if (m1.valeur < m2.valeur)
            {
                return true;
            }
           else  return false;

        }
        public static bool operator >=(MAD m1, MAD m2)
        {
            if (m1.valeur >= m2.valeur)
            {
                return true;
            }
            else
                return false;

        }

        public static bool operator <=(MAD m1, MAD m2)
        {
            if (m1.valeur <= m2.valeur)
            {
                return true;
            }
            else return false;

        }
        public static MAD operator+(MAD m1, MAD m2)
        {
            MAD m3 = new MAD(m1.valeur+m2.valeur);
            return m3;
        }
        public static MAD operator-(MAD m1, MAD m2)
        {
            MAD m3 = new MAD(m1.valeur - m2.valeur);
            return m3;
        }
        public static MAD operator *(MAD m1, double m2)=> new MAD(m1.valeur * m2);
        public static MAD operator /(MAD m1, double m2)=> new MAD(m1.valeur / m2);
       


    }
}
