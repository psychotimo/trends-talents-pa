using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace logic
{
    public class Infuus
    {
        private int patID;
        string infuusData;
        int urenAanGehangen;

        public string InfuusData
        {
            get
            {
                return infuusData;
            }

            set
            {
                infuusData = value;
            }
        }

        public int UrenAanGehangen
        {
            get
            {
                return urenAanGehangen;
            }

            set
            {
                urenAanGehangen = value;
            }
        }

        public int PatID
        {
            get { return patID; }
            set { patID = value; }
        }

        public Infuus( string infuusdata, int uren)
        {
           
            this.infuusData = infuusdata;
            this.urenAanGehangen = uren;
        }
    }
}
