using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibilityPattern.Core.Workflow
{
    internal class TeamLeaderApprovalHandler : ApprovelHandler
    {
        public override void Process(VacationRequest request)
        {
             if(request.Employee.JobTItle == JobTitle.Developer && request.TotalDays <=3)
            {
                Console.WriteLine("Request has been approved by Team Leader");
            }
            else
            {
                CallNext(request);
            }
        }
    }
}
