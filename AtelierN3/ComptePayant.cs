using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtelierN1_G22
{
    class ComptePayant : Compte
    {
        public ComptePayant(MAD s, Client titu) : base(s, titu)
        {


        }
        public override bool debiter(MAD somme)
        {

            if (this.Comparer_solde_avec_5_debi(somme))
            {
                return base.debiter(somme + ((somme * 5) / 100 ));
            }
            else
                return false;
        }
        public override bool crediter(MAD somme)
        {
            if (base.crediter(somme - ((somme * 5) / 100)))
            {
                return true;
            }
            else return false;
        }


    }
}
