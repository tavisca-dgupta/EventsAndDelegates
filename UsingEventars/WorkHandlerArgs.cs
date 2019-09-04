using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsingEventargs
{
    public class WorkHandlerArgs : EventArgs
    {
        public WorkHandlerArgs(int hours,WorkType workType)
        {
            this.hours = hours;
            this.workType = workType;
        }
        public int hours { get; private set; }
        public WorkType workType { get; private set; }
    }
}
