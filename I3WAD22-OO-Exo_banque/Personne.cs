using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace I3WAD22_OO_Exo_banque
{
    class Personne
    {

        #region Champs - Variables membres
        private string _nom;
        private string _prenom;
        //private DateTime _dateNaissance;
        #endregion

        #region Propriétés
        public string Nom
        {
            get { return _nom; }
            set { 
                if(!string.IsNullOrWhiteSpace(value)) _nom = value.Trim();
            }
        }

        public string Prenom
        {
            get { return _prenom; }
            set {
                if (!string.IsNullOrWhiteSpace(value)) _prenom = value.Trim();
            }
        }

        //public DateTime DateNaissance {
        //    get { return _dateNaissance; }
        //    set { _dateNaissance = value; }
        //}

        public DateTime DateNaissance { get; set; }
        #endregion

        #region Constructeurs & destructeur

        #endregion

        #region Méthodes et opérateurs

        #endregion
    }
}
