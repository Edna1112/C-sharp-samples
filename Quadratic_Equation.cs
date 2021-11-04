using System;

namespace Quadratic_Equation
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Type of equation is A*x^2 + B*x + C = 0");
            Console.WriteLine("Please type the A argument:");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please type the B argument:");
            int b = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please type the C argument:");
            int c = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Your equation is " + a + "*x^2 + " + b + "*x + " + c + " = 0");
            double x1, x2;

            if (a != 0 && b != 0 && c != 0)
            {
                double d = Math.Pow(b, 2) - 4 * a * c;
                if (d < 0)
                {
                    Console.WriteLine("There is no solution");
                }
                if (d == 0)
                {
                    x1 = x2 = -b / 2 * a;
                    Console.WriteLine("x1 =" + x1);
                    Console.Write("x2 =" + x2);
                }
                if (d > 0)
                {
                    x1 = (-b - Math.Sqrt(d)) / 2 * a;
                    x2 = (-b + Math.Sqrt(d)) / 2 * a;
                    Console.WriteLine("x1 =" + x1);
                    Console.Write("x2 =" + x2);
                }

            }
            else
            {
                Console.WriteLine("Put no 0 for the arguments");
            }
            Console.ReadLine();
        }
    }
}
