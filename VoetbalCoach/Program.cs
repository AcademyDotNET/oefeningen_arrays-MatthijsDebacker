using System;

namespace VoetbalCoach
{
    class Program
    {
        static void Main(string[] args)
        {
            int playerI = 0;
            string playerAction = "";
            int playerActions = 0;
            
            int[,] players = new int[12,2];
            Random rand = new Random();
            for (int i = 0; i <= players.GetUpperBound(0); i++)
            {
                for (int j = 0; j <= players.GetUpperBound(1); j++)
                {
                    players[i, j] = rand.Next(0, 11);
                }
            }

            while (playerI != 99)
            {
                playerI = AskForInt("Which player do you wish to comment on?");
                if(playerI != 99)
                {
                    Console.WriteLine("Did this player perform a good action (a) or a bad action (b)?");
                    playerAction = Console.ReadLine();
                    playerActions = AskForInt("How many did they perform?");

                    if (playerAction == "a")
                    {
                        players[playerI, 0] = playerActions;
                    }
                    else if (playerAction == "b")
                    {
                        players[playerI, 1] = playerActions;
                    }
                    else
                    {
                        Console.WriteLine("Invalid action type.");
                    }
                }
            }

            PrintTable(players);
        }

        static void PrintTable(int[,] arr)
        {
            int difference = 0;
            int best = int.MinValue, worst = int.MaxValue, average = int.MaxValue;

            int[] bestPlayers = new int[arr.GetUpperBound(0) + 1];
            int[] worstPlayers = new int[arr.GetUpperBound(0) + 1];
            int[] averagePlayers = new int[arr.GetUpperBound(0) + 1];

            Console.WriteLine("Player\tGood\tBad\tDifference");

            for (int i = 0; i <= arr.GetUpperBound(0); i++)
            {
                difference = arr[i, 0] - arr[i, 1];
                
                if(difference > best)
                {
                    best = difference;
                }

                if (difference < worst)
                {
                    worst = difference;
                }

                if(Math.Abs(difference) < Math.Abs(average))
                {
                    average = difference;
                }

                Console.WriteLine($"{i + 1}\t{arr[i, 0]}\t{arr[i, 1]}\t{difference}");
            }

            for (int i = 0; i < arr.GetUpperBound(0) + 1; i++)
            {
                difference = arr[i, 0] - arr[i, 1];

                if (difference == best)
                {
                    bestPlayers[i] = 1;
                }

                if (difference == worst)
                {
                    worstPlayers[i] = 1;
                }

                if (Math.Abs(difference) == Math.Abs(average))
                {
                    averagePlayers[i] = 1;
                }
            }

            Console.WriteLine();
            Console.Write($"Best players: ");
            PrintIndexWithVal(bestPlayers);
            Console.Write($"Worst players: ");
            PrintIndexWithVal(worstPlayers);
            Console.Write($"Most average players: ");
            PrintIndexWithVal(averagePlayers);
        }

        static void PrintIndexWithVal(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if(arr[i] != 0)
                {
                    Console.Write($"{i + 1} ");
                }
            }
            Console.WriteLine();
        }

        static int AskForInt(string question, string errorResponse = "Invalid number, please try again", bool clear = false)
        {
            Console.WriteLine(question);
            int input = 0;

            string sInput = Console.ReadLine();
            while (!int.TryParse(sInput, out input))
            {
                if (clear)
                {
                    Console.Clear();
                }
                Console.WriteLine(errorResponse);
                sInput = Console.ReadLine();
            }

            return input;
        }
    }
}
