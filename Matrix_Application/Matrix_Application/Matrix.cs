using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatrixSpace
{
    public class Matrix
    {
        public static int[,] LastResult { get; set; }
        int[,] tm { get; set; }
        int size1 { get; set; }
        int size2 { get; set; }
        public Matrix(int[,] arg, int i, int j)
        {
            tm = arg;
            size1 = i;
            size2 = j;
            LastResult = arg;
        }


        public void Addition(Matrix matrix2)
        {
            Console.WriteLine("сложить матрицы:");
            int[,] res = new int[size1, size2];
            for (int i = 0; i < this.size1; i++)
            {
                for (int j = 0; j < this.size2; j++)
                {
                    res[i, j] = this.tm[i, j] + matrix2.tm[i, j];
                    Console.Write(res[i, j] + " ");
                }
                Console.WriteLine();
            }
            LastResult = res;
        }

        public void multiplication(Matrix matrix2)
        {
            Console.WriteLine("умножить матрицы:");
            int[,] res = new int[this.size1, matrix2.size2];
            for (int i = 0; i < this.size1; i++)
            {
                for (int j = 0; j < matrix2.size2; j++)
                {
                    for (int k = 0; k < matrix2.size1; k++)
                        res[i, j] += this.tm[i, k] * matrix2.tm[k, j];
                    Console.Write(res[i, j] + " ");
                }
                Console.WriteLine();
            }
            LastResult = res;
        }

        public void transposition()
        {
            Console.WriteLine("транспонировать матрицу:");
            for (int i = 0; i < this.size1; i++)
            {
                Console.WriteLine();
                for (int j = 0; j < this.size2; j++)
                {
                    Console.Write(this.tm[i, j] + "  ");
                }
            }
            Console.WriteLine("\n");
            Console.WriteLine("после транспонирования:\n");
            int[,] M_tr = new int[this.size2, this.size1];
            for (int i = 0; i < this.size2; i++)
            {
                for (int j = 0; j < this.size1; j++)
                {
                    M_tr[i, j] = this.tm[j, i];
                    Console.Write(M_tr[i, j] + " ");
                }
                Console.WriteLine();
            }
            LastResult = M_tr;
        }

        public void Show_Matrix()
        {
            Console.WriteLine("показать матрицу:");
            for (int i = 0; i < this.size1; i++)
            {
                for (int j = 0; j < this.size2; j++)
                {
                    Console.Write(this.tm[i, j] + "  ");
                }
                Console.WriteLine();
            }
        }
    }
}
