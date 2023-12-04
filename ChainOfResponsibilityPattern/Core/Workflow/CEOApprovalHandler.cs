using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibilityPattern.Core.Workflow
{
    internal class CEOApprovalHandler: ApprovelHandler
    {
        public override void Process(VacationRequest request)
        {
            if (request.Employee.JobTItle == JobTitle.CTO)
            {
                Console.WriteLine("Request has been approved by CEO");
            }
            else
            {
                CallNext(request);
            }
        }
    }
}
