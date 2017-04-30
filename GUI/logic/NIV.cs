using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace logic
{
    public class NIV
    {
        public int id;
        public int patientID;
        public DateTime start;
        public DateTime stop;

        public NIV(int id,int patid,DateTime sta,DateTime sto)
        {
            this.id = id;
            this.patientID = patid;
            this.start = sta;
            this.stop = sto;
        }

    }
}
