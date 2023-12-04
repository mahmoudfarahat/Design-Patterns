using ChainOfResponsibilityPattern.Core;
using ChainOfResponsibilityPattern.Core.Workflow;

namespace ChainOfResponsibilityPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var employee = new Employee
            {
                Id = 1,
                Name = "Ibrahim Nada",
                DateOfBirth = new DateOnly(1995, 1, 1),
                HireDate = new DateOnly(2022, 1, 1),
                JobTItle = JobTitle.Developer
            };

            var requset = new VacationRequest
            {
    Employee = employee ,
StartDate =DateTime.Today.AddDays(5),
EndDate = DateTime.Today.AddDays(2)
            };

            var daysValidationHandler = new RequestDaysValidationHandler();
            var teamLeaderHandler = new TeamLeaderApprovalHandler();
            var technicalManagerHandler = new TechnicalManagerApprovalHandler();
            var ctoHandler = new CTOApprovalHandler();
            var ceoHandler = new CEOApprovalHandler();


            daysValidationHandler.setNextHandler(teamLeaderHandler);
            teamLeaderHandler.setNextHandler(technicalManagerHandler);
            technicalManagerHandler.setNextHandler(ctoHandler);
            ctoHandler.setNextHandler(ceoHandler);

            daysValidationHandler.Process(requset);
        }
    }
}
