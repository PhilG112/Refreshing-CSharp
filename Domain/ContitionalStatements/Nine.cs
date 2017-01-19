using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.ContitionalStatements
{
    public delegate void ProcessQuadrant(int y, int x); 
    public class Nine
    {
        private readonly ProcessQuadrant _processQuadrant;
        public enum Quads
        {
            TopLeft,
            TopRight,
            BottomLeft,
            BottomRight
        }

        public Nine()
        {
            _processQuadrant = CalculateQuadrant;
            var y = int.Parse(Console.ReadLine());
            var x = int.Parse(Console.ReadLine());
            Delegate[] methods = _processQuadrant.GetInvocationList();
            foreach (Delegate d in methods)
            {
                d.DynamicInvoke(y, x);
            }
        }

        public void CalculateQuadrant(int y, int x)
        {
            if(y > 0 && x < 0)
                Console.WriteLine(Quads.TopLeft);
            else if(y > 0 && x > 0)
                Console.WriteLine(Quads.TopRight);
            else if(y < 0 && x < 0)
                Console.WriteLine(Quads.BottomLeft);
            else if(y < 0 && x > 0)
                Console.WriteLine(Quads.BottomRight);
            else
                Console.WriteLine("0 point");
        }       
    }
}
