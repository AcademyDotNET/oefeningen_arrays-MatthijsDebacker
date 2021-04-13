using System;

namespace ProPasswordGenerator
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = AskForString("Please give your last name: ");
            string phoneNumnber = AskForString("Please give your phone number (with spaces): ");
            string postCode = AskForString("Please give your postal code: ");

            var nameA = name.ToCharArray();
            var phoneA = phoneNumnber.ToCharArray();
            var postCodeA = postCode.ToCharArray();

            string password = "";

            password = $"{nameA.ToString().ToUpper()}{nameA[1]}{nameA[1]}{nameA.ToString().ToUpper()}";
            //password += nameA[0].ToString().ToUpper();
            //password += nameA[1];
            //password += nameA[1];
            //password += nameA[0].ToString().ToUpper();

            int index = 1;

            while(phoneA[index] != ' ' && index < phoneA.Length)
            {
                password += phoneA[index];
                index++;
            }

            // A little convoluted but it works
            password += Convert.ToString(
                (int)Math.Pow(
                    Convert.ToInt32(postCodeA[0].ToString()),
                    2));

            Console.WriteLine($"Your new password is: {password}");
        }

        static string AskForString(string question)
        {
            Console.WriteLine(question);
            return Console.ReadLine();
        }
    }
}
