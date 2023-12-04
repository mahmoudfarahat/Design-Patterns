using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibilityPattern.Core.Workflow
{
    internal class RequestDaysValidationHandler : ApprovelHandler
    {
        public override void Process(VacationRequest request)
        {
            if( request.TotalDays < 1 )
            {
                Console.Write("Request has been Rejected");
            }
            else
            {
                CallNext(request);
            }
        }
    }
}
