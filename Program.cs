using System;
using System.IO;
using System.Security.Cryptography.X509Certificates;

namespace CourDeCsharp
{
    class Program
    {
       
        static void Main(string[] args)
        {
            Voiture auto = new Voiture();
            auto.Klaxonner();
            auto.VitesseAutorisee(90);
        }

    }
}
