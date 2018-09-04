using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace switchStatements
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Please enter your test score");

            int testScore = Convert.ToInt32(Console.ReadLine());

            switch (testScore)
            {
   
        case 80:
                    Console.WriteLine("Distinction");
                    break;
        case 70:
                    Console.WriteLine("Merit");
                    break;
        case 60:
                    Console.WriteLine("Pass");
                    break;
       case 45:
                    Console.WriteLine("Fail");
                    break;
       default:
                    Console.WriteLine("Your garde can not be processed");
                    break;
           }

            Console.ReadKey();

        }
    }
}
