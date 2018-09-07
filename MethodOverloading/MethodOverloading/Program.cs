using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodOverloading
{
    class Program
    {
        class PrintData
        {
            public void print (int i)
            {
                Console.WriteLine("printing int: {0}", i);
            }
            public void print(double f)
            {
                Console.WriteLine("printing float: {0}", f);
            }

            public void print(string s)
            {
                Console.WriteLine("printing string: {0}", s);
            }
        }

        static void Main(string[] args)
        {
            PrintData p = new PrintData();
            int x = Convert.ToInt32(Console.ReadLine());
            double y = Convert.ToDouble(Console.ReadLine());
            string z = Console.ReadLine();

            p.print(x);
            p.print("");
            p.print(4.76875);

            Console.ReadKey();


        }
    }
}
