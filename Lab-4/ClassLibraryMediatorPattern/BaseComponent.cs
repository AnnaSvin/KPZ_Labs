using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryMediatorPattern
{
    public abstract class BaseComponent
    {
        protected IMediator? _mediator;

        public void SetMediator(IMediator mediator)
        {
            _mediator = mediator;
        }
    }
}
