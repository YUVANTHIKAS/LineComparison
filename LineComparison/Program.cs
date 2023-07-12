using System;

namespace LineComparison
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Line Comparison Problem statement");
            operation operation1 = new operation(2, 1, 4, 3);
            operation operation2 = new operation(6, 4, 2, 3);
            double line1 = operation1.CalculateLength();
            double line2 = operation2.CalculateLength();

            if (line1.Equals(line2)
                Console.WriteLine("Line1 and Line2 are equal");
            else
                Console.WriteLine("Line1 and Line2 are not equal");

        }
    }
}
