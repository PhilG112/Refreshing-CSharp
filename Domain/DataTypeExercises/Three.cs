using System;

namespace Domain.DataTypeExercises
{
    public class Three
    {
        private string userName = "Philg112";
        private string password = "delownz112";

        public void Authenticate()
        {  
            var count = 3;  
            while (count != -1)
            {
                var uName = Console.ReadLine();
                var pass = Console.ReadLine();
                if (uName == userName && pass == password)
                {
                    Console.WriteLine("Welcome");
                }
                else if (uName != userName || pass != password)
                {
                    Console.WriteLine($"Incorrect try again. Attempts remaining {count}");
                    count--;
                }               
            }
            Console.WriteLine("You have been locked out");    
        }
    }
}
