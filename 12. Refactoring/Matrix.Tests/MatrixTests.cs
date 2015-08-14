namespace Matrix.Tests
{
    using System;
    using System.Text;
    using MatrixOperations;
    using NUnit.Framework;

    [TestFixture]
    public class MatrixTests
    {
        [TestCase(1)]
        [TestCase(46)]
        [TestCase(100)]
        public void TestMatrixSizeSetter(int size)
        {
            Matrix matrix = new Matrix(size);

            Assert.AreEqual(size, matrix.Size, "Matrix Size property does not work as expected");
        }

        [TestCase(0)]
        [TestCase(101)]
        [TestCase(-45)]
        [TestCase(200)]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void TestMatrixSizeSetterWithInvalidValues(int size)
        {
            Matrix matrix = new Matrix(size);
        }


        [Test]
        public void TestFindEmptyCellOnEmptyMatrix()
        {
            Matrix matrix = new Matrix(10);

            int[] emptyCell = matrix.FindEmptyCell();

            Assert.AreEqual(0, emptyCell[0], "Empty cell method does not return right coordinates");
            Assert.AreEqual(0, emptyCell[1], "Empty cell method does not return right coordinates");
        }

        [Test]
        public void TestFindEmptyCellOnNonEmptyMatrix()
        {
            Matrix matrix = new Matrix(10);
            for (int i = 0; i < matrix.Size; i++)
            {
                for (int j = 0; j < matrix.Size; j++)
                {
                    matrix.MatrixArray[i, j] = 1;
                }
            }

            matrix.MatrixArray[5, 8] = 0;

            int[] emptyCell = matrix.FindEmptyCell();

            Assert.AreEqual(5, emptyCell[0], "Empty cell method does not return right coordinates");
            Assert.AreEqual(8, emptyCell[1], "Empty cell method does not return right coordinates");
        }

        [Test]
        public void TestIfFindEmptyCellReturnsFirstEmptyCellOnNonEmptyMatrix()
        {
            Matrix matrix = new Matrix(10);

            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < matrix.Size; j++)
                {
                    matrix.MatrixArray[i, j] = 1;
                }
            }

            int[] emptyCell = matrix.FindEmptyCell();

            Assert.AreEqual(2, emptyCell[0], "Empty cell method does not return right X coordinates");
            Assert.AreEqual(0, emptyCell[1], "Empty cell method does not return right Y coordinates");
        }

        [Test]
        public void TestFindEmptyCellOnFullMatrix()
        {
            Matrix matrix = new Matrix(10);

            for (int i = 0; i < matrix.Size; i++)
            {
                for (int j = 0; j < matrix.Size; j++)
                {
                    matrix.MatrixArray[i, j] = 1;
                }
            }

            int[] emptyCell = matrix.FindEmptyCell();

            Assert.AreEqual(-1, emptyCell[0], "Empty cell method does not return right X coordinates");
            Assert.AreEqual(-1, emptyCell[1], "Empty cell method does not return right Y coordinates");
        }

        [TestCase(new int[] { 0, 0 })]
        [TestCase(new int[] { 9, 9 })]
        [TestCase(new int[] { 9, 0 })]
        [TestCase(new int[] { 0, 9 })]
        [TestCase(new int[] { 3, 7 })]
        public void TestIsCellValidWithValidCell(int[] cellCoordinates)
        {
            Matrix matrix = new Matrix(10);
            bool isValid = matrix.IsCellValid(cellCoordinates);

            Assert.AreEqual(true, isValid, "IsCellValid returns false with a valid cell");
        }

        [TestCase(new int[] { -1, 0 }, TestName = "TestIsCellValidWithInvalidCell(-1,0)")]
        [TestCase(new int[] { 0, -1 }, TestName = "TestIsCellValidWithInvalidCell(0,-1)")]
        [TestCase(new int[] { -1, -1 }, TestName = "TestIsCellValidWithInvalidCell(-1,-1)")]
        [TestCase(new int[] { 0, 10 }, TestName = "TestIsCellValidWithInvalidCell(0,10)")]
        [TestCase(new int[] { 10, 0 }, TestName = "TestIsCellValidWithInvalidCell(10,0)")]
        [TestCase(new int[] { 10, 10 }, TestName = "TestIsCellValidWithInvalidCell(10,10)")]
        [TestCase(new int[] { 18, 5 }, TestName = "TestIsCellValidWithInvalidCell(18,5)")]
        [TestCase(new int[] { 4, 98 }, TestName = "TestIsCellValidWithInvalidCell(4,98)")]
        public void TestIsCellValidWithInvalidCell(int[] cellCoordinates)
        {
            Matrix matrix = new Matrix(10);
            bool isValid = matrix.IsCellValid(cellCoordinates);

            Assert.AreEqual(false, isValid, "IsCellValid returns true with an invalid cell");
        }

        [Test]
        public void TestFindEmptyAdjacentCellOnEmptyMatrix()
        {
            Matrix matrix = new Matrix(10);
            int currentRow = 0;
            int currentCol = 0;

            int[] emptyCell = matrix.FindEmptyAdjacentCell(currentRow, currentCol);

            Assert.AreEqual(0, emptyCell[0], "FindEmptyAdjacentCell method does not return right X coordinates");
            Assert.AreEqual(0, emptyCell[1], "FindEmptyAdjacentCell method does not return right Y coordinates");
        }

        [Test]
        public void TestFindEmptyAdjacentCellWhenNoCellIsEmpty()
        {
            Matrix matrix = new Matrix(10);
            int currentRow = 3;
            int currentCol = 3;

            for (int i = 0; i < matrix.Size; i++)
            {
                for (int j = 0; j < matrix.Size; j++)
                {
                    matrix.MatrixArray[i, j] = 1;
                }
            }

            int[] emptyCell = matrix.FindEmptyAdjacentCell(currentRow, currentCol);

            Assert.AreEqual(-1, emptyCell[0], "FindEmptyAdjacentCell method does not return right X coordinates");
            Assert.AreEqual(-1, emptyCell[1], "FindEmptyAdjacentCell method does not return right Y coordinates");
        }

        [TestCase(5, 5)]
        [TestCase(5, 6)]
        [TestCase(6, 6)]
        [TestCase(6, 5)]
        [TestCase(6, 4)]
        [TestCase(5, 4)]
        [TestCase(4, 4)]
        [TestCase(4, 5)]
        [TestCase(4, 6)]
        public void TestFindEmptyAdjacentCellOnNonEmptyMatrix(int emptyCellX, int emptyCellY)
        {
            Matrix matrix = new Matrix(10);
            int currentRow = 5;
            int currentCol = 5;

            for (int i = 0; i < matrix.Size; i++)
            {
                for (int j = 0; j < matrix.Size; j++)
                {
                    matrix.MatrixArray[i, j] = 1;
                }
            }

            matrix.MatrixArray[emptyCellX, emptyCellY] = 0;

            int[] emptyCell = matrix.FindEmptyAdjacentCell(currentRow, currentCol);

            Assert.AreEqual(emptyCellX, emptyCell[0], "FindEmptyAdjacentCell method does not return right X coordinates");
            Assert.AreEqual(emptyCellY, emptyCell[1], "FindEmptyAdjacentCell method does not return right Y coordinates");
        }

        [Test]
        public void TestToStringMethodWithEmptyMatrix()
        {
            Matrix matrix = new Matrix(4);
            StringBuilder builder = new StringBuilder();

            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    builder.Append(string.Format("{0,3}", 0));
                }

                builder.AppendLine();
            }

            Assert.AreEqual(builder.ToString(), matrix.ToString(), "ToString method does not return expected result");
        }

        [Test]
        public void TestToStringMethodWithSizeOneMatrix()
        {
            Matrix matrix = new Matrix(1);

            matrix.MatrixArray[0, 0] = 64;

            Assert.AreEqual(" 64\r\n", matrix.ToString(), "ToString method does not return expected result when matrix has size 1");
        }

        [Test]
        public void TestFillMethod()
        {
            Matrix matrix = new Matrix(6);

            matrix.Fill();

            for (int i = 0; i < matrix.Size; i++)
            {
                for (int j = 0; j < matrix.Size; j++)
                {
                    if (matrix.MatrixArray[i ,j] == 0)
                    {
                        Assert.Fail();
                    }
                }
            }
        }
    }
}
