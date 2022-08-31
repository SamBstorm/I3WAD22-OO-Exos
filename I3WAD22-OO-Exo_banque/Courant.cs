using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace I3WAD22_OO_Exo_banque
{
    class Courant : Compte
    {
        #region Variables membres - Champs
        private double _ligneDeCredit;
        #endregion

        #region Propriétés
        public double LigneDeCredit {
            get { return _ligneDeCredit; }
            set { if(value >= 0 && value >= -Solde) _ligneDeCredit = value; }
        }
        #endregion

        #region Méthodes + opérateurs
        public override void Retrait(double montant) {
            base.Retrait(montant, LigneDeCredit);
        }

        protected override double CalculInteret()
        {
            if (Solde >= 0) return Solde * 0.03;
            return Solde * 0.0975;
        }


        #endregion
    }
}
