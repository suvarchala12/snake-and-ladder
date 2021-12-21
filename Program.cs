// See https://aka.ms/new-console-template for more information
using System;
namespace SnakeAndLadder
{
    class program
    {
        public static int curpostion = 0;
        static Boolean playerTurn = true;
        public static int dieRollPlay(int position, string Player)
        {
            const int NO_PLAY = 0;
            const int LADDER = 1;
            const int SNAKE = 2;
            Random rand = new Random();
            int diceNumber = rand.Next(1, 7);
            int PlayOption = rand.Next(0, 3);
            switch (playOption)
            {
                case NO_PLAY:
                    break;
                LADDER:
                    position = position + diceNumber;
                    if (position != 100)
                    {
                        dieRollPlay(position, Player);
                    }
                    break;
                case SNAKE:
                    position = position - diceNumber;
                    if (position < 100)
                    {
                        position = 0;
                    }
                    break;

            }
            Console.WriteLine("Position of Player{0}:{1]", Player, position);
            return position;
        }
        static void Main(String[] args)
        {
            Console.WriteLine("____Snake &Lader Game____");
            int PositionPlayer1 = 0;
            int PositionPlayer2 = 0;
            int diceRollCount = 0;
            while (PositionPlayer1 < 100 && PositionPlayer2 < 100)
            {
                diceRollCount++;
                if (PlayerTurn)
                {
                    PositionPlayer1 = dieRollPlay(PositionPlayer1, "Player1");
                }
                else
                {
                    PositionPlayer2 = dieRollPlay(PositionPlayer2, "Player2");
                }
                playerTurn = !playerTurn;
            }
            if (PositionPlayer1==100)
            {
                Console.WriteLine("player1 Wins!");
                Console.WriteLine("Total Number of the dice rolled for player 1 is: " + diceRollCount);
            }
            else
            {
                Console.WriteLine("player2 Wins!");
                Console.WriteLine("Total Number of the dice rolled for player 2 is: " + diceRollCount);


            }



        }

        }
    }
