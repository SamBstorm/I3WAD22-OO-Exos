using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace I3WAD22_OO_Exo_banque
{
    class Courant
    {
        #region Variables membres - Champs
        private double _ligneDeCredit;
        private Personne _titulaire;
        private string _numero;
        private double _solde;
        #endregion

        #region Propriétés
        public string Numero {
            get { return _numero; }
            set { if(!string.IsNullOrWhiteSpace(value)) _numero = value; }
        }
        public Personne Titulaire {
            get { return _titulaire; }
            set { if(value != null) _titulaire = value; }
        }
        public double Solde {
            get { return _solde; }
            private set { if(value >= -LigneDeCredit) _solde = value; }
        }
        public double LigneDeCredit {
            get { return _ligneDeCredit; }
            set { if(value >= 0 && value >= -Solde) _ligneDeCredit = value; }
        }
        #endregion

        #region Méthodes + opérateurs
        public void Retrait(double montant) {
            if (montant > 0 && Solde + LigneDeCredit >= montant) Solde -= montant;
        }
        public void Depot(double montant) {
            if (montant > 0) Solde += montant;
        }
        #endregion
    }
}
