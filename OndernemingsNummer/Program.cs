using System;

namespace OndernemingsNummer
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Geef een ondernemingsnummer in: ");
            string nummer = Console.ReadLine();

            if(CheckOndernemingsnummer(nummer))
            {
                Console.WriteLine("Geldig ondernemingsnummer.");
            }
            else
            {
                Console.WriteLine("Ongeldig ondernemingsnummer.");
            }
        }

        static bool CheckOndernemingsnummer(string number)
        {
            string prefix = number.Substring(0, 4);
            int affix = Convert.ToInt32(number.Substring(4, 7));
            int affixTwo = Convert.ToInt32(number.Substring(11));
            Math.DivRem(affix, 97, out int rem);

            if (prefix == "BE 0" && (97 - rem) ==  affixTwo)
            {
                return true;
            }

            return false;
        }
    }
}
