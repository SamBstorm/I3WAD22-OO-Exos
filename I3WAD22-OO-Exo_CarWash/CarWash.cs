using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace I3WAD22_OO_Exo_CarWash
{
    delegate void CarWashAction(Voiture v);
    class CarWash
    {
        private CarWashAction _cycleLavage;

        public CarWash()
        {
            #region Méthode non-anonyme
            //_cycleLavage = Preparer;
            //_cycleLavage += Laver;
            //_cycleLavage += Secher;
            //_cycleLavage += Finaliser; 
            #endregion
            _cycleLavage = delegate (Voiture v) { Console.WriteLine($"Je prépare la voiture : {v.Plaque}"); };
            _cycleLavage += delegate (Voiture v) { Console.WriteLine($"Je lave la voiture : {v.Plaque}"); };
            _cycleLavage += delegate (Voiture v) { Console.WriteLine($"Je sèche la voiture : {v.Plaque}"); };
            _cycleLavage += delegate (Voiture v) { Console.WriteLine($"Je finalise la voiture : {v.Plaque}"); };
        }

        #region Méthode non-anonyme
        //private void Preparer(Voiture v) { 
        //    Console.WriteLine($"Je prépare la voiture : {v.Plaque}"); 
        //}
        //private void Laver(Voiture v) { 
        //    Console.WriteLine($"Je lave la voiture : {v.Plaque}"); 
        //}
        //private void Secher(Voiture v) { 
        //    Console.WriteLine($"Je sèche la voiture : {v.Plaque}"); 
        //}
        //private void Finaliser(Voiture v) { 
        //    Console.WriteLine($"Je finalise la voiture : {v.Plaque}"); 
        //} 
        #endregion
        public void Traiter(Voiture v) {
            _cycleLavage?.Invoke(v);
        }
    }
}
