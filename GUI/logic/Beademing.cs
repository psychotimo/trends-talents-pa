using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace logic
{
    public class Beademing
    {
        int patID;
        DateTime beadStart;
        DateTime beadStop;

        #region props
        public int PatID
        {
            get
            {
                return patID;
            }

            set
            {
                patID = value;
            }
        }

        public DateTime BeadStart
        {
            get
            {
                return beadStart;
            }

            set
            {
                beadStart = value;
            }
        }

        public DateTime BeadStop
        {
            get
            {
                return beadStop;
            }

            set
            {
                beadStop = value;
            }
        }
        #endregion

        public Beademing(DateTime beademStart,DateTime beademStop)
        {
            this.beadStart = beademStart;
            this.beadStop = beademStop;
        }
    }
}
