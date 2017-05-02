using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace logic
{
    public class Katheter
    {
        int patID;
        string kathType;
        DateTime kathDatum;
        public int PatID
        {
            get { return patID; }
            set { patID = value; }
        }
        public string KathType
        {
            get
            {
                return kathType;
            }

            set
            {
                kathType = value;
            }
        }

        public DateTime KathDatum
        {
            get
            {
                return kathDatum;
            }

            set
            {
                if (value == null )
                {
                    kathDatum = new DateTime(0001, 01, 01);
                    
                }
                else {
                    kathDatum = value;
                }

            }
        }

        public Katheter(string type, DateTime kathdat)
        {

            this.kathType = type;
            this.kathDatum = kathdat;
        }
    }
}
