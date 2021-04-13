using System;

namespace RobotSimulator
{
    class Program
    {
        enum Direction
        {
            North,
            East,
            South,
            West
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a sequence to execute: ");
            string input = Console.ReadLine();

            if (input.Length != 0)
            {
                var arr = CorrectInput(input);
                if (arr.Length != 0)
                {
                    ExecuteSequence(arr);
                    Console.ReadLine();
                }
                else
                {
                    Console.WriteLine("Invalid sequence.");
                }
            }
            else
            {
                Console.WriteLine("Invalid input.");
            }
            
        }

        static void ExecuteSequence(char[] sequence, Direction start = Direction.South, int xStart = 0, int yStart = 0, int offsetX = 50, int offsetY = 5)
        {
            int x = xStart + offsetX;
            int y = yStart + offsetY;
            Direction dir = start;
            foreach (var c in sequence)
            {
                switch (c)
                {
                    case 'A':
                        switch (dir)
                        {
                            case Direction.North:
                                y--;
                                break;
                            case Direction.East:
                                x++;
                                break;
                            case Direction.South:
                                y++;
                                break;
                            case Direction.West:
                                x--;
                                break;
                            default:
                                break;
                        }

                        x = Math.Clamp(x, 0, Console.BufferWidth);
                        y = Math.Clamp(y, 0, Console.BufferHeight);
                        Console.SetCursorPosition(x, y);
                        Console.Write("*");
                        System.Threading.Thread.Sleep(20);
                        break;
                    case 'R':
                        dir++;
                        if (dir > Direction.West)
                        {
                            dir = Direction.North;
                        }
                        break;
                    case 'L':
                        dir--;
                        if (dir < Direction.North)
                        {
                            dir = Direction.West;
                        }
                        break;
                    default:
                        break;
                }
            }
        }

        static char[] CorrectInput(string input)
        {
            string correct = "";
            foreach (var c in input)
            {
                switch (c)
                {
                    case 'a':
                    case 'A':
                        correct += 'A';
                        break;
                    case 'r':
                    case 'R':
                        correct += 'R';
                        break;
                    case 'l':
                    case 'L':
                        correct += 'L';
                        break;
                    default:
                        break;
                }
            }
            return correct.ToCharArray();
        }
    }
}
