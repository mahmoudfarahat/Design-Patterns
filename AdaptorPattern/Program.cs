using PayrollSystem.Core;
using System.Text;
using System.Text.Json;

namespace AdaptorPattern
{
    public class Program
    {
        static async Task Main(string[] args)
        {https://localhost:7021/
            var payrollCalculatorUrl = "https://localhost:7021/api/PayrollCalculator";
            var reader = new EmployeeDateReader();
            var employees = reader.GetEmployees();

            var client = new HttpClient();
            foreach (var employee in employees)
            {
                var request = new HttpRequestMessage(HttpMethod.Post, payrollCalculatorUrl);
                request.Content = new StringContent(JsonSerializer.Serialize(employee),Encoding.UTF8,"application/json");

                var response = await client.SendAsync(request);
                var respnoseJson = await response.Content.ReadAsStringAsync();
                var salary = decimal.Parse(respnoseJson);

                Console.WriteLine($"Salary for employee `{employee.FullName}` as of tody = {salary}");
            }
            Console.ReadKey();
        }
    }
}
