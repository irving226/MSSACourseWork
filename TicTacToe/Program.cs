using System;

namespace TicTacToe
{
    class Program
    {
        static void Main(string[] args)
        {
            GameBoard();

        }

        static void BoardProgression(char[,] gameBoard)
        {
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write(gameBoard[i, j] + "");
                }
                //creates a new line after each row
                Console.WriteLine();
            }
        }

        //thinking of another method that will check if there is a win condition present
        static bool Winner(char[,] gameBoard)
        {
            int count = 0;
            char focus;
            for (int i = 0; i < 3; i++)
            {

                for (int j = 0; j < 3; j++)
                {
                    if (gameBoard[i, j] != '-')
                    {
                        count++;
                        focus = gameBoard[i, j];

                        if (gameBoard[++i, j] == focus)
                        {
                            count++;
                            if (gameBoard[++i, j] == focus)
                            {
                                return true;
                            }
                        }
                        else if (gameBoard[i, ++j] == focus)
                        {
                            count++;
                            if (gameBoard[i, ++j] == focus)
                            {
                                return true;
                            }
                        }
                    }
                }


            }
            return false;

        }

        static bool IsBoardFull(char[,] gameBoard)
        {
            for(int i = 0; i < 3; i++)
            {
                for(int j = 0; j < 3; j++)
                {
                    if (gameBoard[i, j] == '-')
                    {
                        return false;
                    }
                }
            }
            return true;
        }
        static void GameBoard()
        {
            bool correctVals = false;
            bool boardIsFull = false;
            //initialize board game
            char[,] gameBoard = new char[,] { { '-', '-', '-' }, { '-', '-', '-' }, { '-', '-', '-' } };

            BoardProgression(gameBoard);
            //game logic will loop as long as the board is not full 
            while (boardIsFull != true)
            {
                //this will loop so long as the board is not full
                correctVals = false;
                while (correctVals != true)
                {
                    Console.WriteLine("Player 1, please choose a space");
                    Console.WriteLine("col:");
                    try
                    {
                        int col = int.Parse(Console.ReadLine());
                        try
                        {
                            Console.WriteLine("row:");
                            int row = int.Parse(Console.ReadLine());
                            if (gameBoard[row, col] != '-')
                            {
                                Console.WriteLine("That space has already been chosen, please try again.");
                                continue;
                            }
                            else
                            {
                                gameBoard[row, col] = 'X';
                                BoardProgression(gameBoard);
                                correctVals = true;
                                if (Winner(gameBoard))
                                {
                                    boardIsFull = true;
                                    break;
                                }
                            }
                        }
                        catch (FormatException e)
                        {

                        }
                    }
                    catch (FormatException e)
                    {

                    }
                }

                //check to see if board is full before allowing other player to go
                if (IsBoardFull(gameBoard))
                {
                    Console.WriteLine("There are no empty spots on the board! The game ends in a draw.");
                    boardIsFull = true;
                };

                correctVals = false;
                while (correctVals != true && boardIsFull != true)
                {
                    Console.WriteLine("Player 2, please choose a space");
                    Console.WriteLine("col:");

                    try
                    {
                        int col = int.Parse(Console.ReadLine());
                        try
                        {
                            Console.WriteLine("row:");
                            int row = int.Parse(Console.ReadLine());

                            if (gameBoard[row, col] != '-')
                            {
                                Console.WriteLine("That space has already been chosen, please try again.");
                                continue;
                            }
                            else
                            {
                                gameBoard[row, col] = 'O';
                                BoardProgression(gameBoard);
                                correctVals = true;
                                if (Winner(gameBoard))
                                {
                                    boardIsFull = true;

                                }
                            }
                        }
                        catch (FormatException e)
                        {

                        }
                    }
                    catch (FormatException e)
                    {

                    }
                }//end of p2 while loop

                //check if board is full
                if (IsBoardFull(gameBoard)){
                    Console.WriteLine("There are no empty spots on the board! The game ends in a draw.");
                    boardIsFull = true;
                };
            }//end of game logic while loop
        }
    }
}
