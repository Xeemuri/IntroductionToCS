using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometry
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите размер фигур: ");
            int n = Convert.ToInt32(Console.ReadLine());

            //Квадрат
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();

            //Треугольник 1
            for (int i = 1; i <= n; i++)
            {
                for (int j = 0; j < i; j++) Console.Write("* ");
                Console.WriteLine();
            }
            Console.WriteLine();

            //Треугольник 2
            for (int i = 0; i < n; i++)
            {
                for (int j = n - i; j > 0; j--) Console.Write("* ");
                Console.WriteLine();
            }
            Console.WriteLine();

            //Треугольник 3
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < i; j++) Console.Write("  ");
                for (int j = n - i; j > 0; j--) Console.Write("* ");
                Console.WriteLine();
            }
            Console.WriteLine();

            //Треугольник 4
            for (int i = 1; i <= n; i++)
            {
                for (int j = n - i; j > 0; j--) Console.Write("  ");
                for (int j = 0; j < i; j++) Console.Write("* ");
                Console.WriteLine();
            }
            Console.WriteLine();

            //Ромб
            for (int i = 1; i <= n; i++)
            {
                for (int j = n - i; j > 0; j--) Console.Write(" ");
                Console.Write("/");
                for (int j = 1; j < i; j++) Console.Write("  ");
                Console.Write("\\");
                Console.WriteLine();
            }
            for(int i = n; i> 0;i--)
            {
                for (int j = n - i; j > 0; j--) Console.Write(" ");
                Console.Write("\\");
                for (int j = 1; j < i; j++) Console.Write("  ");
                Console.Write("/");
                Console.WriteLine();
            }
            Console.WriteLine();

            //+- Квадрат
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write((j+i) % 2 == 0 ? "+ ": "- ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }
    }
}
