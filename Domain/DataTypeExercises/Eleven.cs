using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.DataTypeExercises
{
    public class Eleven
    {
        public void IntToBinary()
        {
            var input = int.Parse(Console.ReadLine());
            var result = Convert.ToString(input, 2);
            Console.WriteLine(result);
        }
    }
}
