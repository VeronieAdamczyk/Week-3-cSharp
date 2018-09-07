using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee
{
    class Program
    {
        static void Main(string[] args)
        {

            IList<Employee> EmployeeList = new List<Employee>()
            {
                new Employee() {EmployeeName= "John", EmployeeID= 456, EmployeePhone = "12356745"},
                new Employee() {EmployeeName= "Mark", EmployeeID= 657, EmployeePhone = "57868902"},
                new Employee() {EmployeeName= "Mike", EmployeeID= 896, EmployeePhone = "63878673"},
            };

            Console.WriteLine(EmployeeList.Count());
            foreach(Employee e in EmployeeList)
            {
                Console.WriteLine("employee name is- {0}, Employee ID is- {1}, their phone number is- {2}", e.EmployeeName, e.EmployeeID, e.EmployeePhone);
            }




            Console.ReadKey();
        }
    }


    class Employee
    {

        public string EmployeeName { get; set; }
        public int EmployeeID { get; set; }
        public string EmployeePhone { get; set; }
    }

}



