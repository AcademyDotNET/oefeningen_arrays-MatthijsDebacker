using System;

namespace Galgje
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Player one, please enter a single word: ");
            string target = Console.ReadLine().ToLower();
            string currentWord = new string('_', target.Length);
            char[] currentWordA = currentWord.ToCharArray();

            int stage = 0;

            while (stage < 10 && target != currentWord)
            {
                Console.Clear();
                Console.WriteLine(currentWord);
                Console.WriteLine("Player two, guess a letter: ");
                Console.WriteLine();
                PrintGallows(stage);
                Console.WriteLine();

                string guess = Console.ReadLine().ToLower();

                bool correctGuess = false;
                if(guess.Length == 1)
                {
                    char g = Convert.ToChar(guess);
                    for (int i = 0; i < target.Length; i++)
                    {
                        if(target[i] == g)
                        {
                            correctGuess = true;
                            currentWordA[i] = g;
                        }
                    }
                    currentWord = string.Join("", currentWordA);
                }
                else if(target == guess)
                {
                    currentWord = guess;
                }

                if(!correctGuess)
                {
                    stage++;
                }
            }

            if(stage < 10 && target == currentWord)
            {
                Console.WriteLine($"You won!");
            }
            else
            {
                Console.Write($"You lose! The word was: {target}.");
            }

        }

        

        static void PrintGallows(int stage)
        {
            switch (stage)
            {
                case 0:
                    Console.WriteLine();
                    break;
                case 1:
                    Console.WriteLine(@"
     _________
     |
     |
     |
     |
     |
     |
  ___|___________");
                    break;
                case 2:
                    Console.WriteLine(@"
     _________
     |/ 
     |  
     |  
     |  
     |  
     |
  ___|___________");
                    break;
                case 3:
                    Console.WriteLine(@"
     _________
     |/      |
     |     
     |     
     |     
     |     
     |
  ___|___________");
                    break;
                case 4:
                    Console.WriteLine(@"
     _________
     |/      |
     |      (_)
     |    
     |    
     |    
     |
  ___|___________");
                    break;
                case 5:
                    Console.WriteLine(@"
     _________
     |/      |
     |      (_)
     |       |
     |     
     |     
     |
  ___|___________");
                    break;
                case 6:
                    Console.WriteLine(@"
     _________
     |/      |
     |      (_)
     |       |
     |       |
     |       
     |
  ___|___________");
                    break;
                case 7:
                    Console.WriteLine(@"
     _________
     |/      |
     |      (_)
     |       |
     |       |
     |      / 
     |
  ___|___________");
                    break;
                case 8:
                    Console.WriteLine(@"
     _________
     |/      |
     |      (_)
     |       |
     |       |
     |      / \
     |
  ___|___________");
                    break;
                case 9:
                    Console.WriteLine(@"
     _________
     |/      |
     |      (_)
     |      \|
     |       |
     |      / \
     |
  ___|___________");
                    break;
                case 10:
                    Console.WriteLine(@"
     _________
     |/      |
     |      (_)
     |      \|/
     |       |
     |      / \
     |
  ___|___________");
                    break;
                default:
                    break;
            }
        }
    }
}
