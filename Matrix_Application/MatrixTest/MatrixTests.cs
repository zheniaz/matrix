using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MatrixSpace
{
    [TestClass]
    public class MatrixTests
    {
        [TestMethod]
        public void Check_Correct_Addition()
        {
            // Arrange

            int n = 2;
            int[,] matrix1 = { { 1, 2 }, { 3, 4 } };
            int[,] matrix2 = { { 1, 2 }, { 3, 4 } };
            int[,] expected = { { 2, 4 }, { 6, 8 } };

            Matrix mt1 = new Matrix(matrix1, n, n);
            Matrix mt2 = new Matrix(matrix2, n, n);

            // Act

            mt1.Addition(mt2);
            int[,] actual = Matrix.LastResult;

            // Assert

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Assert.AreEqual(expected[i, j], actual[i, j]);
                }
            }
        }

        [TestMethod]
        public void Check_Correct_Multiplication()
        {
            // Arrange

            int n = 2;
            int[,] matrix1 = { { 1, 2 }, { 3, 4 } };
            int[,] matrix2 = { { 1, 2 }, { 3, 4 } };
            int[,] expected = { { 7, 10 }, { 15, 22 } };

            Matrix mt1 = new Matrix(matrix1, n, n);
            Matrix mt2 = new Matrix(matrix2, n, n);

            // Act

            mt1.multiplication(mt2);
            int[,] actual = Matrix.LastResult;

            // Assert

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Assert.AreEqual(expected[i, j], actual[i, j]);
                }
            }
        }

        [TestMethod]
        public void Check_Correct_Transposition()
        {
            // Arrange

            int n = 2;
            int[,] matrix1 = { { 1, 2 }, { 3, 4 } };
            int[,] expected = { { 1, 3 }, { 2, 4 } };
            Matrix mt1 = new Matrix(matrix1, n, n);

            // Act

            mt1.transposition();
            int[,] actual = Matrix.LastResult;

            // Assert

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Assert.AreEqual(expected[i, j], actual[i, j]);
                }
            }
        }
    }
}
