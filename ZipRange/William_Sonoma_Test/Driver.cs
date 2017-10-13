using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace William_Sonoma_ZipRange
{
    class Driver
    {
        static void Main(string[] args)
        {
            /*
             *  DataSet1  Simple Test.
             * 
             * */
            Console.WriteLine("Now merging (3, 5) ,(10, 13) ,(8, 11) ,(15, 19) , (13, 16)   ");
            Interval a = new Interval(3, 5);
            Interval b = new Interval(10, 13);
            Interval c = new Interval(8, 11);
            Interval d = new Interval(15, 19);
            Interval e = new Interval(13, 16);

            MergeRange mr = new MergeRange();
            List<Interval> rangeList = new List<Interval>();
            rangeList.Add(a);
            rangeList.Add(b);
            rangeList.Add(c);
            rangeList.Add(d);
            rangeList.Add(e);

            List<Interval> outputList =  mr.mergeIntervals(rangeList);
            // This is just to see pretty output.
            outputList.Reverse();
            outputList.ForEach(x => Console.WriteLine( String.Format("[{0},{1}]", x.lower, x.upper)));
            Console.WriteLine("Press any key to Go to 2nd data set \n");
            Console.ReadLine();

            Console.WriteLine("Now merging [94133, 94133] [94200,94299] [94600,94699]   ");

            /*
          *  DataSet2  Simple Test.
          * 
          * */
            Interval a1 = new Interval(94133, 94133);  // [94200,94299] [94600,94699]
            Interval b1 = new Interval(94200, 94299);
            Interval c1 = new Interval(94600, 94699);
      

            MergeRange mr1 = new MergeRange();
            List<Interval> rangeList1 = new List<Interval>();
            rangeList1.Add(a1);
            rangeList1.Add(b1);
            rangeList1.Add(c1);
         

            List<Interval> outputList1 = mr1.mergeIntervals(rangeList1);
            // This is just to see pretty output.
            outputList1.Reverse();
            outputList1.ForEach(x => Console.WriteLine(String.Format("[{0},{1}]", x.lower, x.upper)));
            Console.WriteLine("Press any key to go to 3rd dataset \n");
            Console.ReadLine();

            Console.WriteLine("Now merging [94133,94133] [94200,94299] [94226,94399] ");

            /*
       *  DataSet3  Simple Test.
       * 
       * */
            Interval a2 = new Interval(94133, 94133);  //  [94133,94133] [94200,94299] [94226,94399]
            Interval b2 = new Interval(94200, 94299);
            Interval c2 = new Interval(94226, 94399);


            MergeRange mr2 = new MergeRange();
            List<Interval> rangeList2 = new List<Interval>();
            rangeList2.Add(a2);
            rangeList2.Add(b2);
            rangeList2.Add(c2);


            List<Interval> outputList2 = mr2.mergeIntervals(rangeList2);
            // This is just to see pretty output.
            outputList2.Reverse();
            outputList2.ForEach(x => Console.WriteLine(String.Format("[{0},{1}]", x.lower, x.upper)));
            Console.Write("Press any key to exit");
            Console.ReadLine();
        }
    }
}
