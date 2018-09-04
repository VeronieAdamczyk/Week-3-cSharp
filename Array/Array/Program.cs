using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] userInput = {0,0,0,0,0};

            foreach (int i= 0; i<userInput.Length; i ++)
            {
                Console.WriteLine("please enter 5 numbers");
                int number1 = Convert.ToInt32(Console.ReadLine());
                int number2 = Convert.ToInt32(Console.ReadLine());
                int number3 = Convert.ToInt32(Console.ReadLine());
                int number4 = Convert.ToInt32(Console.ReadLine());
                int number5 = Convert.ToInt32(Console.ReadLine());

                int total = number1 + number2 + number3 + number4 + number5;
                int average = total / 5;
                Console.WriteLine("The average of your entered numbers is " + average);

                Console.ReadKey();
            }
        }
    }
}
