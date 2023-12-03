namespace BuilderPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var builder = new SalaryCalculatorBuilder();
            while (true)
            {
                Console.WriteLine("Select an Option");
                Console.WriteLine("1. Add 20% Bouns");
                Console.WriteLine("2. Deduct 10% taxes");
                Console.WriteLine("3. Add 2000 Education Package");
                Console.WriteLine("4. Add 1000 transportation ");
                Console.WriteLine("5. Send Payslip to Employee ");
                Console.WriteLine("6. Post Voucher to Gl ");
                Console.WriteLine("0. Build ");

                var option = int.Parse(Console.ReadLine());
                if (option == 1)
                    builder.BonusPercentage(20);
                else if (option == 2)
                    builder.withTaxes(10);
                else if (option == 3)
                    builder.EducationPackage(2000);
                else if (option == 4)
                    builder.Transportation(1000);
                else if (option == 5)
                    builder.SendPayslipToEmployee(true);
                else if (option == 6)
                    builder.PostVoucherToGl(true);
                else if (option == 0)
                {
                    var calculator = builder.Build();
                    var employee = new Employee("Mahmoud", "text@test.com", 50000);
                    var salary = calculator.Calculate(employee);
                    Console.ReadKey();
                    builder = new SalaryCalculatorBuilder();
                }
            }
        }
    }
}
