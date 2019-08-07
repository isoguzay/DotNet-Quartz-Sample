using Quartz;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ioay.Quartz.Console
{
    public class ScheduledTasks : IJob
    {
        public void Execute(IJobExecutionContext context)
        {
            System.Console.WriteLine("Job is triggered..");
        }
    }
}
    