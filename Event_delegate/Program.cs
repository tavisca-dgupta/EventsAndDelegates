using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Event_delegate
{
    class Program
    {
        public static void Main(string[] args)
        {
            Worker work = new Worker();
            work.WorkPerformed += DelMethod.WorkPerformDelMthod;
            work.WorkCompleted += DelMethod.WorkCompleteDelMethod;
            work.DoWork(5, WorkType.Software);
            Console.WriteLine("Hello World!");
            Console.ReadKey();

            // Go to http://aka.ms/dotnet-get-started-console to continue learning how to build a console app! 
        }
    }
}
