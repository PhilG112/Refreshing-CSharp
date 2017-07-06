using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Delegates.PluralSight.BuiltInDelegates
{
    public delegate int BizRulesDelegate(int x, int y);

    public class Run
    {
        public Run()
        {
            var data = new ActionDelegate();
            Action<int, int> myAction = (x, y) => Console.WriteLine(x + y);
            Action<int, int> multiplyAction = (x, y) => Console.WriteLine(x * y);
            data.ProcessAction(4, 5, myAction);
            data.ProcessAction(4, 5, multiplyAction);

        }
    }

    public class ActionDelegate
    {
        public void ProcessAction(int x, int y, Action<int,int> action)
        {
            action(x, y);
            Console.WriteLine("action has been processed");
        }
    }
}
