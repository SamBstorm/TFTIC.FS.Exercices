using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exos_Banque01
{
    class Banque
    {
        public string Nom { get; set; }

        private Dictionary<string, Courant> _comptes = new Dictionary<string, Courant>();

        public Courant this[string numero]
        {
            get
            {
                Courant compte;
                _comptes.TryGetValue(numero, out compte);
                return compte;
            }

            set
            {
                if (value != null && value.Numero == numero)
                    _comptes[numero] = value;
            }
        }

        public void Ajouter(Courant compte)
        {
            if (compte != null)
                _comptes.Add(compte.Numero, compte);
        }

        public void Supprimer(string numero)
        {
            if (numero != null)
                _comptes.Remove(numero);
        }

        public double AvoirDesComptes(Personne titulaire)
        {
            double result = 0;
            foreach (Courant compte in _comptes.Values)
            {
                if (titulaire == compte.Titulaire) result += compte;
            }
            return result;
        }
    }
}
