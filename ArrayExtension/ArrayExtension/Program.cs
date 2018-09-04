using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayExtension
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] userInput = new int [5];
         
            for (int i =0; i <userInput.length; i++)
            {
                Console.WriteLine("please enter 25 numbers");
                int number1 = Convert.ToInt32(Console.ReadLine());
                int number2 = Convert.ToInt32(Console.ReadLine());
                int number3 = Convert.ToInt32(Console.ReadLine());
                int number4 = Convert.ToInt32(Console.ReadLine());
                int number5 = Convert.ToInt32(Console.ReadLine());

                int total = number1 + number2 + number3 + number4 + number5;
                
            foreach (int j in userInput)
                {
                    int number6 = Convert.ToInt32(Console.ReadLine());
                    int number7 = Convert.ToInt32(Console.ReadLine());
                    int number8 = Convert.ToInt32(Console.ReadLine());
                    int number9 = Convert.ToInt32(Console.ReadLine());
                    int number10 = Convert.ToInt32(Console.ReadLine());

                    int total2 = number6 + number7 + number8 + number9 + number10;
                }

                Console.ReadKey();
            }
        }
    }
}
