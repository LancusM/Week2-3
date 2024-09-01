using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week2_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //user gives input, and code changes to lowercase for code ease
            Console.WriteLine("Enter a string: ");
            string phrase = Console.ReadLine().ToLower();
            //finds length of user input and initializes it and vowels integer
            int length = phrase.Length;
            int vowels = 0;
            //for statement, starts at character 0 and moves until the input runs out of characters
            for (int i = 0; i < length; i++)
            {
                //checks phrase for any vowels, adds 1 for every instance. Found how to do this in w3schools C# excercises!
                if (phrase[i] == 'a' || phrase[i] == 'e' || phrase[i] == 'i' || phrase[i] == 'o' || phrase[i] == 'u')
                {
                    vowels++;
                }
            }
            //outputs answer
            Console.WriteLine("The number of vowels in this string is: " + vowels);
            Console.Read();
        }
    }
}
