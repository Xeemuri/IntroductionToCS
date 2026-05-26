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


            for (int height = 0; height < n; height++)
            {
                for (int width = 0; width < n; width++)
                {
                    for (int i = 0; i < n; i++)
                    {
                        for (int j = 0; j < n; j++)
                        {
                            Console.Write((height + width) % 2 == 0 ? "* " : "  ");
                        }
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
