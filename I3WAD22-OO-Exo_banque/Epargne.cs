using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace I3WAD22_OO_Exo_banque
{
    class Epargne
    {
        #region Variables membres - Champs
        private string _numero;
        private Personne _titulaire;
        private double _solde;
        #endregion
        #region Propriétés + Indexeur
        public string Numero { 
            get { return _numero; }
            set {
                if(!string.IsNullOrWhiteSpace(value))
                    _numero = value;
            }
        }
        public DateTime DateDernierRetrait { get; set; }
        public Personne Titulaire {
            get { return _titulaire; }
            set {
                if (value != null)
                    _titulaire = value;
            } 
        }

        public double Solde
        {
            get { return _solde; }
            private set
            {
                if (value >= 0) _solde = value;
            }
        }
        #endregion
        #region Constructeur

        #endregion
        #region Méthodes + Opérateurs
        public void Retrait(double montant) {
            if (montant > 0 && Solde >= montant)
            {
                Solde -= montant;
                DateDernierRetrait = DateTime.Now;
            }
        }

        public void Depot(double montant) {
            if(montant > 0)
                Solde += montant;
        }
        #endregion
    }
}
