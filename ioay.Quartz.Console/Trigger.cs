using Quartz;
using Quartz.Impl;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ioay.Quartz.Console
{
    public class Trigger
    {
        private IScheduler Start()
        {
            ISchedulerFactory factory = new StdSchedulerFactory();
            IScheduler scheduler = factory.GetScheduler();
            if (!scheduler.IsStarted)
                scheduler.Start();

            return scheduler;
        }

        public void RunTrigger()
        {
            IScheduler scheduler = Start();

            IJobDetail job = JobBuilder.Create<ScheduledTasks>().WithIdentity("Job", null).Build();

            // WithIntervalInSeconds or WithIntervalInMinutes or WithIntervalInHours set your scheduled range.
            ISimpleTrigger jobTrigger = (ISimpleTrigger)TriggerBuilder.Create().
                WithIdentity("Job").StartAt(DateTime.UtcNow).
                WithSimpleSchedule(x => x.WithIntervalInSeconds(5).RepeatForever()).Build();
            scheduler.ScheduleJob(job, jobTrigger);
        }
    }
}
