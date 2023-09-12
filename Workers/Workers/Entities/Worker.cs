using System;
using Workers.Entities.Enums;

namespace Workers.Entities {
    internal class Worker {
        public string Name { get; set; }
        // the level will be of the type enum WorkerLevel that contains the level of the workers
        public WorkerLevel level { get; set; }
        public double BaseSalary { get; set; }
        // object composition will be an association of the worker class and department
        public Department Department { get; set; }
        // creating list of contracts and instantiating the list to ensure it is not null
        public List<HourContract> Contracts { get; set; } = new List<HourContract>();

        public Worker(string name, WorkerLevel level, double baseSalary, Department department) {
            Name = name;
            this.level = level;
            BaseSalary = baseSalary;
            Department = department;
        }

        public void AddContract(HourContract contarct) {
            Contracts.Add(contarct);
        }

        public void RemoveContract(HourContract contarct) { 
            Contracts.Remove(contarct);
        }

        // how much the employee earns based on year and month
        public double Income(int year, int month) {
            // salary that the worker receives 
            double sum = BaseSalary;

            foreach(HourContract contract in Contracts) {
                if(contract.Date.Year == year && contract.Date.Month == month) {
                    sum += contract.TotalValue();
                }
            }
            return sum;
        }

    }
}
