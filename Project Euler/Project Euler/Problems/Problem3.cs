using System;
using System.Collections.Generic;
using System.Text;
using Project_Euler;

public class Problem3 : IProblemLong
{
    const long NUM = 600851475143;
    public long Solution()
    {
        Console.WriteLine("Solution to Project Euler Problem 3: ");

        return FindLargestPrimeOf(NUM);
    }

    private long FindLargestPrimeOf(long num)
    {
        bool answerFound = false;
        long div = 2, res = 0;
        while (num != 0 && answerFound != true)
        {
            if (num % div != 0)
            {
                div += 1;
            }
            else
            {
                res = num;
                num /= div;
                if (num == 1)
                {
                    answerFound = true;
                }
            }
        }
        return res;
    }
}


