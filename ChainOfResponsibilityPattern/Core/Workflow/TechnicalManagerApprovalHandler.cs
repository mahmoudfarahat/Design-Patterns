using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibilityPattern.Core.Workflow
{
    internal class TechnicalManagerApprovalHandler : ApprovelHandler
    {
        public override void Process(VacationRequest request)
        {
            if (request.Employee.JobTItle == JobTitle.TeamLeader ||
                (request.Employee.JobTItle == JobTitle.Developer && request.TotalDays > 3))
            {
                Console.WriteLine("Request has been approved by Techical Manager");
            }
            else
            {
                CallNext(request);
            }
        }
    }
}
