using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatrixSpace
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Hello, World!");
                Console.WriteLine("Введите размерность матрицы 1, n x m: ");
                int n = int.Parse(Console.ReadLine());
                int m = int.Parse(Console.ReadLine());
                int[,] matrix1 = new int[n, m];
                for (int i = 0; i < n; i++)
                {
                    for (int j = 0; j < m; j++)
                    {
                        Console.Write("arr[ {0}, {1}] = ", i, j);
                        matrix1[i, j] = int.Parse(Console.ReadLine());
                    }
                }
                Console.WriteLine();

                Console.WriteLine("Введите размерность матрицы 2, k x l: ");
                int k = int.Parse(Console.ReadLine());
                int l = int.Parse(Console.ReadLine());
                int[,] matrix2 = new int[k, l];
                for (int i = 0; i < k; i++)
                {
                    for (int j = 0; j < l; j++)
                    {
                        Console.Write("arr[ {0}, {1}] = ", i, j);
                        matrix2[i, j] = int.Parse(Console.ReadLine());
                    }
                }
                Console.WriteLine();
                Matrix m1 = new Matrix(matrix1, n, m);
                Matrix m2 = new Matrix(matrix2, k, l);

                int a;
                do
                {
                    {
                        Console.WriteLine(@"Please,  type the number:
                    1.  matrix addition
                    2.  multiplication of matrices
                    3.  transposition of matrices
                    4.  Show_Matrix 1
                    5.  Show_Matrix 2
                    ");

                        try
                        {
                            a = int.Parse(Console.ReadLine());

                            switch (a)
                            {
                                case 1:
                                    if (matrix1.GetLength(0) == matrix2.GetLength(0) &&
                                    matrix1.GetLength(1) == matrix2.GetLength(1))
                                    {
                                        m1.Addition(m2);
                                    }
                                    else
                                    {
                                        throw new Exception("Недопустимая для сложения размерность матриц. Должно быть n = l && m = l");
                                    }
                                    break;

                                case 2:
                                    if (matrix1.GetLength(0) == matrix2.GetLength(1))
                                    {
                                        m1.multiplication(m2);
                                    }
                                    else
                                    {
                                        throw new Exception("Недопустимая для умножения размерность матриц. Должно быть n = l");
                                    }
                                    break;

                                case 3:
                                    m1.transposition();
                                    break;

                                case 4:
                                    m1.Show_Matrix();
                                    break;

                                case 5:
                                    m2.Show_Matrix();
                                    break;

                                default:
                                    Console.WriteLine("Exit");
                                    break;
                            }

                        }
                        catch (Exception e)
                        {
                            Console.WriteLine("Error: " + e.Message);
                        }
                    }
                    Console.WriteLine("Press Spacebar to exit; press any key to continue");
                }
                while (Console.ReadKey().Key != ConsoleKey.Spacebar);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Некоректный ввод, " + ex.Message);
            }
        }
    }
}

