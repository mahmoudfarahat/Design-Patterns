namespace PayrollSystem.Core
{
    public class EmployeeDateReader
    {
       public IEnumerable<Employee> GetEmployees()
        {
            return new List<Employee>()
            {
                new Employee()
                {
                    //FullName = "Mahmoud Farahat",
                    FirstName = "Mahmoud",
                    LastName = "Farahat",
                    SecondName ="Ali",
                    PayItems = new List<PayItem>
                    {
                        new PayItem() {Name="Basic Salary",Value = 1000},
                        new PayItem() {Name="Transportation",Value = 250},
                        new PayItem() {Name="Medical Insurance",Value = 150, IsDeduction = true}
                    }
                },
                 new Employee()
                {
                    //FullName = "Mahmoud Ali",
                      FirstName = "ALi",
                    LastName = "Omar",
                    SecondName ="Nour",
                    PayItems = new List<PayItem>
                    {
                        new PayItem() {Name="Basic Salary",Value = 1000},
                        new PayItem() {Name="Transportation",Value = 250},
                        new PayItem() {Name="Medical Insurance",Value = -150}
                    }
                }
            };
        }
    }
}
