using System;
using System.Collections.Generic;
using System.Text;

namespace practiceC_
{
    internal class tic_tac_toe
    {
        static char[,] gameboard =
    {
        { '1', '2', '3' },
        { '4', '5', '6' },
        { '7', '8', '9' }
    };

        static void DisplayBoard(char[,] gameboard)
        {
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write(gameboard[i, j] + " | ");
                }

                Console.WriteLine("\n-----------");
            }
        }

        static bool Win(char[,] gameboard, char player)
        {
            for (int i = 0; i < 3; i++)
            {
                if (gameboard[i, 0] == player &&
                    gameboard[i, 1] == player &&
                    gameboard[i, 2] == player)
                {
                    return true;
                }
                else if (gameboard[0, i] == player &&
                         gameboard[1, i] == player &&
                         gameboard[2, i] == player)
                {
                    return true;
                }
            }

            if (gameboard[0, 0] == player &&
                gameboard[1, 1] == player &&
                gameboard[2, 2] == player)
            {
                return true;
            }
            else if (gameboard[0, 2] == player &&
                     gameboard[1, 1] == player &&
                     gameboard[2, 0] == player)
            {
                return true;
            }

            return false;
        }

        static bool Draw(char[,] gameboard, char player)
        {
            int flag = 0;

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (gameboard[i, j] != 'x' &&
                        gameboard[i, j] != 'o')
                    {
                        flag++;
                    }
                }
            }

            if (flag == 1)
            {
                return true;
            }

            return false;
        }

        static void Main()
        {
            char player = 'x';
            char choice = '0';
            bool iteration = true;

            Console.WriteLine("\n===========================");
            Console.WriteLine("WELCOME TO TIC TAK TOE GAME");
            Console.WriteLine("===========================\n");

            DisplayBoard(gameboard);

            while (iteration)
            {
                Console.Write("Player " + player + " turn... Enter your choice: ");
                choice = Convert.ToChar(Console.ReadLine());

                int choiceInt = choice - '0';

                if (choiceInt <= 9)
                {
                    for (int i = 0; i < 3; i++)
                    {
                        for (int j = 0; j < 3; j++)
                        {
                            if (gameboard[i, j] == choice)
                            {
                                gameboard[i, j] = player;

                                if (Win(gameboard, player))
                                {
                                    Console.WriteLine("\n\nPLAYER " + player + " WINS!");
                                    iteration = false;
                                }

                                if (Draw(gameboard, player))
                                {
                                    Console.WriteLine("\n\nMATCH DRAW!");
                                    iteration = false;
                                }

                                DisplayBoard(gameboard);

                                if (player == 'x')
                                {
                                    player = 'o';
                                }
                                else
                                {
                                    player = 'x';
                                }
                            }
                        }
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input... try again");
                }
            }
        }
    }
}
