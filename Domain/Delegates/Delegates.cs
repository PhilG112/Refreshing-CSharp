using System;
using System.IO;
using System.Threading;

namespace ConsoleApp.Delegates
{
    public delegate int Transformer(int x);
    public delegate void ProgressReporter(int percentComplete);
    public delegate T GenericTransformer<T>(T arg);

    public class Delegates
    {
        public Delegates()
        {
            // Assigning a method to a delegate variable creates a delegate instance
            Transformer t = Square; // Create delegate instance
            // Which can be invoked in the same way as a method
            var answer = t(3); // Invoke delegate
            Console.WriteLine(answer); // => 9

            int[] values = {1, 2, 3};
            Util.Transform(values, Square);
            foreach (var i in values)
            {
                Console.WriteLine(i);
            }

            // Multicast delegates
            ProgressReporter p = WriteProgressToConsole;
            p += WriteProgressToFile;
            Util.HardWork(p);

            // Generic delegates
            int[] values2 = {1, 2, 4};
            Util.GenericTransform(values2, Square); // Hook in Square
            foreach (var v in values2)
            {
                Console.WriteLine(v);
            }

            // Delegate vs Interfaces
            int[] values3 = {1, 2, 3};
            Util.TransformAll(values3, new Squarer());
            foreach (var v in values3)
            {
                Console.WriteLine(v);
            }

            // Cuber example
            int[] values4 = {1, 2, 3};
            Util.Transform(values4, Cuber);
            foreach (var v in values4)
            {
                Console.WriteLine(v);
            }
        }

        public int Square(int x) => x * x;
        public int Cuber(int x) => x * x * x;

        static void WriteProgressToConsole(int percentComplete) 
            => Console.WriteLine(percentComplete);

        static void WriteProgressToFile(int percentComplete) 
            => File.WriteAllText("progress.txt", percentComplete.ToString());
    }

    // Delegates vs Interfaces
    // A delegate design may be a better choice than an interface design if one or more 
    // of these conditions are tue:
        // The interface defines only a single method.
        // Mulicast capability is needed.
        // The subscriber needs to implement the interface multiple times.
    public interface ITransformer
    {
        int Transform(int x);
    }

    public class Squarer : ITransformer
    {
        public int Transform(int x) => x * x;
    }

    // Writing plug-in methods with delegates
    public class Util
    {
        public static void Transform(int[] values, Transformer t)
        {
            for (var i = 0; i < values.Length; i++)
            {
                values[i] = t(values[i]);
            }
        }

        public static void HardWork(ProgressReporter p)
        {
            for (var i = 0; i < 10; i++)
            {
                p(i * 10); // Invoke delegate
                Thread.Sleep(100); // Simulate hard work
            }
        }

        public static void GenericTransform<T>(T[] values, GenericTransformer<T> t)
        {
            for (var i = 0; i < values.Length; i++)
            {
                values[i] = t(values[i]);
            }
        }

        public static void TransformAll(int[] values, ITransformer t)
        {
            for (var i = 0; i < values.Length; i++)
            {
                values[i] = t.Transform(values[i]);
            }
        }
    }
}
