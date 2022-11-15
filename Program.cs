using System;

namespace _06._Operations_Between_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int first = int.Parse(Console.ReadLine());
            int second = int.Parse(Console.ReadLine());
            string op = Console.ReadLine();

            if (op == "/")
            {
                if (second == 0)
                {
                    Console.WriteLine($"Cannot divide {first} by zero");
                }
                else
                {
                    double result = first / (second * 1.0);
                    Console.WriteLine($"{first} / {second} = {result:f2}");
                }
                
            }
            else if (op == "%")
            {
                if (second == 0)
                {
                    Console.WriteLine($"Cannot divide {first} by zero");
                }
                else
                {
                    int result = first % second;
                    Console.WriteLine($"{first} % {second} = {result}");
                }
            }
            else if (op == "+")
            {
                int result = first + second;
                if (result % 2 == 0)
                {
                    Console.WriteLine($"{first} + {second} = {result} - even");
                }
                else
                {
                    Console.WriteLine($"{first} + {second} = {result} - odd");
                }
                
            }
            else if (op == "-")
            {
                int result = first - second;
                if (result % 2 == 0)
                {
                    Console.WriteLine($"{first} - {second} = {result} - even");
                }
                else
                {
                    Console.WriteLine($"{first} - {second} = {result} - odd");
                }
            }
            else if (op == "*")
            {
                int result = first * second;
                if (result % 2 == 0)
                {
                    Console.WriteLine($"{first} * {second} = {result} - even");
                }
                else
                {
                    Console.WriteLine($"{first} * {second} = {result} - odd");
                }
            }
        }
    }
}
