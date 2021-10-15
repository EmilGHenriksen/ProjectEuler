using System;
namespace Project_Euler
{
    public class Problem1 : IProblem
    {
        public int Solution
        {
            get
            {
                Console.WriteLine("Solution to Project Euler Problem 1: \n");

                int res = 0;
                for (int i = 0; i < 1000; i++)
                {
                    if (i % 3 == 0 || i % 5 == 0)
                    {
                        res += i;
                    }
                }
                return res;
            }
        }
    }
}


