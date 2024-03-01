using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atlantik
{
    internal class Secteur
    {
        private int noSecteur;
        private string nom;
        public Secteur(int noSecteur, string nom)
        {
            this.noSecteur = noSecteur;
            this.nom = nom;
        }
        public int getNoSecteur() 
        {
            return noSecteur; 
        }
        public string getNom() 
        {
            return nom; 
        }
        public override string ToString()
        {
            return nom;
        }
    }
}
