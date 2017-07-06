using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Delegates.PluralSight.LambdasDelegates
{
    // Custom delegate
    public delegate int BizRulesDelegate(int x, int y);

    public class ProcessData
    {
        public void Process(int x, int y, BizRulesDelegate del)
        { 
            // Don't have to hard code what happens with x and y - loose coupling
            Console.WriteLine(del(x, y));
        }
    }

    public class Run
    {
        public Run()
        {
            // Using lamdas to define our delegate to use.
            BizRulesDelegate addDelegate = (x, y) => x + y;
            BizRulesDelegate multiplyDelegate = (x, y) => x * y;
            var data = new ProcessData();
            // Pass in the delegates above
            data.Process(4, 5, addDelegate);
            data.Process(4, 5, multiplyDelegate);
        }
    }
}
