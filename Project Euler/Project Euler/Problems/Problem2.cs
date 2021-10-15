using System;
using System.Collections.Generic;
using System.Text;

namespace Project_Euler.Problems
{
    public class Problem2 : IProblem
    {
        public int Solution
        {
            get
            {
                Console.WriteLine("Solution to Project Euler Problem 2: \n");

                int a = 0, b = 1, res = 0, sum = 0;

                while (res < 4000000)
                {
                    res = a + b;
                    if (res % 2 == 0)
                    {
                        sum += res;
                    }
                    a = b;
                    b = res;
                }
                return sum;
            }
        }
    }
}
