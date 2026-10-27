using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    using System;

    class SquareMatrix
    {
        private int n;
        private int a;
        private int b;
        private int[,] matrix;

        public int N
        {
            get => n;
            set => n = value;
        }

        public int A
        {
            get => a;
            set => a = value;
        }

        public int B
        {
            get => b;
            set => b = value;
        }
        public SquareMatrix(int n, int a, int b)
        {
            N = n;
            A = a;
            B = b;
            matrix = new int[N, N];
            FillMatrix();
        }

        private void FillMatrix()
        {
            Random rand = new Random();
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    matrix[i, j] = rand.Next(A, B + 1);
                }
            }
        }

        public void ShowMatrix()
        {
            Console.WriteLine($"Matrica {N}x{N} ([{A}, {B}] mijakayqum):");
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    Console.Write($"{matrix[i, j],4} ");
                }
                Console.WriteLine();
            }
        }
        public int GetOddNumbersCount()
        {
            int count = 0;
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    if (matrix[i, j] % 2 != 0)
                    {
                        count++;
                    }
                }
            }
            return count;
        }
    }

    class Program
    {
        static void Main()
        {
            int matrixSize = 4;
            int minVal = 1;
            int maxVal = 50;

            SquareMatrix myMatrix = new SquareMatrix(matrixSize, minVal, maxVal);

            myMatrix.ShowMatrix();
            int oddCount = myMatrix.GetOddNumbersCount();
            Console.WriteLine($"\nkent tveri qnaky matricum: {oddCount}");
        }
    }
}