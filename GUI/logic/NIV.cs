using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace logic
{
    public class NIV
    {
        private int id;
        private int patientID;
        private DateTime start;
        private DateTime stop;

        public int Id
        {
            get
            {
                return id;
            }

            set
            {
                id = value;
            }
        }

        public int PatientID
        {
            get
            {
                return patientID;
            }

            set
            {
                patientID = value;
            }
        }

        public DateTime Start
        {
            get
            {
                return start;
            }

            set
            {
                start = value;
            }
        }

        public DateTime Stop
        {
            get
            {
                return stop;
            }

            set
            {
                stop = value;
            }
        }

        public NIV(DateTime sta,DateTime sto)
        {
           
            this.Start = sta;
            this.Stop = sto;
        }

    }
}
