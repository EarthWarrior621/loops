using System;

namespace loops
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Why do you want to make games?");
            string response = Console.ReadLine();
            Console.WriteLine($"The sentence, \"{response}\" has {CountNumberOfSpaces(response)} spaces in it.");

            Console.WriteLine("Please enter a whole");
            string response2 = Console.ReadLine();
            Console.WriteLine($"The sum of the individual digits of {response2} is {SumOfDigits(response2)}!");
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sentence">The sentence to count number of spaces</param>
        /// <returns>Number of spaces in the sentence</returns>
        static int CountNumberOfSpaces(string sentence)
        {
            int numberOfSpaces = 0;
            foreach (char character in sentence)
            {
                if (character == ' ')
                {
                    numberOfSpaces++;
                }
            }
            return numberOfSpaces;
        }

        static int SumOfDigits(string number)
        {
            int sum = 0;
            foreach (char digit in number)
            {
                sum += (int)Char.GetNumericValue(digit);
            }
            return sum;
        }   

     }
}
