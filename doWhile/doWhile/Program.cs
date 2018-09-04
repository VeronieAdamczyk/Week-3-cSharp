using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace doWhile
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter a random number");
            int yourNumber = Convert.ToInt32(Console.ReadLine());
            Random numberToGuess = new Random();
            int numGuesses = 0;
            int number = numberToGuess.Next(1, 10);
            do
            {
                Console.WriteLine("guess a number between 1 and 10:");
                yourNumber = Convert.ToInt32(Console.ReadLine());
                numGuesses++;
            } while (yourNumber != number);
            Console.WriteLine("you guessed right!");
            Console.WriteLine("it took you " + numGuesses + " tries to guess");
            Console.ReadKey();
        }
    }
}
