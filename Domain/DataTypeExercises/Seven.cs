using System;

namespace csharpPractice.DataTypeExercises
{
    public class Seven
    {
        private int meters {get; set;}
        private int hours {get; set;}
        private int minutes {get; set;}
        private int seconds {get; set;}
        private TimeSpan time {get; set;}
        public Seven()
        {
            Console.WriteLine("Please input data:");
            meters = int.Parse(Console.ReadLine());
            hours = int.Parse(Console.ReadLine());
            minutes = int.Parse(Console.ReadLine());
            seconds = int.Parse(Console.ReadLine());
            time = new TimeSpan(hours, minutes, seconds);
            this.MetersPerScond();
        }
        public void Calculation()
        {
            
        }

        public void MetersPerScond()
        {
            var result = meters / time.Ticks;
            Console.WriteLine(result);
        }


    }
}