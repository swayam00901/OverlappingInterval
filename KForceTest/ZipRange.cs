using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace KForceTest
{
    class ZipRange
    {
        private List<Range> rangeList = new List<Range>();

        public  void AddRange(Range toAdd)
        {
            if (rangeList.Count == 0)
                rangeList.Add(toAdd);
            else
            {
               
                var newList = rangeList.OrderByDescending(x => x.lower).ToList();
                //Add new Range, if the range overlaps with existing range, merge them
                List<Range> iter = rangeList;
                bool add = true; //flag
                for(int i = 0; i < iter.Count; i++)
                { 

                    Range range = iter[i];
                    //new range within existing range, no need to add
                    if (range.getLower() <= toAdd.getLower() && range.getUpper() >= toAdd.getUpper())
                    {
                        add = false;
                    }
                    //new range is out of existing range, add it
                    else if (range.getLower() > toAdd.getUpper() || range.getUpper() < toAdd.getLower())
                    {
                        add = true;
                    }
                    //Range overlaps, remove existing, update toAdd
                    else
                    {
                        if (range.getLower() < toAdd.getLower())
                            toAdd.setLower(range.getLower());
                        if (range.getUpper() > toAdd.getUpper())
                            toAdd.setUpper(range.getUpper());
                        iter.Remove(iter[i]);
                        add = true;
                    }
                }//end of forloop
                if (add)
                    rangeList.Add(toAdd);
            }//end of else

        }

        public void showRange()
        {
            if (rangeList.Count > 0)
            {
                foreach(var range in rangeList)
                {
                    Console.WriteLine(range.toString());
                }
            }

        }

        public int size()
        {
            return rangeList.Count;
        }

        public  List<Range> getZipRanges()
        {
            return rangeList;
        }


        public  void clear()
        {
            rangeList.Clear();
        }

    }
}
