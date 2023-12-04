using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibilityPattern.Core.Workflow
{
    internal interface IApprovalHandler
    {
        void setNextHandler(IApprovalHandler next);

        void Process(VacationRequest request);
    }
}
