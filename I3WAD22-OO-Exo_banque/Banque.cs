using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace I3WAD22_OO_Exo_banque
{
    class Banque
    {
        private Dictionary<string, Courant> _comptes = new Dictionary<string, Courant>();
        public string Nom { get; set; }

        public Courant this[string numero]
        {
            get {
                //Courant c = null;
                _comptes.TryGetValue(numero, out Courant c);
                return c;
            }
            /*A éviter: moins clair et plus compliquer qu'une méthode*/
            /*
             * set {
                if (value != null && !_comptes.ContainsKey(numero) && numero == value.Numero) _comptes.Add(numero, value);
            }*/
        }

        public void Ajouter(Courant compte) {
            if(compte != null && !_comptes.ContainsKey(compte.Numero)) _comptes.Add(compte.Numero, compte);
        }
        public void Supprimer(string numero) {
            if(!string.IsNullOrWhiteSpace(numero) && _comptes.ContainsKey(numero)) _comptes.Remove(numero);
        }

    }
}
