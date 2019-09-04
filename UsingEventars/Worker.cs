using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsingEventargs
{
    public class Worker
    {
        //public delegate void WorkPerformedHandler(int hours, WorkType workType);

        public event EventHandler<WorkHandlerArgs> WorkPerformed;
        
        public event EventHandler WorkCompleted;
        //public event Action<WorkHandlerArgs> WorkXCompleted;


        public void DoWork(int hours,WorkType workType)
        {

            for(int i=0;i<hours;i++)
            {
                OnWorkPerformed(i+1, WorkType.Software);
            }
            OnWorkCompleted();
            //Console.WriteLine($"work details work hours={hours} work type={workType}");
        }

        public void OnWorkPerformed(int hours,WorkType workType)
        {
            /* WorkPerformedHandler del = WorkPerformed as WorkPerformedHandler;
             if(del!=null)*/
            WorkPerformed?.Invoke(this, new WorkHandlerArgs(hours,workType));
        }

        public void OnWorkCompleted()
        {
            if(WorkCompleted!=null)
            {
                WorkCompleted(this,EventArgs.Empty);
            }
        }

        

    }

    public enum WorkType
    {
        Software,
        hardware
    } 
}
