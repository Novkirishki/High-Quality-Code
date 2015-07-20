namespace Exam_Task_3
{
    using System;
    using System.Numerics;

    public class Program
    {
        /// <summary>
        /// Makes a boolean array with given size as string
        /// </summary>
        /// <param name="size">Size of the board as string</param>
        /// <returns>Boolean array with the given size</returns>
        private static bool[,] MakeBoard(string size)
        {            
            string[] dimensions = size.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            int width = int.Parse(dimensions[0]);
            int height = int.Parse(dimensions[1]);

            bool[,] board = new bool[width, height];

            return board;
        }

        /// <summary>
        /// Adds the given path to board by making tiles true
        /// </summary>
        /// <param name="board">The board to be added path on</param>
        /// <param name="cmd">Path command</param>
        private static void AddPathToBoard(bool[,] board, string[] cmd)
        {
            // starting from top right
            int x = board.GetLength(0) - 1;
            int y = 0;

            switch (cmd[0])
            {
                case "UR":
                case "RU":
                    for (int j = 0; j < int.Parse(cmd[1]) - 1; j++)
                    {
                        if (y + 1 <= board.GetLength(1) - 1 && x - 1 >= 0)
                        {
                            y += 1;
                            x -= 1;
                            board[x, y] = true;
                        }
                    }

                    break;
                case "UL":
                case "LU":
                    for (int j = 0; j < int.Parse(cmd[1]) - 1; j++)
                    {
                        if (y - 1 >= 0 && x - 1 >= 0)
                        {
                            y -= 1;
                            x -= 1;
                            board[x, y] = true;
                        }
                    }

                    break;
                case "DL":
                case "LD":
                    for (int j = 0; j < int.Parse(cmd[1]) - 1; j++)
                    {
                        if (y - 1 >= 0 && x + 1 <= board.GetLength(0) - 1)
                        {
                            y -= 1;
                            x += 1;
                            board[x, y] = true;
                        }
                    }

                    break;
                case "DR":
                case "RD":
                    for (int j = 0; j < int.Parse(cmd[1]) - 1; j++)
                    {
                        if (y + 1 <= board.GetLength(1) - 1 && x + 1 <= board.GetLength(0) - 1)
                        {
                            y += 1;
                            x += 1;
                            board[x, y] = true;
                        }
                    }

                    break;
                default:
                    break;
            }
        }

        /// <summary>
        /// Calculates the sum of all tiles of the board that are true
        /// </summary>
        /// <param name="board">The board</param>
        /// <param name="multiplicationIndex">Index of multiplication of the value of each tile</param>
        /// <returns>Sum of all tiles</returns>
        private static BigInteger CalculateSumOfPathsOnBoard(bool[,] board, int multiplicationIndex)
        {
            BigInteger sum = 0;

            for (int i = 0; i < board.GetLength(0); i++)
            {
                for (int j = 0; j < board.GetLength(1); j++)
                {
                    if (board[i, j] == true)
                    {
                        sum += (board.GetLength(0) - 1 - i + j) * multiplicationIndex;
                    }
                }
            }

            return sum;
        }

        private static void Main(string[] args)
        {
            // read the input
            string line = Console.ReadLine();

            bool[,] board = MakeBoard(line);

            // read number of commands and fill board
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                line = Console.ReadLine();
                string[] cmd = line.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                AddPathToBoard(board, cmd);   
            }

            BigInteger sum = CalculateSumOfPathsOnBoard(board, 3);

            // print result
            Console.WriteLine(sum);
        }
    }
}