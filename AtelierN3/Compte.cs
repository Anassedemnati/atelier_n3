using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtelierN1_G22
{
    abstract class Compte
    {
        private readonly int Numcomp;
        private static int cpt ;
        private MAD solde;
        private  static MAD plafond;
        private Client titulaire;
        private List<Operation> historique; // declaration de la liste
        static  Compte( )
        {
            cpt = 0;
            plafond = new MAD(2000);
        }

        
        public Compte(MAD s, Client titu)
        {
            this.Numcomp = ++cpt;
            this.solde = s;
            this.titulaire = titu;
            this.historique = new List<Operation>();  // la creation de la liste 

            this.titulaire.ajouter_compte(this);
        }

        public virtual  void consulter()
        {
            Console.WriteLine("le num est : " + this.Numcomp);
            
            this.solde.afficherSolde();
            

            foreach(Operation o in historique)
            {
                o.afficherOpration();
            }


        }
     
        public virtual bool crediter(MAD somme)
        {
            MAD nul_val = new MAD(0);
            if (somme > nul_val)
            {
                this.solde += somme;
                this.historique.Add(new Operation("+", somme));
                return true;
            }
            else return false;
        }

        public  virtual bool debiter(MAD somme)
        {
            MAD nul_val = new MAD(0);
            if (this.solde >= somme)
            {
                if (somme <= plafond)
                {
                    if (somme> nul_val)
                    {
                        this.solde -= somme;
                        this.historique.Add(new Operation("-", somme));
                        return true;

                    }
                    else
                    {
                        Console.WriteLine("somme<0");
                        return false;
                    }
                }
                else
                {
                    Console.WriteLine("plafond<somme");
                    return false;
                }
            }
            else
            {
                Console.WriteLine("solde<somme");
                return false;
            }
        }



        public bool verser(Compte c, MAD somme)
        {
            if (this.debiter(somme))
            {
                c.crediter(somme);
                return true;
            }
            return false;
        }

        public void ajouterInteret(double interet)
        {
            MAD inter = this.solde*interet;
            this.crediter(inter);

        }


        public bool ComparerDecouvert(MAD somme,MAD decouvert)
        {
            if(this.solde - somme > decouvert)
            {
                return true;
            }
            return false;
        }
        public bool ComparerSoldeSur2(MAD somme)
        {
            if (somme <= this.solde / 2)
            {
                return true;
            }
            return false;
        }
        public bool Comparer_solde_avec_5_debi(MAD somme)
        {
            if (somme +((somme*5)/100)<= this.solde)
            {
                return true;
            }
            return false;
        }

    }
}
