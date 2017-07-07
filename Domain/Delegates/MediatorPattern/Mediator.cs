using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Delegates.MediatorPattern
{
    public sealed class Mediator
    {
        // Static members
        private static readonly Mediator _Instance = new Mediator();
        private Mediator() { }

        public static Mediator GetInstance()
        {
            return _Instance;
        }

        // Instance functionality
        public event EventHandler<JobChangedEventArgs> JobChanged;

        public void OnJobChanged(object sender, Job job)
        {
            var jobChangeDelegate = JobChanged as EventHandler<JobChangedEventArgs>;
            jobChangeDelegate?.Invoke(sender, new JobChangedEventArgs { Job = job });
        }
    }
}
