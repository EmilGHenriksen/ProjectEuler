using System;
using System.Collections.Generic;
using System.Text;
using Project_Euler;

class Problem6 : IProblemInt
{
    const int NUM = 100;
    public int Solution()
    {
        Console.WriteLine("Solution to Project Euler Problem 6: ");

        int s1 = SumOfSquares(NUM);
        int s2 = SquareOfSum(NUM);

        return FindDifference(s2, s1);
    }

    private int FindDifference(int num1, int num2)
    {
        int res = num1 - num2;
        return Math.Abs(res);
    }

    private int SquareOfSum(int num)
    {
        int res = 0;
        for (int i = 0; i < num; i++)
        {
            res += i + 1;
        }
        res = res*res;
        return res;
    }

    private int SumOfSquares(int num)
    {
        int res = 0;
        for (int i = 0; i < num; i++)
        {
            res += (i + 1) * (i + 1);
        }
        return res;
    }
}

