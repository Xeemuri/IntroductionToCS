using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HardChess
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите размер шахматной доски");
            int n = Convert.ToInt32(Console.ReadLine());


            for (int i = 1; i <= n; i++)
            { 
                for (int j = 1; j <= n; j++) 
                {
                    for (int l = 1; l <= n; l++)
                    {
                        if ((l + i) % 2 == 0)
                        {
                            for (int k = 0; k < n; k++)
                            {
                                Console.Write("* ");
                            }
                        }
                        else
                        {
                            for (int k = 0; k < n; k++)
                            {
                                Console.Write("  ");
                            }
                        }
                    }
                    Console.WriteLine();
                }
            }
        }
    }
}
