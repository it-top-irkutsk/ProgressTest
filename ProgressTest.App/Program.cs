using System;
using System.Threading.Tasks;
using ProgressTest.Lib;
using ProgressTest.Lib2;

namespace ProgressTest.App
{
    class Program
    {
        static async Task Main()
        {
            IProgress progress = new Progress();
            progress.ProgressChanged += i =>
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"Промежуточный результат - {i}");
                Console.ResetColor();
            };

            var calc = new Calculate(progress);
            for (int i = 0; i < 10; i++)
            {
                var res = await calc.Factorial(i);
                Console.WriteLine($"{i}! = {res}");
            }
        }
    }
}