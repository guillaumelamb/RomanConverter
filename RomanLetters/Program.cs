using System;

namespace RomanLetters
{
    public class Program
    {
        static void Main(string[] args)
        {
            bool doContinue = true;

            while (doContinue)
            {
                Console.WriteLine("Insert value betwheen 1 and 3999: (q for exit)");
                string userInput = Console.ReadLine();

                if (userInput == "q")
                {
                    doContinue = false;
                }
                else if (int.TryParse(userInput, out int value))
                {
                    Console.WriteLine(RomanConverter.ToRoman(value));
                }
                else
                {
                    Console.WriteLine("This is not an integer type");
                }
            }
        }
    }
}
