#define ARRAYS_1
//#define ARRAYS_2
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
#if ARRAYS_1
            int[] arr = { 3, 5, 8, 13, 21 };
            Console.WriteLine(arr);
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + "\t");
            }
            Console.WriteLine();

            foreach (int i in arr)
            {
                Console.Write(i + "\t");
            }
            Console.WriteLine(); 
            //Сумма, среднее арифметическое, минимальное и максимальное значение
            Console.WriteLine($"Сумма: {arr.Sum()}");
            Console.WriteLine($"Среднее арифметическое: {arr.Average()}");
            Console.WriteLine($"Минимальное значение: {arr.Min()}");
            Console.WriteLine($"Максимальное значение: {arr.Max()}");
#endif
#if ARRAYS_2
            int[,] i_arr_2 =
                {
                {3,5,8 },
                {13,21,34 },
                {55,89,144 },
                {233,377,610 },
            };
            Console.WriteLine($"Количество измерений: {i_arr_2.Rank}");
            Console.WriteLine($"Length: {i_arr_2.Length}");
            Console.WriteLine($"Rows: {i_arr_2.GetLength(0)}");
            Console.WriteLine($"Cols: {i_arr_2.GetLength(1)}");
            for (int i = 0; i < i_arr_2.GetLength(0); i++)
            {
                for (int j = 0; j < i_arr_2.GetLength(1); j++)
                {
                    Console.Write(i_arr_2[i, j] + "\t");
                }
                Console.WriteLine();
            }
            foreach (int i in i_arr_2)
            {
                Console.Write(i + "\t");
            } 
#endif

        }
    }
}
