using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.DataTypeExercises
{
    public class Ten
    {
        public void TrueFalse()
        {
            var num1 = int.Parse(Console.ReadLine());
            var num2 = int.Parse(Console.ReadLine());
            var result = (num1 % 2 == 0 && num2 % 2 == 0) ? "Numbers are even" : "Numbers are odd";
            Console.WriteLine(result);





        }
    }
}
