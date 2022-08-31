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

        public static double operator +(Courant left, Courant right)
        {
            /*
            double left_solde = 0, right_solde = 0;
            if (left != null && left.Solde > 0) left_solde = left.Solde;
            if (right !=null && right.Solde > 0) right_solde = right.Solde;
            */

            double left_solde = (left != null && left.Solde > 0) ? left.Solde : 0;
            double right_solde = (right != null && right.Solde > 0) ? right.Solde : 0;
            return left_solde + right_solde;
        }

        public static double operator +(double left, Courant right)
        {
            /*
            double left_solde = 0, right_solde = 0;
            if (left > 0) left_solde = left;
            if (right !=null && right.Solde > 0) right_solde = right.Solde;
            */

            double left_solde = (left > 0) ? left : 0;
            double right_solde = (right != null && right.Solde > 0) ? right.Solde : 0;
            return left_solde + right_solde;
        }
        #endregion
    }
}
