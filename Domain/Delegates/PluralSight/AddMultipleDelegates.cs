using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Delegates.PluralSight.MultipleDelegates
{
    // Also giving a delegate a return type
    public delegate int WorkPerformedHandler(int hours, WorkType workType);

    public class AddMultipleDelegates
    {
        public AddMultipleDelegates()
        {
            var del1 = new WorkPerformedHandler(WorkPerformed1);
            var del2 = new WorkPerformedHandler(WorkPerformed2);
            var del3 = new WorkPerformedHandler(WorkPerformed3);

            // Add to invocation list, called sequentially
            del1 += del2 + del3;

            // Only the last delegate to be called will be the one to return a value,
            // as we can only have 1 return type
            var finalHours = del1(10, WorkType.GenerateReports);
            
        }

        public static void DoWork(WorkPerformedHandler del)
        {
            del(5, WorkType.GoToMeetings);
        }

        // Handlers
        public static int WorkPerformed1(int hours, WorkType workType)
        {
            Console.WriteLine($"WorkPerformed1 called {hours}");
            return hours + 1;
        }
        public static int WorkPerformed2(int hours, WorkType workType)
        {
            Console.WriteLine($"WorkPerformed2 called {hours}");
            return hours + 2;
        }

        private static int WorkPerformed3(int hours, WorkType workType)
        {
            Console.WriteLine($"WorkPerformed3 called {hours}");
            return hours + 3;
        }
    }

    public enum WorkType
    {
        GoToMeetings,
        Golf,
        GenerateReports
    }
}
