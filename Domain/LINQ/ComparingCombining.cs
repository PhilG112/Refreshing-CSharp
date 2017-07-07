using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.LINQ
{
    public class ComparingCombining
    {
        public IEnumerable<int> CompareSequence()
        {
            var seq1 = Enumerable.Range(0, 50);
            var seq2 = Enumerable.Range(0, 50).Select(i => i * i);

            // What is in both sequences/collections
            seq1.Intersect(seq2);

            // What is in seq1 and not in seq2
            seq1.Except(seq2);

            // Combine both sequences
            seq1.Concat(seq2);

            // Combine both sequences with no duplicates
            seq1.Concat(seq2).Distinct();

            // Other way to getting unique values without Concat().Distinct()
            return seq1.Union(seq2);
        }
    }
}
