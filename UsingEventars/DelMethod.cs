using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsingEventargs
{
    public class DelMethod
    {
        public static void WorkPerformDelMthod(object sender, WorkHandlerArgs e)
        {
            Console.WriteLine($"work details work hours={e.hours} work type={e.workType}");

        }
        public static void WorkCompleteDelMethod(object sender, EventArgs e)
        {
            Console.WriteLine("Work done");
        }
    }
}
