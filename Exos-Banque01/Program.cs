using System;

namespace Exos_Banque01
{
    class Program
    {
        static void Main(string[] args)
        {
            Personne p1 = new Personne();
            p1.Prenom = "Samuel";
            p1.Nom = "Legrain";
            p1.DateNaiss = new DateTime(1987, 9, 27);

            Courant c1 = new Courant();
            c1.Numero = "BE97 0000 0000 0000";
            c1.LigneDeCredit = 200;
            c1.Titulaire = p1;

            Console.WriteLine(c1);

            Console.WriteLine($"Compte N° {c1.Numero}\nTitulaire : {c1.Titulaire.Nom} {c1.Titulaire.Prenom} né en {c1.Titulaire.DateNaiss.Year}");
            Console.WriteLine($"Solde actuel : {c1.Solde}\tLigne de crédit : {c1.LigneDeCredit}");

            c1.Depot(500);

            Console.WriteLine($"Compte N° {c1.Numero}\nTitulaire : {c1.Titulaire.Nom} {c1.Titulaire.Prenom} né en {c1.Titulaire.DateNaiss.Year}");
            Console.WriteLine($"Solde actuel : {c1.Solde}\tLigne de crédit : {c1.LigneDeCredit}");

            c1.Retrait(1000);

            Console.WriteLine($"Compte N° {c1.Numero}\nTitulaire : {c1.Titulaire.Nom} {c1.Titulaire.Prenom} né en {c1.Titulaire.DateNaiss.Year}");
            Console.WriteLine($"Solde actuel : {c1.Solde}\tLigne de crédit : {c1.LigneDeCredit}");

        }
    }
}
