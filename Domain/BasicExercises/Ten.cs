using System;

namespace csharpPractice.BasicExercises
{
    public class Ten
    {
        // (x + y) * z
        // x * y + x * z
        private int x;
        private int y;
        private int z;
        public Ten()
        {
            Console.WriteLine("Input your numbers");
            x = int.Parse(Console.ReadLine());
            y = int.Parse(Console.ReadLine());
            z = int.Parse(Console.ReadLine());
        }

        public void OutPut()
        {
            Console.WriteLine(CalcOne());
            Console.WriteLine(CalcTwo());
        }

        public int CalcOne()
        {
            return (x + y) * z;
            
        }
        public int CalcTwo()
        {
            return x * y + y * z;
        }
    }
}
