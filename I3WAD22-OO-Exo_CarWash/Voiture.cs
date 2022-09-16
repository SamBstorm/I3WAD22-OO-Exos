using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace I3WAD22_OO_Exo_CarWash
{
    class Voiture
    {
        private string _plaque;
        public string Plaque {
            get {
                return _plaque;
            }
            private set {
                if (string.IsNullOrWhiteSpace(value)) throw new ArgumentNullException();
                _plaque = value;
            }
        }

        public Voiture(string plaque)
        {
            Plaque = plaque;
        }
    }
}
