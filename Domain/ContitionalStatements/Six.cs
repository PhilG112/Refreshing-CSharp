using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Domain.ContitionalStatements
{
    public class Six
    {
        /* Write a C# Sharp program to read the value of an integer m
          and display the value of n is 1 when m is larger than 0, 
          0 when m is 0 and -1 when m is less than 0 
          
          n = 1 when m > 0
          n = 0 when m = 0
          n = -1 when m < 0;  
             
        */


        public void WhatIsValue()
        {
            var m = int.Parse(Console.ReadLine());
            int n;
            if (m > 0)
            {
                n = 1;
                Console.WriteLine($"The value of n = {n}");
            }
            else if (m == 0)
            {
                n = 0;
                Console.WriteLine($"The value of n = {n}");
            }
            else
            {
                n = -1;
                Console.WriteLine($"The value of n is {n}");
            }
        }
    }
}
