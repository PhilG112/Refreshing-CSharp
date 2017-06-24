using System;

namespace Domain.Arrays
{
    public struct PointS
    {
        public int X, Y;
    }

    public class PointC
    {
        public int X, Y;
    }

    public class Arrays
    {
        public Arrays()
        {
            // Declares an array of 5 characters, Once an aray has been created, it's
            // length cannot be changed.
            char[] vowels = new char[5]; 
            // Give each index a value
            vowels[0] = 'a';
            vowels[1] = 'e';
            vowels[2] = 'i';
            vowels[3] = 'o';
            vowels[4] = 'u';
            Console.WriteLine(vowels[1]); // => 'e'

            // ReSharper disable once ForCanBeConvertedToForeach
            for (int i = 0; i < vowels.Length; i++)
            {
                Console.Write(vowels[i]); // => aeiou
            }

            // Array initiazlization expression
            char[] vowels2 = {'a', 'e', 'i', 'o', 'u'};

            // Default element initialization
            // Since int is a value type, it allocates 1000 integers in one
            // contiguouse block of memory, default value for each element will be 0
            int[] a = new int[1000];
            Console.WriteLine(a[123]); // => 0

            // Value types vs reference types
            PointS[] p = new PointS[1000]; // Value type
            int x = p[500].X; // => 0

            PointC[] p2 = new PointC[1000]; // Reference type
            int x2 = p2[500].X; // Runtime error, NullReferenceException

            // To avoid the above error, we must explicitly instantiate 1000 points 
            // after instantiating the array:
            for (int i = 0; i < p2.Length; i++)
            {
                p2[i] = new PointC(); // Set array element i with a new PointC
            }

            // An array itself is always a reference type object, regardless of the 
            // element type, the following is legal;
            int[] a2 = null;

            // MULTIDIMENSIONAL ARRAYS
                // Multidimensional come in two varieties: rectengular and jagged.
                // Rectangular arrays represent an n-dimensional block of memory and jagged
                // arrays are arrays of arrays

            // RECTANGULAR ARRAYS:
                // Rectangular arrays are declared using commas to seperate each
                // dimension. The following decalres a 2d array, where the dimensions are
                // 3x3
            int[,] matrix = new int[3,3];
            // The GetLength() of an array returns the length for a given dimension
            // starting at 0:
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = i * 3 + j;
                }
            }
            // The above will result in the following:
            int[,] matrix2 = {
                {0, 1, 2},
                {3, 4, 5},
                {6, 7, 8}
            };

            // JAGGED ARRAYS:
            int[][] jagged = new int[3][];
            // The inner dimensions aren't specified in the declaration because,
            // unlike a rectangular array, each ineer array can be an arbitrary length,
            // Each inner array is implicitly initialized to null rather than an,
            // empty array. Each inner array must be created manually:
            for (int i = 0; i < jagged.Length; i++)
            {
                jagged[i] = new int[3]; // Create inner array
                for (int j = 0; j < jagged[i].Length; j++)
                {
                    jagged[i][j] = i * 3 + j;
                }
            }

            // Jagged arrays can be initalized as follows:
            var jagged2 = new int[][]
            {
                new[] {0, 1, 2},
                new[] {3, 4, 5},
                new[] {6, 7, 8, 9}  // Additional element at the end
            };
        }
    }
}
