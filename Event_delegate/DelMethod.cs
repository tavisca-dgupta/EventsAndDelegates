using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Event_delegate
{
    public class DelMethod
    {
        public static void WorkPerformDelMthod(int hours, WorkType work)
        {
            Console.WriteLine($"work details work hours={hours} work type={work}");

        }
        public static void WorkCompleteDelMethod(object sender, EventArgs e)
        {
            Console.WriteLine("Work done");
        }
    }
}
