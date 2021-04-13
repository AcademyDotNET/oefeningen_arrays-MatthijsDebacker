using System;

namespace CaesarEncryptie
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please give a sentence to encrypt and decrypt.");
            string text = Console.ReadLine();

            int key = AskForInt("Please give an encryption key: ");

            // Slightly redudndant check to make sure the key is not too large
            if(key > 26)
            {
                key -= (26 * (int)Math.Floor(key / 26.0));
            }

            char[] arr;

            Console.WriteLine("Encrypted: ");
            arr = Encrypt(text.ToCharArray(), key); 
            foreach (var c in arr)
            {
                Console.Write(c);
            }
            Console.WriteLine();

            Console.WriteLine("Decrypted: ");
            arr = Decrypt(arr, key);
            foreach (var c in arr)
            {
                Console.Write(c);
            }
        }

        static char[] Encrypt(char[] arr, int integer = 3)
        {
            char[] solution = new char[arr.Length];
            for (int i = 0; i < arr.Length; i++)
            {
                if(arr[i] != ' ')
                {
                    int c = arr[i];
                    c += integer;
                    if ((arr[i] < 'a' && c > 'Z') || (arr[i] > 'Z' && c > 'z'))
                    {
                        c -= 26;
                    }
                    else if ((arr[i] < 'a' && c < 'A') || (arr[i] > 'Z'&& c < 'a'))
                    {
                        c += 26;
                    }
                    solution[i] = Convert.ToChar(c);
                }
                else
                {
                    solution[i] = arr[i];
                }

            }

            return solution;
        }

        static char[] Decrypt(char[] arr, int integer = 3)
        {
            return Encrypt(arr, -integer);
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
