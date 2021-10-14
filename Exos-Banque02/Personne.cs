using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exos_Banque01
{
    class Personne
    {
        private string _nom;

        public string Nom
        {
            get { return _nom; }
            set { _nom = value; }
        }

        public string Prenom { get; set; }

        public DateTime DateNaiss { get; set; }
    }
}
