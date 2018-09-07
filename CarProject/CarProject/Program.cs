using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarProject
{
    // Car class starts
    class Car
    {
        public string make  { get; set; }
        public string model { get; set; }
        public int    price  { get; set; }
        //public static int numberOfCars;

       public Car(string make, string model, int price)
           {

            this.make= make;
            this.model = model;
            this.price = price;
        }

   public static Car CreateCar()
        {
            string make;
            string model;
            int price;

            Console.WriteLine("please enter a make:");
            make = Console.ReadLine();
            Console.WriteLine("please enter a model:");
            model = Console.ReadLine();
            Console.WriteLine("please enter a price:");
            price = Convert.ToInt32(Console.ReadLine());

            Car myCar = new Car(make, model, price);
            return myCar;
        }    

        public static void DisplayAllCars(List<Car> allCars)
        {
            Console.WriteLine("Here is a list of the cars currently stored: ");

            foreach (Car car in allCars)
            {
                Console.WriteLine("Make: {0}", car.make);
                Console.WriteLine("Model: {0}", car.model);
                Console.WriteLine("Price: £{0}", car.price);  
            }
        }


       
    } // End of car class

    class Program
    {
        static void Main(string[] args)
        {
           
            string response;

            List<Car> CarMake = new List<Car>();
         
            do
            {
                Console.WriteLine("Please type A to add a car to the list, D to Delete a car from the list, L to view the list of cars or X to Exit:");
                response = Console.ReadLine().ToUpper();

                if (response == "A")
                {
                    CarMake.Add(Car.CreateCar());
                }
                if(response=="D")
                {
                    CarMake.Remove(Car.CreateCar());
                }
                if(response == "L")
                {
                    Car.DisplayAllCars(CarMake);
                }
            } while (response != "X");
           
            Console.WriteLine(CarMake.Count);

            Console.ReadKey();
        }
    }
}
 