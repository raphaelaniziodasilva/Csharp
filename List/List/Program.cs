using System.Collections.Generic;
using System.Globalization;

namespace ListExercise {
    internal class Program {
        static void Main(string[] args) {
            Console.WriteLine("How many employees will be registered ?");
            int num = int.Parse(Console.ReadLine());

            // create list of employees
            List<Employee> employees = new List<Employee>();

            // scrolling through the number of employees to be registered
            for(int i = 0; i < num; i++) {
                Console.Write("Id: ");
                int id = int.Parse(Console.ReadLine());

                Console.Write("Name: ");
                string name = Console.ReadLine();

                Console.Write("Salary: ");
                double salary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                // add employee in the list
                employees.Add(new Employee(id, name, salary));

            }

            Console.Write("Enter the employee id that will have salary increase : ");
            int searchId = int.Parse(Console.ReadLine());

            // checking if id employee exists
            Employee employ = employees.Find(e => e.Id == searchId);
            if(employ) {
                Console.Write("Enter the percentage: ");
                double percentage = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                employ.IncreaseSalary(percentage)
            } else {
                Console.WriteLine("This id does not exist!");
            }

            Console.WriteLine();
            Console.WriteLine("Updated list of employees:");
            foreach(Employee obj in employees) {
                Console.WriteLine(obj);
            }
        }
    }
}