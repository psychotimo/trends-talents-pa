using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace logic
{
    public class Drains
    {
        private int patID;

        public int PatID
        {
            get { return patID; }
            set { patID = value; }
        }

        private string drainInfo;

        public string DrainInfo
        {
            get { return drainInfo; }
            set { drainInfo = value; }
        }


        public Drains(string draininf)
        {
            this.drainInfo = draininf;
        }
    }
}
