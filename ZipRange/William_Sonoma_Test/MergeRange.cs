using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace William_Sonoma_ZipRange
{
    class MergeRange
    {
        public List<Interval> mergeIntervals(List<Interval> rangeList)
        {
            List<Interval> sortedRangeList = rangeList.OrderByDescending(x => x.lower).ToList();
            List<Interval> outputRangeList = new List<Interval>();
            int index = 0; // Stores index of last element
                           // in output array (modified sortedRangeList[])
                           // Traverse all input Intervals
                for (int i = 0; i < sortedRangeList.Count; i++)
                {
                    // If this is not first Interval and overlaps
                    // with the previous one
                    if (index != 0 && sortedRangeList[index - 1].lower <= sortedRangeList[i].upper)
                    {
                        while (index != 0 && sortedRangeList[index - 1].lower <= sortedRangeList[i].upper)
                        {
                            // Merge previous and current Intervals
                            sortedRangeList[index - 1].upper = Math.Max(sortedRangeList[index - 1].upper, sortedRangeList[i].upper);
                            sortedRangeList[index - 1].lower = Math.Min(sortedRangeList[index - 1].lower, sortedRangeList[i].lower);
                            index--;
                        }
                    }
                    else // Doesn't overlap with previous, add to
                         // solution
                        sortedRangeList[index] = sortedRangeList[i];

                    index++;
                }
            // Now arr[0..index-1] stores the merged Intervals
            Console.WriteLine( "\n The Merged Intervals are: ");
            for (int i = 0; i < index; i++)
            {
                outputRangeList.Add(sortedRangeList[i]);
               // Console.WriteLine(String.Format("[{0},{1}]", sortedRangeList[i].lower, sortedRangeList[i].upper));
            }
            
            return outputRangeList;
        }
    }
}
