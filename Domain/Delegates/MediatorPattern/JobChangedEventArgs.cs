using System;

namespace Domain.Delegates.MediatorPattern
{
    public class JobChangedEventArgs : EventArgs
    {
        public Job Job { get; set; }
    }
}