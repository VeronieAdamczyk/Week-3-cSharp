using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassRectangle
{
    class Shape
    {
        protected double Width;
        protected double Length;


        public void SetValues(double w, double l)
        {
            Width = w;
            Length = l;
        }
    }


    class Rectangle : Shape
    {
        public double getArea()
        {
            return (Width * Length);
        }
    }
    

    class Division : Shape
    {
        public double divide()
        {
            return (Width / Length);
        }
    }



    class Addition : Shape
    {
        public double add()
        {
            return (Width + Length);
        }
    }

    class Perameter : Shape
    {
        public double Peram1()
        {
            return ((Width*2) + (Length*2));
        }
    }

    class SquareRoot : Shape
    {
        public double SquareRoot1()
        {
            return Width + Length;
        }
    }

    class RectangleTester
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter 2 numbers to find the area of a rectanlge");

            double x = Convert.ToDouble(Console.ReadLine());
            double y = Convert.ToDouble(Console.ReadLine());


            Rectangle Rect = new Rectangle();
            Rect.SetValues(x, y);
            Perameter peram = new Perameter();
            peram.SetValues(x,y);
            Console.WriteLine("Total area: {0}", Rect.getArea());
            Console.WriteLine("The Perameter is: {0}", peram.Peram1());
            


            Division div = new Division();
            div.SetValues(x, y);
            Console.WriteLine("Numbers devided are {0}",div.divide());


            Addition add2 = new Addition();
            add2.SetValues(x, y);
            Console.WriteLine("Numbers added together are {0}", add2.add());

            SquareRoot SR1 = new SquareRoot();
            SR1.SetValues(x, y);
            Console.WriteLine("Square root of added numbers is {0}", Math.Sqrt(SR1.SquareRoot1()));

            Console.ReadKey();
        }
    }
}
