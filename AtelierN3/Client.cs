using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtelierN1_G22
{
    class Client
    {
        private string nom;
        private string prenom;
        private string adresse;
        private List<Compte> comptes;


        public Client(string n,string p, string a)
        {
            this.nom = n;
            this.prenom = p;
            this.adresse = a;
            this.comptes = new List<Compte>();

        }

        public void afficherClient()
        {
            Console.WriteLine("le nom est : " + this.nom);
            Console.WriteLine("le prenom est : " + this.prenom);
            Console.WriteLine("l'adresse est : " + this.adresse);

            foreach(Compte c in comptes)
            {
                c.consulter();

            }


        }

        public void ajouter_compte(Compte co)
        {
            this.comptes.Add(co);
        }

    }
}
