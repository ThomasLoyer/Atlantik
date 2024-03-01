using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atlantik
{
    internal class LiaisonPortArriveeDepart
    {
        private int liaison;
        private string portDepart;
        private string portArrivee;

        public LiaisonPortArriveeDepart(int liaison, string portDepart, string portArrivee)
        {
            this.liaison = liaison;
            this.portDepart = portDepart;
            this.portArrivee = portArrivee;
        }
        public int GetLiaison()
        {
            return liaison;
        }
        public string GetPortDepart()
        {
            return portDepart;
        }
        public string GetPortArrivee()
        {
            return portArrivee;
        }
        public override string ToString()
        {
            return portDepart + "-" + portArrivee;
        }
    }
}
