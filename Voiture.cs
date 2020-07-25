using System;
using System.Collections.Generic;
using System.Text;

namespace CourDeCsharp
{
    class Voiture
    {
        public bool VitesseAutorisee(int vitesse)
        {
            return vitesse <= 180;
        }

        public void Klaxonner()
        {
            if (!VitesseAutorisee(180))
                Console.WriteLine("Pouet !");
            else
                Console.WriteLine("Danger de mort");
        }
    }
}
