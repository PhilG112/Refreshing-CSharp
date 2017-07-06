using System;

namespace Domain.Delegates.PluralSight
{
    // Define our Delegate
    public delegate void WorkPerformedHandler(int hours, WorkType workType);

    public enum WorkType
    {
        Golf
    }

    public class CreatingDelegates
    {
        // Create delegate instances
        private WorkPerformedHandler del1 = new WorkPerformedHandler(WorkPerformed1);
        private WorkPerformedHandler del2 = new WorkPerformedHandler(workPerformed2);


        public CreatingDelegates()
        {
            // Invoke delegate
            del1(5, WorkType.Golf);
            // Adding to the invocation list
            del1 += del2;
        }

        // Handlers
        public static void WorkPerformed1(int hours, WorkType workType)
        {
            Console.WriteLine("WorkPerformed1 called");
        }

        public static void workPerformed2(int hours, WorkType workType)
        {
            Console.WriteLine("WorkPerformed2 called");
        }
    }
}
