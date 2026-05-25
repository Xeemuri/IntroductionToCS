//#define FACTORIAL
//#define POWER
#define FIBONACCI
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
            Console.WriteLine("Factorial:");
            Console.Write("Введите число для вычисления факториала: ");
            int n = Convert.ToInt32(Console.ReadLine());
            BigInteger f = 1;   //Класс BigInteger реализует длинную арифметику
            for (int i = 1; i <= n; i++)
            {
                f *= i;
                Console.WriteLine($"{i}! = {f}");
            } 
#endif //FACTORIAL

#if POWER
            Console.Write("Введите основание степени: ");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите показатель степени: ");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.Write($"{a} ^ {n} = ");
            if (n < 0)
            {
                a = 1 / a;
                n = -n;
            }
            double N = 1;
            for (int i = 0; i < n; i++)
            {
                N *= a;

            }
            Console.WriteLine(N); 
#endif
            Console.Write("Введите предел для чисел Фибоначчи: ");
            int n = Convert.ToInt32(Console.ReadLine());
            for (int a = 0, b = 1, c = a + b; a < n; c = (a = b) + (b = c))
            {
                Console.Write(a + "\t");
            }
            Console.WriteLine();
        }
    }
}
