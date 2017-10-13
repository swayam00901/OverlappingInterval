using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KForceTest
{
    class Range
    {
        internal int lower;
        internal int upper;

        //Constructors
       public Range(int lower, int upper)
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

        public int getLower()
        {
            return lower;
        }

        public void setLower(int lower)
        {
            this.lower = lower;
        }

        public int getUpper()
        {
            return upper;
        }

        public void setUpper(int upper)
        {
            this.upper = upper;
        }

        public String toString()
        {
            return String.Format("At {0}, and  {1}.",lower, upper);
        }

        public bool equals(Object other)
        {
            bool result = false;
            if (other.GetType() == typeof(Range)) {
                Range that = (Range)other;
                result = (this.getLower() == that.getLower() && this.getUpper() == that.getUpper());
            }
            return result;
        }
    }
}
