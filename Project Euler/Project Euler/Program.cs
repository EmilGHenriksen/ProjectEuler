using System;

namespace Project_Euler
{
    class Program
    {
        static void Main(string[] args)
        {
            Problem1 p1 = new Problem1();
            Console.WriteLine(p1.Solution() + "\n");

            Problem2 p2 = new Problem2();
            Console.WriteLine(p2.Solution() + "\n");

            Problem3 p3 = new Problem3();
            Console.WriteLine(p3.Solution() + "\n");

            Problem6 p6 = new Problem6();
            Console.WriteLine(p6.Solution() + "\n");
        }
    }
}
