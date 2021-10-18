using System;
using System.Collections.Generic;
using System.Text;
using Project_Euler;

public class Problem2 : IProblemInt
{
    public int Solution()
    {
        Console.WriteLine("Solution to Project Euler Problem 2: ");

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


