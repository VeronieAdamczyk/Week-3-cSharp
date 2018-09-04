using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inputProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter an Int Number");

            int response = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(response);

            Console.WriteLine("Please enter a single character");

            char response1 = Convert.ToChar(Console.ReadLine());

            Console.WriteLine(response1);

            Console.WriteLine("Please enter your favourite colour in CAPITALS");
            String response2 = (Console.ReadLine()).ToLower();

            Console.WriteLine(response2);

            Console.ReadKey();

        }
    }
}
