using System;

namespace I3WAD22_OO_Exo_banque
{
    class Program
    {
        static void Main(string[] args)
        {
            Personne titulaire1 = new Personne();
            titulaire1.Nom = "Legrain";
            titulaire1.Prenom = "Samuel";
            titulaire1.DateNaissance = new DateTime(1987,9,27);

            Personne titulaire2 = new Personne();
            titulaire2.Nom = "    Willis      ";
            titulaire2.Prenom = "";
            titulaire2.DateNaissance = new DateTime(1987, 9, 27);
        }
    }
}
