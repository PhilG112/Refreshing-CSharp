using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.ContitionalStatements
{
    public class One
    {
        public void Compare()
        {
            var input1 = int.Parse(Console.ReadLine());
            var input2 = int.Parse(Console.ReadLine());
            Console.WriteLine(input1 == input2 ? $"{input1} and {input2} are equal." : $"{input1} and {input2} are not equal.");
        }
    }
}
