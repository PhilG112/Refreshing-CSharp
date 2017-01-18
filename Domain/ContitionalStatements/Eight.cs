using System;
using System.Collections.Generic;
using System.Linq;

namespace Domain.ContitionalStatements
{
    public class Eight
    {
        public Eight()
        {
            List<int> list = new List<int>
            {
                3546,
                6785,
                092187,
                829374,
                4353,
                2323,
                000515,
                645728,
                912749
            };

            var maxIndex = !list.Any() ? -1 :
                list.Select((value, index) => new { Value = value, Index = index })
                    .Aggregate((a, b) => (a.Value > b.Value) ? a : b)
                    .Index;
            Console.WriteLine(maxIndex);
            
          

            var maxIndex2 = list.Max();
            Console.WriteLine($"The largest number in the list is {maxIndex2} at position {list.IndexOf(maxIndex2)}");

            var oneLiner = list.IndexOf(list.Max());
        }
    }
}
