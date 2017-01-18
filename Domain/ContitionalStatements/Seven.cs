using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.ContitionalStatements
{
    public delegate void ProcessHeight(int h);
    public class Seven
    {
        private readonly ProcessHeight _height;
        public enum Heights
        {
            Dwarf,
            Short,
            Tall
        }

        public Seven()
        {
            _height = FilterHeight;
            Delegate[] methods = _height.GetInvocationList();
            var input = int.Parse(Console.ReadLine());
            foreach (Delegate d in methods)
            {
                d.DynamicInvoke(input);
            }
        }

        public void FilterHeight(int h)
        {
            if (h <= 135)
                Console.WriteLine(Heights.Dwarf);
            else if (h > 135 && h < 165)
                Console.WriteLine(Heights.Short);
            else
                Console.WriteLine(Heights.Tall);
        }
    }
}
