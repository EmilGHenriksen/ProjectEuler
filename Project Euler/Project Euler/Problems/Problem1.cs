using System;
using Project_Euler;

public class Problem1 : IProblem<int>
{
    public int Solution()
    {
        {
            Console.WriteLine("Solution to Project Euler Problem 1: ");

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



