using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForEachLoops
{
    class Program
    {
        static void Main(string[] args)
        {

            //int[] arrayOfNumbers = { 5, 4, 5, 4, 5, 6, 7 };
            //foreach(int i in arrayOfNumbers)
            //{
            //    Console.WriteLine("The value of i is:" + i);
            //}

            //int j;
            //for(j =0; j<7; j++)
            //{
            //    Console.WriteLine("The value of i is:" + arrayOfNumbers[j]);
            //}



            string[] sevenDwaves = { "Happy", "Sleepy", "Doc", "Bashfull", "Dopy", "Grumpy", "Sneezy" };

            //int l;
            //for (l = 0; l < 7; l++) 
            //{
            //    Console.WriteLine(sevenDwaves[l] + " Your Dinner is ready!");
            //}
            

            foreach (string i in sevenDwaves)
            {
                Console.WriteLine(i + " what would you like for dinner?");
                string food = (Console.ReadLine());
                Console.WriteLine(i + "! Your " + food + " is ready");
            }


            foreach (string i in sevenDwaves)
            {
                Console.WriteLine(i + " what would you like to drink?");


                string drink = (Console.ReadLine());
                Console.WriteLine(i + "! Your " + drink + " is ready");
            }

            Console.ReadKey();
        }
    }
}
