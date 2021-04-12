using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtelierN1_G22
{
    class Comptecourant :Compte
    {
        private Int64 num_cart_banc;
        private MAD decouvert_max;
       public Comptecourant(MAD s, Client titu, MAD dec,Int64 num_cart):base(s, titu)
        {
            this.decouvert_max = dec;
            this.num_cart_banc = num_cart;
        }

        public override bool debiter(MAD somme)
        {
           
            if (this.ComparerDecouvert(somme, decouvert_max))
            {
                return base.debiter(somme);
            }
            else
                return false;
        }
        public override void consulter()
        {
            base.consulter();
            this.decouvert_max.afficherSolde();
        }




    }
}
