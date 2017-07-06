using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Delegates.PluralSight
{
    public class WorkPerformedEventArgs : EventArgs
    {
        public WorkPerformedEventArgs(int hours, WorkType workType)
        {
            Hours = hours;
            WorkType = WorkType;
        }

        public int Hours { get; set; }
        public WorkType WorkType { get; set; }
    }

    public class Worker2
    {
        public event EventHandler<WorkPerformedEventArgs> WorkPerformed;
        public event EventHandler WorkCompleted;

        public void DoWork(int hours, WorkType workType)
        {
            // Do work here and notify consumer that work has been performed
            for (int i = 0; i < hours; i++)
            {
                // Raise event
                OnWorkPerformed(i + 1, workType);
            }
            OnWorkCompleted();
        }

        protected virtual void OnWorkPerformed(int hours, WorkType workType)
        {
            // Check if listeners are attatched and raise the event
            WorkPerformed?.Invoke(this, new WorkPerformedEventArgs(hours, workType));

            // Other way to check for null, cast to underlying delegate first
            var del = WorkPerformed as EventHandler<WorkPerformedEventArgs>;
            del?.Invoke(this, new WorkPerformedEventArgs(hours, workType));
        }

        protected virtual void OnWorkCompleted()
        {
            WorkCompleted?.Invoke(this, EventArgs.Empty);
        }
    }
}
