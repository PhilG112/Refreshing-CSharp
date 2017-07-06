using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.ProgrammingProblems
{
    public static class CountVowels
    {
        private static readonly List<char> vowels = new List<char> { 'a', 'e', 'i', 'o', 'u' };

        public static Dictionary<char, int> Count(string input)
        {
            var dict = new Dictionary<char, int>();
            var query = input.ToLower()
                .Where(c => vowels.Contains(c))
                .GroupBy(c => c)
                .Select(grp => new
                {
                    Value = grp.Key,
                    Count = grp.Count()
                });
            foreach (var c in query)
            {
                dict.Add(c.Value, c.Count);
            }
            return dict;
        }
    }
}
