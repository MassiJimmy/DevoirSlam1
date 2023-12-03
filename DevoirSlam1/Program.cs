using System;

namespace DevoirSlam1
{
    public class COMMANDE
    {
        public int idCde { get; set; } // Numéro de commande
        public int numCli { get; set; } // numéro du client
        public DateTime dateCde { get; set; }
        public int[] tabProd { get; set; }
        public int[] tabQte { get; set; }
        public int[] TabQte { get; set; }
        public int nbProd { get; set; }
        public COMMANDE(int idCde, int numCli, DateTime dateCde, int[] tabProd, int[] tabQte, int[] TabQte, int nbProd)
        {
            this.idCde = idCde;
            this.numCli = numCli;
            this.dateCde = dateCde;
            this.tabProd = tabProd;
            this.tabQte = tabQte;
            this.TabQte = TabQte;
            this.nbProd = nbProd;
        }
    }
    
    class Program
    {
        static void Main(string[] args)
        {
            
            int UnNumProd = 0;
            int UneQte = 0;
            COMMANDE cde1 = new COMMANDE(1, 1, DateTime.Now, new int[10], new int[10], new int[1], 5);
            AjoutProd(UnNumProd, UneQte,cde1.tabProd,cde1.tabQte);
            Console.WriteLine("Id commande= " + cde1.idCde);
            Console.WriteLine("Numéro de client = " + cde1.numCli);
            Console.WriteLine("Date de la commande = " + cde1.dateCde);
            Console.WriteLine("Tableau des id produits = ");
            for (int j = 0; j < 10; j++)
            {
                Console.Write(cde1.tabProd[j] + " ");
            }
            Console.WriteLine("");
            Console.WriteLine("Tableau de la quantité des produits = ");
            for (int j = 0; j < 10; j++)
            {
                Console.Write(cde1.tabQte[j] + " ");
            }
            Console.WriteLine("");
            cde1.TabQte[0] = cde1.tabQte[1];
            Console.WriteLine("Quantité du produit tabProd[1]= " + cde1.TabQte[0]);




        }
        static void AjoutProd(int UnNumProd, int UneQte, int[] tabProd, int[] tabQte)
        {
            int i = 0;
            int re = 1;
            do
            {
                Console.WriteLine("Entrez le numéro de produit");
                UnNumProd = int.Parse(Console.ReadLine());
                Console.WriteLine("Entrez la quantité de ce produit");
                UneQte = int.Parse(Console.ReadLine());
                tabProd[i] = UnNumProd;
                tabQte[i] = UneQte;
                i++;
                Console.WriteLine("Voulez vous ajouter un autre produit? 1 pour oui");
                re = int.Parse(Console.ReadLine());
            } while (i<10 && re==1);
        }
    }
}
