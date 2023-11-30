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
                    FullName = "Mahmoud Farahat",
                    PayItems = new List<PayItem>
                    {
                        new PayItem() {Name="Basic Salary",Value = 1000},
                        new PayItem() {Name="Transportation",Value = 250},
                        new PayItem() {Name="Medical Insurance",Value = -150}
                    }
                },
                 new Employee()
                {
                    FullName = "Mahmoud Ali",
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
