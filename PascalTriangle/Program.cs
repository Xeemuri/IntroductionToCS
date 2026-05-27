using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PascalTriangle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите высоту для треугольника: ");
            int n = Convert.ToInt32(Console.ReadLine());
            int c, dif;
            for (int i = 0; i < n; i++) // строчки треугольника
            {
                for (int j = 0; j < n - i - 1; j++) //отступы для выравнивания 
                {
                    Console.Write('\t');
                }
                for (int j = 0; j <= i; j++)//сам треугольник
                {
                    if (j == 0 || j == i) Console.Write(1);
                    else
                    {
                        double fact_i = 1;
                        double fact_j = 1;
                        double fact_dif = 1;
                        dif = i - j;

                        for (int k = 1; k <= dif; k++)
                        {
                            fact_dif *= k;
                        }
                        for (int k = 1; k <= i; k++)
                        {
                            fact_i *= k;
                        }
                        for (int k = 1; k <= j; k++)
                        {
                            fact_j *= k;
                        }
                        c = Convert.ToInt32(fact_i / (fact_j * fact_dif)); //формула биномиального коэффициента С(i,j) = i! / (j! * (i-j)!) 
                        Console.Write(c);
                    }
                    if (j < i)
                    {
                        Console.Write("\t\t");
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
