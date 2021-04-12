using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtelierN1_G22
{
    class CompEpargne : Compte
    {
        private double tauxInteret;
        private int cpt_debit = 0;
        public CompEpargne(MAD s,Client titu) : base(s,titu)
        {
            bool res;
            double taux;
            do
            {
                Console.WriteLine("donnez un taux");
               res=double.TryParse( Console.ReadLine(),out taux);

            } while (taux<=0 || taux>100 ||!res);

            this.tauxInteret = taux;

        }
        public void calculInteret()
        {
            this.ajouterInteret( this.tauxInteret / 100);
                  
        }
        public override void consulter()
        {
            base.consulter();
            Console.WriteLine(" le taux est :" + this.tauxInteret);

        }
        public override bool debiter(MAD somme)
        {
            if (ComparerSoldeSur2(somme) )
            {
                
                return base.debiter(somme); 
            }
            else
            {
                return false;
            }
        }



        }
}
