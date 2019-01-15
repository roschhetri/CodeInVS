﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeInVS
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Code in VS add to Git Repo");

            //New Line added in VS

            //New Line added in GitHub
            Console.WriteLine("Enter a positive number to calculate Factorial:");
            int fact = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Factorial of {0} is {1}", fact, Feature1.Factorial(fact));

            Console.WriteLine("==================================");
            Console.WriteLine("Enter the Nth Fibonacci number:");
            int n = Convert.ToInt32(Console.ReadLine());
            Feature2.Fibonacci_Iterative(n);
            Console.WriteLine("==================================");
            Console.ReadLine();
        }
        
        //Added Feature3 by another Developer to master branch
        
        //Added Feature4 by another Developer1 to master branch
    }
}
