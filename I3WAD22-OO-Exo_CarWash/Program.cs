﻿using System;

namespace I3WAD22_OO_Exo_CarWash
{
    class Program
    {
        static void Main(string[] args)
        {
            Voiture v1 = new Voiture("1-BEL-123");
            Voiture v2 = new Voiture("1-BEL-456");
            Voiture v3 = new Voiture("1-BEL-789");
            Voiture v4 = new Voiture("1-BEL-101");
            Voiture v5 = new Voiture("1-BEL-112");

            CarWash cw = new CarWash();
            cw.Traiter(v1);
            cw.Traiter(v2);
            cw.Traiter(v3);
            cw.Traiter(v4);
            cw.Traiter(v5);
        }
    }
}
