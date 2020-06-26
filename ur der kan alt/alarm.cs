using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ur_der_kan_alt
{
    class alarm
    {
        public DateTime op;
        public List<DayOfWeek> dayOfs;
       // public bool måske;

        public alarm(List<DayOfWeek> dayOfs,TimeSpan ts)
        {
            op = DateTime.Today + ts;
            this.dayOfs = dayOfs;
           // måske = true;
        }

        public string ToDateString()
        {
            return string.Format("{0} kl. {1:00}:{2:00}", op.DayOfWeek, op.Hour, op.Minute);
        }

    }
}
