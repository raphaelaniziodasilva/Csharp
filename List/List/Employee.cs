using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListExercise {
    internal class Employee {
        public int Id { get; private set; }
        public string Name { get; set; }
        public double Salary { get; set; }

        public Employee(int id, string name, double salary) {
            Id = id;
            Name = name;
            Salary = salary;
        }

        public override string ToString() {
            return "Id: " + Id
                + ", Name: " + Name
                + ", Salary R$: " + Salary.ToString("F2", CultureInfo.InvariantCulture);
        }

        public void IncreaseSalary(double percentage) {
            if (percentage >= 0) {
                Salary += Salary * (percentage / 100.0);
            }
            else {
                System.out.println("Invalid percentage. Please provide a percentage between 0 and 100.");
            }
        }
    }
}
