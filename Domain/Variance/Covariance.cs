using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Variance
{
    public class Covariance
    {
        readonly Stack<Bear> _bears = new Stack<Bear>();
        // Stack<Animal> animals = bears; // Compile-time error
        // The above restriction prevents the possibility of runtime failture
        // with the following code:
            // animals.Push(new Camel()); // Trying to add camel to bears

        public Covariance()
        {
            // The following is now legal after defining constraints on
            // ZooCleaner.Wash()
            ZooCleaner.Wash(_bears);
        }
    }

    // Variance is not automatic.
    // To ensure static type safety, type parameters are not automatically variant.
    public class Animal { }
    public class Bear : Animal { }
    public class Camel : Animal { }

    public class Stack<T> // A simple stack implementation
    {
        private int _position;
        readonly T[] _data = new T[1000];

        public void Push(T obj) => _data[_position++] = obj;
        public T Pop() => _data[--_position];
    }

    public class ZooCleaner
    {
        // Calling Wash with a stack of bears would generate a compile-time error.
        public static void Wash(Stack<Animal> animals) { }

        // To avoid the above we redefine Wash with a constraint:
        public static void Wash<T>(Stack<T> animals) where T : Animal { }
    }
}
