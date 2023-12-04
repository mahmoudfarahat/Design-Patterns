using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibilityPattern.Core.Workflow
{
    internal class CTOApprovalHandler : ApprovelHandler
    {
        public override void Process(VacationRequest request)
        {
            if(request.Employee.JobTItle == JobTitle.TechnicalManager)
            {
                Console.WriteLine("Request has been approved by CTO");
            }
            else
            {
                CallNext(request);
            }
        }
    }
}
