using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtelierN1_G22
{
    class Program
    {
        static void Main(string[] args)
        {

            Client cl1 = new Client("elhainouni", "Badr", "add1");
            Client cl2 = new Client("ouatiq", "Abdelallah", "add2");
            MAD s1 = new MAD(20000);
            MAD s3 = new MAD(20000);
            MAD dec = new MAD(200);
            CompEpargne cpt1 = new CompEpargne(s1, cl1);
            CompEpargne cpt2 = new CompEpargne(s1, cl1);
            Comptecourant cpt3 = new Comptecourant(s1,cl1, dec);
            //Compte cptest = new(s1, cl1);

            cpt1.crediter(new MAD(1500));
            cpt1.verser(cpt2, new MAD(1500));
            cpt2.consulter();
            cpt1.consulter();
            cl1.afficherClient();
            Console.ReadKey();

        }
    }
}
