using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern
{
    internal class SalaryCalculatorBuilder
    {
        private  int _taxPercentage = 0;
        private decimal _bonusPercentage = 0;
        private decimal _educationPackage = 0;
        private decimal _transportation = 0;
        private bool _sendPayslipToEmployee = true;
        private bool _postResultsToGl = true;

        public SalaryCalculatorBuilder withTaxes(int taxPercentage)
        {
            LogMessage($"{taxPercentage}");
            _taxPercentage = taxPercentage;
            return this;
        }
        public SalaryCalculatorBuilder BonusPercentage(int bonusPercentage)
        {
            LogMessage($"{bonusPercentage}");
            _bonusPercentage = bonusPercentage;
            return this;
        }
        public SalaryCalculatorBuilder EducationPackage(int educationPackage)
        {
            LogMessage($"{educationPackage}");
            _educationPackage = educationPackage;
            return this;
        }
        public SalaryCalculatorBuilder Transportation(int transportation)
        {
            LogMessage($"{transportation}");
            _transportation = transportation;
            return this;
        }
        public SalaryCalculatorBuilder SendPayslipToEmployee(bool sendPayslipToEmployee)
        {
            LogMessage($"{sendPayslipToEmployee}");
            _sendPayslipToEmployee = sendPayslipToEmployee;
            return this;
        }
        public SalaryCalculatorBuilder PostVoucherToGl(bool postResultsToGl)
        {
            LogMessage($"{postResultsToGl}");
            _postResultsToGl = postResultsToGl;
            return this;
        }

        private void LogMessage(string message)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(message);
            Console.ForegroundColor= ConsoleColor.White;
        }

        public SalaryCalculator Build()
        {
            return new SalaryCalculator(_taxPercentage, _bonusPercentage, _educationPackage, _transportation, _sendPayslipToEmployee, _postResultsToGl);
        }
   
    }
}
