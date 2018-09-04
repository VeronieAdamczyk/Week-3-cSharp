using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ifStatements
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter your test score");

            int testScore = Convert.ToInt32(Console.ReadLine());

            if (testScore >= 80)
            { Console.WriteLine("Great score- Distinction"); }

            else if ((testScore >= 70) && (testScore <= 79))
            {
                Console.WriteLine("Good Job - Merit");
            }

            else if ((testScore >=46) && (testScore<=69))
            {
                Console.WriteLine("You passed this test");
            }
            else 
                    {
                Console.WriteLine("Sorry, you did not pass this time");
            }

            Console.ReadKey();
        }
    }
}
