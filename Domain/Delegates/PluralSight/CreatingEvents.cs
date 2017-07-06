using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Delegates.PluralSight
{
    public class Worker
    {
        // Define events
        public event WorkPerformedHandler WorkPerformed;
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
            WorkPerformed?.Invoke(hours, workType);

            // Other way to check for null, cast to underlying delegate first
            var del = WorkPerformed as WorkPerformedHandler;
            del?.Invoke(hours, workType);
        }

        protected virtual void OnWorkCompleted()
        {
            WorkCompleted?.Invoke(this, EventArgs.Empty);
        }
    }
}
