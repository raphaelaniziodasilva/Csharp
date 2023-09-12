using System.Globalization;
using Workers.Entities;
using Workers.Entities.Enums;

namespace Workers {
    internal class Program {
        static void Main(string[] args) {
            Console.Write("Enter a department's name: ");
            string deptName = Console.ReadLine();

            Console.WriteLine("Enter worker data: ");

            Console.Write("Name: ");
            string name = Console.ReadLine();

            Console.Write("Level (Junior/MidLevel/Senior): ");
            // convert the string to the object of type WorkerLevel which is the enumeration
            WorkerLevel level = Enum.Parse<WorkerLevel>(Console.ReadLine());

            Console.Write("Base Salary: ");
            double baseSalary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            // creating department
            Department dept = new Department(deptName);

            // creating worker
            Worker worker = new Worker(name, level, baseSalary, dept);

            // how many contracts will the worker have
            Console.Write("How many contracts to this worker: ");
            int n = int.Parse(Console.ReadLine());

            // scrool through the number of contacts the user has entered
            for(int i = 1; i <= n; i++) {

                // class HourContract

                Console.WriteLine($"Enter #{i} contract data:");

                Console.Write("Date (DD/MM/YYYY): ");
                DateTime date = DateTime.Parse(Console.ReadLine());

                Console.Write("Value per hour: ");
                double valuePerHour = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                Console.Write("Duration (Hours): ");
                int hours = int.Parse(Console.ReadLine());

                // create contract: HourContract
                HourContract contract = new HourContract(date, valuePerHour, hours);

                // adding the worker's contract in the list of contracts
                worker.AddContract(contract);

                Console.WriteLine(); 
                Console.Write("Enter month and year to calculate incom (MM/YYYY): ");
                string monthAndYear = Console.ReadLine();
                // using the substring function to clip the month ex: 08
                int month = int.Parse(monthAndYear.Substring(0, 2));

                // using the substring function to clip the year ex: 2023
                int year = int.Parse(monthAndYear.Substring(3));

                // priting worker data
                Console.WriteLine("Name: " + worker.Name);
                Console.WriteLine("Department: " + worker.Department.Name);
                Console.WriteLine("Income for " + monthAndYear + ": " + worker.Income(year, month).ToString("F2", CultureInfo.InvariantCulture));

            }


        }
    }
}