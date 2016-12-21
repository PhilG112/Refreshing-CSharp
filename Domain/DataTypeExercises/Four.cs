using System;

namespace Domain.DataTypeExercises
{
    public class Four
    {
        public void Operations()
        {
            var num1 = int.Parse(Console.ReadLine());
            var operation = Console.ReadLine();
            var num2 = int.Parse(Console.ReadLine());

            switch (operation)
            {
                case "+":
                    Console.WriteLine(num1 + num2);
                    break;
                case "-":
                    Console.WriteLine(num1 - num2);
                    break;
                case "*":
                    Console.WriteLine(num1 * num2);
                    break;
                case "/":
                    Console.WriteLine(num1 / num2);
                    break;
                case "%":
                    Console.WriteLine(num1 % num2);
                    break;
                default:
                    Console.WriteLine("Invalid Input");
                    break;
            }

        }
    }
}
