using System;
using System.Collections.Generic;
using System.Text;
using Project_Euler;

class Problem5 : IProblemLong
{
    const int SMALLESTDIV = 2520;
    public long Solution()
    {
        Console.WriteLine("Solution to Project Euler Problem 5: ");

        return EvenlyDivisible(SMALLESTDIV);
    }

    private long EvenlyDivisible(int num)
    {
        long ans = 0;
        bool check = false;
        int count = 0;
        while (check == false)
        {
            for (int i = 20; i >= 11; i--)
            {
                if (num % i == 0)
                {
                    count++;
                }
                else
                {
                    num += SMALLESTDIV;
                    i = 21;
                    count = 0;
                }
                if (count == 10)
                {
                    ans = num;
                    check = true;
                }
            }
        }
        return ans;
    }
}
