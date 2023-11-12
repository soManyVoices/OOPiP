using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;
using MatrixLibrary;

namespace UnitTestForClassMatrix
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void InputSizeFromConsole_ShouldSetCorrectSize()
        {
            
            SquareMatrix matrix = new SquareMatrix("Матрица", 4);
            int expectedSize = 4;

            
            using (StringReader sr = new StringReader("4"))
            {
                Console.SetIn(sr);
                matrix.InputSizeFromConsole();
            }

           
            Assert.AreEqual(expectedSize, matrix.Size);
        }

        [TestMethod]
        public void SumOfMainDiagonal_ShouldReturnCorrectSum()
        {
            
            SquareMatrix matrix = new SquareMatrix("Матрица", 3);
            matrix[0, 0] = 1;
            matrix[1, 1] = 2;
            matrix[2, 2] = 3;
            double expectedSum = 6;

           
            double actualSum = matrix.SumOfMainDiagonal();

            
            Assert.AreEqual(expectedSum, actualSum);
        }

        [TestMethod]
        public void SumOfElementsAboveMainDiagonal_ShouldReturnCorrectSum()
        {
            
            SquareMatrix matrix = new SquareMatrix("Матрица", 3);
            matrix[0, 1] = 1;
            matrix[0, 2] = 2;
            matrix[1, 2] = 3;
            double expectedSum = 6;

            double actualSum = matrix.SumOfElementsAboveMainDiagonal();

           
            Assert.AreEqual(expectedSum, actualSum);
        }

        [TestMethod]
        public void SumOfElementsBelowMainDiagonal_ShouldReturnCorrectSum()
        {
            
            SquareMatrix matrix = new SquareMatrix("Матрица", 3);
            matrix[1, 0] = 1;
            matrix[2, 0] = 2;
            matrix[2, 1] = 3;
            double expectedSum = 6;

            
            double actualSum = matrix.SumOfElementsBelowMainDiagonal();

            
            Assert.AreEqual(expectedSum, actualSum);
        }

        [TestMethod]
        public void ProductOfDiagonals_ShouldReturnCorrectProduct()
        {
            
            SquareMatrix matrix = new SquareMatrix("Матрица", 3);
            matrix[0, 0] = 2;
            matrix[1, 1] = 3;
            matrix[2, 2] = 4;
            matrix[0, 1] = 3;
            matrix[1, 2] = 2;
            matrix[1, 0] = 4;
            matrix[2, 1] = 3;
            double expectedProduct = 1728;

            
            double actualProduct = matrix.ProductOfDiagonals();

            
            Assert.AreEqual(expectedProduct, actualProduct);
        }

        [TestMethod]
        public void ProductOfAllDiagonals_ShouldReturnCorrectProduct()
        {
            
            SquareMatrix matrix = new SquareMatrix("Матрица", 3);
            matrix[0, 0] = 2;
            matrix[1, 1] = 3;
            matrix[2, 2] = 4;
            matrix[0, 2] = 2;
            matrix[2, 0] = 4;
            double expectedProduct = 192;

            
            double actualProduct = matrix.ProductOfAllDiagonals();

            
            Assert.AreEqual(expectedProduct, actualProduct);
        }
    }
}
