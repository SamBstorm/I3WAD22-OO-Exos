using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace I3WAD22_OO_Exo_banque
{
    class Compte
    {
        #region Champs - Variables Membres
        private Personne _titulaire;
        private string _numero;
        private double _solde;
        #endregion
        #region Propriétés + Indexeurs
        public string Numero
        {
            get { return _numero; }
            set { if (!string.IsNullOrWhiteSpace(value)) _numero = value; }
        }
        public Personne Titulaire
        {
            get { return _titulaire; }
            set { if (value != null) _titulaire = value; }
        }
        public double Solde
        {
            get { return _solde; }
        }
        #endregion
        #region Constructeur

        #endregion
        #region Méthodes + Opérateurs
        public void Depot(double montant)
        {
            if (montant > 0)
                _solde += montant;
        }

        protected void Retrait(double montant, double limite)
        {
            if (montant > 0 && Solde + limite >= montant)
                _solde -= montant;
        }

        public virtual void Retrait(double montant)
        {
            this.Retrait(montant, 0);
        }
        #endregion
    }
}
