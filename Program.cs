using System;

namespace FibonacciNums
{
    static class Fibonacci
    {
        public static long GetFibonacciNumber(long num)
        {
            if 
              (num == 0)
              return 0;
            if 
              (num == 1) 
              return 1;

            return GetFibonacciNumber(num - 1) + GetFibonacciNumber(num - 2);
            
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("Введіть номер числа послідовності Фібоначчі:");
            if (long.TryParse(Console.ReadLine(), out long pos))
            {
                try
                {
                    long result = Fibonacci.GetFibonacciNumber(pos - 1);
                    Console.WriteLine($"Вхідний параметр: {pos}\n Вихідне значення: {result}");
                }
                catch (ArgumentException ex)
                {
                    Console.WriteLine(ex.Message);
                }
                catch (StackOverflowException)
                {
                    Console.WriteLine("Значення занадто велике!");
                }
            } else
            {
                Console.WriteLine("Введено некоректне значення!");
            }
        }
    }
}
