using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern
{
    internal class Employee
    {
        // immutal object  => readonly 
        public Employee(string name, string email , decimal basicSalary)
        {
            Name = name;
            Email = email;
            BasicSalary = basicSalary;
        }

        public decimal BasicSalary { get; set; }
        public string Name { get; }
        public string Email { get; set; }


    }
}
