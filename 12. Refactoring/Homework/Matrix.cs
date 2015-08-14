namespace MatrixOperations
{
    using System;
    using System.Text;

    /// <summary>
    /// Class representing a matrix and giving functionality to fill it, 
    /// search for empty cells, check if cell is inside matrix boundaries and
    /// print the matrix.
    /// </summary>
    public class Matrix
    {
        private int size;
        private int[,] matrixArray;

        /// <summary>
        /// Initializes a new instance of the Matrix class
        /// </summary>
        /// <param name="size">The size of the matrix side</param>
        public Matrix(int size)
        {
            this.Size = size;
            this.MatrixArray = new int[this.Size, this.Size];
        }

        /// <summary>
        /// Gets or sets size of the matrix
        /// </summary>
        public int Size
        {
            get
            {
                return this.size;
            }

            set
            {
                if (value <= 0 || value > 100)
                {
                    throw new ArgumentOutOfRangeException("Matrix size must be between 1 and 100");
                }

                this.size = value;
            }
        }

        /// <summary>
        /// Gets or sets the matrix as an integer array
        /// </summary>
        public int[,] MatrixArray
        {
            get
            {
                return this.matrixArray;
            }

            set
            {
                this.matrixArray = value;
            }
        }

        /// <summary>
        /// Fills every cell of the matrix with a value equal to the number in which the cells are filled.
        /// Example: first cell = 1, second = 2, etc.
        /// The filling begins from the upper left corner and continues diagonally to the lower right corner. 
        /// If lower right cell is filled it moves to the next empty adjacent cell clockwise.
        /// If no empty adjacent cell it searches for an empty cell in the whole matrix.
        /// If found the process is repeated, if not the matrix is filled.
        /// </summary>
        public void Fill()
        {
            int filledCellsCount = 0,
                currentRow = 0,
                currentColumn = 0;

            int[] emptyCellCoordinates = this.FindEmptyCell();

            while (this.IsCellValid(emptyCellCoordinates))
            {
                currentRow = emptyCellCoordinates[0];
                currentColumn = emptyCellCoordinates[1];

                this.MatrixArray[currentRow, currentColumn] = ++filledCellsCount;

                emptyCellCoordinates = this.FindEmptyAdjacentCell(currentRow, currentColumn);

                if (!this.IsCellValid(emptyCellCoordinates))
                {
                    emptyCellCoordinates = this.FindEmptyCell();
                }
            }
        }

        /// <summary>
        /// Finds empty cell in the whole matrix
        /// </summary>
        /// <returns>Empty cell coordinates, if no empty cell is found returns {-1, -1}</returns>
        public int[] FindEmptyCell()
        {
            for (int i = 0; i < this.MatrixArray.GetLength(0); i++)
            {
                for (int j = 0; j < this.MatrixArray.GetLength(0); j++)
                {
                    if (this.MatrixArray[i, j] == 0)
                    {
                        return new int[2] { i, j };
                    }
                }
            }

            return new int[2] { -1, -1 };
        }

        /// <summary>
        /// Checks if cell is inside the boundaries of the matrix
        /// </summary>
        /// <param name="cellCoordinates">Integer array with the cell coordinates - {x, y}</param>
        /// <returns>True if valid, false otherwise</returns>
        public bool IsCellValid(int[] cellCoordinates)
        {
            if (cellCoordinates[0] < 0 || cellCoordinates[0] >= this.MatrixArray.GetLength(0))
            {
                return false;
            }
            else if (cellCoordinates[1] < 0 || cellCoordinates[1] >= this.MatrixArray.GetLength(1))
            {
                return false;
            }

            return true;
        }

        /// <summary>
        /// Method searches for an empty adjacent cell to the given one.
        /// A cell is adjacent if it has common side or corner to the given.
        /// A cell is empty if it has value 0.
        /// </summary>
        /// <param name="currentRow">The row of the current cell</param>
        /// <param name="currentCol">The column of the current cell</param>
        /// <returns>An integer array with the coordinates of the found empty cell. If no cell is found returns {-1, -1}</returns>
        public int[] FindEmptyAdjacentCell(int currentRow, int currentCol)
        {
            for (int i = 0; i < Directions.BoardDirections.Length; i++)
            {
                Direction currentDirection = Directions.BoardDirections[i];
                if (this.IsCellValid(new int[] { currentRow + currentDirection.X, currentCol + currentDirection.Y})
                    && this.MatrixArray[currentRow + currentDirection.X, currentCol + currentDirection.Y] == 0)
                {
                    return new int[2] { currentRow + currentDirection.X, currentCol + currentDirection.Y };
                }
            }

            return new int[2] { -1, -1 };
        }

        /// <summary>
        /// Method returns matrix as a string, where every row is on a separate line
        /// </summary>
        /// <returns>Matrix as a string</returns>
        public override string ToString()
        {
            StringBuilder builder = new StringBuilder();

            for (int row = 0; row < this.MatrixArray.GetLength(0); row++)
            {
                for (int col = 0; col < this.MatrixArray.GetLength(1); col++)
                {
                    builder.Append(string.Format("{0,3}", this.MatrixArray[row, col]));
                }

                builder.AppendLine();
            }

            return builder.ToString();
        }
    }
}