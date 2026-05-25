//#define FACTORIAL

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace SimpleTasks
{
    internal class Program
    {
        static void Main(string[] args)
        {
#if FACTORIAL
            Console.WriteLine("Factoria:");
            Console.Write("Введите число для вычисления Факториала:");
            int n = Convert.ToInt32(Console.ReadLine());
            BigInteger f = 1; //Класс 'BigInteger' реализует длинную арифметику.
            for (int i = 1; i <= n; i++)
            {
                f *= i;
                Console.WriteLine($"{i}! = {f}");
            } 
#endif





        }
    }
}
