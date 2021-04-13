using System;

namespace Bob
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] answers = new string[5] { "Sure", "Whoa, chill out!", "Calm down, I know what I'm doing", "Fine, be that way", "whatever" };
            string response = "";

            do
            {
                Console.WriteLine("Say somethign to Bob.");
                response = Console.ReadLine();

                if (response.Contains("?") && response.Contains("!"))
                {
                    Console.WriteLine(answers[2]);
                }
                else if (response.Contains("!"))
                {
                    Console.WriteLine(answers[1]);
                }
                else if (response.Contains("?"))
                {
                    Console.WriteLine(answers[0]);
                }
                else if(response == "")
                {
                    Console.WriteLine(answers[3]);
                }
                else
                {
                    Console.WriteLine(answers[4]);
                }
            } while (true);
        }
    }
}
