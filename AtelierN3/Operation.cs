using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtelierN1_G22
{
    class Operation
    {
        private int num;
        private static int cpt = 0;
        private DateTime dateop;
        private string libelle;
        private MAD montant;


        public Operation( string lib, MAD montant)
        {
            this.num = ++cpt;
            this.dateop = DateTime.Now;
            this.libelle = lib;
            this.montant = montant;
        }

        public void afficherOpration()
        {
            Console.Write(this.dateop + "|" + this.num + "|" + this.libelle);
            this.montant.afficherSolde();
        }



    }
}
