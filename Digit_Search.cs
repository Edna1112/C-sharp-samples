using System;


namespace AnythingGoes
{
    class Program
    {
        static void Main(string[] args)
        {

            
            Console.WriteLine("put a float number with a .");

            string number = Console.ReadLine();
            Console.WriteLine("put a digit to search");
            char digit= Convert.ToChar(Console.ReadLine());
            string subnumber = number.Substring(number.IndexOf("."));
             if (subnumber.Contains(digit))
             {
                 Console.WriteLine("true");
             }
             else
             {
                 Console.WriteLine("false");
             }
            
        }
        

    }

    }

