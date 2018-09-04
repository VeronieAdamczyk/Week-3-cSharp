using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculator
{
    class Program
    {
        static void Main(string[] args)

        {

            int result = AddNumbers(0,0);
            Console.WriteLine("your result is " + result);
            
            int result2 = MinusNumbers(0, 0);
            Console.WriteLine("your result is " + result2);

            int result3 = MultNumbers(0, 0);
            Console.WriteLine("your result is " + result3);

            int result4 = DivNumbers(0, 0);
            Console.WriteLine("your result is " + result4);


            Console.ReadKey();
        }
        public static int AddNumbers(int FirstNumber, int SecondNumber)
        {
            Console.WriteLine("please enter a number");
            FirstNumber = Convert.ToInt32(Console.ReadLine()); 
            Console.WriteLine("please enter another number to add to your pervious number");
            SecondNumber = Convert.ToInt32(Console.ReadLine());
            int total;
            total = FirstNumber + SecondNumber;
            return (total);
        }


        public static int MinusNumbers(int FirstNumber, int SecondNumber)
        {
            Console.WriteLine("please enter a number");
            FirstNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("please enter another number to subtract from your pervious number");
            SecondNumber = Convert.ToInt32(Console.ReadLine());
            int total;
            total = FirstNumber - SecondNumber;
            return (total);

        }

        public static int MultNumbers(int FirstNumber, int SecondNumber)
        {
            Console.WriteLine("please enter a number");
            FirstNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("please enter another number to multiply with your pervious number");
            SecondNumber = Convert.ToInt32(Console.ReadLine());
            int total;
            total = FirstNumber * SecondNumber;
            return (total);

        }
        public static int DivNumbers(int FirstNumber, int SecondNumber)
        {
            Console.WriteLine("please enter a number");
            FirstNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("please enter another number to divide your pervious number");
            SecondNumber = Convert.ToInt32(Console.ReadLine());
            int total;
            total = FirstNumber / SecondNumber;
            return (total);

        }
    }
}