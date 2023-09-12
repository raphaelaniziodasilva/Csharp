using System;

namespace Workers.Entities {
    internal class Department {
        public string Name { get; set; }

        public Department(string name) {
            Name = name;
        }
    }
}
