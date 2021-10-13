using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exos_Banque01
{
    class Courant
    {
        public string Numero { get; set; }
        public double Solde { get; private set; }

        #region Si le solde n'était pas une auto-propriété
        //private double _solde;

        //public double Solde
        //{
        //    get { return _solde; }
        //} 
        //ATTENTION : SI la propriété Solde n'a pas de SET, alors les lignes 39 et 44 doivent affecter les valeurs au champs _solde
        #endregion

        public Personne Titulaire { get; set; }

        private double _ligneDeCredit;

        public double LigneDeCredit
        {
            get { return _ligneDeCredit; }
            set { 
                if(value >= 0) _ligneDeCredit = value;
                //signaler erreur
            }
        }

        public void Retrait(double montant) {
            if (montant <= 0) return;   //signaler erreur
            if( Solde + LigneDeCredit >= montant) Solde = Solde - montant;
            //signaler l'erreur
        }
        public void Depot(double montant) {
            if (montant <= 0) return;   //signaler erreur
            Solde = Solde + montant;
        }

    }
}
