using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace logic
{
    public class Medicatie
    {
        private int patID;
        string medicatieType;
        int aantal;
        string manier;
        public int PatID
        {
            get { return patID; }
            set { patID = value; }
        }


        public string MedicatieType
        {
            get
            {
                return medicatieType;
            }

            set
            {
                medicatieType = value;
            }
        }

        public int Aantal
        {
            get
            {
                return aantal;
            }

            set
            {
                aantal = value;
            }
        }

        public string Manier
        {
            get
            {
                return manier;
            }

            set
            {
                manier = value;
            }
        }

        public Medicatie( string medtype,int veelheid,string methode)
        {
           
            this.medicatieType = medtype;
            this.aantal = veelheid;
            this.manier = methode;
        }
    }
}
