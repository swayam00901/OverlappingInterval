using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace William_Sonoma_ZipRange
{
    class Interval
    {
        internal long  lower;
        internal long  upper;
        public Interval(int lower, int upper)
        {
            if (lower <= upper)
            {
                this.lower = lower;
                this.upper = upper;
            }
            else
            {
                this.lower = upper;
                this.upper = lower;
            }
        }
    }
}

