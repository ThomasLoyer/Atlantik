using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atlantik
{
    internal class Periode
    {
        private int noPerdiode;
        private string dateDebut;
        private string dateFin;

        public Periode(int noPerdiode, string dateDebut, string dateFin)
        {
            this.noPerdiode = noPerdiode;
            this.dateDebut = dateDebut;
            this.dateFin = dateFin;
        }
        public int getNoPerdiode() 
        {
            return noPerdiode; 
        }
        public string getDateDebut()
        {
            return dateDebut;
        }
        public string getDateFin()
        {
            return dateFin;
        }
        public override string ToString()
        {
            return dateDebut + " au " + dateFin;
        }
    }
}
