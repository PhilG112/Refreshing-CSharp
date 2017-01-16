using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.ContitionalStatements
{
    public class Five
    {
        public void CanVote()
        {
            var age = int.Parse(Console.ReadLine());
            Console.WriteLine(age >= 21 ? "You can vote!" : "You cannot vote :(");
        }
    }
}
