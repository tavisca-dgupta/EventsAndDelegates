using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsingEventargs
{
    class Program
    {
        public static void Main(string[] args)
        {
            Worker work = new Worker();
            //work.WorkPerformed += new EventHandler<WorkHandlerArgs>(DelMethod.WorkPerformDelMthod);
            work.WorkCompleted += DelMethod.WorkCompleteDelMethod;//delegate Inference
            work.WorkPerformed += (s ,e) => {
                Console.WriteLine($"work details work hours={e.hours} work type={e.workType}");
            }; 

            work.DoWork(5, WorkType.Software);
            Console.WriteLine("Hello World!");
            Console.ReadKey();
            // Go to http://aka.ms/dotnet-get-started-console to continue learning how to build a console app! 
        }
    }
}
