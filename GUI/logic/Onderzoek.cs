using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace logic
{
    public class Onderzoek
    {
        private int patID;
        private string onderzoekInfo;

        public int Patid
        {
            get { return patID; }
            set { patID = value; }
        }

        public string OnderzoekInfo
        {
            get { return onderzoekInfo; }
            set { onderzoekInfo = value; }
        }

        public Onderzoek(string ondinfo)
        {

            this.onderzoekInfo = ondinfo;
        }
    }
}
