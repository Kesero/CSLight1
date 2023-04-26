using System;
using System.Collections.Generic;
using System.Web;

namespace CSHomeWork1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const ConsoleKey KeyUpArrow = ConsoleKey.UpArrow;
            const ConsoleKey KeyDownArrow = ConsoleKey.DownArrow;
            const ConsoleKey KeyLeftArrow = ConsoleKey.LeftArrow;
            const ConsoleKey KeyRightArrow = ConsoleKey.RightArrow;

            Console.CursorVisible = false;
            char[,] playMap = {
            { '#','#','#','#','#','#','#','#','#','#','#','#' },
            { '#',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ','#' },
            { '#',' ','#',' ','#',' ',' ','#','#','#',' ','#' },
            { '#',' ','#',' ','#',' ',' ',' ',' ',' ',' ','#' },
            { '#',' ','#',' ','#',' ',' ','#','#','#',' ','#' },
            { '#',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ','#' },
            { '#','#','#','#','#','#','#','#','#','#','#','#' }};
            int playerPositionX = 1;
            int playerPositionY = 1;
            int playerDirectionX = 0;
            int playerDirectionY = 0;
            char playerSymbol = '@';
            bool isPlayerAlive = true;

            while (isPlayerAlive)
            {
                Console.Clear();
                PrintPlayMap(playMap);
                PrintPlayer(playerSymbol, playerPositionX, playerPositionY);
                ConsoleKeyInfo key = Console.ReadKey();

                switch (key.Key)
                {
                    case KeyUpArrow:
                        playerDirectionX = 0; playerDirectionY = -1;
                        break;

                    case KeyDownArrow:
                        playerDirectionX = 0; playerDirectionY = 1;
                        break;

                    case KeyLeftArrow:
                        playerDirectionX = -1; playerDirectionY = 0;
                        break;

                    case KeyRightArrow:
                        playerDirectionX = 1; playerDirectionY = 0;
                        break;

                    default:
                        playerDirectionX = 0; playerDirectionY = 0;
                        break;

                }

                MovePlayer(playerDirectionX, playerDirectionY, playMap, playerSymbol, ref playerPositionX, ref playerPositionY);
            }
        }

        public static void PrintPlayMap(char[,] playMap)
        {
            for (int i = 0; i < playMap.GetLength(0); i++)
            {
                for (int j = 0; j < playMap.GetLength(1); j++)
                {
                    Console.Write(playMap[i, j]);
                }

                Console.WriteLine();
            }
        }

        public static void PrintPlayer(char playerSymbol, int playerPositionX, int playerPositionY)
        {
            Console.SetCursorPosition(playerPositionX, playerPositionY);
            Console.Write(playerSymbol);
            Console.SetCursorPosition(0, 0);
        }

        public static void MovePlayer(int positionDirectionX, int positionDirectionY, char[,] playMap, char playerSymbol, ref int playerPositionX, ref int playerPositionY)
        {
            char wallSymbol = '#';
            char voidSymbol = ' ';

            if (playMap[playerPositionY + positionDirectionY, playerPositionX + positionDirectionX] != wallSymbol)
            {
                playMap[playerPositionY, playerPositionX] = voidSymbol;
                playerPositionX += positionDirectionX;
                playerPositionY += positionDirectionY;
                playMap[playerPositionY, playerPositionX] = playerSymbol;
            }
        }
    }
}