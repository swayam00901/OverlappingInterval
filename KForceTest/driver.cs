using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace KForceTest
{
    class driver
    {
        
        static void Main(string[] args)
        {
            
            Range a = new Range(3, 5);
            Range b = new Range(10, 13);
            Range c = new Range(8, 11);
            Range d = new Range(15, 19);
            Range e = new Range(13, 16);

            ZipRange zipRange_ = new ZipRange();
            zipRange_.AddRange(a);
            zipRange_.AddRange(b);
            zipRange_.AddRange(c);
            zipRange_.AddRange(d);
            zipRange_.AddRange(e);

            zipRange_.showRange();
            Console.Write("\nPress any key to exit... ");
            Console.ReadLine();

        }
    }
}
