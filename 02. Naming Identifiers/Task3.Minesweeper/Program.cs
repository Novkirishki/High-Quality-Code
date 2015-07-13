using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Minesweeper
{
    public class minite
    {
        static void Main(string[] args)
        {
            string command = string.Empty;
            char[,] gameField = CreateGameField();
            char[,] bombField = CreateBombField();
            int turnsCount = 0;
            bool endGame = false;
            List<Player> players = new List<Player>(6);
            int row = 0;
            int column = 0;
            bool isNewGame = true;
            const int MaxTurns = 35;
            bool winGame = false;

            do
            {
                if (isNewGame)
                {
                    Console.WriteLine("Let's play Minesweeper. Try your luck and field all fields without mines." +
                    " 'top' command shows highscores, 'restart' starts a new game, 'exit' closes the game!");
                    PrintGameField(gameField);
                    isNewGame = false;
                }

                Console.Write("Input row and column : ");
                command = Console.ReadLine().Trim();

                if (command.Length >= 3)
                {
                    if (int.TryParse(command[0].ToString(), out row) 
                        && int.TryParse(command[2].ToString(), out column) 
                        && row <= gameField.GetLength(0) && column <= gameField.GetLength(1))
                    {
                        command = "turn";
                    }
                }

                switch (command)
                {
                    case "top":
                        PrintHighscores(players);
                        break;
                    case "restart":
                        gameField = CreateGameField();
                        bombField = CreateBombField();
                        PrintGameField(gameField);
                        endGame = false;
                        isNewGame = false;
                        break;
                    case "exit":
                        Console.WriteLine("Bye!");
                        break;
                    case "turn":
                        if (bombField[row, column] != '*')
                        {
                            if (bombField[row, column] == '-')
                            {
                                Turn(gameField, bombField, row, column);
                                turnsCount++;
                            }

                            if (MaxTurns == turnsCount)
                            {
                                winGame = true;
                            }
                            else
                            {
                                PrintGameField(gameField);
                            }
                        }
                        else
                        {
                            endGame = true;
                        }
                        break;
                    default:
                        Console.WriteLine("\nInvalid command\n");
                        break;
                }

                if (endGame)
                {
                    PrintGameField(bombField);
                    Console.Write("\nYou died with {0} points. " + "Enter your name: ", turnsCount);
                    string name = Console.ReadLine();
                    Player currentPlayer = new Player(name, turnsCount);

                    if (players.Count < 5)
                    {
                        players.Add(currentPlayer);
                    }
                    else
                    {
                        for (int i = 0; i < players.Count; i++)
                        {
                            if (players[i].Points < currentPlayer.Points)
                            {
                                players.Insert(i, currentPlayer);
                                players.RemoveAt(players.Count - 1);
                                break;
                            }
                        }
                    }

                    players.Sort((Player player1, Player player2) => player2.Name.CompareTo(player1.Name));
                    players.Sort((Player player1, Player player2) => player2.Points.CompareTo(player1.Points));
                    PrintHighscores(players);

                    gameField = CreateGameField();
                    bombField = CreateBombField();
                    turnsCount = 0;
                    endGame = false;
                    isNewGame = true;
                }

                if (winGame)
                {
                    Console.WriteLine("\nWell done. You managed to find all mines");
                    PrintGameField(bombField);
                    Console.WriteLine("Enter your name: ");
                    string name = Console.ReadLine();
                    Player player = new Player(name, turnsCount);
                    players.Add(player);
                    PrintHighscores(players);
                    gameField = CreateGameField();
                    bombField = CreateBombField();
                    turnsCount = 0;
                    winGame = false;
                    isNewGame = true;
                }
            }
            while (command != "exit");
        }

        private static void PrintHighscores(List<Player> players)
        {
            Console.WriteLine("\nPoints:");

            if (players.Count > 0)
            {
                for (int i = 0; i < players.Count; i++)
                {
                    Console.WriteLine("{0}. {1} --> {2} points",
                        i + 1, players[i].Name, players[i].Points);
                }
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("No highscores!\n");
            }
        }

        private static void Turn(char[,] gameField, char[,] bombs, int row, int column)
        {
            char numberOfAdjacentBombs = CalculateAdjacentBombs(bombs, row, column);
            bombs[row, column] = numberOfAdjacentBombs;
            gameField[row, column] = numberOfAdjacentBombs;
        }

        private static void PrintGameField(char[,] gameField)
        {
            int rows = gameField.GetLength(0);
            int columns = gameField.GetLength(1);
            Console.WriteLine("\n    0 1 2 3 4 5 6 7 8 9");
            Console.WriteLine("   ---------------------");

            for (int i = 0; i < rows; i++)
            {
                Console.Write("{0} | ", i);

                for (int j = 0; j < columns; j++)
                {
                    Console.Write(string.Format("{0} ", gameField[i, j]));
                }

                Console.Write("|");
                Console.WriteLine();
            }

            Console.WriteLine("   ---------------------\n");
        }

        private static char[,] CreateGameField()
        {
            int fieldRows = 5;
            int fieldColumns = 10;
            char[,] board = new char[fieldRows, fieldColumns];

            for (int i = 0; i < fieldRows; i++)
            {
                for (int j = 0; j < fieldColumns; j++)
                {
                    board[i, j] = '?';
                }
            }

            return board;
        }

        private static char[,] CreateBombField()
        {
            int rows = 5;
            int columns = 10;
            char[,] gameField = new char[rows, columns];

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    gameField[i, j] = '-';
                }
            }

            List<int> randomNumbers = new List<int>();

            while (randomNumbers.Count < 15)
            {
                Random random = new Random();
                int randomNumber = random.Next(50);

                if (!randomNumbers.Contains(randomNumber))
                {
                    randomNumbers.Add(randomNumber);
                }
            }

            foreach (int number in randomNumbers)
            {
                int row = (number / columns);
                int column = (number % columns);

                if (column == 0 && number != 0)
                {
                    row--;
                    column = columns;
                }
                else
                {
                    column++;
                }
                gameField[row, column - 1] = '*';
            }

            return gameField;
        }

        //private static void smetki(char[,] pole)
        //{
        //    int kol = pole.GetLength(0);
        //    int red = pole.GetLength(1);

        //    for (int i = 0; i < kol; i++)
        //    {
        //        for (int j = 0; j < red; j++)
        //        {
        //            if (pole[i, j] != '*')
        //            {
        //                char kolkoo = CalculateAdjacentBombs(pole, i, j);
        //                pole[i, j] = kolkoo;
        //            }
        //        }
        //    }
        //}

        private static char CalculateAdjacentBombs(char[,] bombsField, int row, int column)
        {
            int numberOfBombs = 0;
            int rows = bombsField.GetLength(0);
            int columns = bombsField.GetLength(1);

            if (row - 1 >= 0)
            {
                if (bombsField[row - 1, column] == '*')
                {
                    numberOfBombs++;
                }
            }

            if (row + 1 < rows)
            {
                if (bombsField[row + 1, column] == '*')
                {
                    numberOfBombs++;
                }
            }

            if (column - 1 >= 0)
            {
                if (bombsField[row, column - 1] == '*')
                {
                    numberOfBombs++;
                }
            }

            if (column + 1 < columns)
            {
                if (bombsField[row, column + 1] == '*')
                {
                    numberOfBombs++;
                }
            }

            if ((row - 1 >= 0) && (column - 1 >= 0))
            {
                if (bombsField[row - 1, column - 1] == '*')
                {
                    numberOfBombs++;
                }
            }

            if ((row - 1 >= 0) && (column + 1 < columns))
            {
                if (bombsField[row - 1, column + 1] == '*')
                {
                    numberOfBombs++;
                }
            }

            if ((row + 1 < rows) && (column - 1 >= 0))
            {
                if (bombsField[row + 1, column - 1] == '*')
                {
                    numberOfBombs++;
                }
            }

            if ((row + 1 < rows) && (column + 1 < columns))
            {
                if (bombsField[row + 1, column + 1] == '*')
                {
                    numberOfBombs++;
                }
            }
            return char.Parse(numberOfBombs.ToString());
        }
    }
}
