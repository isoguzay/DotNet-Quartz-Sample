using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ioay.Quartz.Console
{
    class QuartzScheduler
    {
        static void Main(string[] args)
        {
            Trigger trigger = new Trigger();
            trigger.RunTrigger();
        }
    }
}
