using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int size = 7;
            int[,] matrix = new int[size, size];
            Random random = new Random();

            Console.WriteLine("Початкова матриця:");
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    matrix[i, j] = random.Next(0, 101);
                    Console.Write(matrix[i, j] + " ");
                }
                Console.WriteLine();
            }
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size - i - 1; j++)
                {
                    int temp = matrix[i, j];
                    matrix[i, j] = matrix[size - j - 1, size - i - 1];
                    matrix[size - j - 1, size - i - 1] = temp;
                }
            }
            Console.WriteLine("Перетворена матриця (симетрична відносно побічної діагоналі):");
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    Console.Write(matrix[i, j] + " ");
                }
                Console.WriteLine();
            }   
            Console.ReadKey();

        }
    }
}
