using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.LINQ
{
    public class Creating
    {
        public IEnumerable<Customer> RetrieveEmptyList()
        {
            return Enumerable.Repeat(new Customer(), 10);
        }

        public IEnumerable<int> BuildIntegerSequence()
        {
            var integers = Enumerable.Range(0, 100)
                .Select(i => 5 + (10 * i));
            return integers;
        }

        public IEnumerable<int> BuildRepeatedIntegerSequence()
        {
            var integers = Enumerable.Repeat(-1, 10);
            return integers;
        }

        public IEnumerable<string> BuildStringSequence()
        {
            var strings = Enumerable.Range(0, 10).Select(i => ((char)('A' + i)).ToString());
            return strings;
        }

        public IEnumerable<string> BuildRandomStringSequence()
        {
            var rand = new Random();
            var strings = Enumerable.Range(0, 10)
                .Select(i => ((char)('A' + rand.Next(0, 26))).ToString());
            return strings;
        }
    }
}
