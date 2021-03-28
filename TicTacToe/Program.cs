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


            //Player X Win Conditions
            //row 0 win condition
            if (gameBoard[0, 0] == 'X' && gameBoard[0, 1] == 'X' && gameBoard[0, 2] == 'X')
            {
                return true;
            }
            //row 1 win condition
            if (gameBoard[1, 0] == 'X' && gameBoard[1, 1] == 'X' && gameBoard[1, 2] == 'X')
            {

                return true;
                //row 2 win condition
            }
            if (gameBoard[2, 0] == 'X' && gameBoard[2, 1] == 'X' && gameBoard[2, 2] == 'X')
            {
                return true;
            }

            //col 0 win condition 
            if (gameBoard[0, 0] == 'X' && gameBoard[1, 0] == 'X' && gameBoard[2, 0] == 'X')
            {
                return true;
            }
            //Col 1 win condition
            if (gameBoard[0, 1] == 'X' && gameBoard[1, 1] == 'X' && gameBoard[2, 1] == 'X')
            {
                return true;

                //Col 2 win condition
            }
            if (gameBoard[0, 2] == 'X' && gameBoard[1, 2] == 'X' && gameBoard[2, 2] == 'X')
            {
                return true;
            }

            //Diagonal Win Coinditions 
            if (gameBoard[0, 0] == 'X' && gameBoard[1, 1] == 'X' && gameBoard[2, 2] == 'X')
            {
                return true;
            }
            if (gameBoard[0, 2] == 'X' && gameBoard[1, 1] == 'X' && gameBoard[2, 0] == 'X')
            {
                return true;
            }


            //Player O Win Conditions 

            //row 0 win condition
            if (gameBoard[0, 0] == 'O' && gameBoard[0, 1] == 'O' && gameBoard[0, 2] == 'O')
            {
                return true;
            }
            //row 1 win condition
            if (gameBoard[1, 0] == 'O' && gameBoard[1, 1] == 'O' && gameBoard[1, 2] == 'O')
            {
                return true;

            } //row 2 win condition
            if (gameBoard[2, 0] == 'O' && gameBoard[2, 1] == 'O' && gameBoard[2, 2] == 'O')
            {
                return true;
            }
            // col 0 win condition
            if (gameBoard[0, 0] == 'O' && gameBoard[1, 0] == 'O' && gameBoard[2, 0] == 'O')
            {
                return true;
            }
            //Col 1 win condition
            if (gameBoard[0, 1] == 'O' && gameBoard[1, 1] == 'O' && gameBoard[2, 1] == 'O')
            {
                return true;

            } //Col 2 win condition
            if (gameBoard[0, 2] == 'O' && gameBoard[1, 2] == 'O' && gameBoard[2, 2] == 'O')
            {
                return true;
            }

            //Diagonal Win Coinditions 
            if (gameBoard[0, 0] == 'O' && gameBoard[1, 1] == 'O' && gameBoard[2, 2] == 'O')
            {
                return true;
            }
            if (gameBoard[0, 2] == 'O' && gameBoard[1, 1] == 'O' && gameBoard[2, 0] == 'O')
            {
                return true;
            }
            return false;
        }


        static void GameBoard()
        {

            bool isLegal = false;
            //initialize board game
            char[,] gameBoard = new char[,] { { '-', '-', '-' }, { '-', '-', '-' }, { '-', '-', '-' } };


            for (int i = 0; i < 9; i++)
            {
                isLegal = false;
                while (!isLegal)
                {
                    Console.Write("Player one, please choose a row: ");
                    int row = int.Parse(Console.ReadLine());
                    Console.WriteLine("Enter a Col: ");
                    int col = int.Parse(Console.ReadLine());
                    if (gameBoard[row, col] != '-')
                    {
                        isLegal = false;
                        continue;
                    }
                    else
                    {
                        gameBoard[row, col] = 'X';
                        isLegal = true;
                        BoardProgression(gameBoard);
                        if (Winner(gameBoard))
                        {
                            Console.WriteLine("Player One is the Winner!");
                            break;
                        }
                    }

                }
               
                    isLegal = false;
                    while (!isLegal && !Winner(gameBoard))
                    {
                        Console.Write("Player two, please choose a row: ");
                        int row = int.Parse(Console.ReadLine());
                        Console.WriteLine("Enter a Col: ");
                        int col = int.Parse(Console.ReadLine());
                        if (gameBoard[row, col] != '-')
                        {
                            isLegal = false;
                            continue;
                        }
                        else
                        {
                            gameBoard[row, col] = 'O';
                            isLegal = true;
                            BoardProgression(gameBoard);
                            if (Winner(gameBoard))
                            {
                                Console.WriteLine("Player Two is the Winner!");
                            }

                        }

                    }
                

                if (Winner(gameBoard))
                {
                    break;
                }
            }
            Console.WriteLine("There are no more open spaces on the board, The game ends in a draw.");
        }
    }
}








