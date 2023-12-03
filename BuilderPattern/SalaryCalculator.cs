using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern
{
    internal class SalaryCalculator
    {
        // complex object immutal object 
        public SalaryCalculator(int taxPercentage = 0 , decimal bonusPercentage =0 , decimal educationPackage =0 , decimal transportation =0,
            bool sendPayslipToEmployee = true , bool postResultsToGl = true
            )
        {
            TaxPercentage = taxPercentage;
            BonusPercentage = bonusPercentage;
            EducationPackage = educationPackage;
            Transportation = transportation;
            SendPayslipToEmployee = sendPayslipToEmployee;
            PostResultsToGl = postResultsToGl;
        }

        public int TaxPercentage { get; }
        public decimal BonusPercentage { get; }
        public decimal EducationPackage { get; }
        public decimal Transportation { get; }
        public bool SendPayslipToEmployee { get; }
        public bool PostResultsToGl { get; }

        public decimal Calculate(Employee employee)
        {
            var bonus = employee.BasicSalary * BonusPercentage / 100;
            var taxes = employee.BasicSalary * TaxPercentage / 100;
            var salary = employee.BasicSalary + EducationPackage + Transportation + bonus - taxes;

            Console.ForegroundColor = ConsoleColor.Green;
            if (SendPayslipToEmployee)
                Console.WriteLine($"Payslip has been sent to `{employee.Email}`");
            if (PostResultsToGl)
                Console.WriteLine($"Salary vouher with total amount ({salary} EGP) has been sent to GL");
            Console.ForegroundColor= ConsoleColor.White;

            return salary;

        }

    }
}
