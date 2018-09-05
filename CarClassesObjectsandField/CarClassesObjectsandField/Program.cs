using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarClassesObjectsandField
{
    class Car
    {
        public string Make;
        public string Model;
        public int Price;

        

        public Car (string UserMake, string UserModel, int UserPrice)
        {
            this.Make = UserMake;
            this.Model = UserModel;
            this.Price = UserPrice;


        }

        public static Car CreateCar()
        {
            string UserMake;
            string UserModel;
            int UserPrice;

            Console.WriteLine("please enter a make:");
            UserMake = Console.ReadLine();
            Console.WriteLine("please enter a model:");
            UserModel = Console.ReadLine();
            Console.WriteLine("please enter a price:");
            UserPrice = Convert.ToInt32(Console.ReadLine());

            Car myCar = new Car(UserMake, UserModel, UserPrice);
            return myCar;
        }

        public static void DisplayAllCars(List<Car> allCars)
        {
            Console.WriteLine("Here is the current list of Cars:");
            foreach (Car obj in allCars)
            {
                Console.WriteLine("make:{0}", obj.Make);
                Console.WriteLine("model:{0}", obj.Model);
                Console.WriteLine("price:{0}", obj.Price);
            }
        }
    } // end of car class




    class Program
    {
        static void Main(string[] args)
        {
            string response;

            List<Car> carsList = new List<Car>();

            carsList.Add(Car.CreateCar());
            Car.DisplayAllCars(carsList);

            Console.ReadKey();
        }
    }
}
