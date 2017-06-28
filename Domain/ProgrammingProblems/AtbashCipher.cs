using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.ProgrammingProblems
{
    public class AtbashCipher
    {
        private string _plain = "abcdefghijklmnopqrstuvwxyz";
        private string _cipher = "zyxwvutsrqponmlkjihgfedcba";
        private readonly string _input;
        private readonly List<int> _indices = new List<int>();

        public AtbashCipher(string input)
        {
            _input = input;
        }

        public string Encode()
        {
            Splitter(_input).ForEach(x => _indices.Add(_plain.IndexOf(x)));
            return _indices.Aggregate("", (current, index) => current + _cipher[index]);
        }

        public string Decode()
        {
            Splitter(_input).ForEach(x => _indices.Add(_cipher.IndexOf(x)));
            return _indices.Aggregate("", (current, index) => current + _plain[index]);
        }

        private List<char> Splitter(string input)
        {
            return input.ToCharArray().ToList();
        }
    }
}
