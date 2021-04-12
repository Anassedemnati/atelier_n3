using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtelierN1_G22
{
    class devise:IDevise
    {
        private double valeur;
        public devise(double val)
        {
            this.valeur = val;
        }
        public double convertir_to_us()
        {
            return this.valeur * 0.11;
        }
        public double convertir_to_eur()
        {
            return this.valeur * 0.09;
        }
    }
}
