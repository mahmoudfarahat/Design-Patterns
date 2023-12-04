using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibilityPattern.Core.Workflow
{
    internal abstract class ApprovelHandler : IApprovalHandler
    {
        private IApprovalHandler _next;
        public abstract void Process(VacationRequest request);

        public void setNextHandler(IApprovalHandler next)
        {
            _next = next;
        }

        protected void CallNext(VacationRequest request)
        {
            if(_next != null) 
                _next.Process(request);
        }
    }
}
